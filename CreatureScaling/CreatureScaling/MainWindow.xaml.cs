using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CreatureScaling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Creature.Seed();
            inCR.Focus();
        }

        private void btnScale_Click(object sender, RoutedEventArgs e)
        {
            CHALLENGE_RATING CR = CHALLENGE_RATING.EIGHTH;
            if (inCR.Text == "1/8")
            {
                
            }
            else if(inCR.Text == "1/4")
            {
                CR = CHALLENGE_RATING.QUARTER;
            }
            else if (inCR.Text == "1/2")
            {
                CR = CHALLENGE_RATING.HALF;
            }
            else
            {
                int test = 0;

                if (!inCR.Text.Contains('/'))
                {
                    if (int.TryParse(inCR.Text, out test))
                    {
                        if (test <= 30)
                        {
                            CR = (CHALLENGE_RATING)(int.Parse(inCR.Text) + 3);
                        }
                        else
                        {
                            CR = CHALLENGE_RATING.INVALID;
                        }
                    }
                }
                else
                {
                    CR = CHALLENGE_RATING.INVALID;
                }
            }
            
           Creature temp = Creature.NewCR(CR);

            outArmor.Text = "" + temp.ArmorClass;
            outAttack.Text = "" + temp.AttackBonus;
            outDmg.Text = "" + temp.DmgPerRound;
            outHP.Text = "" + temp.HitPoints;
            outProf.Text = "" + temp.ProfBonus;
            outSave.Text = "" + temp.SaveDC;
            outXp.Text = "" + temp.Experience;

        }
    }
}
