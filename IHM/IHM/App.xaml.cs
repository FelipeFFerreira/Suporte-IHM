using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using IHM.Views;

namespace IHM
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "Expander_Experimental" });

            InitializeComponent();

            MainPage = new Tela_IHM();
          
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
