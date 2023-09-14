using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration_
{
    public partial class FrmConfirm : Form
    {
        private Delegatetext DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
        public FrmConfirm()
        {
            InitializeComponent();
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
            DelProgram = new Delegatetext(StudentInfoClass.GetProgram);
            DelLastName = new Delegatetext(StudentInfoClass.GetLastName);
            DelFirstName = new Delegatetext(StudentInfoClass.GetFirstName);
            DelMiddleName = new Delegatetext(StudentInfoClass.GetMiddleName);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelAddress = new Delegatetext(StudentInfoClass.GetAddress);


            Lstudentno.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            Lprogram.Text = DelProgram(StudentInfoClass.Program);
            Llastname.Text = DelLastName(StudentInfoClass.LastName);
            Lfirstname.Text = DelFirstName(StudentInfoClass.FirstName);
            Lmiddlename.Text = DelMiddleName(StudentInfoClass.MiddleName);
            Lage.Text = DelNumAge(StudentInfoClass.Age).ToString();
            Lcontactno.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            Laddress.Text = DelAddress(StudentInfoClass.Address);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {

        }
        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
