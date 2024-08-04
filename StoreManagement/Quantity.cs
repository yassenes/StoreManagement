﻿using System;
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
    public partial class Quantity : Form
    {
        public Quantity()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Main.listView1.SelectedItems.Count > 0)
            {
                string no = Main.listView1.SelectedItems[0].SubItems[0].Text;
                string name = Main.listView1.SelectedItems[0].SubItems[1].Text;
                string price = Main.listView1.SelectedItems[0].SubItems[2].Text;
                if (Main.GetSqlHandle.ChangeQuantity(no, name, price, textBox1.Text) == 1)
                {
                    DialogResult d = MessageBox.Show("تم تغير الكمية بنجاح الي: [" + textBox1.Text + "]", "اعلام", MessageBoxButtons.OK);
                    if (d == DialogResult.OK)
                        Close();
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
