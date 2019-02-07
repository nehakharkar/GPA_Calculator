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

 
    public partial class Summary : Form
    {
        private Form1 form1;
        int acount=0;
        int bcount=0;
        int ccount=0;
        int dcount=0;
        int fcount=0;
        public Summary(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            List<String> summarygrade = new List<String>();
            summarygrade.AddRange(form1.gradelist);

            List<Double> summarycredit = new List<Double>();
            summarycredit.AddRange(form1.creditlist);

            List<String> summarygpa = new List<String>();
            summarygpa.AddRange(form1.gpalist);

           for(int  i=0; i< summarygrade.Count; i++)
            {
                if(Char.Parse(summarygrade[i]) == 'A')
                {
                    acount++;
                }
                else if (Char.Parse(summarygrade[i]) == 'B')
                {
                    bcount++;
                }
                else if (Char.Parse(summarygrade[i]) == 'C')
                {
                    ccount++;
                }
                else if (Char.Parse(summarygrade[i]) == 'D')
                {
                    dcount++;
                }
                else if (Char.Parse(summarygrade[i]) == 'F')
                {
                    fcount++;
                }
            }

            lblACount.Text = acount.ToString();
            lblBCount.Text = bcount.ToString();
            lblCCount.Text = ccount.ToString();
            lblDCount.Text = dcount.ToString();
            lblFCount.Text = fcount.ToString();

            for(int i=0; i < summarygrade.Count; i++)
            {
                listBoxGPAsummary.Items.Add(summarygrade[i]+ "(" +summarycredit[i] +")--> GPA: "+summarygpa[i]);


            }
        }

    }
}
