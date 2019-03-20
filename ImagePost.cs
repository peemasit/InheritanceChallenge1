using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge1 {
    class ImagePost:Post {
        protected string Image { get; set; }
        public ImagePost(string title, string sendByUsername,string image, bool isPublic) {
            this.ID = NextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            this.Image = image;
        }
        public override string ToString() {
            return string.Format($"{this.ID} - {this.Title} - {this.Image} - by {this.SendByUsername}");
        }

    }
}
