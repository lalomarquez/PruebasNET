using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //var link = new List<string>();
                //link.Add("https://www.youtube.com/watch?v=GlGuLcQhrWg");
                string link = @"https://www.youtube.com/watch?v=YzC-FYg66xA&list=PL0kIvpOlieSNWR3YPSjh9P2p43SFnNBlB&index=1";
                //foreach (var item in link)
                //{

                    IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls("https://www.youtube.com/watch?v=YzC-FYg66xA&list=PL0kIvpOlieSNWR3YPSjh9P2p43SFnNBlB&index=1");
                    VideoInfo video = videoInfos.First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 720);
                    var videoDownloader = new VideoDownloader(video, Path.Combine(@"C:\Users\lalomarquez\Desktop\", video.Title + video.VideoExtension));

                    videoDownloader.DownloadProgressChanged += (sender, argss) => Console.WriteLine(argss.ProgressPercentage);
                    videoDownloader.Execute();
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }          
        }
    }
}
