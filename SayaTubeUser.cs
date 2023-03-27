using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal_Modul_6
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;
        private string title;

        public SayaTubeUser(string Username)
        {
            this.Username = Username;
            uploadedVideos= new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount(int id, int playCount)
        {
            int total = 0;
            foreach (SayaTubeVideo video in uploadedVideos)
            total += uploadedVideos.Count;
            return total;
        }

        public string GetVideoName(int id, string title)
        {
            foreach (SayaTubeVideo video in uploadedVideos);
            return title;

        }
       
        public void addVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount(int id, int playCount)
        {
            System.Console.WriteLine("nama" + id);
            System.Console.WriteLine("judul" + title);
            System.Console.WriteLine("jumlah play count: " + playCount);

        }
    }
}
