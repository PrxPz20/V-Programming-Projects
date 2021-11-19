using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concentration_Game
{
    public partial class Form1 : Form
    {

        bool allowClick = false;
        PictureBox firstGuess;
        Random random = new Random();
        Timer clickTimer = new Timer();
        int time = 60;
        Timer timer = new Timer { Interval = 1000 };


        public Form1()
        {
            InitializeComponent();
            startGame();
        }

        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }

        private static IEnumerable<Image> images
        {
            get 
            {
                return new Image[]
                {
                    Properties.Resources.image1,
                    Properties.Resources.image2,
                    Properties.Resources.image3,
                    Properties.Resources.image4,
                    Properties.Resources.image5,
                    Properties.Resources.image6,
                    Properties.Resources.image7,
                    Properties.Resources.image8,
                };
            }
        }

        private void ResetImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }

            HideImages();

        }

        private void HideImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.Question_Mark;
            }

        }

        private PictureBox getFreeSlot()
        {
            int num;

            do
            {
                num = random.Next(0, pictureBoxes.Count());
            } while (pictureBoxes[num].Tag != null);

            return pictureBoxes[num];

        }

        private void setRandomImages()
        {
            foreach (var image in images)
            {
                getFreeSlot().Tag = image;
                getFreeSlot().Tag = image;
            }
        }

        private void clickImage(object sender, EventArgs e)
        {
            if (!allowClick)
                return;

            var pic = (PictureBox)sender;
            
            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }

            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;
                }

                HideImages();
            }
            else
            {
                allowClick = false;

            }

            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible))
                return;

            MessageBox.Show("Win!!!!!");
            ResetImages();


        }


        private void startGame()
        {
            allowClick = true;
            setRandomImages();
            HideImages();


            clickTimer.Interval = 1000;
            startButton.Enabled = false;
        }
    }
}
