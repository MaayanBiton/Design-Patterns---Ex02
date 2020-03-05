using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookApp
{
    public class PostAdapter
    {
        private readonly Post       r_Post;
        private string              m_NewPost;

        public PostAdapter(Post i_Post)
        {
            this.r_Post = i_Post;
        } 

        public string NewPost
        {
            get { return this.m_NewPost ?? this.r_Post.Message; }
            set { this.m_NewPost = value; }
        }

        public string ImageURL
        {
            get { return this.r_Post.From.PictureNormalURL; }
        }

        public string UserName
        {
            get { return this.r_Post.From.Name; }
        }

        public static List<PostAdapter> CreateAdapterPosts(FacebookObjectCollection<Post> i_Posts)
        {
            List<PostAdapter> wrappedPosts = new List<PostAdapter>();
            foreach (Post post in i_Posts)
            {
                wrappedPosts.Add(new PostAdapter(post));
            }

            return wrappedPosts;
        }
    }
}
