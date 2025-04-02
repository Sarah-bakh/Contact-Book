using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ContactDB
{
    public partial class FRM : Form
    {
        IContactRepository Repository;
        public int ContactId = 0;
        public FRM()
        {

            InitializeComponent();
            Repository = new ContactRepository();
        }

        private void FRM_Load(object sender, EventArgs e)
        {
            if (ContactId==0) 
            {
                this.Text = "افزودن شخص جدید";
            }
            else
            {
                this.Text = "ویرایش شخص";
                DataTable dt = Repository.SelectRow(ContactId);
                Txtname.Text = dt.Rows[0][1].ToString();
                txtfamily.Text=dt.Rows[0][2].ToString();
                txtmobile.Text=dt.Rows[0][3].ToString();
                txtadress.Text=dt.Rows[0][4].ToString();
                txtmail.Text=dt.Rows[0][5].ToString();
                numage.Value =int.Parse( dt.Rows[0][6].ToString());
                sbmbtn.Text = "ویرایش";

            }
        }
        bool Validateinput()
        {
           
            if (Txtname.Text == "")
            {
             
                MessageBox.Show("لطفا نام را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtfamily.Text == "")
            {
                
                MessageBox.Show("لطفا نام خانوادگی را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtmobile.Text == "")
            {
             
                MessageBox.Show("لطفا موبایل خود  را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (numage.Value == 0)
            {
             
                MessageBox.Show("لطفاسن خود را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtmail.Text=="")
            {
                MessageBox.Show("لطفا ایمیل خود را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void sbmbtn_Click(object sender, EventArgs e)
        {
            if (Validateinput())
            {
                bool Issucsess;

                if (ContactId == 0)
                {
                    Issucsess = Repository.Insert(Txtname.Text, txtfamily.Text, txtadress.Text, txtmail.Text, txtmobile.Text, (int)numage.Value);
                }
                else 
                {
                    Issucsess = Repository.Update(ContactId,Txtname.Text,txtfamily.Text,txtadress.Text,txtmail.Text,txtmobile.Text,(int)numage.Value);

                }
                if (Issucsess)
                {
                    MessageBox.Show("با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else 
                {
                    MessageBox.Show("عملیات با شکست مواجه شد", "شکست", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
