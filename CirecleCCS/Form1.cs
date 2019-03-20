using System;
using System.Drawing;
using System.Windows.Forms;

namespace CirecleCCS
{
    public partial class Form1 : Form
    {
        CcsGo ccs = new CcsGo();
        public Form1()
        {
            InitializeComponent();
            panel1.AutoScroll = true;
            pictureBox_x.SizeMode = PictureBoxSizeMode.AutoSize;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ccs.ResizePinSize = 10;
            ccs.Create();
           
        }
        private void pictureBox_x_Paint(object sender, PaintEventArgs e)
        {
            ccs.DrawRubberBand(pictureBox_x,e);
        }

        private void pictureBox_x_MouseDown(object sender, MouseEventArgs e)
        {
            ccs.StartPoint(pictureBox_x,e);
        }

        private void pictureBox_x_MouseMove(object sender, MouseEventArgs e)
        {
            ccs.TrackRubberBand(pictureBox_x, e);
            label_xval.Text = "E->X:" + e.X.ToString();
            label_yval.Text = "E->Y:" + e.Y.ToString();
            labelccsX.Text = "CcsX:" + ccs.X.ToString();
            label_CcsY.Text = "CcsY:" + ccs.Y.ToString();
        }

        private void pictureBox_x_MouseUp(object sender, MouseEventArgs e)
        {
            ccs.EndPoint(pictureBox_x,e);
        }

        bool IsInELP(Point Cusorpostion,Point ElpCenter,int radius)
        {
            int elpX = ElpCenter.X;
            int elpY = ElpCenter.Y;
            int csX = Cusorpostion.X;
            int csY = Cusorpostion.Y;
            if (!((elpX - csX) * (elpX - csX) + (elpY - csY) * (elpY - csY) >= radius * radius))
                return true;
            else
                return false;
        }

        //Load Image
        private void button_LoadImage_Click(object sender, EventArgs e)
        {
            Bitmap x = fileImage();
            if(x != null)
                pictureBox_x.Image = x;
        }

        Bitmap fileImage()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "BMP文件|*.txt|JPG文件|*.jpg|PNG文件|*.png|所有文件|*.*",
                FilterIndex = 4,
                RestoreDirectory = true
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image m = Image.FromFile(ofd.FileName) as Bitmap;
                Bitmap v = new Bitmap(m);
                m.Dispose();
                return v;
            }
            else
            {
                return null;
            }
        }
    }
}
