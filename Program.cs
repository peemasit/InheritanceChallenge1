using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge1 {
    class Program {
        static void Main(string[] args) {
            Post post = new Post("Hello there!","Peem",true);
            ImagePost imagePost = new ImagePost("Hello there!","Peem","https://image.com",true);
            VideoPost videoPost = new VideoPost("Hi", "Peem", "https://videocall.com", 5, true);
            Console.WriteLine(post);
            Console.WriteLine(imagePost);
            Console.WriteLine(videoPost);
            videoPost.Play();
            Console.WriteLine("press any key to stop video!");
            Console.ReadLine();
            videoPost.Stop();
            Console.ReadKey();
        }
    }
}
