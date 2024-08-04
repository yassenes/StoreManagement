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
    public partial class Name : Form
    {
        public Name()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Main.listView1.SelectedItems.Count > 0)
            {
                string price = Main.listView1.SelectedItems[0].SubItems[2].Text;
                string quantity = Main.listView1.SelectedItems[0].SubItems[3].Text;
                string no = Main.listView1.SelectedItems[0].SubItems[0].Text;

                if (Main.GetSqlHandle.UpdateName(no, textBox1.Text, price, quantity) == 1)
                {
                    DialogResult d = MessageBox.Show("تم تغير الاسم بنجاح الي: [" + price + "]", "اعلام", MessageBoxButtons.OK);
                    if (d == DialogResult.OK)
                        Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
