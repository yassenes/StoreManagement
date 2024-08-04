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
    public partial class Sold : Form
    {
        public Sold()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Main.listView1.SelectedItems.Count > 0)
            {
                string no = Main.listView1.SelectedItems[0].SubItems[0].Text;
                string name = Main.listView1.SelectedItems[0].SubItems[1].Text;
                string price = Main.listView1.SelectedItems[0].SubItems[2].Text;
                uint programPrice = Convert.ToUInt32(textBox2.Text);
                uint currentPrice = Convert.ToUInt32(price);
                uint total = programPrice - currentPrice;

                int quantity = Convert.ToInt32(textBox1.Text);

                if (Main.GetSqlHandle.ItemSold(no, name, Convert.ToString(total * quantity), textBox1.Text, price) == 1)
                {
                    DialogResult dialog = MessageBox.Show("تم بيع: [" + name + "] بكمية [" + textBox1.Text + "]", "اعلام", MessageBoxButtons.OK);
                    if (dialog == DialogResult.OK)
                    {
                        Close();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
