using Microsoft.Web.WebView2.Core;

namespace GoogleWeb2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task initizated()
        {
            var env = await CoreWebView2Environment.CreateAsync(userDataFolder: Path.GetTempPath());
            await webView21.EnsureCoreWebView2Async(env);
        }
        public async void InitBrowser()
        {
            await initizated();
           webView21.CoreWebView2.Navigate("https://www.google.com/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           InitBrowser();
        }
    }
}