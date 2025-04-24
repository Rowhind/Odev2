using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ListedenListeye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);

            textBox1.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<object> selectedItems = new List<object>();

            foreach (var item in listBox1.SelectedItems)
            {
                selectedItems.Add(item);
            }

            // Seçilenleri listBox2'ye ekleyip listBox1'den kaldır
            foreach (var item in selectedItems)
            {
                listBox2.Items.Add(item);
                listBox1.Items.Remove(item);
            }
        }
    }
}
