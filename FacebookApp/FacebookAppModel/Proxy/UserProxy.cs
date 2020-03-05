using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.IO;

namespace FacebookApp
{
    public class UserProxy
    {
        public UserProxy(User i_user)
        {
            this.LoggedInUser = i_user;
        }

        public User LoggedInUser { get; set; }

        public string SaveToFileString { get; set; }

        public string FileName { get; set; }

        public void SaveInfoToFile(FileFormatForm i_FileFormatForm)
        {
            using (Stream stream = File.Open(this.FileName, FileMode.CreateNew))
            using (StreamWriter streamWriter = new StreamWriter(stream))
            {
                string formatString = i_FileFormatForm.ChosenFileFormat.ToString();
                streamWriter.Write(formatString);
                streamWriter.Write(this.SaveToFileString);
            }
        }
    }
}
