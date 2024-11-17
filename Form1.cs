using System.Diagnostics.Metrics;
using System.Media;
using NAudio;
using NAudio.Wave;

namespace Text_to_MorseConverter_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StarMorse();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DefaultMorse();
        }

        private void StarMorse()
        {
            bool EditOrNot = true;
            string StringToRead = Convert.ToString(textBox1.Text);
            string NewString = StringToRead;

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'a')
                {
                    if (EditOrNot == true)
                    {
                        NewString = StringToRead.Replace("a", "*_");
                    }
                    continue;
                }
                if (Letter == 'A')
                {
                    if (EditOrNot == true)
                    {
                        NewString = StringToRead.Replace("A", "*_");
                    }
                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'b')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("b", "_***");
                    }

                    continue;
                }
                if (Letter == 'B')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("B", "_***");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'c')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("c", "_*_*");
                    }

                    continue;
                }
                if (Letter == 'C')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("C", "_*_*");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'd')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("d", "_**");
                    }

                    continue;
                }
                if (Letter == 'D')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("D", "_**");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'e')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("e", "*");
                    }

                    continue;
                }
                if (Letter == 'E')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("E", "*");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'f')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("f", "**_*");
                    }

                    continue;
                }
                if (Letter == 'F')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("F", "**_*");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'g')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("g", "__*");
                    }

                    continue;
                }
                if (Letter == 'G')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("G", "__*");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'h')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("h", "****");
                    }

                    continue;
                }
                if (Letter == 'H')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("H", "****");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'i')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("i", "**");
                    }

                    continue;
                }
                if (Letter == 'I')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("I", "**");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'j')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("j", "*___");
                    }

                    continue;
                }
                if (Letter == 'J')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("J", "*___");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'k')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("k", "_*_");
                    }

                    continue;
                }
                if (Letter == 'K')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("K", "_*_");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'l')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("l", "*_**");
                    }

                    continue;
                }
                if (Letter == 'L')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("L", "*_**");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'm')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("m", "__");
                    }

                    continue;
                }
                if (Letter == 'M')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("M", "__");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'n')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("n", "_*");
                    }

                    continue;
                }
                if (Letter == 'N')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("N", "_*");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'o')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("o", "___");
                    }

                    continue;
                }
                if (Letter == 'O')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("O", "___");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'p')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("p", "*__*");
                    }

                    continue;
                }
                if (Letter == 'P')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("P", "*__*");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'q')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("q", "__*_");
                    }

                    continue;
                }
                if (Letter == 'Q')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("Q", "__*_");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'r')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("r", "*_*");
                    }

                    continue;
                }
                if (Letter == 'R')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("R", "*_*");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 's')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("s", "***");
                    }

                    continue;
                }
                if (Letter == 'S')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("S", "***");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 't')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("t", "_");
                    }

                    continue;
                }
                if (Letter == 'T')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("T", "_");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'u')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("u", "**_");
                    }

                    continue;
                }
                if (Letter == 'U')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("U", "**_");
                    }

                    continue;
                }
            }


            foreach (char Letter in StringToRead)
            {
                if (Letter == 'v')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("v", "***_");
                    }

                    continue;
                }
                if (Letter == 'V')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("V", "***_");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'w')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("w", "*__");
                    }

                    continue;
                }
                if (Letter == 'W')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("W", "*__");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'x')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("x", "_**_");
                    }

                    continue;
                }
                if (Letter == 'X')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("X", "_**_");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'y')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("y", "_*__");
                    }

                    continue;
                }
                if (Letter == 'Y')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("Y", "_*__");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'z')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("z", "__**");
                    }

                    continue;
                }
                if (Letter == 'Z')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("Z", "__**");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == 'ä')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("ä", "*_*_");
                    }

                    continue;
                }
                if (Letter == 'Ä')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("Ä", "*_*_");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == 'ö')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("ö", "___*");
                    }

                    continue;
                }
                if (Letter == 'Ö')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("Ö", "___*");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == 'ü')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("ü", "**__");
                    }

                    continue;
                }
                if (Letter == 'ü')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("Ü", "**__");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == ' ')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace(" ", "/");
                    }

                    continue;
                }
            }


            //NUMBERS
            foreach (char Letter in StringToRead)
            {
                if (Letter == '0')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("0", "_____");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == '1')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("1", "*____");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == '2')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("2", "**___");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == '3')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("3", "***__");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == '4')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("4", "****_");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == '5')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("5", "*****");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == '6')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("6", "_****");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == '7')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("7", "__***");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == '8')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("8", "___**");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == '9')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("9", "____*");
                    }

                    continue;
                }
            }

            //SatzEnde
            foreach (char letter in StringToRead)
            {
                if (letter == '.')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace(".", "*_*_*_");
                    }

                    continue;
                }
            }
            foreach (char letter in StringToRead)
            {
                if (letter == '!')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("!", "_*_*__");
                    }

                    continue;
                }
            }
            foreach (char letter in StringToRead)
            {
                if (letter == '?')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("?", "**__**");
                    }

                    continue;
                }
            }
            foreach (char letter in StringToRead)
            {
                if (letter == '€')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("€", "* **_ *_*");
                    }

                    continue;
                }
            }
            foreach (char letter in StringToRead)
            {
                if (letter == '$')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("$", "***_**_");
                    }

                    continue;
                }
            }

            foreach (char letter in StringToRead)
            {
                if (letter == '"')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("\"", "*__**__*");
                    }

                    continue;
                }
            }



            //Komma
            foreach (char letter in StringToRead)
            {
                if (letter == ',')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace(",", "__**__");
                    }

                    continue;
                }
            }

            //Doppelpunkte
            foreach (char letter in StringToRead)
            {
                if (letter == ':')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace(":", "___***");
                    }

                    continue;
                }
            }
            foreach (char letter in StringToRead)
            {
                if (letter == ';')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace(";", "_*_*_*");
                    }

                    continue;
                }
            }

            //Rechenzeichen
            foreach (char letter in StringToRead)
            {
                if (letter == '+')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("+", "*_*_*");
                    }

                    continue;
                }
            }
            foreach (char letter in StringToRead)
            {
                if (letter == '-')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("-", "_****_");
                    }

                    continue;
                }
            }
            foreach (char letter in StringToRead)
            {
                if (letter == '*')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("*", "_**_");
                    }

                    continue;
                }
            }
            foreach (char letter in StringToRead)
            {
                if (letter == '/')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("/", "_**_*");
                    }

                    continue;
                }
            }
            foreach (char letter in StringToRead)
            {
                if (letter == '=')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("=", "_***_");
                    }

                    continue;
                }
            }

            //Klammern
            foreach (char letter in StringToRead)
            {
                if (letter == '(')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("(", "_*__*");
                    }

                    continue;
                }
            }
            foreach (char letter in StringToRead)
            {
                if (letter == ')')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace(")", "_*__*_");
                    }

                    continue;
                }
            }
            //noch nicht fertig
            foreach (char letter in StringToRead)
            {
                if (letter == '[')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("[", "_*__*");
                    }

                    continue;
                }
            }
            //noch nicht fertig
            foreach (char letter in StringToRead)
            {
                if (letter == ']')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("]", "_*__*_");
                    }

                    continue;
                }
            }

            foreach (char letter in StringToRead)
            {
                if (letter == '@')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("@", "*__*_*");
                    }

                    continue;
                }
            }

            textBox2.Text = NewString;

        }

        private void DefaultMorse()
        {
            bool EditOrNot = true;
            string StringToRead = Convert.ToString(textBox1.Text);
            string NewString = StringToRead;

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'a')
                {
                    if (EditOrNot == true)
                    {
                        NewString = StringToRead.Replace("a", "._");
                    }
                    continue;
                }
                if (Letter == 'A')
                {
                    if (EditOrNot == true)
                    {
                        NewString = StringToRead.Replace("A", "._");
                    }
                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'b')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("b", "_...");
                    }

                    continue;
                }
                if (Letter == 'B')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("B", "_...");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'c')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("c", "_._.");
                    }

                    continue;
                }
                if (Letter == 'C')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("C", "_._.");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'd')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("d", "_..");
                    }

                    continue;
                }
                if (Letter == 'D')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("D", "_..");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'e')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("e", ".");
                    }

                    continue;
                }
                if (Letter == 'E')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("E", ".");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'f')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("f", ".._.");
                    }

                    continue;
                }
                if (Letter == 'F')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("F", ".._.");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'g')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("g", "__.");
                    }

                    continue;
                }
                if (Letter == 'G')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("G", "__.");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'h')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("h", "....");
                    }

                    continue;
                }
                if (Letter == 'H')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("H", "....");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'i')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("i", "..");
                    }

                    continue;
                }
                if (Letter == 'I')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("I", "..");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'j')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("j", ".___");
                    }

                    continue;
                }
                if (Letter == 'J')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("J", ".___");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'k')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("k", "_._");
                    }

                    continue;
                }
                if (Letter == 'K')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("K", "_._");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'l')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("l", "._..");
                    }

                    continue;
                }
                if (Letter == 'L')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("L", "._..");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'm')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("m", "__");
                    }

                    continue;
                }
                if (Letter == 'M')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("M", "__");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'n')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("n", "_.");
                    }

                    continue;
                }
                if (Letter == 'N')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("N", "_.");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'o')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("o", "___");
                    }

                    continue;
                }
                if (Letter == 'O')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("O", "___");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'p')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("p", ".__.");
                    }

                    continue;
                }
                if (Letter == 'P')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("P", ".__.");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'q')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("q", "__._");
                    }

                    continue;
                }
                if (Letter == 'Q')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("Q", "__._");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'r')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("r", "._.");
                    }

                    continue;
                }
                if (Letter == 'R')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("R", "._.");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 's')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("s", "...");
                    }

                    continue;
                }
                if (Letter == 'S')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("S", "...");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 't')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("t", "_");
                    }

                    continue;
                }
                if (Letter == 'T')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("T", "_");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'u')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("u", ".._");
                    }

                    continue;
                }
                if (Letter == 'U')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("U", ".._");
                    }

                    continue;
                }
            }


            foreach (char Letter in StringToRead)
            {
                if (Letter == 'v')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("v", "..._");
                    }

                    continue;
                }
                if (Letter == 'V')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("V", "..._");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'w')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("w", ".__");
                    }

                    continue;
                }
                if (Letter == 'W')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("W", ".__");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'x')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("x", "_.._");
                    }

                    continue;
                }
                if (Letter == 'X')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("X", "_.._");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'y')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("y", "_.__");
                    }

                    continue;
                }
                if (Letter == 'Y')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("Y", "_.__");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == 'z')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("z", "__..");
                    }

                    continue;
                }
                if (Letter == 'Z')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("Z", "__..");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == 'ä')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("ä", "._._");
                    }

                    continue;
                }
                if (Letter == 'Ä')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("Ä", "._._");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == 'ö')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("ö", "___.");
                    }

                    continue;
                }
                if (Letter == 'Ö')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("Ö", "___.");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == 'ü')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("ü", "..__");
                    }

                    continue;
                }
                if (Letter == 'ü')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("Ü", "..__");
                    }

                    continue;
                }
            }

            foreach (char Letter in StringToRead)
            {
                if (Letter == ' ')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace(" ", "/");
                    }

                    continue;
                }
            }


            //NUMBERS
            foreach (char Letter in StringToRead)
            {
                if (Letter == '0')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("0", "_____");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == '1')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("1", ".____");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == '2')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("2", "..___");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == '3')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("3", "...__");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == '4')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("4", "...._");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == '5')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("5", ".....");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == '6')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("6", "_....");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == '7')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("7", "__...");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == '8')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("8", "___..");
                    }

                    continue;
                }
            }
            foreach (char Letter in StringToRead)
            {
                if (Letter == '9')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("9", "____.");
                    }

                    continue;
                }
            }

            //SatzEnde
            foreach (char letter in StringToRead)
            {
                if (letter == '.')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace(".", "._._._");
                    }

                    continue;
                }
            }
            foreach (char letter in StringToRead)
            {
                if (letter == '!')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("!", "_._.__");
                    }

                    continue;
                }
            }
            foreach (char letter in StringToRead)
            {
                if (letter == '?')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("?", "..__..");
                    }

                    continue;
                }
            }
            foreach (char letter in StringToRead)
            {
                if (letter == '€')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("€", ". .._ ._.");
                    }

                    continue;
                }
            }
            foreach (char letter in StringToRead)
            {
                if (letter == '$')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("$", "..._.._");
                    }

                    continue;
                }
            }

            foreach (char letter in StringToRead)
            {
                if (letter == '"')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("\"", ".__..__.");
                    }

                    continue;
                }
            }



            //Komma
            foreach (char letter in StringToRead)
            {
                if (letter == ',')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace(",", "__..__");
                    }

                    continue;
                }
            }

            //Doppelpunkte
            foreach (char letter in StringToRead)
            {
                if (letter == ':')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace(":", "___...");
                    }

                    continue;
                }
            }
            foreach (char letter in StringToRead)
            {
                if (letter == ';')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace(";", "_._._.");
                    }

                    continue;
                }
            }

            //Rechenzeichen
            foreach (char letter in StringToRead)
            {
                if (letter == '+')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("+", "._._.");
                    }

                    continue;
                }
            }
            foreach (char letter in StringToRead)
            {
                if (letter == '-')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("-", "_...._");
                    }

                    continue;
                }
            }
            foreach (char letter in StringToRead)
            {
                if (letter == '*')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("*", "_.._");
                    }

                    continue;
                }
            }
            foreach (char letter in StringToRead)
            {
                if (letter == '/')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("/", "_.._*");
                    }

                    continue;
                }
            }
            foreach (char letter in StringToRead)
            {
                if (letter == '=')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("=", "_..._");
                    }

                    continue;
                }
            }

            //Klammern
            foreach (char letter in StringToRead)
            {
                if (letter == '(')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("(", "_.__.");
                    }

                    continue;
                }
            }
            foreach (char letter in StringToRead)
            {
                if (letter == ')')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace(")", "_.__._");
                    }

                    continue;
                }
            }
            //noch nicht fertig
            foreach (char letter in StringToRead)
            {
                if (letter == '[')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("[", "_.__.");
                    }

                    continue;
                }
            }
            //noch nicht fertig
            foreach (char letter in StringToRead)
            {
                if (letter == ']')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("]", "_.__._");
                    }

                    continue;
                }
            }

            foreach (char letter in StringToRead)
            {
                if (letter == '@')
                {
                    if (EditOrNot == true)
                    {
                        NewString = NewString.Replace("@", ".__._.");
                    }

                    continue;
                }
            }

            textBox2.Text = NewString;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowser = new FolderBrowserDialog();
            textBox3.Text = FolderBrowser.SelectedPath;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string TextToSound = textBox2.Text;
            string OutputFolder = textBox3.Text;
            var waveF = new WaveFormat(44100, 1);
            string OutputFile = Path.Combine(OutputFolder, "MorseCode.wav");
            using (var waveFile = new WaveFileWriter (OutputFile, waveF))
            {
                using (var wave = new WaveInEvent())
                {
                    wave.WaveFormat = waveF;
                    SoundPlayer player = new SoundPlayer();
                    wave.StartRecording();

                    wave.DataAvailable += (s, e) =>
                    {
                        waveFile.Write(e.Buffer, 0, e.BytesRecorded);
                    };

                    foreach (char Character in TextToSound)
                    {
                        if (Character == '.' | Character == '*')
                        {
                            player.SoundLocation = @"BeepShort.wav";
                            player.PlaySync();
                            continue;
                        }

                        if (Character == '_')
                        {
                            player.SoundLocation = @"BeepLong.wav";
                            player.PlaySync();
                            continue;
                        }
                        if (Character == ' ')
                        {
                            System.Threading.Thread.Sleep(400);
                            continue;
                        }

                        if (Character == '/')
                        {
                            System.Threading.Thread.Sleep(700);
                            continue;
                        }
                    }
                    wave.StopRecording();
                }
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
