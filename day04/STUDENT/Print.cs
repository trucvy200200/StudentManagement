using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using Font = Xceed.Document.NET.Font;


namespace day04
{
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void Print_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from std");
            fillGrid(cmd);
            if (radioButton_No.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudenst(command);
            dataGridView1.Columns[0].HeaderText = "Student ID";
            dataGridView1.Columns[1].HeaderText = "First Name";
            dataGridView1.Columns[2].HeaderText = "Last Name";
            dataGridView1.Columns[3].HeaderText = "Birth Date";
            dataGridView1.Columns[4].HeaderText = "Gender";
            dataGridView1.Columns[5].HeaderText = "Phone";
            dataGridView1.Columns[6].HeaderText = "Address";
            dataGridView1.Columns[7].HeaderText = "Picture";
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void radioButton_yes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void radioButton_No_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            String query;
            if (radioButton_yes.Checked)
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                if (radio_Male.Checked)
                {
                    query = "Select * from std where gender='Male' AND bdate between '" + date1 + "'and'" + date2 + "'";
                }
                else if (radio_Female.Checked)
                {
                    query = "Select * from std where gender='Female' AND bdate between '" + date1 + "'and'" + date2 + "'";
                }
                else
                {
                    query = "Select * from std where bdate between '" + date1 + "'and'" + date2 + "'";
                }
                cmd = new SqlCommand(query);
                fillGrid(cmd);
            }
            else
            {
                if (radio_Male.Checked)
                {
                    query = "Select * from std where gender='Male'";
                }
                else if (radio_Female.Checked)
                {
                    query = "Select * from std where gender='Female'";
                }
                else
                {
                    query = "Select * from std ";
                }
                cmd = new SqlCommand(query);
                fillGrid(cmd);
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
        STUDENT st = new STUDENT();
        private void button_Save_Click(object sender, EventArgs e)
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
                //doc.InsertParagraph();
                //Create Table
                //var listPlayer = CreateInitData();
                Table t = doc.AddTable(dataGridView1.Rows.Count + 1, 8);
                t.Alignment = Alignment.center;
                t.Design = TableDesign.ColorfulList;
                // Fill cells by adding text.  
                // First row

                t.Rows[0].Cells[0].Paragraphs.First().Append("ID");
                t.Rows[0].Cells[1].Paragraphs.First().Append("First Name");
                t.Rows[0].Cells[2].Paragraphs.First().Append("Last Name");
                t.Rows[0].Cells[3].Paragraphs.First().Append("Birthday");
                t.Rows[0].Cells[4].Paragraphs.First().Append("Gender");
                t.Rows[0].Cells[5].Paragraphs.First().Append("Phone");
                t.Rows[0].Cells[6].Paragraphs.First().Append("Address");
                t.Rows[0].Cells[7].Paragraphs.First().Append("Picture");
                //int i = 1;
                MemoryStream ms = new MemoryStream();
                PictureBox picture1 = new PictureBox();
                int j = 0;
                for (int i = 1; i <= dataGridView1.RowCount; i++)
                {
                    t.Rows[i].Cells[0].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[0].Value.ToString());
                    t.Rows[i].Cells[1].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[1].Value.ToString());
                    t.Rows[i].Cells[2].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[2].Value.ToString());
                    string stringtodate = ((DateTime)dataGridView1.Rows[j].Cells[3].Value).ToString("MM-dd-yyyy");
                    t.Rows[i].Cells[3].Paragraphs.First().Append(stringtodate);
                    t.Rows[i].Cells[4].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[4].Value.ToString());
                    t.Rows[i].Cells[5].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[5].Value.ToString());
                    t.Rows[i].Cells[6].Paragraphs.First().Append(dataGridView1.Rows[j].Cells[6].Value.ToString());

                    using (MemoryStream ms1 = new MemoryStream())
                    {
                        byte[] pic;
                        pic = (byte[])dataGridView1.Rows[j].Cells[7].Value;
                        MemoryStream picture = new MemoryStream();
                        System.Drawing.Image myImg = st.ByteArrayToImage(pic);
                        myImg.Save(ms1, myImg.RawFormat);
                        ms1.Seek(0, SeekOrigin.Begin);
                        var img2 = doc.AddImage(ms1);
                        Picture p2 = img2.CreatePicture();
                        p2.Width = 100;
                        p2.Height = 100;
                        Paragraph par2 = doc.InsertParagraph();
                        par2.Alignment = Alignment.center;
                        //    par2.AppendPicture(p2);
                        t.Rows[i].Cells[7].Paragraphs.First().AppendPicture(p2);
                    }

                    //    var img2 = doc.AddImage(@"w1.png");
                    //    Picture p2 = img2.CreatePicture();
                    //    Paragraph par2 = doc.InsertParagraph();
                    //    par2.Alignment = Alignment.center;
                    //    par2.AppendPicture(p2);
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
