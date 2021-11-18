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

        bool allowClick = false; // Allows user to choose and click on first card only after they click on "Start" button
        PictureBox firstGuess;

        int time = 60;


        About About = new About();
        string cardImageName = "image";

        Timer clickTimer = new Timer();
        //Timer timer = new Timer { Interval = 1000 };
        Random Random = new Random();

        public MainPage() { InitializeComponent();
            
        }

        private PictureBox[] pictureBoxes {
            get
            { return Controls.OfType<PictureBox>().ToArray(); }
        }


        private static IEnumerable<Image> images {
            get {
                return new Image[]
                {
                    Properties.Resources.image0,
                    Properties.Resources.image1,
                    Properties.Resources.image2,
                    Properties.Resources.image3,
                    Properties.Resources.image4,
                    Properties.Resources.image5,
                    Properties.Resources.image6,
                    Properties.Resources.image7,
                    Properties.Resources.image8,
                    Properties.Resources.image9,
                    Properties.Resources.image10,
                    Properties.Resources.image11,
                    Properties.Resources.image12,
                };
            }
        }

        private void aboutStripMenuItem_Click(object sender, EventArgs e) { About.ShowDialog(); }


        private void startGameTimer()
        {
            timer.Start();
            // delegate (below) = object-oriented function, similar to a pointer
            timer.Tick += delegate
            {
                time--;
                if (time < 0)
                {
                    timer.Stop(); // Ran out of time
                    MessageBox.Show("Out of time");
                    ResetImages(); // The game resets and user can choose to play again
                }

                var ssTime = TimeSpan.FromSeconds(time);
                CountDownLabel.Text = "00:" + time.ToString(); // Displaying time in sec
            };
        }

        private void ResetImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }

            HideImages();
            setRandomImages();
            time = 60;
            timer.Start();
        }

        private void HideImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.qm;
            }
        }


        private PictureBox getFreeSlot()
        {
            int num;

            do
            {
                num = Random.Next(0, pictureBoxes.Count());
            }
            while (pictureBoxes[num].Tag != null);
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

        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            HideImages();

            allowClick = true;
            clickTimer.Stop();
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
                clickTimer.Start();
            }

            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible))
                return;
            MessageBox.Show("You Win, Now Try Again");
            ResetImages();
        }

        private void startGame(object sender, EventArgs e)
        {
            allowClick = true;
            setRandomImages();
            HideImages();
            startGameTimer();
            clickTimer.Interval = 1000;
            clickTimer.Tick += ClickTimer_Tick;
            startButton.Enabled = false;

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
