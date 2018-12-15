using Newtonsoft.Json;

namespace MyJsonModel
{
    public class JsonModel
    {
        [JsonProperty("arrayOne")]
        public int []arrayOne { get; set; }

        [JsonProperty("arrayTwo")]
        public int[] arrayTwo { get; set; }
    }
}
