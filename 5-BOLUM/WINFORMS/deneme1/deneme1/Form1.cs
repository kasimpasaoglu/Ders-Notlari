namespace deneme1
{
    public partial class Form1 : Form
    {
        string secim = "";
        int sayi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // sayýlarýn herhangi bir tanesine týklanýldýðýnda, ekranda bu sayýyý görelim!!

            var selectedButton = (Button)sender;

            lblEkran.Text += selectedButton.Text;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            // iþlem düðmelerine bastýðýmýzda bu metoda gelecekler!!
            var selectedIslem = (Button)sender;
            secim = selectedIslem.Text;

            // ekrandaki deðeri bir deðiþken üzerine alalým!!

            sayi = int.Parse(lblEkran.Text);
            // ekraný temizle
            lblEkran.Text = "";

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // sayi butonlarýna týklanýldýðýnda bu metoda geliyor!!

            MessageBox.Show("týklanýldý");

           

        }

        private void button15_Click(object sender, EventArgs e)
        {
            // eþittir düððmesine basýldýðýnda çalýþýr!!

            int sayi2 = int.Parse(lblEkran.Text);
            if (secim == "+")
            {
                lblEkran.Text=(sayi+sayi2).ToString();
            }
            else if (secim == "-")
            {
                lblEkran.Text = (sayi - sayi2).ToString();
            }
            else if (secim == "/")
            {
                lblEkran.Text = (sayi / sayi2).ToString();
            }
            else if (secim == "x")
            {
                lblEkran.Text = (sayi * sayi2).ToString();
            }
        }
    }
}
