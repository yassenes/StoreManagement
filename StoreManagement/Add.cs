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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addNewItem_Click(object sender, EventArgs e)
        {
            Main.GetSqlHandle.Add(textName.Text, textPrice.Text, textQuantity.Text);
            DialogResult dialog = MessageBox.Show("تم الاضافة بنجاح", "اضافة ايتم", MessageBoxButtons.OK);
            if (dialog == DialogResult.OK)
            {
                Close();
            }
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
