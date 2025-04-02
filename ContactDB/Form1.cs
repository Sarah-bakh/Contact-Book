namespace ContactDB
{
    public partial class Form1 : Form
    {
        IContactRepository repository;
        public Form1()
        {
            InitializeComponent();
            repository = new ContactRepository();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridBind();
        }

        private void GridBind()
        {
            dgcontact.AutoGenerateColumns = false;
            dgcontact.DataSource = repository.SelectAll();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            GridBind();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FRM fRM = new FRM();
            fRM.ShowDialog();
            if (fRM.DialogResult == DialogResult.OK)
            {
                GridBind();
            }

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (dgcontact.CurrentRow != null)
            {
                string name = dgcontact.CurrentRow.Cells[2].Value.ToString();
                string lastname = dgcontact.CurrentRow.Cells[3].Value.ToString();
                string fullname = name + " " + lastname;
                if (MessageBox.Show($"آیا از حذف{fullname}مطمن هستید؟ ", "توجه", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int ContactID = int.Parse(dgcontact.CurrentRow.Cells[0].Value.ToString());
                    repository.Delete(ContactID);
                    GridBind();

                }

            }
            else
            {
                MessageBox.Show("لطفا یک شخص را انتخاب نمایید. ");
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (dgcontact.CurrentRow != null)
            {
                int ContactId = int.Parse(dgcontact.CurrentRow.Cells[0].Value.ToString());
                FRM frm = new FRM();
                frm.ContactId = ContactId;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    GridBind();
                }

            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dgcontact.DataSource = repository.Search(txtsearch.Text);
        }
    }
}
