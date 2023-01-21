using _06_events.lib;
using _06_events.lib.Messenger;
namespace _06_events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnVideEncode.Click += EventOfClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EventOfClick(object sender, EventArgs e)
        {
            Video video = new Video() { Name = "Video.mp4" };
            VideoEncode vid = new VideoEncode();

            vid.Encoded += new Email().SendMensage;
            vid.Encoded += new SMS().SendMensage;

            vid.Encode(video);
        }

    }
}