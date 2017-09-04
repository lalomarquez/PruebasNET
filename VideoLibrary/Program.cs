using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;

namespace VideoLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando!");

            //string link = @"https://www.youtube.com/watch?v=nsEYtDwj3ZU&index=110&list=PL6n9fhu94yhVDV697uvHpavA3K_eWGQap";

            var link = new List<string>();
            link.Add("https://www.youtube.com/watch?v=f79GNqOiDQ8");
            //link.Add("https://www.youtube.com/watch?v=-47WKM3AeL4");


            foreach (var item in link)
            {
                SaveVideoToDisk(item);
            }            

            Console.WriteLine("Hecho");
            Console.ReadKey();
        }

        static void SaveVideoToDisk(string link)
        {
            try
            {
                var youTube = YouTube.Default; // starting point for YouTube actions
                var video = youTube.GetVideo(link); // gets a Video object with info about the video       
                Console.WriteLine(video.FullName);
                
                File.WriteAllBytes(@"C:\Users\lalomarquez\Desktop\" + video.FullName.Replace("- YouTube", ""), video.GetBytes());

                Console.WriteLine("Descarga realizada!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
    }
}
