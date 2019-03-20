using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge1 {
    class Post {
        private static int currentPostID;
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        public Post() {
        }
        public Post(string title,string sendByUsername,bool isPublic) {
            this.ID = NextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }
        protected int NextID() {
            return ++currentPostID;
        }

        public override string ToString() {
            return string.Format($"{this.ID} - {this.Title} - by {this.SendByUsername}");
        }

    }
}
