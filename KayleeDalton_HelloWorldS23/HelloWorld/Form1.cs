namespace HelloWorld
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            richTextBox1.Visible = false;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = true;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible=false;
            button4.Visible=true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible=true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;  
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}