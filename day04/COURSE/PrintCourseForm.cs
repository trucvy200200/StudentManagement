using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace day04
{
    public partial class PrintCourseForm : Form
    {
        public PrintCourseForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = course.getCourse(command);
            dataGridView1.Columns[0].HeaderText = "Course ID";
            dataGridView1.Columns[1].HeaderText = "Course Name";
            dataGridView1.Columns[2].HeaderText = "Period";
            dataGridView1.Columns[3].HeaderText = "Description";
            dataGridView1.Columns[4].HeaderText = "Semester";
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            String query = "";
            if (radioButton_AZ.Checked)
            {

                query = "Select * from Course order by label asc";
            }
            else if (radioButton_ZA.Checked)
            {
                query = "Select * from Course order by label desc";
            }
            else query = "Select * from Course";
            cmd = new SqlCommand(query);
            fillGrid(cmd);
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                #region one
                string fileName = "Export_Course_List.docx";
                var doc = DocX.Create(fileName);
                #endregion

                #region two
                string title = "Course_List";

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
                //doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                #endregion
                dataGridView1.AllowUserToAddRows = false;
                #region four
                doc.InsertParagraph();
                //Create Table
                //var listPlayer = CreateInitData();
                Table t = doc.AddTable(dataGridView1.Rows.Count + 1, 6);
                t.Alignment = Alignment.center;
                t.Design = TableDesign.ColorfulList;
                t.Rows[0].Cells[0].Paragraphs.First().Append("Course ID");
                t.Rows[0].Cells[1].Paragraphs.First().Append("Course Name");
                t.Rows[0].Cells[2].Paragraphs.First().Append("Period");
                t.Rows[0].Cells[3].Paragraphs.First().Append("Description");
                t.Rows[0].Cells[4].Paragraphs.First().Append("Semester");
                t.Rows[0].Cells[5].Paragraphs.First().Append("Teacher ID");
                int j = 0;
                for (int i = 1; i <= dataGridView1.RowCount; i++)
                {
                    t.Rows[i].Cells[0].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[0].Value.ToString());
                    t.Rows[i].Cells[1].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[1].Value.ToString());
                    t.Rows[i].Cells[2].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[2].Value.ToString());
                    t.Rows[i].Cells[3].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[3].Value.ToString());
                    t.Rows[i].Cells[4].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[4].Value.ToString());
                    t.Rows[i].Cells[5].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[5].Value.ToString());
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
        private void btn_Print_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            print.Document = printDoc;
            print.AllowSelection = true;
            print.AllowSomePages = true;
            if (print.ShowDialog() == DialogResult.OK) printDoc.Print();
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {

        }
    }
}

