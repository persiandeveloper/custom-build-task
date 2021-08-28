using Newtonsoft.Json;
using System;

namespace ClassTest
{
    public class Class1
    {
        public void A()
        {
            var obj = JsonConvert.SerializeObject(new { X = 2 });
        }
    }
}
