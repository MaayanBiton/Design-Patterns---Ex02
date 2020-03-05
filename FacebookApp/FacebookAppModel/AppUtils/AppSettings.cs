using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookApp
{
    public class AppSettings
    {
        private const string            k_FileName = "\\appSettings.xml";

        private AppSettings()
        {
            this.RememberMe = false;
            this.LastAccessToken = null;  
        }

        public bool RememberMe { get; set; }

        public string LastAccessToken { get; set; }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = new AppSettings();
            string pathOfSettingsFile = Environment.CurrentDirectory;
            pathOfSettingsFile += k_FileName;

            try
            {
                if (File.Exists(pathOfSettingsFile) && new FileInfo(pathOfSettingsFile).Length > 0)
                {
                    using (Stream stream = new FileStream(pathOfSettingsFile, FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                        appSettings = serializer.Deserialize(stream) as AppSettings;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return appSettings;
        }

        public void SaveToFile()
        {
            FileMode fileMode;
            string pathOfSettingsFile = Environment.CurrentDirectory;

            pathOfSettingsFile += k_FileName;
            fileMode = File.Exists(pathOfSettingsFile) ? FileMode.Truncate : FileMode.CreateNew;

            if (!this.RememberMe)
            {
                this.LastAccessToken = null;
            }

            using (Stream stream = new FileStream(pathOfSettingsFile, fileMode))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                serializer.Serialize(stream, this);
            }
        }

        public void LoginAndInit(out LoginResult o_LoginResult, out UserProxy o_LoggedInUserProxy)
        {   //we used guy's app ID. Our app ID is "515144672559542"
            o_LoginResult = FacebookService.Login(
                "1450160541956417",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_friends",
                "user_likes",
                "user_photos",
                "user_posts",
                "user_hometown",
                "email",
                "user_tagged_places",
                "user_location",
                "user_tagged_places"
                );

            if (!string.IsNullOrEmpty(o_LoginResult.AccessToken))
            {
                o_LoggedInUserProxy = new UserProxy(o_LoginResult.LoggedInUser);
            }
            else
            {
                throw new Exception(o_LoginResult.ErrorMessage);
            }
        }
    }
}
