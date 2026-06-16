using System; using System.Windows.Forms; using Microsoft.Web.WebView2.WinForms;
namespace WebApp { static class Program { [STAThread] static void Main() {
    Application.EnableVisualStyles(); Application.SetCompatibleTextRenderingDefault(false);
    var form = new Form { Text = "Sinister Mail", Width = 1024, Height = 768, StartPosition = FormStartPosition.CenterScreen };
    var wv = new WebView2(); wv.Dock = DockStyle.Fill; form.Controls.Add(wv);
    wv.CoreWebView2InitializationCompleted += (s, e) => wv.CoreWebView2.Navigate("https://techsinister.com");
    wv.Source = new Uri("https://techsinister.com");
    Application.Run(form);
} } }