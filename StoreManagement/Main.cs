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
    public partial class Main : Form
    {
        public static SqlHandle GetSqlHandle { get; set; }
        private Size oldSize;
        public Main()
        {
            InitializeComponent();

            var ini = new IniFile("sql.ini");
            var host = ini.Read("Host", "Sql");
            GetSqlHandle = new SqlHandle($"Server={host};Database=Store;Integrated Security=True;MultipleActiveResultSets=True;");
            // GetSqlHandle = new SqlHandle($"Data Source={host};Network Library=DBMSSOCN;Initial Catalog={database};User ID={user};Password={password};Connection Timeout=10;MultipleActiveResultSets=True;");


            GetSqlHandle.LoadItems();
            GetSqlHandle.LoadSold();
            GetSqlHandle.LoadHistory();
            GetSqlHandle.ItemCount();
            GetSqlHandle.SoldCount();

            oldSize = base.Size;
        }

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            foreach (Control cnt in this.Controls)
            {
                ResizeAll(cnt, base.Size);
            }
            oldSize = base.Size;
        }
        private void ResizeAll(Control cnt, Size newSize)
        {
            int iWidth = newSize.Width - oldSize.Width;
            cnt.Left += (cnt.Left * iWidth) / oldSize.Width;
            cnt.Width += (cnt.Width * iWidth) / oldSize.Width;

            int iHeight = newSize.Height - oldSize.Height;
            cnt.Top += (cnt.Top * iHeight) / oldSize.Height;
            cnt.Height += (cnt.Height * iHeight) / oldSize.Height;

            listView1.Width += (listView1.Width * iWidth) / oldSize.Width;

            listView1.Height += (listView1.Height * iHeight) / oldSize.Height;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quantity quantity = new Quantity();
            quantity.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sold sold = new Sold();
            sold.Show();
            sold.textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dialog = MessageBox.Show("هل انت متاكد؟", "مسح ايتم", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    string price = Main.listView1.SelectedItems[0].SubItems[2].Text;
                    string name = Main.listView1.SelectedItems[0].SubItems[1].Text;
                    string quantity = Main.listView1.SelectedItems[0].SubItems[3].Text;
                    string no = Main.listView1.SelectedItems[0].SubItems[0].Text;

                    Main.GetSqlHandle.RemoveItem(no, name, price, quantity);

                }
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dialog = MessageBox.Show("هل انت متاكد؟", "مسح ايتم", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    string price = Main.listView1.SelectedItems[0].SubItems[2].Text;
                    string name = Main.listView1.SelectedItems[0].SubItems[1].Text;
                    string quantity = Main.listView1.SelectedItems[0].SubItems[3].Text;
                    string no = Main.listView1.SelectedItems[0].SubItems[0].Text;

                    Main.GetSqlHandle.RemoveItem(no, name, price, quantity);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lVSold_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Price price = new Price();
            price.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void sqlConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {
                    var item = listView1.Items[i];
                    if (item.SubItems[1].Text.ToLower().Contains(textBox1.Text.ToLower()))
                    {
                    }
                    else
                    {
                        listView1.Items.Remove(item);
                    }
                }
                if (listView1.SelectedItems.Count == 1)
                {
                    listView1.Focus();
                }
            }
            else
            {
                GetSqlHandle.LoadItems();
            }
        }
    }
}
