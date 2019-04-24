using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        //Larissa Oliveira WMADJr.A

        //ArrayList in the global scope to access it in the whole form.
        private ArrayList messageN = new ArrayList();

        //Boolean Flag to check the Setence State.
        private bool sentenceState;

        public Form1()
        {
            InitializeComponent();

            //Populating the ArrayList.
            messageN.Add("I");
            messageN.Add("Love");
            messageN.Add("Programming");
            messageN.Add("So");
            messageN.Add("Much");

            //ORIGINAL Sentence State.
            sentenceState = true;
        }

        private bool CheckState()
        {
            //TRUE = ORIGINAL Sentence, FALSE = REVERSED Sentence.
            if (sentenceState == true)
            {
                lblMessage.Text = string.Join(" ", messageN.ToArray());
            }
            else
            {
                lblMessage.Text = string.Join(" ", messageN.ToArray().Reverse());
            }

            return false;
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            //ORIGINAL Sentence.
            sentenceState = true;
            CheckState();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            //REVERSED Sentence.
            sentenceState = false;
            CheckState();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Won't add Empty Strings to the ArrayList.
            if (txtSecondPos.Text == string.Empty)
            {
                MessageBox.Show("Please insert a value.");
                return;
            }
       
            //Inserting the value into the Second Index in the ArrayList.
            messageN.Insert(1, txtSecondPos.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Making sure they want to delete.
            if (MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //Checking if the Setence is in its ORIGINAL state so we can delete the Second Index of it.
                sentenceState = true;
                CheckState();

                //Deleting the Second Index of the ArrayList.
                messageN.RemoveAt(1);
            }               
        }
    }
}