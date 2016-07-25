using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_Group1_M16_Lab67
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            System.Windows.Forms.Button[] buttons = new System.Windows.Forms.Button[100];
            int locationX = 10, locationY = 10;

            for (int i=0;i<10;i++)
            { 
                for(int j=0;j<10;j++)
                {
                    int index = i * 10 + j;
                    buttons[index] = new Button();
                    buttons[index].Size = new System.Drawing.Size(50, 50);
                    buttons[index].Location = new System.Drawing.Point(locationX, locationY);
                    locationX += buttons[index].Size.Width;
                    buttons[index].Text = (index + 1).ToString();
                    buttons[index].Click += Button_Click;
                    this.Controls.Add(buttons[index]);
                }
                locationX = 10;
                locationY += buttons[0].Size.Height;
            }


        }
        private void Button_Click(object sender, EventArgs e)
        {
            string buttonText = ((Button)sender).Text;

        }
}
}
