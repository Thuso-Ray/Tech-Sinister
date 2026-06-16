using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace WebApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new Form { Text = "Sinister Mail", Width = 1024, Height = 768, StartPosition = FormStartPosition.CenterScreen };
            var webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            form.Controls.Add(webView);
            webView.CoreWebView2InitializationCompleted += (s, e) => webView.CoreWebView2.Navigate("https://mail.techsinister.com");
            webView.Source = new Uri("https://mail.techsinister.com");
            Application.Run(form);
        }
    }
}