using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using NFCFormsSample.View;

namespace NFCFormsSample.View
{
	public class MenuPage : ContentPage
	{
		public MenuPage ()
		{

            Grid mainGrid = new Grid()
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1,GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1,GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1,GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1,GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1,GridUnitType.Star) }
                },

                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star ) },
                }
            };


            Button newTransactionButton = new Button() { Text = "New Transaction" };
            newTransactionButton.Clicked += NewTransactionButtonClicked;

            Button checkBalanceButton = new Button() { Text = "Check Balance" };
            checkBalanceButton.Clicked += CheckBalanceButtonClicked; 

            Button viewTransactionsButton = new Button() { Text = "View Transactions" };
            viewTransactionsButton.Clicked += ViewTransactionsButtonClicked;

            Button exportTransactionsButton = new Button() { Text = "Export Transactions" };
            exportTransactionsButton.Clicked += ExportTransactionsButtonClicked;

            Button loadOrUpdateDataButton = new Button() { Text = "Load or Update Data" };
            loadOrUpdateDataButton.Clicked += LoadOrUpdateDataButtonClicked;

            async void NewTransactionButtonClicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new TransactionPage () );
            }

            async void CheckBalanceButtonClicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new WaitingForTagPage ());
            }

            void ViewTransactionsButtonClicked(object sender, EventArgs e)
            {
                return;
            }

            void ExportTransactionsButtonClicked(object sender, EventArgs e)
            {
                return;
            }

            void LoadOrUpdateDataButtonClicked(object sender, EventArgs e)
            {
                return;
            }




            mainGrid.Children.Add(newTransactionButton, 0, 0);
            mainGrid.Children.Add(viewTransactionsButton, 0, 1);
            mainGrid.Children.Add(exportTransactionsButton, 0, 2);
            mainGrid.Children.Add(loadOrUpdateDataButton, 0, 3);
            mainGrid.Children.Add(checkBalanceButton, 0, 4);

            Content = mainGrid;


		}
	};
}