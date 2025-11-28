using Newtonsoft.Json;

namespace SQLProject.Models
{
    public class SalesResponse
    {
        public string success { get; set; }

        [JsonProperty("Records")]
        public List<SalesData> Records { get; set; }
    }


}
