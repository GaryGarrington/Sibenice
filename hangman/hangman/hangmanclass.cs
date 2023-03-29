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
    class hangmanclass
    {
        public List<string> words = new List<string>(); // seznam možných slov
        public List<char> letters = new List<char>(); // vybrané slovo rozdělené na písmena
        public List<char> guesses = new List<char>(); // hádaná písmena
        public List<Control> labels = new List<Control>(); // list labelů
        public int error = 0; // počet chyb
        public int points; // počet uhodnutých písmenna
        public string word; // hádané slovo
        public string a; // Tvoří string hádaných písmen, který se následně vypíše
        public bool endgame = false; // určuje, jestli uživatel dohrál
        public bool winresult; // určuje, jestli uživatel vyhrál
        public Control used; // label hádaných písmen
        public Control pictureBox1; // obrázek šibenice
        public Control[] label; // nalezený label
        public DialogResult result; // Rozhodnutí uživatele jestli chce pokračovat ve hře

        /// <summary>
        /// Načte/resetuje hru 
        /// </summary>
        public void load()
        {
            used.Text = "";
            words.Clear();
            letters.Clear();
            guesses.Clear();
            error = 0;
            points = 0;
            endgame = false;
            pictureBox1.BackgroundImage = Image.FromFile("Noose0.png");
            for (int i = 0; i < 5; i++)
            {
                labels[i].Text = "-";
            }
            // Vyčištění z předchozí hry
            string line;
            StreamReader fload = new StreamReader("src.csv");
            while ((line = fload.ReadLine()) != null)
            {
                words.Add(line.ToUpper()); // načte dostupná slova ze souboru src.csv do listu words
            }
            Random rnd = new Random();
            int numbah = rnd.Next(0, words.Count - 1);
            word = words[numbah]; // náhodně vybere jedno slovo z listu words
            foreach (char c in words[numbah])
            {
                letters.Add(c); // rozdělí vybrané slovo na jednotlivá písmena
            }
        }
        /// <summary>
        /// Kontroluje, jestli uživatel dané písmeno už nehádal
        /// </summary>
        /// <param name="guess">
        /// Uživatelův guess
        /// </param>
        /// <returns>
        /// Bool, jestli bylo písmeno už hádáno
        /// </returns>
        public bool guesscheck(char guess)
        {
            if (guesses.Count == 0) // je potřeba zvlášť podmínka pokavaď uživatel ještě neudělal žádné guessy, jinak by nefungoval for cyklus níže
            {
                used.Text += " " + guess; // guess se zapíše do labelu
                guesses.Add(guess); // guess se přídá do listu guessů
                return true;
            }
            for (int j = 0; j < guesses.Count; j++)
            {
                if (guess == guesses[j]) // pokavaď se uživatel pokusí znovu hádat písmeno které již zkoušel...
                    return false; // program nebude pokračovat
                if (j == guesses.Count - 1) // pokavaď se nenajde stisknuté písmeno mezi již hádanými...
                {
                    guesses.Add(guess); // přídá se do listu hádaných písmen
                    guesses.Sort(); // abecedně se seřadí
                    for (int i = 0; i < guesses.Count; i++)
                    {
                        a = string.Join(" ", guesses); // všechna hádaná písmena z listu se zapíší do labelu
                    }
                    used.Text = a;
                    return true;
                }
            }
            return true;
        }
        /// <summary>
        /// Vyhodnotí uživatelovo hádané písmeno
        /// </summary>
        /// <param name="guess">
        /// uživatelův guess
        /// </param>
        public void game(char guess)
        {
            for (int i = 0; i < letters.Count; i++)
            {
                if (guess == letters[i]) // pokavaď se hádané písmeno shoduje s jedním z písmen slova...
                {
                    labels[i].Text = Convert.ToString(letters[i]); // písmeno se "odhalí" v příslušném labelu
                    points++; // přičte se bod
                    break;
                }
                if (i == letters.Count - 1) // pokavaď se hádané písmeno neshoduje s jedním z písmen slova...
                {
                    switch (error) // podle počtu chyb se načte příslušný obrázek šibenice
                    {
                        case 0:
                            pictureBox1.BackgroundImage = Image.FromFile("Noose1.png");
                            pictureBox1.Size = pictureBox1.PreferredSize;
                            error++;
                            break;
                        case 1:
                            pictureBox1.BackgroundImage = Image.FromFile("Noose2.png");
                            pictureBox1.Size = pictureBox1.PreferredSize;
                            error++;
                            break;
                        case 2:
                            pictureBox1.BackgroundImage = Image.FromFile("Noose3.png");
                            pictureBox1.Size = pictureBox1.PreferredSize;
                            error++;
                            break;
                        case 3:
                            pictureBox1.BackgroundImage = Image.FromFile("Noose4.png");
                            pictureBox1.Size = pictureBox1.PreferredSize;
                            error++;
                            break;
                        case 4:
                            pictureBox1.BackgroundImage = Image.FromFile("Noose5.png");
                            pictureBox1.Size = pictureBox1.PreferredSize;
                            endgame = true; // Uživatel dohrál
                            winresult = false; // Uživatel prohrál
                            return;
                    }
                }
            }
            if (points == 5) // pokud uživatel uhodne všechna písmena...
            {
                endgame = true; // uživatel dohrál
                winresult = true; // uživatel vyhrál
                return;
            }
            return;
        }
        /// <summary>
        /// Ukáže uživateli výsledek hry, zeptá se jestli chce hrát znovu
        /// </summary>
        /// <param name="win">
        /// Výsledek hry
        /// </param>
        /// <returns>
        /// Uživatelův výběr v MessageBoxu
        /// </returns>
        public DialogResult resetcheck(bool win)
        {
            if (win == true) // Pokud uživatel vyhrál...
            {
                result = MessageBox.Show("Vyhrál jsi" + Environment.NewLine + "Chceš pokračovat?", "WIN WIN WIN", MessageBoxButtons.YesNo);
                // MessageBox oznámí výhru, zeptá se jestli chce další hru
                return result;
            }
            else // pokud uživatel prohrál...
            {
                result = MessageBox.Show("Prohrál jsi" + Environment.NewLine + "hádané slovo: " + word + Environment.NewLine + "Chceš pokračovat?", "L L L", MessageBoxButtons.YesNo);
                // MessageBox oznámí prohru, zeptá se jestli chce další hru
                return result;
            }
        }
    }
}
