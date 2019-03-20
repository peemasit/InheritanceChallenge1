using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InheritanceChallenge1 {
    class VideoPost:Post {
        protected string Video { get; set; }
        protected int Length { get; set; }

        protected bool Playing = false;
        protected int Duration = 0;
        Timer timer;

        public VideoPost(string title, string sendByUsername,string video, int length, bool isPublic
            ) {
            this.ID = NextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            this.Video = video;
            this.Length = length;
        }

        public void Play() {
            if (!Playing) {
                Playing = true;
                Console.WriteLine("Play");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object i) {
            if (Duration < Length) {
                Duration++;
                Console.WriteLine($"Video at {Duration}s");
                GC.Collect();
            } else {
                Stop();
                Console.WriteLine("video finished!");
            }
        }
        public void Stop() {
            if (Playing) {
                Playing = false;
                Console.WriteLine($"stopped at {Duration}s");
                timer.Dispose();
            }
        }

        public override string ToString() {
            return string.Format($"{this.ID} - {this.Title} - {this.Video} - {this.Length} - by {this.SendByUsername}");
        }

    }
}
