using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal_Modul_6
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            id = 0;
            this.title = title;
            this.playCount = 0;

        }

        public void increasePlayCount(int playCount)
        {
            this.id = playCount;
        }

        public void PrintVideoDetails()
        {
            System.Console.WriteLine(id);
            System.Console.WriteLine(title);
            System.Console.WriteLine(playCount);
        }
        public int getId() 
        { 
            return id; 
        }

        public string getTitle()
        {
            return title;
        }

        public int getPlayCount()
        {
            return playCount;
        }


    }
}
