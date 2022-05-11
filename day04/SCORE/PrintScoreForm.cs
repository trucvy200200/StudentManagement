using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class PrintScoreForm : Form
    {
        public PrintScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        private void btn_Search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.searchScoreByCourseName(TextBoxCourseName.Text);
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.Columns[0].HeaderText = "Student ID";
            dataGridView1.Columns[1].HeaderText = "First Name";
            dataGridView1.Columns[2].HeaderText = "Last Name";
            dataGridView1.Columns[3].HeaderText = "Course ID";
            dataGridView1.Columns[4].HeaderText = "Course Name";
            dataGridView1.Columns[5].HeaderText = "Student Score";
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            #region one
            string fileName = "Export_Score_List.docx";
            var doc = DocX.Create(fileName);
            #endregion

            #region two
            string title = "Score_List";

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
            t.Rows[0].Cells[0].Paragraphs.First().Append("Student ID");
            t.Rows[0].Cells[1].Paragraphs.First().Append("First Name");
            t.Rows[0].Cells[2].Paragraphs.First().Append("Last Name");
            t.Rows[0].Cells[3].Paragraphs.First().Append("Course ID");
            t.Rows[0].Cells[4].Paragraphs.First().Append("Course Name");
            t.Rows[0].Cells[5].Paragraphs.First().Append("Student Score");
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
    }
}
