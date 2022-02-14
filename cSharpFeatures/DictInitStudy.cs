using System.Collections.Generic;

namespace cSharpFeatures
{
    public class DictInitStudy
    {
        public DictInitStudy()
        {
            Dictionary<string, string> oldWay = new Dictionary<string, string>()
            {
                {"key1", "value of Key 1" },
                {"key2","value of Key 2" }
            };

            Dictionary<string, string> newWay = new Dictionary<string, string>()
            {
                ["Key1"] = "Value of key 1",
                ["Key2"] = "value of Key 2"
            };
        }

    }
}
