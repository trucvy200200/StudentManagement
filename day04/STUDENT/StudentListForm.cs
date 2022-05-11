using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day04
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.myDBDataSet.std);
            SqlCommand command = new SqlCommand("Select * from std ");
            DataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudenst(command);
            DataGridView1.Columns[0].HeaderText = "Student ID";
            DataGridView1.Columns[1].HeaderText = "First Name";
            DataGridView1.Columns[2].HeaderText = "Last Name";
            DataGridView1.Columns[3].HeaderText = "Birth Date";
            DataGridView1.Columns[4].HeaderText = "Gender";
            DataGridView1.Columns[5].HeaderText = "Phone";
            DataGridView1.Columns[6].HeaderText = "Address";
            DataGridView1.Columns[7].HeaderText = "Picture";
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from std ");
            DataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudenst(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDeleteStudentForm UDSF = new UpdateDeleteStudentForm();
            UDSF.TextBoxID.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            UDSF.TextBoxFirstName.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            UDSF.TextBoxLastName.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            UDSF.DateTimePicker1.Value = (DateTime)DataGridView1.CurrentRow.Cells[3].Value;
            if (DataGridView1.CurrentRow.Cells[4].Value.ToString().Trim()=="Female")
            {
                UDSF.radioButtonFemale.Checked = true;
            }
            else
            {
                UDSF.radioButtonMale.Checked = true;
            }
            UDSF.TextBoxPhone.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            UDSF.TextBoxAddress.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])DataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            UDSF.PictureBox.Image = Image.FromStream(picture);
            this.Show();
            UDSF.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
