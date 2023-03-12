
/*
Author: Kaylee Dalton
Course: CS2263
Date: 01/30/2023
Project: ROT13/CaesarCipherProject

This project implements the ROT13/Caesar Cipher encryption technique, which involves 
shifting each letter in the string by a fixed number of places down the alphabet. 
*/

using System;
using System.IO;
namespace CS2263Project4KayleeDalton
{
    public partial class ROT13 : Form
    {
        public ROT13()
        {
            InitializeComponent();
        }
        class Rot13DecoderRing
        {
            private static string encodedText;
            private static string clearText;

            
            //a canonicalizeString method that takes a string s
            //replaces all upper-case characters with the equivalent lower case character 
            //(‘A’-> ‘a’), removes any characters in the string except characters and spaces. 
           
            public static string CanonicalizeString(string messyString)
            {
                string output = "";

                for (int i = 0; i < messyString.Length; i++)
                {
                    char character = messyString[i];
                    int charValue = (int)character;

                    if ((charValue >= 65 && charValue <= 90) ||
                        (charValue >= 97 && charValue <= 122) ||
                        character == ' ')
                    {
                        output += Char.ToLower(character);
                    }
                }

                return output;
            }
        }
        // The Rot13 function takes a character and returns an encrypted version of it.
        // It uses an array of lowercase letters 'a' to 'z', and finds the input character's position in the array.
        // If the character is in the array, the function adds 13 to its position and returns the encrypted character.
        static char Rot13Char(char character)
        {
            char[] lowerAlphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] upperAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            int index;
            if (char.IsLower(character))
            {
                index = Array.IndexOf(lowerAlphabet, character);
                if (index != -1)
                {
                    index = (index + 13) % 26;
                    return lowerAlphabet[index];
                }
                else
                {
                    return character;
                }
            }
            else if (char.IsUpper(character))
            {
                index = Array.IndexOf(upperAlphabet, character);
                if (index != -1)
                {
                    index = (index + 13) % 26;
                    return upperAlphabet[index];
                }
                else
                {
                    return character;
                }
            }
            else
            {
                return character;
            }
        }

        // Converts a clear string to an encrypted rot13 string.
        // Iterates through each character and passes it to the Rot13Char function and returns a string.

        static string Rot13String(string clearString) 
        {
            char[] input = clearString.ToCharArray();
            for(int i = 0; i < input.Length;i++)
            {
                input[i] = Rot13Char(input[i]);
            }
            string rottenString = new string(input);
            return rottenString;
        }

        // Converts a clear text file to an encrypted rot13 file.
        // Reads in clear file, converts its contents to rot13, and writes the result to a new file.
        static void WriteRot13File(string clearFilePath, string rot13FilePath)
        {
            string clearText = File.ReadAllText(clearFilePath);
            string rot13Text = Rot13String(clearText);
            File.WriteAllText(rot13FilePath, rot13Text);
        }

        //Takes string file location and returns .txt file as a string
        static string ConvertFileToString(string fileLocation)
        {
            try
            {
                string fileContents = File.ReadAllText(fileLocation);
                return fileContents;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
                return "";
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred while reading the file");
                return "";
            }
        }

        //Encrypt text from one box and display in the other
        private void button1_Click(object sender, EventArgs e)
        {
            // Get the input from the input textbox
            string inputText = input.Text;

            // Call the Rot13String function with the input
            string rot13Text = Rot13String(inputText);

            // Set the output textbox with the result
            output.Text = rot13Text;

        }



        //Encrypt a .txt file from the computer
        //Got help with using OpenDialog from this video: https://www.youtube.com/watch?v=pPQQJmX_3MM

        private void button2_Click(object sender, EventArgs e)
        {
            String encryptText = "";
            String cleanTextLocation = "";
            String finishedTextLocation = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select File to Encrypt/Decipher";
            openFileDialog1.Filter = "All files (*.*) |*.*|Text File (*.txt*)|*.txt*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.ShowDialog();
            if(openFileDialog1.FileName != "") 
            {
                cleanTextLocation = openFileDialog1.FileName;   
            }
            else { cleanTextLocation = ""; }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                finishedTextLocation = saveFileDialog1.FileName;
                // code to save the string to the file at the location "finishedTextLocation"
            }




            WriteRot13File(cleanTextLocation, finishedTextLocation);



        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {


        }
    }
}