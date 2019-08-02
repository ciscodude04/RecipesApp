using RecipesApp.ViewModels;
using System;
using Xamarin.Forms;

namespace RecipesApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GotoProteinButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProteinsPageModel());
        }
    }
}
