namespace StoreManagement
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sqlConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tSold = new System.Windows.Forms.TabPage();
            lVSold = new System.Windows.Forms.ListView();
            cNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            tItems = new System.Windows.Forms.TabPage();
            listView1 = new System.Windows.Forms.ListView();
            ciNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ciName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ciPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ciQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ciDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            listView2 = new System.Windows.Forms.ListView();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            tSold.SuspendLayout();
            tItems.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            storeToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(821, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // storeToolStripMenuItem
            // 
            storeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            addToolStripMenuItem,
            removeToolStripMenuItem,
            sqlConnectToolStripMenuItem,
            exitToolStripMenuItem});
            storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            storeToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            storeToolStripMenuItem.Text = "Store";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += new System.EventHandler(addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += new System.EventHandler(removeToolStripMenuItem_Click);
            // 
            // sqlConnectToolStripMenuItem
            // 
            sqlConnectToolStripMenuItem.Name = "sqlConnectToolStripMenuItem";
            sqlConnectToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            sqlConnectToolStripMenuItem.Text = "Sql Connect";
            sqlConnectToolStripMenuItem.Click += new System.EventHandler(sqlConnectToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(603, 81);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(100, 59);
            button1.TabIndex = 2;
            button1.Text = "اضافة ايتم جديد";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click);
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(718, 146);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(91, 55);
            button2.TabIndex = 3;
            button2.Text = "بيع";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(button2_Click);
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(603, 146);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(100, 55);
            button3.TabIndex = 4;
            button3.Text = "تغير الكمية";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(button3_Click);
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(718, 81);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(91, 59);
            button4.TabIndex = 5;
            button4.Text = "مسح ايتم";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new System.EventHandler(button4_Click);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(608, 373);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(185, 123);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات المتجر";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(20, 75);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(13, 13);
            label6.TabIndex = 5;
            label6.Text = "0";
            label6.Click += new System.EventHandler(label6_Click);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(115, 75);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 13);
            label5.TabIndex = 4;
            label5.Text = ":المخزونات";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(20, 44);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(13, 13);
            label4.TabIndex = 3;
            label4.Text = "0";
            label4.Click += new System.EventHandler(label4_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(101, 44);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(82, 13);
            label3.TabIndex = 2;
            label3.Text = ":البضاعة المباعة";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(20, 16);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(13, 13);
            label2.TabIndex = 1;
            label2.Text = "0";
            label2.Click += new System.EventHandler(label2_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(94, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 13);
            label1.TabIndex = 0;
            label1.Text = ":البضاعة الموجودة";
            // 
            // tSold
            // 
            tSold.Controls.Add(lVSold);
            tSold.Location = new System.Drawing.Point(4, 22);
            tSold.Name = "tSold";
            tSold.Padding = new System.Windows.Forms.Padding(3);
            tSold.Size = new System.Drawing.Size(582, 447);
            tSold.TabIndex = 1;
            tSold.Text = "مباع";
            tSold.UseVisualStyleBackColor = true;
            // 
            // lVSold
            // 
            lVSold.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            cNo,
            cName,
            cPrice,
            cQuantity,
            cDate});
            lVSold.FullRowSelect = true;
            lVSold.GridLines = true;
            lVSold.HideSelection = false;
            lVSold.Location = new System.Drawing.Point(3, 6);
            lVSold.Name = "lVSold";
            lVSold.Size = new System.Drawing.Size(573, 435);
            lVSold.TabIndex = 0;
            lVSold.UseCompatibleStateImageBehavior = false;
            lVSold.View = System.Windows.Forms.View.Details;
            lVSold.SelectedIndexChanged += new System.EventHandler(lVSold_SelectedIndexChanged);
            // 
            // cNo
            // 
            cNo.Text = "رقم";
            // 
            // cName
            // 
            cName.Text = "الاسم";
            cName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            cName.Width = 200;
            // 
            // cPrice
            // 
            cPrice.Text = "السعر";
            cPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            cPrice.Width = 90;
            // 
            // cQuantity
            // 
            cQuantity.Text = "الكمية";
            cQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cDate
            // 
            cDate.Text = "ميعاد البيع";
            cDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            cDate.Width = 159;
            // 
            // tItems
            // 
            tItems.Controls.Add(listView1);
            tItems.ForeColor = System.Drawing.SystemColors.ControlText;
            tItems.Location = new System.Drawing.Point(4, 22);
            tItems.Name = "tItems";
            tItems.Padding = new System.Windows.Forms.Padding(3);
            tItems.Size = new System.Drawing.Size(582, 447);
            tItems.TabIndex = 0;
            tItems.Text = "البضاعة";
            tItems.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            ciNo,
            ciName,
            ciPrice,
            ciQuantity,
            ciDate});
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(3, 6);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(573, 441);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.SelectedIndexChanged += new System.EventHandler(listView1_SelectedIndexChanged);
            // 
            // ciNo
            // 
            ciNo.Text = "رقم";
            // 
            // ciName
            // 
            ciName.Text = "الاسم";
            ciName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ciName.Width = 200;
            // 
            // ciPrice
            // 
            ciPrice.Text = "السعر";
            ciPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ciPrice.Width = 90;
            // 
            // ciQuantity
            // 
            ciQuantity.Text = "الكمية";
            ciQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ciDate
            // 
            ciDate.Text = "الميعاد";
            ciDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ciDate.Width = 159;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tItems);
            tabControl1.Controls.Add(tSold);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new System.Drawing.Point(12, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(590, 473);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listView2);
            tabPage1.Location = new System.Drawing.Point(4, 22);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new System.Drawing.Size(582, 447);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "التحويلات";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3,
            columnHeader4,
            columnHeader5});
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.HideSelection = false;
            listView2.Location = new System.Drawing.Point(3, 6);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new System.Drawing.Size(573, 441);
            listView2.TabIndex = 2;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = System.Windows.Forms.View.Details;
            listView2.SelectedIndexChanged += new System.EventHandler(listView2_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "نوع التغير";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "الاسم";
            columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "السعر";
            columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "الكمية";
            columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "الميعاد";
            columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader5.Width = 159;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(718, 207);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(91, 49);
            button5.TabIndex = 7;
            button5.Text = "تغير السعر";
            button5.UseVisualStyleBackColor = true;
            button5.Click += new System.EventHandler(button5_Click);
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(603, 207);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(100, 49);
            button6.TabIndex = 8;
            button6.Text = "تغير الاسم";
            button6.UseVisualStyleBackColor = true;
            button6.Click += new System.EventHandler(button6_Click);
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(603, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(164, 20);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(773, 58);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(36, 13);
            label7.TabIndex = 10;
            label7.Text = "الاسم";
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(821, 512);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Store";
            Load += new System.EventHandler(Main_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tSold.ResumeLayout(false);
            tItems.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ColumnHeader cNo;
        public System.Windows.Forms.ColumnHeader cName;
        public System.Windows.Forms.ColumnHeader cPrice;
        public System.Windows.Forms.ColumnHeader cQuantity;
        public System.Windows.Forms.ColumnHeader cDate;
        public System.Windows.Forms.TabPage tItems;
        public System.Windows.Forms.ColumnHeader ciNo;
        public System.Windows.Forms.ColumnHeader ciName;
        public System.Windows.Forms.ColumnHeader ciPrice;
        public System.Windows.Forms.ColumnHeader ciQuantity;
        public System.Windows.Forms.ColumnHeader ciDate;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripMenuItem sqlConnectToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        public static System.Windows.Forms.Button button6;
        public static System.Windows.Forms.Label label1;
        public static System.Windows.Forms.Button button5;
        public static System.Windows.Forms.ListView listView2;
        public static System.Windows.Forms.Label label6;
        public static System.Windows.Forms.Label label5;
        public static System.Windows.Forms.Label label4;
        public static System.Windows.Forms.Label label3;
        public static System.Windows.Forms.Label label2;
        public static System.Windows.Forms.TabPage tSold;
        public static System.Windows.Forms.ListView lVSold;
        public static System.Windows.Forms.ListView listView1;
    }
}

