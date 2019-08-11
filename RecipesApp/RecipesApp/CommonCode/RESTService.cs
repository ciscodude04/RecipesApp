using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipesApp.CommonCode
{
    public class RESTService
    {
        string recipe_data;

        public void test()
        {
            var client = new RestClient("https://food2fork.com/api/search");

            var request = new RestRequest("", Method.GET);
            request.AddParameter("key", "c29e46be7bed5362bc20a5330e54ec73");
            request.AddParameter("q", "meat");

            //request.AddHeader("header", "");

            request.RequestFormat = DataFormat.Json;

            IRestResponse response = client.Execute(request);
            var content = response.Content;

            recipe_data = content;

            RootObjectModel recipeList = JsonConvert.DeserializeObject<RootObjectModel>(recipe_data);

            var name = recipeList.recipes[0].title;

            Console.Write(name);
        }
    }
}
