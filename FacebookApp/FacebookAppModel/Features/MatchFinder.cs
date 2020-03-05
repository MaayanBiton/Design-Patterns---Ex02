using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookApp
{
    public class MatchFinder : IFeature
    {
        private const int           k_StartYearSubStringIndex = 6;
        private const int           k_MaxAgeRange = 120;
        private UserProxy           m_LoggedInUser;

        public MatchFinder(UserProxy i_LoggedInUser)
        {
            this.SelectedGender = new Dictionary<string, bool>();
            this.m_LoggedInUser = i_LoggedInUser;
        }

        public string AgeRangeSelected { get; set; }

        public Dictionary<string, bool> SelectedGender { get; set; }

        public List<User> MatchFriends { get; set; }

        public void MatchInitializer(MatchFinder i_Feature, bool i_IsFemaleChecked, bool i_IsMaleChecked, string i_AgeRangeSelected)
        {
            this.genderListInit(i_Feature, i_IsFemaleChecked, i_IsMaleChecked);
            i_Feature.AgeRangeSelected = i_AgeRangeSelected.ToString();
        }

        public void FeatureCliked()
        {
            this.FindMatch();
        }

        public void FindMatch()
        {
            foreach (User friend in this.m_LoggedInUser.LoggedInUser.Friends)
            {
                if (this.isInAgeRange(friend))
                {
                    this.MatchFriends.Add(friend);
                }
            }
        }

        private bool isInAgeRange(User i_Friend)
        {
            bool isInRange = false;
            int friendAge = this.parseBirthdayToAge(i_Friend.Birthday);
            int maxAge;
            int minAge;

            this.parseAgeRange(this.AgeRangeSelected, out minAge, out maxAge);
            isInRange = this.isFriendInRange(friendAge, minAge, maxAge);
            return isInRange;
        }

        private void parseAgeRange(string i_AgeRange, out int o_MinAge, out int o_MaxAge)
        {
            int index = 0;
            o_MaxAge = 0;
            o_MinAge = 0;

            while (index < i_AgeRange.Length)
            {
                if (i_AgeRange[index] == '-' || i_AgeRange[index] == '+')
                {
                    o_MinAge = int.Parse(i_AgeRange.Substring(0, index - 1));
                    if (i_AgeRange[index] != '+')
                    {
                        o_MaxAge = int.Parse(i_AgeRange.Substring(index + 1));
                    }
                    else
                    {
                        o_MaxAge = k_MaxAgeRange;
                    }

                    break;
                }
            }
        }

        private bool isFriendInRange(int i_FriendAge, int i_MinAge, int i_MaxAge)
        {
            bool isInRange = false;

            if (i_FriendAge >= i_MinAge && i_FriendAge <= i_MaxAge)
            {
                isInRange = true;
            }

            return isInRange;
        }

        private int parseBirthdayToAge(string i_Birthday)
        {
            int age;
            bool isParseSuccessfull = int.TryParse(i_Birthday.Substring(k_StartYearSubStringIndex), out age);

            if (isParseSuccessfull)
            {
                age = DateTime.Now.Year - age;
            }
            else
            {
                throw new Exception("Unsuccessfull parse in parseBirthdayToAge method");
            }

            return age;
        }

        private void genderListInit(MatchFinder i_MatchFinder, bool i_IsFemaleChecked, bool i_IsMaleChecked)
        {
            if (i_IsMaleChecked)
            {
                i_MatchFinder.SelectedGender.Add("Male", true);
            }
            else
            {
                i_MatchFinder.SelectedGender.Add("Male", false);
            }

            if (i_IsFemaleChecked)
            {
                i_MatchFinder.SelectedGender.Add("Female", true);
            }
            else
            {
                i_MatchFinder.SelectedGender.Add("Female", false);
            }
        }
    }
}