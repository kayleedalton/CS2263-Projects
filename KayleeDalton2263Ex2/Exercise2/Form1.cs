using Microsoft.VisualBasic;

//Add notes

namespace Exercise2
{
    public partial class Form1 : Form
    {
        ///Initial values
        String year = "";
        int numYear = 0;
        String nString = "";
        int n = 0;
        int fib = 0;
        int sum1 = 1;
        int sum2 = 1;
        String triangleRow = "";
        String triangleLine = "";
        int rows = 0;
        int alphNum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        ///On txtIn button, run the following code
        private void txtInConfirm_Click(object sender, EventArgs e)
        {
            
            year = txtIn.Text;
            
            numYear = int.Parse(year);
            ///Checking if number fits criteria for leap year
            if (((numYear % 4 == 0) && (numYear % 100 !=0)) || (numYear % 400 == 0))
            {
                
                lblOut.Text = "It is a Leap Year!";
            }
            else
            {
                
                lblOut.Text = "It is not a Leap Year";
            }

           

        }
        
        ///On the fibButton click, the following code runs
        private void fibButton_Click(object sender, EventArgs e)
        {
            nString = txtIn.Text;
            
            n = int.Parse(nString);
            ///Need to parse fibBox to get n
            if (n < 0)
            {
                fiboSum.Text = "Number cannot be negative";
            }

            else if (n < 3) 
                ///Sum for first 2 values is 1
            {
                fiboSum.Text = "1";
            }

            else
            {
                ///Fibonnaci Sequence Formula
                for (int i = 2; i < n; i++)
                {
                    fib = sum1 + sum2;
                    sum1 = sum2;
                    sum2 = fib;

                }
                fiboSum.Text = (fib.ToString());
                sum1 = 1;
                sum2 = 1;
                fib = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            triangleBox.Text = "";
            triangleLine = "";
            triangleRow = txtIn.Text;
            //Validating user input
            if ((triangleRow == "") | (int.Parse(triangleRow) < 0))
            {
                triangleBox.Text = "Not Valid";
            }
            else
            {
                rows = int.Parse(triangleRow);
                //Simple triangle made with dots and a loop
                for (int i = 0; i < rows; i++)
                {
                    triangleLine += "*";
                    triangleBox.Text += (triangleLine + "\n");
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dots = 0;
            triangleBox.Text = "";
            triangleRow = txtIn.Text;
            rows = int.Parse(triangleRow);

            if ((triangleRow == "") | (int.Parse(triangleRow) < 0))
            {
                triangleBox.Text = "Not Valid";
            }
            else
            {
                //Creating triangle with increasing dots and decreasing lines
                for (int i = 0; i < rows; i++)
                {
                    triangleLine = "";
                    for (int j = 1; j < (rows - dots); j++)
                    {
                        triangleLine += "-";

                    }
                    for (int k = 0; k < dots; k++)
                    {
                        triangleLine += "*";
                    }
                    dots++;

                    triangleBox.Text += (triangleLine + "\n");


                }
            }
        }

        ///Enter first n letters of the alphabet on button click

        private void alphButton_Click(object sender, EventArgs e)
        {
            alphBox.Text = "";
            String alph = txtIn.Text;
            //Start with unicode before 'a'
            char newAlph = '`';
            alphNum = int.Parse(alph);

            //Validating number is correct
            if (alphNum > 26)
            {
                alphBox.Text = "Cannot be greater than 26";
            }

            else if (alphNum < 0)
            {
                alphBox.Text = "Cannot be negative";
            }
            else 
            { 
                
                for (int a = 0; a < alphNum; a++)
                {
                    //Iterate chars each loop
                    alphBox.Text += (Char)(Convert.ToUInt16(newAlph) + 1);
                    newAlph = (Char)(Convert.ToUInt16(newAlph) + 1);
                }
            }
            


        }
        ///Implemented code from word doc
        private void btnTask4_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int r = 0; r < 10; r++)
            {
                for (int j = 0; j < 10; j++)
                    s += "*";
                s += "\r\n";
            }
            txtMultiLineOut.Text = s;
        }

        ///Empty Labels and Text Boxes
        private void txtIn_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void isLeap_Click(object sender, EventArgs e)
        {

        }

        private void fiboSum_Click(object sender, EventArgs e)
        {

        }

        private void triangleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void alphBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

