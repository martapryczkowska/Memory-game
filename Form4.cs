using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEMORY
{
    public partial class Form4 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.sound);
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer(Properties.Resources.yeah);
        int Timecounter;
        int iloscruchow;
        Random random = new Random();

        List<int> numbers = new List<int>()
        {
            1,1,2,2,3,3,4,4,5,5,6,6,7,7,8,8,9,9,10,10,11,11,12,12,13,13,14,14,15,15,16,16,17,17,18,18,19,19,20,20,21,21,22,22,23,23,24,
        24,25,25,26,26,27,27,28,28,29,29,30,30,31,31,32,32};

        Image bckgImage = Properties.Resources.bckg;
        PictureBox firstClicked, secondClicked;
        public Form4()
        {
            InitializeComponent();
            iloscruchow = 0;
            timer2.Start();
            timer3.Start();
            SetImage();
            AssingImage();
        }

        private void showImage(PictureBox box)
        {
            switch (Convert.ToInt32(box.Tag))
            {
                case 1:
                    box.Image = Properties.Resources.game1;
                    break;
                case 2:
                    box.Image = Properties.Resources.game2;
                    break;
                case 3:
                    box.Image = Properties.Resources.game3;
                    break;
                case 4:
                    box.Image = Properties.Resources.game4;
                    break;
                case 5:
                    box.Image = Properties.Resources.game5;
                    break;
                case 6:
                    box.Image = Properties.Resources.game6;
                    break;
                case 7:
                    box.Image = Properties.Resources.game7;
                    break;
                case 8:
                    box.Image = Properties.Resources.game8;
                    break;
                case 9:
                    box.Image = Properties.Resources.game9;
                    break;
                case 10:
                    box.Image = Properties.Resources.game10;
                    break;
                case 11:
                    box.Image = Properties.Resources.game11;
                    break;
                case 12:
                    box.Image = Properties.Resources.game12;
                    break;
                case 13:
                    box.Image = Properties.Resources.game13;
                    break;
                case 14:
                    box.Image = Properties.Resources.game14;
                    break;
                case 15:
                    box.Image = Properties.Resources.game15;
                    break;
                case 16:
                    box.Image = Properties.Resources.game16;
                    break;
                case 17:
                    box.Image = Properties.Resources.game17;
                    break;
                case 18:
                    box.Image = Properties.Resources.game18;
                    break;
                case 19:
                    box.Image = Properties.Resources.game19;
                    break;
                case 20:
                    box.Image = Properties.Resources.game20;
                    break;
                case 21:
                    box.Image = Properties.Resources.game21;
                    break;
                case 22:
                    box.Image = Properties.Resources.game22;
                    break;
                case 23:
                    box.Image = Properties.Resources.game23;
                    break;
                case 24:
                    box.Image = Properties.Resources.game24;
                    break;
                case 25:
                    box.Image = Properties.Resources.game25;
                    break;
                case 26:
                    box.Image = Properties.Resources.game26;
                    break;
                case 27:
                    box.Image = Properties.Resources.game27;
                    break;
                case 28:
                    box.Image = Properties.Resources.game28;
                    break;
                case 29:
                    box.Image = Properties.Resources.game29;
                    break;
                case 30:
                    box.Image = Properties.Resources.game30;
                    break;
                case 31:
                    box.Image = Properties.Resources.game31;
                    break;
                case 32:
                    box.Image = Properties.Resources.game32;
                    break;
                default:
                    box.Image = Properties.Resources.bckg;
                    break;
            }
            // This function converts picureBox tag to image;

        }

        private void SetImage()
        {
            PictureBox picturebox;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is PictureBox)
                    picturebox = (PictureBox)tableLayoutPanel1.Controls[i];
                else
                    continue;
                picturebox.BackgroundImage = bckgImage;
                picturebox.Image = bckgImage;
            }
        }
        private void AssingImage()
        {
            PictureBox picturebox;
            int randomNumber;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is PictureBox)
                    picturebox = (PictureBox)tableLayoutPanel1.Controls[i];
                else
                    continue;
                randomNumber = random.Next(0, numbers.Count);
                picturebox.Tag = numbers[randomNumber];
                numbers.RemoveAt(randomNumber);
            }
        }

        private void click_Image(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
                return;
            PictureBox clickedPicturebox = sender as PictureBox;
            if (clickedPicturebox == null)
                return;
            if (clickedPicturebox.Image != bckgImage)
                return;
            if (firstClicked == null)
            {
                firstClicked = clickedPicturebox;
                iloscruchow++;
                showImage(firstClicked);
                return;
            }
            secondClicked = clickedPicturebox;
            iloscruchow++;
            showImage(secondClicked);
            checkWinner();
            if (firstClicked.Tag.ToString() == secondClicked.Tag.ToString())
            {
                player.Play();
                firstClicked = null;
                secondClicked = null;
            }
            else
                timer1.Start();

        }


        private void HideImage(PictureBox picturebox)
        {
            picturebox.Image = bckgImage;
        }


        private void checkWinner()
        {
            PictureBox picturebox;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                picturebox = (PictureBox)tableLayoutPanel1.Controls[i];

                if (picturebox != null && picturebox.Image == bckgImage)
                    return;

            }
            timer2.Stop();
            player2.Play();
            MessageBox.Show("Wygrałeś" + "\n" + "Czas: " + Timecounter + "s" + "\n" + "Ilość ruchów: " + iloscruchow, "Gratulacje!");


        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            timer1.Stop();
            HideImage(firstClicked);
            HideImage(secondClicked);
            firstClicked = null;
            secondClicked = null;
        }

        private void timer2_Tick_2(object sender, EventArgs e)
        {
            Timecounter = Timecounter + 1;
            timeLabel.Text = "czas: " + Timecounter + "s";
        }

        private void timer3_Tick_2(object sender, EventArgs e)
        {
            movesLabel.Text = "ilosc ruchow: " + iloscruchow;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.rodzic.x++;

        }
    }

}
