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
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.sound);
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer(Properties.Resources.yeah);
        int Timecounter;
        int iloscruchow;
        Random random = new Random();

        List<int> numbers = new List<int>()
        {
            1,1,2,2,3,3,4,4,5,5,6,6,7,7,8,8
        };

        Image bckgImage = Properties.Resources.bckg;
        PictureBox firstClicked, secondClicked;
        public Form1()
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
                    box.Image = Properties.Resources.dog1;
                    break;
                case 2:
                    box.Image = Properties.Resources.dog2;
                    break;
                case 3:
                    box.Image = Properties.Resources.dog3;
                    break;
                case 4:
                    box.Image = Properties.Resources.dog4;
                    break;
                case 5:
                    box.Image = Properties.Resources.dog5;
                    break;
                case 6:
                    box.Image = Properties.Resources.dog6;
                    break;
                case 7:
                    box.Image = Properties.Resources.dog7;
                    break;
                case 8:
                    box.Image = Properties.Resources.dog8;
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
                picturebox.Tag =numbers[randomNumber];
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
                firstClicked = null;
                secondClicked = null;
                player.Play();
            }
            else
                 timer1.Start();
           
        }
        

        private void HideImage(PictureBox picturebox)
        {
            picturebox.Image = bckgImage;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();
            HideImage(firstClicked);
            HideImage(secondClicked);
            firstClicked = null;
            secondClicked = null;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void double_click_Image(object sender, EventArgs e)
        {
            if (secondClicked != null)
                return;
            PictureBox clickedPicturebox = sender as PictureBox;
            HideImage(clickedPicturebox);
            firstClicked = null;


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Timecounter = Timecounter + 1;
            timeLabel.Text = "czas: " + Timecounter + "s";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            movesLabel.Text = "ilosc ruchow: " + iloscruchow;
        }

        private void checkWinner()
        {
            PictureBox picturebox;
            for (int i = 0; i<tableLayoutPanel1.Controls.Count; i++)
            {
                    picturebox = (PictureBox)tableLayoutPanel1.Controls[i];

                if (picturebox != null && picturebox.Image == bckgImage)
                    return;
                
            }
            timer2.Stop();
            player2.Play();
            MessageBox.Show("Wygrałeś"+"\n" +"Czas: "+ Timecounter +"s"+ "\n"+ "Ilość ruchów: "+ iloscruchow , "Gratulacje!");

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.rodzic.x++;

        }
    }

}
