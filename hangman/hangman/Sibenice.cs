using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace hangman_OOP
{
    class Sibenice
    {
        public List<string> words = new List<string>();
        public List<char> letters = new List<char>();
        public List<char> guesses = new List<char>();
        public int error = 0;
        public string word;
        public string a;
        public int win;
        public Control used;
        public Control pictureBox1;
        public Control[] labels;
        public Control label;
        

        public void load()
        {
            used.Text = "";
            words.Clear();
            letters.Clear();
            guesses.Clear();
            error = 0;
            win = 0;
            pictureBox1.BackgroundImage = Image.FromFile("Noose0.png");
            for (int i = 0; i < 5; i++)
            {
                label = Array.Find(labels, element => element.Name == "image" + i);
                label.Text = "-";
            }
            string line;
            StreamReader fload = new StreamReader("src.csv");
            while ((line = fload.ReadLine()) != null)
            {
                words.Add(line.ToUpper());
            }
            Random rnd = new Random();
            int numbah = rnd.Next(0, words.Count - 1);
            word = words[numbah];
            foreach (char c in words[numbah])
            {
                letters.Add(c);
            }
        }
    }
}
