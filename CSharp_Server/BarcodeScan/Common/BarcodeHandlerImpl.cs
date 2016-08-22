using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarcodeScan.Common
{
    class BarcodeHandlerImpl:IBarcodeHandler
    {
        public string Post(string barcode)
        {
            //条码处理逻辑
            return barcode;
        }
    }
}
