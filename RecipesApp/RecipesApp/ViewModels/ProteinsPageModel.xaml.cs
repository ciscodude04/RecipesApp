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
		public ProteinsPageModel ()
		{
			InitializeComponent ();
            MeatButton.Clicked += MeatButton_Clicked;
            TurkeyButton.Clicked += TurkeyButton_Clicked;
            ChickenButton.Clicked += TurkeyButton_Clicked;
            PorkButton.Clicked += TurkeyButton_Clicked;
            FishButton.Clicked += FishButton_Clicked;
        }


        private void MeatButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DescriptorPageModel());
        }

        private void TurkeyButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DescriptorPageModel());
        }

        private void ChickenButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DescriptorPageModel());
        }

        private void PorkButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DescriptorPageModel());
        }

        private void FishButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DescriptorPageModel());
        }

        //private void ToolbarItem_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new DescriptorPageModel());
        //}
    }
}