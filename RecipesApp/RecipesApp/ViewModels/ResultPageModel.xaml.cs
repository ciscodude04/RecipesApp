using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RecipesApp.ViewModels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultPageModel : ContentPage
    {
        public ResultPageModel(string descriptor, string protein)
        {
            InitializeComponent();

            SearchWord.Text = "Resultados para: " + descriptor + " " + protein;
        }

        private async void Result1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecipePageModel());
        }

        //private void Result1_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new RecipePage());
        //}
	}
}