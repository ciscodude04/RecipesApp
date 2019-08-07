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
	public partial class ProteinsPageModel : ContentPage
	{
        string specific_protein;
		public ProteinsPageModel ()
		{
			InitializeComponent ();
            //MeatButton.Clicked += MeatButton_Clicked;
            //TurkeyButton.Clicked += TurkeyButton_Clicked;
            //ChickenButton.Clicked += TurkeyButton_Clicked;
            //PorkButton.Clicked += TurkeyButton_Clicked;
            //FishButton.Clicked += FishButton_Clicked;
        }


        private async void MeatButton_Clicked(object sender, EventArgs e)
        {
            specific_protein = "Beef";
            await Navigation.PushAsync(new DescriptorPageModel(specific_protein));
        }

        private async void TurkeyButton_Clicked(object sender, EventArgs e)
        {
            specific_protein = "Turkey";
            await Navigation.PushAsync(new DescriptorPageModel(specific_protein));
        }

        private async void ChickenButton_Clicked(object sender, EventArgs e)
        {
            specific_protein = "Chicken";
            await Navigation.PushAsync(new DescriptorPageModel(specific_protein));
        }

        private async void PorkButton_Clicked(object sender, EventArgs e)
        {
            specific_protein = "Pork";
            await Navigation.PushAsync(new DescriptorPageModel(specific_protein));
        }

        private async void FishButton_Clicked(object sender, EventArgs e)
        {
            specific_protein = "Fish";
            await Navigation.PushAsync(new DescriptorPageModel(specific_protein));
        }

        //private void ToolbarItem_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new DescriptorPageModel());
        //}
    }
}