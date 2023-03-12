/*Kaylee Dalton
CS 2263
01/12/2023 finished 1/28/2023
Project 3*/



using System.Text;
namespace KayleeDalton2263Ex3
{
    public partial class Ex3 : Form
        
    {

        String string1;
        String string2;
        int number1;
        int number2;
        public Ex3()
        {
            InitializeComponent();
            String string1 = "";
            String string2 = "";
            int number1;
            int number2;
            
        }
        Random rand = new Random();

        //1.Create a function that accepts 2 integers (pass by reference) and swaps them. 
        void swapByReference(ref int a, ref int b)
        {
            int aValue = a;
            a = b;
            b = aValue;
            

        }
        //2. Create a function that accepts a real number and returns a string
        //containing the numerals for the digits to the left of the decimal point.
        string realToRoman(double number)
        {
            int num = (int)number;
            string roman = "";

            var numeralValues = new Tuple<string, int>[] {
        Tuple.Create("M", 1000),
        Tuple.Create("CM", 900),
        Tuple.Create("D", 500),
        Tuple.Create("CD", 400),
        Tuple.Create("C", 100),
        Tuple.Create("XC", 90),
        Tuple.Create("L", 50),
        Tuple.Create("XL", 40),
        Tuple.Create("X", 10),
        Tuple.Create("IX", 9),
        Tuple.Create("V", 5),
        Tuple.Create("IV", 4),
        Tuple.Create("I", 1)
    };

            for (int i = 0; i < numeralValues.Length; i++)
            {
                while (num >= numeralValues[i].Item2)
                {
                    roman += numeralValues[i].Item1;
                    num -= numeralValues[i].Item2;
                }
            }

            return roman;
        }

        //3. Create a RECURSIVE function accepts an array of integers and reverses it
        //Got help on this from this youtube video.
        //The video uses C and not C# but it helped me understand the logic: https://youtu.be/YKoM4udWNKM

        public int[] Reverse(int[] arr) {
            int end = (arr.Length-1);
            int start = 0;
            //I had to make a nested function so the user wouldn't have to input
            //a start and end and could just input an array

            int[] ReverseArray(int[] arr, int start, int end)
            {
                if (start >= end)
                    return arr;

                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                return ReverseArray(arr, start + 1, end - 1);
            }

            arr = ReverseArray(arr, start, end);
            return arr;
        }

        //4. Create a function that accepts a positive integer and returns an integer array
        //of that length that contains random integers between 200 and 900. 
        int[] ArrayCreator(int length)
        {
            var rand = new Random();
            int[] arrayFoo = new int[length];

            for (int i = 0; i < length; i++)
            {
                arrayFoo[i] = rand.Next(200, 900);
            }

            return arrayFoo;
        }
        //4 continued: Function that accepts array
        //and returns a string containing a string representation of the
        //integers in that array separated by spaces 
        String intArrayToString(int[] arr) 
        {
            String outputString = "";
            char start = '0';
            for (int i = 0; i < arr.Length; i++)
            {
                
                outputString += ((start + i) + " ");
            }
            return outputString;
        }


        //5. Write a function that accepts 2 strings s1 and s2 and returns true IFF (if and only if)
        //none of the characters in s1 are in s2 and none characters in s2 are in s1. Note this function may return true
        //even if s1 is not identical to s2 or even if they are not of the same length.

