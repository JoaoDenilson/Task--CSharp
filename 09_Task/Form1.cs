using System.Windows.Forms;
using System.Net;
namespace _09_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            string address = txtSite.Text;

            WebClient web = new WebClient();
            //string html = web.DownloadString(address);
            string html = await web.DownloadStringTaskAsync(new Uri(address));

            txtResult.Text = html;
        }
    }
}