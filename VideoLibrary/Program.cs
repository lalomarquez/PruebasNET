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
            var link = new List<string>();
            //link.Add("");

            foreach (var item in link)
                SaveVideoToDisk(item);    

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
                File.WriteAllBytes(@"C:\Users\lalomarquez\Desktop\down\" + video.FullName.Replace("- YouTube", ""), video.GetBytes());
                Console.WriteLine("Descarga realizada!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
    }
}
