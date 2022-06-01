using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace day04
{
    public partial class CourseStdList : Form
    {
        public CourseStdList()
        {
            InitializeComponent();
        }
        COURSE co = new COURSE();
        private void CourseStdList_Load(object sender, EventArgs e)
        {
            textBoxCourseName.Text = co.getCourseNameByCourseID(Globals.GlobalCourseId);
            lb_Semester.Text = "Semester: "+co.getSemesterByCourseID(Globals.GlobalCourseId);
            DataGridViewColumn c = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell(); //Specify which type of cell in this column
            c.HeaderText = "STT";
            
            cell.Style.BackColor = Color.Wheat;
            c.CellTemplate = cell;
            dataGridView1.Columns.Add(c);
            dataGridView1.DataSource = co.getStudentByCourse(Globals.GlobalCourseId);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                #region one
                string fileName = "Export_Student_List.docx";
                var doc = DocX.Create(fileName);
                #endregion

                #region two
                string title = "Student_List";

                Formatting titleFormat = new Formatting();
                titleFormat.FontFamily = new Xceed.Document.NET.Font("Tahoma");
                titleFormat.Size = 20D;
                titleFormat.Position = 40;
                titleFormat.FontColor = Color.BlueViolet;
                titleFormat.UnderlineColor = Color.Gray;
                titleFormat.Italic = true;

                //Formatting Text Paragraph  
                Formatting textParagraphFormat = new Formatting();
                //font family  
                textParagraphFormat.FontFamily = new Xceed.Document.NET.Font("Tahoma");
                //font size  
                textParagraphFormat.Size = 12D;
                //Spaces between characters  
                textParagraphFormat.Spacing = 1;
                //Insert title  
                Paragraph paragraphTitle = doc.InsertParagraph(title, false, titleFormat);
                paragraphTitle.Alignment = Alignment.center;
                //Insert text 
                string textParagraph = "Course Name: " + textBoxCourseName.Text + "\n" + lb_Semester.Text + "\n";

                doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                #endregion
                dataGridView1.AllowUserToAddRows = false;
                #region four
                doc.InsertParagraph();
                //Create Table
                //var listPlayer = CreateInitData();
                Table t = doc.AddTable(dataGridView1.Rows.Count + 1, 4);
                t.Alignment = Alignment.center;
                t.Design = TableDesign.ColorfulList;
                t.Rows[0].Cells[0].Paragraphs.First().Append("STT");
                t.Rows[0].Cells[1].Paragraphs.First().Append("Student ID ");
                t.Rows[0].Cells[2].Paragraphs.First().Append("First Name");
                t.Rows[0].Cells[3].Paragraphs.First().Append("Last Name");

                int j = 0;
                for (int i = 1; i <= dataGridView1.RowCount; i++)
                {
                    t.Rows[i].Cells[0].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[0].Value.ToString());
                    t.Rows[i].Cells[1].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[1].Value.ToString());
                    t.Rows[i].Cells[2].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[2].Value.ToString());
                    t.Rows[i].Cells[3].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[3].Value.ToString());

                    j++;
                }
                doc.InsertTable(t);
                #endregion
                #region part of one
                doc.Save();
                Process.Start("WINWORD.EXE", fileName);
                #endregion
                Console.Read();
            }
            catch
            {
                MessageBox.Show("File word is open", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
