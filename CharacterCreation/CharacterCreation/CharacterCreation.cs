using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreation
{
    public partial class CharacterCreator : Form
    {
        public CharacterCreator()
        {
            InitializeComponent();
        }

        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if(control is RichTextBox)
                {
                    RichTextBox richTextBox = (RichTextBox)control;
                    richTextBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            String outStr = "Race: " + inRace.Text + Environment.NewLine + Environment.NewLine +
                            "Gender: " + inGender.Text + Environment.NewLine + Environment.NewLine +
                            "Age: " + inAge.Text + Environment.NewLine + Environment.NewLine +
                            "Alignment: " + inAlign.Text + Environment.NewLine + Environment.NewLine +
                            "Height: " + inHeight.Text + Environment.NewLine + Environment.NewLine +
                            "Weight: " + inWeight.Text + Environment.NewLine + Environment.NewLine +
                            "Fitness: " + inFitness.Text + Environment.NewLine + Environment.NewLine +
                            "Skin: " + inSkin.Text + Environment.NewLine + Environment.NewLine +
                            "Eyes: " + inEyes.Text + Environment.NewLine + Environment.NewLine +
                            "Hair: " + inHair.Text + Environment.NewLine + Environment.NewLine +
                            "Misc Body: " + inMisc.Text + Environment.NewLine + Environment.NewLine +
                            "Apparel: " + inApp.Text + Environment.NewLine + Environment.NewLine +
                            "Unique Items: " + inItems.Text + Environment.NewLine + Environment.NewLine +
                            "Skills: " + inSkills.Text + Environment.NewLine + Environment.NewLine +
                            "Incompetence: " + inIncomp.Text + Environment.NewLine + Environment.NewLine +
                            "Weakness: " + inWeak.Text + Environment.NewLine + Environment.NewLine +
                            "Hobbies: " + inHobbies.Text + Environment.NewLine + Environment.NewLine +
                            "Childhood Life: " + inChildhood.Text + Environment.NewLine + Environment.NewLine +
                            "Important Past Event: " + inPast.Text + Environment.NewLine + Environment.NewLine +
                            "Best Accomplishment: " + inAccomp.Text + Environment.NewLine + Environment.NewLine +
                            "Secret: " + inSecret.Text + Environment.NewLine + Environment.NewLine + 
                            "Story Role: " + inStory.Text;

            String fileName = inName.Text + ".txt";

            TextWriter outFile = new StreamWriter(fileName);
            outFile.Write(outStr);
            outFile.Close();

            ResetAllControls(this);
        }
    }
}
