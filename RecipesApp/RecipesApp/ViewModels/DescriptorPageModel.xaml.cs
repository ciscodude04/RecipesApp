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
	public partial class DescriptorPageModel : ContentPage
	{
        string protein_word;
        string specific_description;
		public DescriptorPageModel (string parameter)
		{
			InitializeComponent ();
            protein_word = parameter;
            //FriedButton.Clicked += FriedButton_Clicked;
            //RoastedButton.Clicked += RoastedButton_Clicked;
            //BakedButton.Clicked += BakedButton_Clicked;
            //GrilledButton.Clicked += GrilledButton_Clicked;
            //StewedButton.Clicked += StewedButton_Clicked;
            //SoupButton.Clicked += SoupButton_Clicked;
            //SandwhichButton.Clicked += SandwhichButton_Clicked;
        }

        private async void FriedButton_Clicked(object sender, EventArgs e)
        {
            specific_description = "Fried";
            await Navigation.PushAsync(new ResultPageModel(specific_description, protein_word));
        }

        private async void RoastedButton_Clicked(object sender, EventArgs e)
        {
            specific_description = "Roasted";
            await Navigation.PushAsync(new ResultPageModel(specific_description, protein_word));
        }

        private async void BakedButton_Clicked(object sender, EventArgs e)
        {
            specific_description = "Baked";
            await Navigation.PushAsync(new ResultPageModel(specific_description, protein_word));
        }

        private async void GrilledButton_Clicked(object sender, EventArgs e)
        {
            specific_description = "Grilled";
            await Navigation.PushAsync(new ResultPageModel(specific_description, protein_word));
        }

        private async void StewedButton_Clicked(object sender, EventArgs e)
        {
            specific_description = "Stew";
            await Navigation.PushAsync(new ResultPageModel(specific_description, protein_word));
        }

        private async void SoupButton_Clicked(object sender, EventArgs e)
        {
            specific_description = "Soup";
            await Navigation.PushAsync(new ResultPageModel(specific_description, protein_word));
        }

        private async void SandwhichButton_Clicked(object sender, EventArgs e)
        {
            specific_description = "Sandwhich";
            await Navigation.PushAsync(new ResultPageModel(specific_description, protein_word));
        }
    }
}