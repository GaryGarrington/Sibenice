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

namespace hangman
{
    public partial class Form1 : Form
    {
        hangmanclass hang = new hangmanclass();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char guess = char.ToUpper(e.KeyChar); // převod stisknuté klávesy na character
            if (hang.guesscheck(guess) == true) // pokud uživatel zadal písmeno které ještě nezadával...
            {
                hang.game(guess); // vyhodnotí se jeho guess
            }
            if (hang.endgame == true) // Pokud uživatel dohrál...
            {
                DialogResult result = hang.resetcheck(hang.winresult); // Program se zeptá jestli chce uživatel hrát znovu
                if (result == DialogResult.Yes) hang.load(); // Pokud ano, hra se resetuje
                else this.Close(); // Pokud ne, program se ukončí
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hang.used = used;
            hang.pictureBox1 = pictureBox1;
            for (int i = 0; i < 5; i++)
            {
                hang.label = Controls.Find("letter" + i, true);
                hang.labels.Add(hang.label[0]);
            }
            // dosazení ovládacích prvků aplikace do příslušných proměnných objektu
            hang.load(); // Načtení hry
        }
    }
}