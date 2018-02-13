using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockPatternViewer
{
    class CommonLibrary
    {
        public string FileName;

        public CommonLibrary()
        {
            OpenFileDialog openDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                Multiselect = false
            };
            openDialog.ShowDialog();
            if (openDialog.FileName!="")
            {
                FileName=openDialog.FileName;
            }
        }

    }
}
