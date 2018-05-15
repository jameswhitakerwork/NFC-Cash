using NFCFormsSample.Logic;
using Poz1.NFCForms.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NFCFormsSample.View
{
	public class WaitingForTagPage : ContentPage
	{
		public WaitingForTagPage ()
		{
            App.Current.device.NewTag += DeviceHandler.readTag;
            App.Current.device.NewTag += CheckBalance;
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Waiting for tag..." }
                }
            };
        }

        async void CheckBalance(object sender, NfcFormsTag e)
        {
            await Navigation.PushAsync(new CheckBalancePage()); 
        }
	}
}