namespace Fusco_cassaforte
{
    public partial class Form1 : Form
    {
        private string inserito;
        private int conta;
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
            if (numeri < 1)
            {
                numeri = 1;
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
                MessageBox.Show("Hai inserito il codice corretto, cassaforte aperta!");
                button3.Location = new Point(button3.Location.X + 100, button3.Location.Y);
            }
            if (numeriSicurezza != numeri)
            {
                if (conta < 6)
                {
                    MessageBox.Show("Hai inserito il codice errato!!... Riprova");
                    accessoCodice.Text = $"{1}";
                    conta++;
                }
                if (conta > 5)
                {
                    MessageBox.Show("Hai raggiunto i tentativi massimi!! Non puoi piu' accedere alla cassaforte");
                }
            }

            //sposta button

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button3.Location = new Point(button3.Location.X - 100, button3.Location.Y);
        }

        private void apri()
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            inserito = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (c.CodiceSbloccoSegreto == inserito)
            {
                MessageBox.Show("Hai inserito il codice corretto, cassaforte aperta!");
                button3.Location = new Point(button3.Location.X + 100, button3.Location.Y);
            }
            if (c.CodiceSbloccoSegreto != inserito)
            {
                MessageBox.Show("Hai inserito il codice errato!");            
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
