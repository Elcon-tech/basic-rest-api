using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warikan
{
    public partial class Warikan : Form
    {
        public Warikan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textbox_total.Text,out int i))
            {
                int ta1 = int.Parse(textbox_total.Text);
                decimal nud1 = numericUpDown_people.Value;
                double w = ta1 / (int)nud1;
                result.Text = "Total:" + ta1.ToString() + "\nPeople:" + nud1.ToString() + "\nEach:" + w.ToString();
            }
            else
            {
                result.Text = "Total shuld be a int number.";
            }
        }
    }
}
