using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApp
{
   public class PostNewStatus : IFeature
    {
        public PostNewStatus(UserProxy i_LoggedInUser)
        {
            this.LoggedInUser = i_LoggedInUser;
        }

        public string NewPost { get; set; }

        public UserProxy LoggedInUser { get; set; }
        
        public void FeatureCliked()
        {
            this.LoggedInUser.LoggedInUser.PostStatus(this.NewPost);
        }
    }
}
