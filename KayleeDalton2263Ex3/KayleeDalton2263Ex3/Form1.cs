//Kaylee Dalton
//CS 2263
//01/12/2023
//Project 3


namespace KayleeDalton2263Ex3
{
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = 3;
            int exponent = 3;
            int i = 1;
            int answer = number;
            while (i < exponent) 
            {
                
                answer = answer * number;
                i++;
            }
            label1.Text = answer.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}