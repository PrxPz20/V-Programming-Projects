using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Concentration_Game
{
    public partial class MainPage : Form
    {

        About About = new About();
        string cardImageName = "image";


        public MainPage() { InitializeComponent();
            setQuastionIconAndNameToButtons();
        }
            /*
                    Properties.Resources.Baby_Dack,
                    Properties.Resources.Baby_Goose,
                    Properties.Resources.Baby_Sheep,
                    Properties.Resources.Bird,
                    Properties.Resources.Cat,
                    Properties.Resources.Chicken,
                    Properties.Resources.cock,
                    Properties.Resources.Cow,
                    Properties.Resources.Dog,
                    Properties.Resources.Goose,
                    Properties.Resources.Horse,
                    Properties.Resources.Rabbit,
                    Properties.Resources.Pig,
            */

        private void aboutStripMenuItem_Click(object sender, EventArgs e) { About.ShowDialog(); }

        private void setQuastionIconAndNameToButtons() {

            //Button button = new Button();
            Random random = new Random();
            Label label;
            int cardRandomNumber;
            int imageNumber;


            for (int count = 0; count < cardTableLayoutPanel.Controls.Count; count++) {

                if (cardTableLayoutPanel.Controls[count] is Label)
                    label = (Label)cardTableLayoutPanel.Controls[count];
                else
                    continue;
            }


            
            //cardRandomNumber = random.Next(0, );
            //cardRandomNumber = images;

            
        
        
        
        }


    } // END OF MainPage Class
}

/*
 *             Label label;
            int cardRandomNumber;

            for (int count = 0; count < cardTableLayoutPanel.Controls.Count; count++) {

                if (cardTableLayoutPanel.Controls[count] is Label)
                    label = (Label)cardTableLayoutPanel.Controls[count];
                else
                    continue;

                cardRandomNumber = Random.Next(0,  )

 
 
                cardRandomNumber = imageNumber =random.Next(1, 6);
                button.Name = cardRandomNumber.ToString();
                button.Image = Properties.Resources.qm;
                button.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(button.Name);
                //button.Text = button.Image;
                MessageBox.Show("Radom: " + cardRandomNumber);

            cardTableLayoutPanel.Controls.Add(button); 
 
 
 * 
 */
