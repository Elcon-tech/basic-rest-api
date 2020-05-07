using System;
using System.Windows.Forms;

namespace MyClock
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void timeNow_Click(object sender, EventArgs e)
        {

        }

        private void secTimer_Tick(object sender, EventArgs e)
        {
            SetDisplayTime();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            SetDisplayTime();
        }

        private void SetDisplayTime()
        {
            timeNow.Text = DateTime.Now.ToString("HH:mm:ss:fff");
        }

        private void menuItemClose_Click(object sender, EventArgs e)
        {
            FormFadeOut();
            this.Close();
        }
        private void FormFadeOut()
        {
            for(int n = 49; n >= 0; n--)
            {
                this.Opacity = (double)n / 100;
                System.Threading.Thread.Sleep(10);
            }

        }
    }
}
