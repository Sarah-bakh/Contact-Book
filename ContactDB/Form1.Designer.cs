namespace ContactDB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btndel = new Button();
            btnedit = new Button();
            dgcontact = new DataGridView();
            contactID = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            MyName = new DataGridViewTextBoxColumn();
            Family = new DataGridViewTextBoxColumn();
            Mobile = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtsearch = new TextBox();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgcontact).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1277, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(124, 24);
            toolStripButton1.Text = "افزودن مورد جدید";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(93, 24);
            toolStripButton2.Text = "به روز رسانی";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtsearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1265, 73);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btndel);
            groupBox2.Controls.Add(btnedit);
            groupBox2.Controls.Add(dgcontact);
            groupBox2.Location = new Point(0, 107);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1277, 355);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "لیست";
            // 
            // btndel
            // 
            btndel.Location = new Point(1057, 326);
            btndel.Name = "btndel";
            btndel.Size = new Size(94, 29);
            btndel.TabIndex = 2;
            btndel.Text = "حذف";
            btndel.UseVisualStyleBackColor = true;
            btndel.Click += btndel_Click;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(1168, 326);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(94, 29);
            btnedit.TabIndex = 1;
            btnedit.Text = "ویرایش";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // dgcontact
            // 
            dgcontact.AllowUserToAddRows = false;
            dgcontact.AllowUserToDeleteRows = false;
            dgcontact.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgcontact.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgcontact.Columns.AddRange(new DataGridViewColumn[] { contactID, Email, MyName, Family, Mobile, Age });
            dgcontact.Location = new Point(0, 27);
            dgcontact.Name = "dgcontact";
            dgcontact.ReadOnly = true;
            dgcontact.RowHeadersWidth = 51;
            dgcontact.Size = new Size(1262, 286);
            dgcontact.TabIndex = 0;
            // 
            // contactID
            // 
            contactID.DataPropertyName = "ContactID";
            contactID.HeaderText = "کدشخص";
            contactID.MinimumWidth = 6;
            contactID.Name = "contactID";
            contactID.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "ایمیل";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // MyName
            // 
            MyName.DataPropertyName = "Name";
            MyName.HeaderText = "نام";
            MyName.MinimumWidth = 6;
            MyName.Name = "MyName";
            MyName.ReadOnly = true;
            // 
            // Family
            // 
            Family.DataPropertyName = "Family";
            Family.HeaderText = "نام خانوادگی";
            Family.MinimumWidth = 6;
            Family.Name = "Family";
            Family.ReadOnly = true;
            // 
            // Mobile
            // 
            Mobile.DataPropertyName = "Mobile";
            Mobile.HeaderText = "شماره موبایل";
            Mobile.MinimumWidth = 6;
            Mobile.Name = "Mobile";
            Mobile.ReadOnly = true;
            // 
            // Age
            // 
            Age.DataPropertyName = "Age";
            Age.HeaderText = "سن";
            Age.MinimumWidth = 6;
            Age.Name = "Age";
            Age.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1127, 34);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 0;
            label1.Text = "جستحو:";
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(547, 31);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(552, 28);
            txtsearch.TabIndex = 1;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 507);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "دفترچه تلفن من";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgcontact).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgcontact;
        private DataGridViewTextBoxColumn contactID;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn MyName;
        private DataGridViewTextBoxColumn Family;
        private DataGridViewTextBoxColumn Mobile;
        private DataGridViewTextBoxColumn Age;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private Button btndel;
        private Button btnedit;
        private TextBox txtsearch;
        private Label label1;
    }
}
