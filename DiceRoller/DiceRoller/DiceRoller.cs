using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller
{
    public partial class DiceRoller : Form
    {
        public DiceRoller()
        {
            InitializeComponent();
            inDieType.SelectedIndex = 0;
            inAdvantage.SelectedIndex = 0;
        }



        private void btnRoll_Click(object sender, EventArgs e)
        {
            String type = inDieType.Text;

            String advantage = inAdvantage.Text;

            int numRolls = Int32.Parse(inNumRolls.Text);

            int add = 0;

            if(inPlus.Text != "")
            {
                add = Int32.Parse(inPlus.Text);
            }

            Random rnd = new Random();

            if(advantage == "Normal" )
            {
                int total = 0;
                for(int i = 0; i < numRolls; i++)
                {
                    if(type == "d3")
                    {
                        total += rnd.Next(1, 4);
                    }
                    else if(type == "d4")
                    {
                        total += rnd.Next(1, 5);
                    }
                    else if (type == "d6")
                    {
                        total += rnd.Next(1, 7);
                    }
                    else if (type == "d8")
                    {
                        total += rnd.Next(1, 9);
                    }
                    else if (type == "d10")
                    {
                        total += rnd.Next(1, 11);
                    }
                    else if (type == "d12")
                    {
                        total += rnd.Next(1, 13);
                    }
                    else if (type == "d20")
                    {
                        total += rnd.Next(1, 21);
                    }
                    else if (type == "d100")
                    {
                        total += rnd.Next(1, 101);
                    }
                }

                total += add;

                outRolls.Items.Add("Roll        " + numRolls + "" + type + " + " + add + "      ( " + advantage + " ) " + " = " + total);

            }
            else
            {
                int total = 0;
                int total2 = 0;


                for (int i = 0; i < numRolls; i++)
                {
                    if (type == "d3")
                    {
                        total += rnd.Next(1, 4);
                    }
                    else if (type == "d4")
                    {
                        total += rnd.Next(1, 5);
                    }
                    else if (type == "d6")
                    {
                        total += rnd.Next(1, 7);
                    }
                    else if (type == "d8")
                    {
                        total += rnd.Next(1, 9);
                    }
                    else if (type == "d10")
                    {
                        total += rnd.Next(1, 11);
                    }
                    else if (type == "d12")
                    {
                        total += rnd.Next(1, 13);
                    }
                    else if (type == "d20")
                    {
                        total += rnd.Next(1, 21);
                    }
                    else if (type == "d100")
                    {
                        total += rnd.Next(1, 101);
                    }
                }

                for (int i = 0; i < numRolls; i++)
                {
                    if (type == "d3")
                    {
                        total2 += rnd.Next(1, 4);
                    }
                    else if (type == "d4")
                    {
                        total2 += rnd.Next(1, 5);
                    }
                    else if (type == "d6")
                    {
                        total2 += rnd.Next(1, 7);
                    }
                    else if (type == "d8")
                    {
                        total2 += rnd.Next(1, 9);
                    }
                    else if (type == "d10")
                    {
                        total2 += rnd.Next(1, 11);
                    }
                    else if (type == "d12")
                    {
                        total2 += rnd.Next(1, 13);
                    }
                    else if (type == "d20")
                    {
                        total2 += rnd.Next(1, 21);
                    }
                    else if (type == "d100")
                    {
                        total2 += rnd.Next(1, 101);
                    }
                }

                total += add;
                total2 += add;

                int roll = 0;

                if(advantage == "Advantage")
                {
                    if(total >= total2)
                    {
                        roll = total;
                    }
                    else
                    {
                        roll = total2;
                    }
                }
                else
                {
                    if (total >= total2)
                    {
                        roll = total2;
                    }
                    else
                    {
                        roll = total;
                    }
                }

                outRolls.Items.Add("Roll        " + numRolls + "" + type + " + " + add +  " = " + total + "       Second Roll     " + numRolls + 
                                                         "" + type + " + " + add + " = " + total2 + " ( " + advantage + " ) " + " = " + roll);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            outRolls.Items.Clear();
        }
    }
}
