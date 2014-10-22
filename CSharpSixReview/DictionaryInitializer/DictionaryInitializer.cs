using System.Collections.Generic;

namespace CSharpSixReview.DictionaryInitializer
{
    class DictionaryInitializer
    {
        public void Initialize5()
        {
            var scores = new Dictionary<string, int>();
            scores["Reading"] = 10;
            scores["Writing"] = 6;
            scores["Use of english"] = 7;
        }

        public void Initialize5b()
        {
            var scores = new Dictionary<string, int>()
            {
                {"Reading", 10 },
                {"Writing", 6 },
                {"Use of english", 7 }
            };
        }

        public void Initialize6()
        {
            var scores = new Dictionary<string, int>()
            {
                ["Reading"] = 10,
                ["Writing"] = 6,
                ["Use of english"] = 7
            };
        }
    }
}
