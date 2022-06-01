using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using Font = Xceed.Document.NET.Font;
namespace day04
{
    public partial class AvgResultForm : Form
    {
        public AvgResultForm()
        {
            InitializeComponent();
        }
        RESULT re = new RESULT();
        string data = "std";
        int averageIndex;
        private void AvgResultForm_Load(object sender, EventArgs e)
        {
            data = "std";
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = re.getAvgScoreByStudent();
            dataGridView1.Columns[0].HeaderText = "Student ID";
            dataGridView1.Columns[1].HeaderText = "First Name";
            dataGridView1.Columns[2].HeaderText = "Last Name";
            dataGridView1.Columns[3].HeaderText = "Average Score";
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                double result = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                dataGridView1.Rows[i].Cells[4].Value = re.getResult(result);
            }
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                if (data == "score")
                {
                    #region one
                    string fileName = "Export_Student_Score.docx";
                    var doc = DocX.Create(fileName);
                    #endregion

                    #region two
                    string title = "Student_Score";

                    Formatting titleFormat = new Formatting();
                    titleFormat.FontFamily = new Font("Tahoma");
                    titleFormat.Size = 20D;
                    titleFormat.Position = 40;
                    titleFormat.FontColor = Color.BlueViolet;
                    titleFormat.UnderlineColor = Color.Gray;
                    titleFormat.Italic = true;

                    //Formatting Text Paragraph  
                    Formatting textParagraphFormat = new Formatting();
                    //font family  
                    textParagraphFormat.FontFamily = new Font("Tahoma");
                    //font size  
                    textParagraphFormat.Size = 12D;
                    //Spaces between characters  
                    textParagraphFormat.Spacing = 1;
                    //Insert title  
                    Paragraph paragraphTitle = doc.InsertParagraph(title, false, titleFormat);
                    paragraphTitle.Alignment = Alignment.center;
                    //Insert text  
                    string textParagraph = "Student ID: " + TextBoxSearch.Text
                        + "\nName: " + TextBoxFname.Text + " " + TextBoxLname.Text + "\n";

                    doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                    #endregion
                    dataGridView1.AllowUserToAddRows = false;
                    #region four
                    doc.InsertParagraph();
                    //Create Table
                    //var listPlayer = CreateInitData();
                    Table t = doc.AddTable(dataGridView1.Columns.Count - 4, 2);
                    t.Alignment = Alignment.center;
                    t.Design = TableDesign.ColorfulList;
                    // Fill cells by adding text.  
                    // First row
                    t.Rows[0].Cells[0].Paragraphs.First().Append("Course Name");
                    t.Rows[0].Cells[1].Paragraphs.First().Append("Score");

                    int j = 1;
                    for (int i = 0; i < averageIndex - 3; i++)
                    {
                        t.Rows[j].Cells[0].Paragraphs.First().Append(dataGridView1.Columns[i + 3].HeaderText.ToString());
                        t.Rows[j].Cells[1].Paragraphs.First().Append(dataGridView1.Rows[0].Cells[i + 3].Value.ToString());
                        j++;
                    }
                    doc.InsertTable(t);
                    textParagraph = "Average Score: " + dataGridView1.Rows[0].Cells[averageIndex].Value.ToString()
                        + "\nResult: " + dataGridView1.Rows[0].Cells[averageIndex + 1].Value.ToString();
                    doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                    #endregion
                    #region part of one
                    doc.Save();
                    Process.Start("WINWORD.EXE", fileName);
                    #endregion
                    Console.Read();
                }
                else
                {
                    #region one
                    string fileName = "Export_Score_List.docx";
                    var doc = DocX.Create(fileName);
                    #endregion

                    #region two
                    string title = "Student_Score_List";

                    Formatting titleFormat = new Formatting();
                    titleFormat.FontFamily = new Font("Tahoma");
                    titleFormat.Size = 20D;
                    titleFormat.Position = 40;
                    titleFormat.FontColor = Color.BlueViolet;
                    titleFormat.UnderlineColor = Color.Gray;
                    titleFormat.Italic = true;

                    //Formatting Text Paragraph  
                    Formatting textParagraphFormat = new Formatting();
                    //font family  
                    textParagraphFormat.FontFamily = new Font("Tahoma");
                    //font size  
                    textParagraphFormat.Size = 12D;
                    //Spaces between characters  
                    textParagraphFormat.Spacing = 1;
                    //Insert title  
                    Paragraph paragraphTitle = doc.InsertParagraph(title, false, titleFormat);
                    paragraphTitle.Alignment = Alignment.center;
                    //Insert text  
                    //doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                    #endregion
                    dataGridView1.AllowUserToAddRows = false;
                    #region four
                    doc.InsertParagraph();
                    //Create Table
                    //var listPlayer = CreateInitData();
                    Table t = doc.AddTable(dataGridView1.Rows.Count + 1, 5);
                    t.Alignment = Alignment.center;
                    t.Design = TableDesign.ColorfulList;
                    // Fill cells by adding text.  
                    // First row
                    t.Rows[0].Cells[0].Paragraphs.First().Append("Student ID");
                    t.Rows[0].Cells[1].Paragraphs.First().Append("First Name");
                    t.Rows[0].Cells[2].Paragraphs.First().Append("Last Name");
                    t.Rows[0].Cells[3].Paragraphs.First().Append("Average Score");
                    t.Rows[0].Cells[4].Paragraphs.First().Append("Result");
                    int j = 0;
                    for (int i = 1; i <= dataGridView1.RowCount; i++)
                    {
                        t.Rows[i].Cells[0].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[0].Value.ToString());
                        t.Rows[i].Cells[1].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[1].Value.ToString());
                        t.Rows[i].Cells[2].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[2].Value.ToString());
                        t.Rows[i].Cells[3].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[3].Value.ToString());
                        t.Rows[i].Cells[4].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[4].Value.ToString());
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
            }
            catch
            {
                MessageBox.Show("File word is open", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void btn_Search_Click(object sender, EventArgs e)
        {
            data = "score";
            try
            {
                int id = Convert.ToInt32(TextBoxSearch.Text);
            
                SqlCommand cmd = new SqlCommand("Select a.Id, a.fname, a.lname from std a where a.Id =" + id);
                SqlCommand cmd2 = new SqlCommand("Select a.student_Id, b.label, a.student_score from score a, course b where a.student_Id =" + id + " and a.course_id = b.id");
                DataTable dt1 = re.getData(cmd);
                DataTable dt2 = re.getData(cmd2);
                dataGridView1.ReadOnly = true;
                dataGridView1.RowTemplate.Height = 80;
                dataGridView1.DataSource = dt1;
                dataGridView1.Columns[0].HeaderText = "Student ID";
                dataGridView1.Columns[1].HeaderText = "First Name";
                dataGridView1.Columns[2].HeaderText = "Last Name";
                int j = 3;
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    DataColumn a = new DataColumn();
                    dt1.Columns.Add(a);
                    a.ColumnName = dt2.Rows[i].ItemArray[1].ToString();
                    dataGridView1.Rows[0].Cells[j + i].Value = dt2.Rows[i].ItemArray[2].ToString();
                }
                //Add average column
                DataTable dt3 = re.getAvgScoreByStudentID(id);
                DataColumn b = new DataColumn();
                dt1.Columns.Add(b);
                b.ColumnName = "Average Score";
                averageIndex = j + dt2.Rows.Count;
                dataGridView1.Rows[0].Cells[averageIndex].Value = dt3.Rows[0].ItemArray[0].ToString();
                //Add Result Column
                b = new DataColumn();
                dt1.Columns.Add(b);
                b.ColumnName = "Result";
                double result = Convert.ToDouble(dataGridView1.Rows[0].Cells[j + dt2.Rows.Count].Value);
                dataGridView1.Rows[0].Cells[averageIndex + 1].Value = re.getResult(result);
                dataGridView1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("ID must be numeric");
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            data = "std";
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = re.getAvgScoreByStudent();
            dataGridView1.Columns[0].HeaderText = "Student ID";
            dataGridView1.Columns[1].HeaderText = "First Name";
            dataGridView1.Columns[2].HeaderText = "Last Name";
            dataGridView1.Columns[3].HeaderText = "Average Score";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                double result = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                dataGridView1.Rows[i].Cells[4].Value = re.getResult(result);
            }
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TextBoxFname.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
