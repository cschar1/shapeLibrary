using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace shapeLibrary
{
    public partial class UserControl1 : UserControl
    {
        private int rWidth;
        private int rHeight;
        bool increasing;
        public UserControl1()
        {
            InitializeComponent();
            rWidth = 30;
            rHeight = 30;
            increasing = true;
            timer1.Start();
            timer1.Interval = 100;
        }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Coral, new Rectangle(30, 30, rWidth, rHeight));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rWidth >= 50 || rWidth <= 25)
                increasing = !increasing;

            if (increasing)
            {
                rWidth += 5;
                rHeight += 5;
            }
            else
            {
                rWidth -= 5;
                rHeight -= 5;
            }

            this.Invalidate();
            
        }
    }
}
