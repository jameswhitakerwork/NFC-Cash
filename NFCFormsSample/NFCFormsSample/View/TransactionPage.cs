using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NFCFormsSample.View
{
	public class TransactionPage : ContentPage
	{
        Entry entry;

		public TransactionPage ()
		{
            entry = new Entry { Placeholder = "Input transaction amount" };
            entry.Keyboard = Keyboard.Numeric;


            Content = new StackLayout
            {
                Children = { entry }

            };

		}
	}
}