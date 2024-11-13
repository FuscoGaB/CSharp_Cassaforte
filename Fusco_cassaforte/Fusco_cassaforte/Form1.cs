namespace Fusco_cassaforte
{
    public partial class Form1 : Form
    {
        private double numeriSicurezza;
        private double numeri;
        private double codice;
        private Cassaforte c;
        public Form1()
        {
            InitializeComponent();
            c = new Cassaforte(001, "zx10r", "kawasaki", "a1b2c3d4e5f6");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void impostaCodiceUtente()
        {

        }

        private void testoCodice_TextChanged(object sender, EventArgs e)
        {
            numeri = Convert.ToInt32(testoCodice.Text);

        }

        private void accessoCodice_TextChanged(object sender, EventArgs e)
        {
            numeriSicurezza = Convert.ToInt32(accessoCodice.Text);
            //cassaforte.Codiceutente
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numeri < 0)
            {
                numeri = 0;
                testoCodice.Text = numeri.ToString();
            }
            if (numeri > 99999)
            {
                numeri = 99999;
                testoCodice.Text = numeri.ToString();
            }
            //testoCodice.Text = Convert.ToString(numeri);
            MessageBox.Show("Codice registrato");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numeriSicurezza == numeri) 
            {
                MessageBox.Show("Hai inserito il codice corretto");
            }
            if (numeriSicurezza != numeri)
            {
                MessageBox.Show("Hai inserito il codice errato!!");
                accessoCodice.Text = $"{0}";
            }
        }
    }
}
