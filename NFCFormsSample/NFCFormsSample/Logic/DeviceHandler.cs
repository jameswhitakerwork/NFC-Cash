using NdefLibrary.Ndef;
using NFCFormsSample.View;
using Poz1.NFCForms.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace NFCFormsSample.Logic
{
    public static class DeviceHandler
    {
        static INfcForms device = DependencyService.Get<INfcForms>();
        private static Switch IsWriteable;
        private static Switch IsConnected;
        private static Switch IsNDEFSupported;
        public static ObservableCollection<string> ndefMessageCollection;

        public static string test = "tag contents...";

        public static void NFCFormsSample()
        {
            device = DependencyService.Get<INfcForms>();
        }

        public static async void readTag(object sender, NfcFormsTag e)
        {
            //IsWriteable.IsToggled = e.IsWriteable; error object reference instance
            // IsNDEFSupported.IsToggled = e.IsNdefSupported;

            if (e.IsNdefSupported)
                ndefMessageCollection = readNDEFMEssage(e.NdefMessage);
            test = ndefMessageCollection.ToString();
        }

        public static ObservableCollection<string> readNDEFMEssage(NdefMessage message)
        {
            ObservableCollection<string> collection = new ObservableCollection<string>();

            if (message == null)
            {
                return collection;
            }

            foreach (NdefRecord record in message)
            {
                // Go through each record, check if it's a Smart Poster
                if (record.CheckSpecializedType(false) == typeof(NdefSpRecord))
                {
                    // Convert and extract Smart Poster info
                    var spRecord = new NdefSpRecord(record);
                    collection.Add("URI: " + spRecord.Uri);
                    collection.Add("Titles: " + spRecord.TitleCount());
                    collection.Add("1. Title: " + spRecord.Titles[0].Text);
                    collection.Add("Action set: " + spRecord.ActionInUse());
                }

                if (record.CheckSpecializedType(false) == typeof(NdefUriRecord))
                {
                    // Convert and extract Smart Poster info
                    var spRecord = new NdefUriRecord(record);
                    collection.Add("Text: " + spRecord.Uri);
                }
            }



            return collection;
        }
    }
}

