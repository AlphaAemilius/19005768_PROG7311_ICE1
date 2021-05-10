using System;

namespace MemeSynthesis.Models
{
    public class Memes
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        private int width { get; set; }
        private int height { get; set; }
        private int box_count { get; set; }

        public Memes()
        {

        }
    }

}
