using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfClickVer2._0
{


    public partial class MainForm : Form
    {
        private int _s = 60;
        private int Score = 0;
        private int Count = 4;
        public MainForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
        class Picture
        {
            public void SetPictureBoxImagesPepe(PictureBox ptb1, PictureBox ptb2, PictureBox ptb3, PictureBox ptb4)
            {
                ptb1.Image = Image.FromFile("Z:\\Program C#\\GameOfClickVer2.0\\GameOfClickPicture\\Pepe.png");
                ptb2.Image = Image.FromFile("Z:\\Program C#\\GameOfClickVer2.0\\GameOfClickPicture\\Pepe.png");
                ptb3.Image = Image.FromFile("Z:\\Program C#\\GameOfClickVer2.0\\GameOfClickPicture\\Pepe.png");
                ptb4.Image = Image.FromFile("Z:\\Program C#\\GameOfClickVer2.0\\GameOfClickPicture\\Pepe.png");
            }
            public void SetPictureBoxImagePig(PictureBox ptb1, PictureBox ptb2, PictureBox ptb3, PictureBox ptb4)
            {
                ptb1.Image = Image.FromFile("Z:\\Program C#\\GameOfClickVer2.0\\GameOfClickPicture\\Свинтя.png");
                ptb2.Image = Image.FromFile("Z:\\Program C#\\GameOfClickVer2.0\\GameOfClickPicture\\Свинтя.png");
                ptb3.Image = Image.FromFile("Z:\\Program C#\\GameOfClickVer2.0\\GameOfClickPicture\\Свинтя.png");
                ptb4.Image = Image.FromFile("Z:\\Program C#\\GameOfClickVer2.0\\GameOfClickPicture\\Свинтя.png");
            }
            public void SetPictureBoxImageYad(PictureBox ptb1, PictureBox ptb2, PictureBox ptb3, PictureBox ptb4)
            {
                ptb1.Image = Image.FromFile("Z:\\Program C#\\GameOfClickVer2.0\\GameOfClickPicture\\Яд.png");
                ptb2.Image = Image.FromFile("Z:\\Program C#\\GameOfClickVer2.0\\GameOfClickPicture\\Яд.png");
                ptb3.Image = Image.FromFile("Z:\\Program C#\\GameOfClickVer2.0\\GameOfClickPicture\\Яд.png");
                ptb4.Image = Image.FromFile("Z:\\Program C#\\GameOfClickVer2.0\\GameOfClickPicture\\Яд.png");
            }
        }
        private void PictureVisible()
        {
            ptb1.Visible = true;
            ptb2.Visible = true;
            ptb3.Visible = true;
            ptb4.Visible = true;
        }
        private void PictureLocationYad()
        {
            ptb1.Location = new Point(480, 180);
            ptb2.Location = new Point(800, 80);
            ptb3.Location = new Point(360, 430);
        }
        private void низкаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture picture = new Picture();
            picture.SetPictureBoxImagesPepe(ptb1, ptb2, ptb3, ptb4);
            pnlMap.BackgroundImage = Image.FromFile("Z:\\Program C#\\GameOfClick\\GameOfClickPicture\\Easy.jpg");
            pnlMap.BackgroundImageLayout = ImageLayout.Stretch;
            pnlInfo.Visible = true;
            btnStartGame.Enabled = true;
            PictureVisible();
            lblTimerResult.Text = "60";
            this.Score = 0;
            this.Count = 4;
            lblCountPointResult.Text = this.Score.ToString();
            lblCountObjectResult.Text = this.Count.ToString();
            pnlMap.Enabled = false;

        }

        private void средняяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture picture = new Picture();
            picture.SetPictureBoxImagePig(ptb1, ptb2, ptb3, ptb4);
            pnlMap.BackgroundImage = Image.FromFile("Z:\\Program C#\\GameOfClick\\GameOfClickPicture\\Normal.jpg");
            pnlMap.BackgroundImageLayout = ImageLayout.Stretch;
            pnlInfo.Visible = true;
            btnStartGame.Enabled = true;
            PictureVisible();
            lblTimerResult.Text = "60";
            this.Score = 0;
            this.Count = 4;
            lblCountPointResult.Text = this.Score.ToString();
            lblCountObjectResult.Text = this.Count.ToString();
            pnlMap.Enabled = false;
        }
        private void ClickPicture_Click(object sender, EventArgs e)
        {

            ((PictureBox)sender).Visible = false;

            this.Score++;
            lblCountPointResult.Text = this.Score.ToString();
            this.Count--;
            lblCountObjectResult.Text = this.Count.ToString();

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            pnlInfo.Visible = false;
            foreach (PictureBox pictureBox in pnlMap.Controls)
            {
                pictureBox.BackColor = Color.Transparent;
            }
            lblCountPointResult.Text = Score.ToString();
            lblCountObjectResult.Text = Count.ToString();
        }
        private void tmr_Tick(object sender, EventArgs e)
        {
            _s = int.Parse(lblTimerResult.Text);
            _s--;
            lblTimerResult.Text = _s.ToString();
            if (_s == 0)
            {
                tmr.Stop();
                MessageBox.Show($"Ваше время вышло!\nВы не успели найти {lblCountObjectResult.Text} предмета\nПопробуйте снова", "Упс...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Score == 4)
            {
                tmr.Stop();
                MessageBox.Show($"Поздравляем!\nВы успели найти все предметы за {60 - _s} секунд", "Ура",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            tmr.Start();
            btnStartGame.Enabled = false;
            pnlMap.Enabled = true;

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            tmr.Start();
            this.Score = 0;
            this.Count = 4;
            this._s = 60;
            lblCountPointResult.Text = this.Score.ToString();
            lblCountObjectResult.Text = this.Count.ToString();
            lblTimerResult.Text = this._s.ToString();
            PictureVisible();
        }
        private void высокаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMap.BackgroundImage = Image.FromFile("Z:\\Program C#\\GameOfClick\\GameOfClickPicture\\Hard.jpg");
            Picture picture = new Picture();
            picture.SetPictureBoxImageYad(ptb1, ptb2, ptb3, ptb4);
            PictureLocationYad();
            pnlMap.BackgroundImageLayout = ImageLayout.Stretch;
            pnlInfo.Visible = true;
            btnStartGame.Enabled = true;
            PictureVisible();
            lblTimerResult.Text = "60";
            this.Score = 0;
            this.Count = 4;
            lblCountPointResult.Text = this.Score.ToString();
            lblCountObjectResult.Text = this.Count.ToString();
            pnlMap.Enabled = false;
        }
        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ваша задача заключается в том, чтобы за отведенное время найти все предметы на картинке", "Правила",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
