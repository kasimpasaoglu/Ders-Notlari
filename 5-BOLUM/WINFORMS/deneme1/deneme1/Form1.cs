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
            // say�lar�n herhangi bir tanesine t�klan�ld���nda, ekranda bu say�y� g�relim!!

            var selectedButton = (Button)sender;

            lblEkran.Text += selectedButton.Text;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            // i�lem d��melerine bast���m�zda bu metoda gelecekler!!
            var selectedIslem = (Button)sender;
            secim = selectedIslem.Text;

            // ekrandaki de�eri bir de�i�ken �zerine alal�m!!

            sayi = int.Parse(lblEkran.Text);
            // ekran� temizle
            lblEkran.Text = "";

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // sayi butonlar�na t�klan�ld���nda bu metoda geliyor!!

            MessageBox.Show("t�klan�ld�");

           

        }

        private void button15_Click(object sender, EventArgs e)
        {
            // e�ittir d���mesine bas�ld���nda �al���r!!

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
