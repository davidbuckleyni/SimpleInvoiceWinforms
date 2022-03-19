using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.Theme;
using Syncfusion.WinForms.Core;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.Core;
using Syncfusion.WinForms.Themes;

namespace SimpleInvoice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTk4MTAxQDMxMzkyZTM0MmUzMGFFZnMrai8ra0RUOSs2VlFVamc0UHVIeFpYYkNsQzBZQVpXOFBXdkhiaEk9");
            SfSkinManager.LoadAssembly(typeof(GridOffice2016DarkGrayThemeColors).Assembly);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
