using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class Price : Form
    {
        public Price()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Main.listView1.SelectedItems.Count > 0)
            {
                string price = Main.listView1.SelectedItems[0].SubItems[2].Text;
                string name = Main.listView1.SelectedItems[0].SubItems[1].Text;
                string quantity = Main.listView1.SelectedItems[0].SubItems[3].Text;
                string no = Main.listView1.SelectedItems[0].SubItems[0].Text;

                if (Main.GetSqlHandle.UpdatePrice(no, name, textBox1.Text, quantity) == 1)
                {
                    DialogResult d = MessageBox.Show("تم تغير السعر بنجاح الي: [" + price + "]", "اعلام", MessageBoxButtons.OK);
                    if (d == DialogResult.OK)
                        Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
