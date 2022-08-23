using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JsonExample
{
    public class FetchJsonOfStock
    {
   
        public Stock Read(string path)
        {
            using (StreamReader file = new StreamReader(path))

                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Stock>(json);

                }
                catch (Exception)
                {
                    return null;
                }

        }
    }
}