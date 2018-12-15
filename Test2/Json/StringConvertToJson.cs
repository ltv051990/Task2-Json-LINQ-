using System;
using MyJsonModel;
using Newtonsoft.Json;


namespace JsonConverter
{
    public class JsonToModel
    {
        public static JsonModel StringToModel(string input)
        {
            JsonModel json = null;

            try
            {
                json = JsonConvert.DeserializeObject<JsonModel>(input);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Can't convert string to Json\r\n" + exc);
                json = null;
            }

            return json;
        }

    }
}
