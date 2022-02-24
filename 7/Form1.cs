using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int count = 1;
        owner[] ownerarray = new owner[count];
        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = @"C:/Users/vanya/Desktop/input15.bin";
            try
            {
                using (BinaryReader dataIn = new BinaryReader(new FileStream(path, FileMode.Open), Encoding.GetEncoding("windows-1251")))
                {
                    string fio_;
                    string mark_;
                    string number_;
                    string registration_;
                    string serial_;
                    

                    for (int i = 0; i < count; i++)
                    {
                       fio_ = dataIn.ReadString().Trim();
                       mark_ = dataIn.ReadString().Trim();
                       number_ = dataIn.ReadString().Trim();
                       registration_ = dataIn.ReadString().Trim();
                       serial_ = dataIn.ReadString().Trim();
                       ownerarray[i] = new owner(fio_, mark_, number_, registration_, serial_);
                    }
                }
            }
            catch (IOException exc)
            {
                MessageBox.Show("Ошибка открытия файла:\n{0}", exc.Message);
                return;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dataGridView1[0, 1].Value.ToString();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void условиеЗадачиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(ownerarray[0].fio, ownerarray[0].number, ownerarray[0].mark, ownerarray[0].serial, ownerarray[0].registration);
        }
    }
}
