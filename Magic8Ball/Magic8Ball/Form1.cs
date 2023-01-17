namespace Magic8Ball
{
    public partial class Form1 : Form
    {
        List<string> magic8BallFortunes = new List<string>()
{
    "It is certain",
    "It is decidedly so",
    "Without a doubt",
    "Yes - definitely",
    "You may rely on it",
    "As I see it, yes",
    "Most likely",
    "Outlook good",
    "Yes",
    "Signs point to yes",
    "Reply hazy, try again",
    "Ask again later",
    "Better not tell you now",
    "Cannot predict now",
    "Concentrate and ask again",
    "Don't count on it",
    "My reply is no",
    "My sources say no",
    "Outlook not so good",
    "Very doubtful",
    "Nope"
};
        public Form1()
        {
            InitializeComponent();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand1 = new Random((int)DateTime.Now.Ticks);
            int randomNum = rand1.Next(0, 20);
            string fortune = magic8BallFortunes[randomNum];
            fortuneOut.Text = fortune;
        }
    }
}