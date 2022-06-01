using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day04
{
    public partial class RemoveScoreForm : Form
    {
        public RemoveScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        private void btn_RemoveScore_Click(object sender, EventArgs e)
        {
           try
           {
                int studentID = Convert.ToInt32(DataGridViewScore.CurrentRow.Cells[0].Value.ToString());
                int courseID = Convert.ToInt32(DataGridViewScore.CurrentRow.Cells[3].Value.ToString());
                if ((MessageBox.Show("Are you sure want to delete this score", "Remove Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (score.deleteScore(studentID, courseID))
                    {
                        MessageBox.Show("Score Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataGridViewScore.DataSource = score.getStudentScore();
                    }
                    else
                    {
                        MessageBox.Show("Score Not Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
           }
           catch
           {
                MessageBox.Show("Choose one to remove", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
        }

        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            DataGridViewScore.DataSource = score.getStudentScore(); 
        }
    }
}
