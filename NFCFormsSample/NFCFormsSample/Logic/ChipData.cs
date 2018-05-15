using System;
using System.Collections.Generic;
using System.Text;
using NdefLibrary.Ndef;

namespace NFCFormsSample.Logic
{
    class ChipData
    {
        string payload;
        string projectID;
        int beneficiaryID;
        int chipID;
        double balance;
        int passCode;

        public void Unpack(NdefRecord ndefRecord)
        {
            //unpack the record and set this objects properties
            payload = ndefRecord.ToString();

        }

        public NdefRecord Pack()
        {
            // pack up this object into a record to be returned for creating a message to be written to the tag
            var message = new NdefRecord();
            return message;
        }
    }
}
