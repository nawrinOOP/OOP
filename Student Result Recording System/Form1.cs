using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Result_Recording_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstTranscript.Items.Add("Student Number\t" + "Obtained Marks\t" + "Percentage\t" + "Result \t" + "Rank");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit", "Student Result Recording System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnItemClear_Click(object sender, EventArgs e)
        {
            lstTranscript.Items.Clear();
            lstTranscript.Items.Add("Student Number\t" + "Obtained Marks\t" + "Percentage\t" + "Result \t" + "Rank");
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lstTranscript.SelectedItems.Count > 0)
            {
                for (int q = lstTranscript.SelectedItems.Count - 1; q >= 0; q--)
                {
                    lstTranscript.Items.Remove(lstTranscript.SelectedItems);
                    lstTranscript.SelectedItems.Clear();
                }

            }
            else
            {
                MessageBox.Show("No item selected, select an item now ", "Student Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            txtRank.Clear();
            txtObainedMarks.Clear();
            txtPercentage.Clear();
            txtResult.Clear();
            txtStudentNumber.Clear();
            lblDecision.Text = "";


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Select a row to be deleted", "Student Result Recording Systems");
            }
        }

        private void btnTranscript_Click(object sender, EventArgs e)
        {
            lstTranscript.Items.Add(txtStudentNumber.Text + "\t\t" + txtObainedMarks.Text + "\t\t" + txtPercentage.Text + "\t\t" + txtResult.Text + "\t" + txtRank.Text);

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            double TotalResult, perC, Marks, totalM;
            perC = 100;
            totalM = 100;

            Marks = Convert.ToDouble(txtObainedMarks.Text);
            TotalResult = (perC / totalM) * Marks;
            double value = TotalResult / 100;
            string result = value.ToString("#0.%");
            txtPercentage.Text = Convert.ToString(result);

            if (txtObainedMarks.Text == "")
            {
                MessageBox.Show("Enter a scores", "Record correct entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStudentNumber.Focus();
                txtPercentage.Text = "0";
            }
            else if (Marks > 100)
            {
                MessageBox.Show("Not more than 100", "Record correct entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRank.Clear();
                txtObainedMarks.Text = "";
                txtPercentage.Text = "";
                txtResult.Clear();
                lblDecision.Text = "";
            }

            if (TotalResult >= 80)
            {
                txtRank.Text = "1";
                lblDecision.Text = "Course Complete";
                txtResult.Text = "Pass";
            }
            else if (TotalResult >= 70)
            {
                txtRank.Text = "2";
                lblDecision.Text = "Course Complete";
                txtResult.Text = "Pass";
            }
            else if (TotalResult >= 60)
            {
                txtRank.Text = "3";
                lblDecision.Text = "Course Complete";
                txtResult.Text = "Pass";
            }
            else if (TotalResult >= 50)
            {
                txtRank.Text = "4";
                lblDecision.Text = "Course Complete";
                txtResult.Text = "Pass";
            }
            else if (TotalResult >= 40)
            {
                txtRank.Text = "5";
                lblDecision.Text = "Course Complete";
                txtResult.Text = "Pass";
            }
            else if (TotalResult >= 30)
            {
                txtRank.Text = "6";
                lblDecision.Text = "Resubmit";
                txtResult.Text = "Fail";
            }
            else if (TotalResult >= 20)
            {
                txtRank.Text = "7";
                lblDecision.Text = "Resubmit";
                txtResult.Text = "Fail";
            }
            else if (TotalResult >= 10)
            {
                txtRank.Text = "8";
                lblDecision.Text = "Resubmit";
                txtResult.Text = "Fail";
            }

            if (txtObainedMarks.Text == "")
            {

                txtRank.Clear();
                txtObainedMarks.Text = "";
                txtPercentage.Text = "";
                txtResult.Clear();
                lblDecision.Text = "";
                txtStudentNumber.Focus();

            }

            dataGridView1.Rows.Add(txtStudentNumber.Text, txtObainedMarks.Text, txtPercentage.Text, txtResult.Text, txtRank.Text);

        }

        private void lstTranscript_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtObainedMarks_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

