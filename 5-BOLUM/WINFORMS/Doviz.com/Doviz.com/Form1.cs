using HtmlAgilityPack;

namespace Doviz.com
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 5000;
            timer1.Start();
           

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //HtmlWeb web = new HtmlWeb();
            //var htmlDoc = web.Load("https://www.doviz.com");
            //var node = htmlDoc.DocumentNode.SelectSingleNode("//html/body/header/div[2]/div/div[1]/div[1]/a/span[2]").InnerHtml;

            //textBox1.Text = node;

            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load("https://tr.wikipedia.org/wiki/Anasayfa");
            var node = htmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"mp-tfa-h2\"]/a/span").InnerHtml;

            textBox1.Text = node;


            var content = htmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"mp-tfa\"]").InnerText;

            richTextBox1.Text = content;

            // textBox1.Text = node;
            // //*[@id="c1"]/div[1]/span[1]/span

        }
    }
}
