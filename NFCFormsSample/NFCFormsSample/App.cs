using NFCFormsSample.View;
using Poz1.NFCForms.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NFCFormsSample
{
	public class App : Application
	{

        public INfcForms device;

        public App ()
		{
            // The root page of your application
            device = DependencyService.Get<INfcForms>();
            MainPage = new NavigationPage(new MenuPage() ); 
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        public static new App Current
        {
            get
            {
                return (App)Application.Current;
            }
        }
    }
}
