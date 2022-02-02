using LasalleManagement.Business;

namespace LasalleManagement.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            int studentId;
            if (!int.TryParse(txtStudentId.Text, out studentId))
            {
                MessageBox.Show("ID must be numeric",
                                 "Warning",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }
            else if (txtStudentName.Text == "" || txtStudentEmail.Text == "")
            {
                MessageBox.Show("Please inform Name and Email",
                                 "Warning",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }

            Student myStudent = new Student();
            myStudent.Id = studentId;
            myStudent.Name = txtStudentName.Text;
            myStudent.Email = txtStudentEmail.Text;

            lstStudents.Items.Add("STUDENT: " + myStudent.AllStudentFields);

            txtStudentId.Text = "";
            txtStudentName.Text = "";
            txtStudentEmail.Text = "";
        }

        private void btnAddInternationalStudent_Click(object sender, EventArgs e)
        {
            int studentId;
            if (!int.TryParse(txtInternationalStudentId.Text, out studentId))
            {
                MessageBox.Show("ID must be numeric",
                                 "Warning",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }
            else if (txtInternationalStudentName.Text == "" || txtInternationalStudentEmail.Text == "")
            {
                MessageBox.Show("Please inform Name and Email",
                                 "Warning",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }

            InternationalStudent myStudent = new InternationalStudent();
            myStudent.Id = studentId;
            myStudent.Name = txtInternationalStudentName.Text;
            myStudent.Email = txtInternationalStudentEmail.Text;
            myStudent.HomeCountry = txtInternationalStudentHomeCountry.Text;

            lstStudents.Items.Add("INTERNATIONAL STUDENT: " + myStudent.AllInternationalStudentFields);

            txtInternationalStudentId.Text = "";
            txtInternationalStudentName.Text = "";
            txtInternationalStudentEmail.Text = "";
            txtInternationalStudentHomeCountry.Text = "";
        }
    }
}