        bool checkNoCommonCharacters(string s1, string s2)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                if (s2.Contains(s1[i]))
                    return false;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                if (s1.Contains(s2[i]))
                    return false;
            }
            return true;
        }
        //6. Write a function that accepts a 2D integer array a and returns true IFF
        //there exists an integer n such that n occurs at least once in every row of a. 
        bool CheckIfNIsInEachRow(int[,] arr, int n)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                bool found = false;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == n)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    return false;
                }
            }
            return true;
        }
        //6 continued: create 2d array with random numbers from 0-99
        int[,] random2DArray(int rows, int columns)
        {
            int[,] result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = rand.Next(100);
                }
            }
            return result;
        }

        int[] randomArray(int length)
        {
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = rand.Next(100);
            }
            return result;
        }
        //7. Write a function that accepts a 2D array of strings and returns the average
        //of all the ascii values of all the characters in all the strings in that array. 
        double AverageAsciiValues(string[,] arr)
        {
            double sum = 0;
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr[i, j].Length; k++)
                    {
                        sum += (int)arr[i, j][k];
                        count++;
                    }
                }
            }
            return sum / count;
        }
        //7 continued: Write a function that randomly fills that array with strings
        //containing 5 to 10 randomly selected lower case characters.


        string[,] RandomStringArray(int rows, int columns)
        {
            string[,] result = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int stringLength = rand.Next(5, 11);
                    StringBuilder sb = new StringBuilder();
                    for (int k = 0; k < stringLength; k++)
                    {
                        char c = (char)('a' + rand.Next(26));
                        sb.Append(c);
                    }
                    result[i, j] = sb.ToString();
                }
            }
            return result;
        }

        //8. Write a RECURSIVE function that accepts a 1D array of integers a
        //and returns the sum of all the odd integers in a.

        int SumOfOddNumbers(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                return 0;
            }
            int sum = SumOfOddNumbers(arr, index + 1);
            if (arr[index] % 2 != 0)
            {
                sum += arr[index];
            }
            return sum;
        }

        //Testing #1, takes two numbers and swaps them
        private void button2_Click(object sender, EventArgs e)
        {
            string1 = textBox1.Text;
            string2 = textBox2.Text;
            number1 = int.Parse(string1);
            number2 = int.Parse(string2);


            swapByReference(ref number1, ref number2);
            textBox1.Text = number1.ToString();
            textBox2.Text = number2.ToString();
            int num1 = 2, num2 = 3;
            swapByReference(ref num1, ref num2);

            listBox1.Items.Add("swapping num1 = 2 and num2 = 3: num1 = " + num1 + ", num2 = " + num2);

            num1 = 5; num2 = 7;
            swapByReference(ref num1, ref num2);
            listBox1.Items.Add("Swapping num1 = 5 and num2 = 7: num1 = " + num1 + ", num2 = " + num2);

            num1 = 42; num2 = 43;
            swapByReference(ref num1, ref num2);
            listBox1.Items.Add("Swapping num1 = 42 and num2 = 43: num1 = " + num1 + ", num2 = " + num2);

        }


        //Testing #2 Create a function that accepts a real number and returns a
        //string containing the numerals for the digits to the left of the decimal point.
        private void digToLeft_Click(object sender, EventArgs e)
        {
            String numeral;
            String decRemoveString;
            double decRemoveInt;
            decRemoveString= textBox3.Text;
            decRemoveInt = double.Parse(decRemoveString);
            numeral = realToRoman(decRemoveInt);
            MessageBox.Show(numeral);

        }

        //Testing #3 and #4 A set of three functions: the first generates an array of random integers,
        //the second reverses it,
        //and the third returns a string representation of the reversed array.
        private void reverseArrayButton_Click(object sender, EventArgs e)
        {
            String arrayLenStr = "";
            int arrayLenInt = 0;
            String arrayOutput = "";
            arrayLenStr = arrayInteger.Text;
            arrayLenInt = int.Parse(arrayLenStr);
            int[] randomArray = ArrayCreator(arrayLenInt);
            //Use your function from #3 to reverse that array. 
            randomArray = Reverse(randomArray);
            arrayOutput = intArrayToString(randomArray);
            MessageBox.Show(arrayOutput);


        }
        //testing #5 Write a function that accepts 2 strings s1 and s2 and returns true IFF
        //(if and only if) none of the characters in s1 are in s2 and none characters
        //in s2 are in s1. 
        private void isTextInText_Click(object sender, EventArgs e)
        {
            String s1Text = "";
            String s2Text = "";

            s1Text = s1.Text; s2Text = s2.Text;

            if (checkNoCommonCharacters(s1Text, s2Text))
            {
                MessageBox.Show("No Common Characters");
            }
            else MessageBox.Show("Common Characters");

        }

        //testing #6 Returns true IFF there exists an integer n such that
        //n occurs at least once in every row of a. 
        private void isNInArray_Click(object sender, EventArgs e)
        {
            String nString = integerN.Text;
            int n = int.Parse(nString);
            int[,] arrayToCheck = random2DArray(5,5);
            if (CheckIfNIsInEachRow(arrayToCheck, n))
                 MessageBox.Show("n is in every row of the array, you win!");
            else MessageBox.Show("n is not in every row you lose");


        }
        
        //Testing #7 which has two functions:
        //One that calculates the average ASCII value of characters in a 2D array of strings
        //One that randomly fills the array with strings of random length and lowercase characters.
       
        private void avgASCII_Click(object sender, EventArgs e)
        {
            String AscLengthString = avgAscLength.Text;
            int AscLengthInt = int.Parse(AscLengthString);
            String[,] randomArrStr = RandomStringArray(AscLengthInt, (2*AscLengthInt));
            double output = AverageAsciiValues(randomArrStr);
            char outputChar = (char)output;
            MessageBox.Show("The average character was "+ outputChar.ToString());
            
        }
        //Testing #8 Write a RECURSIVE function that accepts a 1D array of integers a
        //and returns the sum of all the odd integers in a.
        private void sumOfOdd_Click(object sender, EventArgs e)
        {
            //Testing using array of numbers (this is my parent's zipcode)
            int[] numbers = new int[] { 8, 3, 4, 0, 2 };

            int sum = SumOfOddNumbers(numbers, 0);
            MessageBox.Show("Array's numbers were 8,3,4,0,2 Sum of odd numbers is: " + sum.ToString()); 

        }











        //Text boxes below

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        { 

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void s1_TextChanged(object sender, EventArgs e)
        {

        }

        private void s2_TextChanged(object sender, EventArgs e)
        {

        }

        private void integerN_TextChanged(object sender, EventArgs e)
        {

        }

        private void avgAscLength_TextChanged(object sender, EventArgs e)
        {

        }


    }
}