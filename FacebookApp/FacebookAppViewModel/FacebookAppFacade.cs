using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public class FacebookAppFacade
    {
        private static readonly string[] sr_AgeRange = new string[] { "18-21", "22-25", "26-30", "31-40", "41-50", "51-65", "66+" };

        public AppSettings AppSettings { get; set; }

        internal LoginResult        m_LoginResult;
        internal UserProxy          m_LoggedInUserProxy;

        public string[] AgeRange
        {
            get
            {
                return sr_AgeRange;
            }
        }

        public void LoginAndInit()
        {
            AppSettings.LoginAndInit(out m_LoginResult, out this.m_LoggedInUserProxy);
        }

        public void PostStatus(string i_NewPost)
        {
            IFeature post;
            if (!string.IsNullOrEmpty(i_NewPost))
            {
                post = FeaturesFactoryMethod.Create(MethodFactoryTypes.eFacebookFeatureType.Post, this.m_LoggedInUserProxy);
                (post as PostNewStatus).NewPost = i_NewPost;
                post.FeatureCliked();
            }
        }

        public Dictionary<User, int> SortLikes()
        {
            IFeature sort;
            sort = FeaturesFactoryMethod.Create(MethodFactoryTypes.eFacebookFeatureType.LikeSorter, this.m_LoggedInUserProxy);
            sort.FeatureCliked();
            return (sort as LikeSorter).FriendsLikeCounter;
        }

        public List<User> FindMatch(bool i_IsFemaleChecked, bool i_IsMaleChecked, string i_AgeRangeSelected)
        {
            IFeature findMatch = FeaturesFactoryMethod.Create(MethodFactoryTypes.eFacebookFeatureType.MatchFinder, this.m_LoggedInUserProxy);
            (findMatch as MatchFinder).MatchInitializer(findMatch as MatchFinder, i_IsFemaleChecked, i_IsMaleChecked, i_AgeRangeSelected);

            if ((i_IsFemaleChecked || i_IsMaleChecked) && !i_AgeRangeSelected.Equals("Select your desired age range"))
            {
                (findMatch as MatchFinder).FeatureCliked();
            }
            else
            {
                throw new Exception("Not all parameters are selected");
            }

            return (findMatch as MatchFinder).MatchFriends;
        }

        public List<PostAdapter> GetPosts()
        {
            return PostAdapter.CreateAdapterPosts(this.m_LoggedInUserProxy.LoggedInUser.Posts);
        }
    }
}
