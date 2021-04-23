using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BITCollege_NN.Models;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class frmBatch : Form
    {
        BITCollege_NNContext context = new BITCollege_NNContext();
        public frmBatch()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the link button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkProcess_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Batch batch = new Batch();
            if (txtKey.Text == "" || txtKey.TextLength != 8)
            {
                MessageBox.Show("A 64-bit Key must be entered", "Error");
            }
            else
            {
                if (radAll.Checked)
                {
                    richTextBox1.Text = null;
                    foreach (BITCollege_NN.Models.Program program in programComboBox.Items)
                    {
                        batch.processTransmission(program.ProgramAcronnym, txtKey.Text);
                        richTextBox1.Text += batch.writeLogData();
                    }     
                }
                else if (radSelect.Checked)
                {
                    batch.processTransmission(programComboBox.SelectedValue.ToString(), txtKey.Text);
                    richTextBox1.Text = batch.writeLogData();
                }
            }

            
        }

        /// <summary>
        /// Handles the form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBatch_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);

            programBindingSource.DataSource = context.Programs.Select(program => program).ToList();

        }

        /// <summary>
        /// Handles radio button select changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (radSelect.Checked)
            {
                programComboBox.Enabled = true;
            }
            else
            {
                programComboBox.Enabled = false;
            }
        }
    }
}
