using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipesApp.CommonCode
{
    class RecipesDetails
    {
        public string publisher { get; set; }
        public string f2f_url { get; set; }
        public string title { get; set; }
        public string source_url { get; set; }
        public string recipe_id { get; set; }
        public string image_url { get; set; }
        public double social_rank { get; set; }
        public string publisher_url { get; set; }
    }

    class RootObjectModel
    {
        public int count { get; set; }
        public List<RecipesDetails> recipes { get; set; }
    }
}
