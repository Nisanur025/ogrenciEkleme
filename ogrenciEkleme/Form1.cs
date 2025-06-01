using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenciEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {// Ekle Butonu
            try
            {
                int[] sayi = { sayac };
                string adSoyad;
                int no;
                adSoyad = textBox1.Text;
                no = Convert.ToInt32(textBox2.Text);

                if (no == 0)
                {
                    MessageBox.Show("Lütfen 100-1000 araasında no giriniz!");
                }
                int satirindeks = dataGridView1.Rows.Add();// Her seferinde yeni satır ekler
                for (int i = 0; i < sayi.Length; i++)
                {
                    dataGridView1.Rows[satirindeks].Cells[0].Value = no;
                    dataGridView1.Rows[satirindeks].Cells[1].Value = adSoyad;
                    dataGridView1.Rows[satirindeks].Cells[2].Value = comboBox1.SelectedItem;
                    dataGridView1.Rows[satirindeks].Cells[4].Value = dateTimePicker1.Value;
                    if (radioButton1.Checked)
                    {
                        dataGridView1.Rows[satirindeks].Cells[3].Value = radioButton1.Text;
                    }
                    else
                    {
                        dataGridView1.Rows[satirindeks].Cells[3].Value = radioButton2.Text;
                    }
                }
                // Yukarı satırın uzun yolu
                //dataGridView1.Rows[0].Cells[0].Value = no;
                //dataGridView1.Rows[0].Cells[1].Value = adSoyad; // 0.Satır 1.Sütun
                //dataGridView1.Rows[0].Cells[2].Value = comboBox1.SelectedItem;
                //dataGridView1.Rows[0].Cells[4].Value = dateTimePicker1.Value;



                sayac++; // Her butona basımda sayac güncellenir ve for döngüsünde i için kullanırız
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
                // ascending artarak sıralasın, Columns[0] 0.kolon sıralansın

                
            }
            catch(Exception hata)
            {
                MessageBox.Show($"Hata Var!:\n {hata}");
            }
            // en son tüm içerikleri temizleyelim ki veriler yazıldığında tekrar yazabilelim
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.SelectedIndex = -1; // Seçilmemiş olsun
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); // datagridview İçeriğini siler
        }
    }
}
