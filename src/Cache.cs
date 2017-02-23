using System.Collections.Generic;

namespace src
{
    public class Cache
    {
        public int Capacity { get; set; }

        public List<Score> scores;

        public Cache()
        {
            scores = new List<Score>();
        }
    }
}
