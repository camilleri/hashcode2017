using System.Collections.Generic;

namespace src
{
    public class Endpoint
    {
        public int Id { get; set; }

        public int DataCenterLatency { get; set; }
        public Dictionary<Cache, int> CacheScore { get; set; } // [cacheId, Score]

        public Endpoint()
        {
            CacheScore = new Dictionary<Cache, int>();
        }
    }
}
