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
		public DescriptorPageModel ()
		{
			InitializeComponent ();
            FriedButton.Clicked += FriedButton_Clicked;
            RoastedButton.Clicked += RoastedButton_Clicked;
            BakedButton.Clicked += BakedButton_Clicked;
            GrilledButton.Clicked += GrilledButton_Clicked;
            StewedButton.Clicked += StewedButton_Clicked;
            SoupButton.Clicked += SoupButton_Clicked;
            SandwhichButton.Clicked += SandwhichButton_Clicked;
		}

        private void FriedButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ResultPageModel());
        }

        private void RoastedButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ResultPageModel());
        }

        private void BakedButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ResultPageModel());
        }

        private void GrilledButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ResultPageModel());
        }

        private void StewedButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ResultPageModel());
        }

        private void SoupButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ResultPageModel());
        }

        private void SandwhichButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ResultPageModel());
        }
    }
}