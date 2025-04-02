namespace ContactDB
{
    partial class FRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            sbmbtn = new Button();
            txtadress = new TextBox();
            label6 = new Label();
            txtmail = new TextBox();
            label5 = new Label();
            numage = new NumericUpDown();
            label4 = new Label();
            txtmobile = new TextBox();
            label3 = new Label();
            txtfamily = new TextBox();
            label2 = new Label();
            Txtname = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numage).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(sbmbtn);
            groupBox1.Controls.Add(txtadress);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(numage);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtmobile);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtfamily);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Txtname);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 319);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // sbmbtn
            // 
            sbmbtn.Location = new Point(348, 265);
            sbmbtn.Name = "sbmbtn";
            sbmbtn.Size = new Size(94, 29);
            sbmbtn.TabIndex = 12;
            sbmbtn.Text = "ثبت";
            sbmbtn.UseVisualStyleBackColor = true;
            sbmbtn.Click += sbmbtn_Click;
            // 
            // txtadress
            // 
            txtadress.Location = new Point(26, 176);
            txtadress.Multiline = true;
            txtadress.Name = "txtadress";
            txtadress.Size = new Size(416, 83);
            txtadress.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(448, 179);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 10;
            label6.Text = "آدرس:";
            // 
            // txtmail
            // 
            txtmail.Location = new Point(26, 134);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(416, 27);
            txtmail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(448, 137);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 8;
            label5.Text = "ایمیل:";
            // 
            // numage
            // 
            numage.Location = new Point(37, 83);
            numage.Name = "numage";
            numage.Size = new Size(136, 27);
            numage.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 85);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 6;
            label4.Text = "سن:";
            // 
            // txtmobile
            // 
            txtmobile.Location = new Point(320, 86);
            txtmobile.Name = "txtmobile";
            txtmobile.Size = new Size(136, 27);
            txtmobile.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 89);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 4;
            label3.Text = "موبایل:";
            // 
            // txtfamily
            // 
            txtfamily.Location = new Point(37, 39);
            txtfamily.Name = "txtfamily";
            txtfamily.Size = new Size(136, 27);
            txtfamily.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 42);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 2;
            label2.Text = "نام خانوادگی:";
            // 
            // Txtname
            // 
            Txtname.Location = new Point(320, 36);
            Txtname.Name = "Txtname";
            Txtname.Size = new Size(136, 27);
            Txtname.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(462, 39);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 0;
            label1.Text = "نام:";
            // 
            // FRM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 329);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRM";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Load += FRM_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button sbmbtn;
        private TextBox txtadress;
        private Label label6;
        private TextBox txtmail;
        private Label label5;
        private NumericUpDown numage;
        private Label label4;
        private TextBox txtmobile;
        private Label label3;
        private TextBox txtfamily;
        private Label label2;
        private TextBox Txtname;
        private Label label1;
    }
}