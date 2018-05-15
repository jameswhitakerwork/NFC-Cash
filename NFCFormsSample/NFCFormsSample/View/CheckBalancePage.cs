using NFCFormsSample.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NFCFormsSample.View
{
	public class CheckBalancePage : ContentPage
	{
		public CheckBalancePage ()
		{
            App.Current.device.NewTag += DeviceHandler.readTag;  
			Content = new StackLayout {
				Children = {
					new Label { Text = DeviceHandler.test }
				}
			};
		}
	}
}