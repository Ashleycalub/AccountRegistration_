namespace AccountRegistration_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.StudentNo = long.Parse(Tstudentno.Text);
            StudentInfoClass.Program = Tprogram.Text.ToString();
            StudentInfoClass.LastName = Tlastname.Text.ToString();
            StudentInfoClass.FirstName = Tfirstname.Text.ToString();
            StudentInfoClass.MiddleName = Tmiddlename.Text.ToString();
            StudentInfoClass.Age = long.Parse(Tage.Text);
            StudentInfoClass.ContactNo = long.Parse(Tcontactno.Text);
            StudentInfoClass.Address = Taddress.Text.ToString();

            FrmConfirm confirm = new FrmConfirm();

            DialogResult rslt = new DialogResult();

            rslt = confirm.ShowDialog();
            if (rslt == DialogResult.OK)
            {
                Tstudentno.Text = "";
                Tprogram.Text = "";
                Tlastname.Text = "";
                Tfirstname.Text = "";
                Tmiddlename.Text = "";
                Tage.Text = "";
                Tcontactno.Text = "";
                Taddress.Text = "";

            }

        }
    }
}