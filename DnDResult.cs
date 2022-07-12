using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster
{
    public class DnDResult<T>
    {
        [JsonProperty("count")]
        public long Count { get; set; }
        [JsonProperty("results")]
        public List<T> Results { get; set; }
    }
}
