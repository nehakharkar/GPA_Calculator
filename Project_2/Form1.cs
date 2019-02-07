using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form1 : Form
    {
        double count = 1;
        double sumCreditHrs = 0;
        double sumGradePoint = 0;
        double varPointGrade ;
        double GPA = 0;
        double sGPA;
        String finalGPA;
        double CreditHrs;
        double a, b = 0;
        Boolean flagRemoveLast = false;
        public List<string> gradelist = new List<string>();
        public List<double> creditlist = new List<double>();
        public List<string> gpalist = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes the form and project
            this.Close();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //Textbox Grade gets the focus when form loads
            txtGrade.Focus();

        }


        private void txtCreditHrs_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {


            if (IsValidData())
            {
                CreditHrs = Convert.ToDouble(txtCreditHrs.Text);
                var varGradePoint = Convert.ToString(txtGrade.Text);
                gradelist.Add(varGradePoint.ToUpper());
                creditlist.Add(CreditHrs);

                //checking if A is 4 points, B is 3 points, C is 2 points, D is one point, and F has zero point.
                if (txtGrade.Text == "A" || txtGrade.Text == "a")
                {
                    varPointGrade = 4;
                }
                else if (txtGrade.Text == "B" || txtGrade.Text == "b")
                {
                    varPointGrade = 3;
                }
                else if (txtGrade.Text == "C" || txtGrade.Text == "c")
                {
                    varPointGrade = 2;
                }
                else if (txtGrade.Text == "D" || txtGrade.Text == "d")
                {
                    varPointGrade = 1;
                }
                else if (txtGrade.Text == "F" || txtGrade.Text == "f")
                {
                    varPointGrade = 0;
                }

                count++;
                lblGrade.Text = "Grade of Course" + " " + count + ":";
                lblCreditHrs.Text = "Credit Hours of Course" + " " + count + ":";

                sumCreditHrs = sumCreditHrs + CreditHrs;
                sumGradePoint = sumGradePoint + varPointGrade * CreditHrs;
                GPA = sumGradePoint / sumCreditHrs;

                if (flagRemoveLast == true)
                {
                    a = a + CreditHrs * varPointGrade;
                    b = b + CreditHrs;
                    GPA = a / b;
                    flagRemoveLast = false;
                }


                finalGPA = GPA.ToString("N3");
                //Converting the GPA from double to string
                lblGpaOutput.Text = finalGPA;
                gpalist.Add(finalGPA);

                

                btnRemoveLast.Enabled = true;
                txtGrade.Clear();
                txtCreditHrs.Clear();
            }

        }
        public bool IsValidData()
        {
            return
                IsPresent(txtGrade, "Grade") &&
                IsLetter(txtGrade, "Grade") &&
                IsWithinRange(txtGrade, "Grade", 'A', 'F') &&
                IsPresent(txtCreditHrs, "Credit Hours") &&
                IsInt32(txtCreditHrs, "Credit Hours") &&
                IsWithinRange(txtCreditHrs, "Credit Hours", 0, 6);


        }
        public bool IsPresent(TextBox textbox, string name)
        {
            if (textbox.Text == "")
            {
                MessageBox.Show(name + " is a required field", "Entry Error");
                textbox.Focus();
                return false;
            }
            return true;
        }

        public bool IsInt32(TextBox textbox, string name)
        {
            int number = 0;
            if (Int32.TryParse(textbox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be an Integer field", "Entry Error");
                textbox.Focus();
                return false;
            }
        }
        private bool IsWithinRange(TextBox textbox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textbox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min + " and " + max + ".", "Entry error");
                textbox.Clear();
                textbox.Focus();
                return false;
            }
            return true;
        }
        private bool IsWithinRange(TextBox textbox, string name, char min, char max)
        {

            String textboxstring = textbox.Text;
            Char character = Char.Parse(textboxstring.ToUpper());
            if (character == 'E' || character == 'e')
            {
                MessageBox.Show(name + " must be in the Range A to D plus F. ", "Entry error");
                textbox.Clear();
                textbox.Focus();
                return false;
            }
            else if (character <= max)
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be in the Range A to D plus F. ", "Entry error");
                textbox.Focus();
                return false;
            }
            
        }
        private bool IsLetter(TextBox textbox, string name)
        {

            Char character = Convert.ToChar(textbox.Text);
            
            if (Char.IsLetter(character))
            {
               return true; 
            }
           
            {
                MessageBox.Show(name + " must be a Letter "+ ".", "Entry error");
                textbox.Focus();
                return false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            count = 1;
            lblGrade.Text = "Grade of Course" + " " + count + ":";
            lblCreditHrs.Text = "Credit Hours of Course" + " " + count + ":";
            txtGrade.Clear();
            txtCreditHrs.Clear();
            int resetCount = 0;
            lblGpaOutput.Text = resetCount.ToString("N3");
            txtGrade.Focus();
            btnRemoveLast.Enabled = true;
            a = 0; b = 0;
            gradelist.Clear();
            creditlist.Clear();
            gpalist.Clear();

            sumCreditHrs = 0;
            sumGradePoint = 0;
            varPointGrade = 0;
            GPA = 0;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            Summary s = new Summary(this);
            s.ShowDialog();
        }

        

        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                btnRemoveLast.Enabled = false;
                txtGrade.Focus();
                flagRemoveLast = true;
            }
            else if (count == 2)
            {
                Reset();
                flagRemoveLast = true;
            }
            else
            {
                count--;
                lblGrade.Text = "Grade of Course" + " " + count + ":";
                lblCreditHrs.Text = "Credit Hours of Course" + " " + count + ":";
                gradelist.RemoveAt(gradelist.Count - 1);
                creditlist.RemoveAt(creditlist.Count - 1);
                gpalist.RemoveAt(gpalist.Count - 1);


                a = sumGradePoint - varPointGrade* CreditHrs;
                b= sumCreditHrs - CreditHrs;
                sumGradePoint =   a;
                sumCreditHrs =  b;

                sGPA = a / b;
                lblGpaOutput.Text = sGPA.ToString("N3");
                flagRemoveLast = true;

            }
            
            if (flagRemoveLast == true)
            {
                btnRemoveLast.Enabled = false;
            }

        }
    }
}
