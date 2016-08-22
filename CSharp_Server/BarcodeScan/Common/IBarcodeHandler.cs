using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarcodeScan.Common
{
    interface IBarcodeHandler
    {
        string Post(string barcode);
    }
}
