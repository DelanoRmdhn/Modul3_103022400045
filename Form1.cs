namespace Modul3_103022400045
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!");
                return;
            }

            if (txtNilaiAwal.Text == "")
            {
                MessageBox.Show("Masukan Angka Yang Valid!");
                return;
            }

            double nilai = Convert.ToDouble(txtNilaiAwal.Text);
            string dari = comboBox1.SelectedItem.ToString();
            string ke = comboBox2.SelectedItem.ToString();
            
            double celcius = 0;
            
            if (dari == "Celcius") { 
                celcius = nilai;
            } else if (dari == "Fahrenheit") { 
                celcius = (nilai - 32) * 5 / 9;
            } else if (dari == "Kelvin") { 
                celcius = nilai - 273.15;
            } else if (dari == "Reamur") { 
                celcius = nilai * 5 / 4;
            }

            double hasil = 0;

            if(ke == "Celcius") { 
                hasil = celcius;
            } else if (ke == "Fahrenheit") { 
                hasil = (celcius * 9 / 5) + 32;
            } else if (ke == "Kelvin") { 
                hasil = celcius + 273.15;
            } else if (ke == "Reamur") { 
                hasil = celcius * 4 / 5;
            }

            txtNilaiAkhir.Text = hasil.ToString();
        }

      

        
            
        


        private void txtNilaiAwal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
