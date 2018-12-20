using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularCalculator
{
    public partial class Form1 : Form
    {
        int rectWidth;
        int rectHeight;

        int formHeight;
        int formWidth;

        int xPos;
        int yPos;

        int mode = 0;

        string Length;
        string Breadth;
        string _base;

        decimal lengthNum;
        decimal breadthNum;
        decimal baseNum;

        public Form1()
        {
            InitializeComponent();
            formHeight = this.Height;
            formWidth = this.Width;
            rectWidth = 250;
            rectHeight = 250;

            breadthLbl.Visible = false;
            breadthTbx.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Invalidate();
        }

        //Formulas
        #region Formulas
        decimal squareArea(decimal length)
        {
            return length * length;
        }

        decimal rectArea(decimal length, decimal breadth)
        {
            return length * breadth;
        }

        decimal triArea(decimal length, decimal height)
        {
            return (length * height) / 2;
        }

        decimal trapArea(decimal base1,decimal base2,decimal height)
        {
            return ((base1 + base2) / 2) * height;
        }

        decimal circleArea(decimal radius)
        {
            decimal pi = 3.14159m;
            return pi * radius * radius;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            decimal realAnswer = 0;

            Length = lengthTbx.Text;
            Breadth = breadthTbx.Text;
            _base = baseTbx.Text;

            if (lengthTbx.Text != string.Empty)
            {
                lengthNum = Convert.ToDecimal(Length);
                if(breadthTbx.Text != string.Empty)
                {
                    breadthNum = Convert.ToDecimal(Breadth);
                    if (baseTbx.Text != string.Empty)
                    {
                        baseNum = Convert.ToDecimal(_base);
                    }
                }
            }
            
            if (mode == 0)
            {
                realAnswer = squareArea(lengthNum);
            }
            else if(mode == 1)
            {
                realAnswer = rectArea(lengthNum, breadthNum);
            }
            else if(mode == 2)
            {
                realAnswer = triArea(lengthNum, breadthNum);
            }
            else if(mode == 3)
            {
                realAnswer = trapArea(lengthNum, baseNum, breadthNum);
            }
            else if(mode == 4)
            {
                realAnswer = circleArea(lengthNum);
            }
            answerLbl.Text = realAnswer.ToString();
        }

        SolidBrush myBrush = new SolidBrush(Color.White);

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            xPos = (formWidth / 2) - (rectWidth / 2) - 10;
            yPos = (formHeight / 2) - (rectHeight / 2) - 25;

            if (mode == 0 || mode == 1)
            {
                e.Graphics.FillRectangle(myBrush, xPos, yPos, rectWidth, rectHeight);
            }
            else if (mode == 2)
            {
                Point[] a = { new Point(400, 100), new Point(525, 350), new Point(275, 350) };
                e.Graphics.FillPolygon(myBrush, a);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }
            else if (mode == 3)
            {
                Point[] a = { new Point(300, 100), new Point(500, 100), new Point(600, 350), new Point(200, 350) };
                e.Graphics.FillPolygon(myBrush, a);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }
            else if (mode == 4)
            {
                e.Graphics.FillEllipse(myBrush, xPos, yPos, rectWidth, rectHeight);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }
        }

        private void squareBtn_Click(object sender, EventArgs e)
        {
            Visibility(false, false, false, false);

            mode = 0;

            breadthLbl.Text = "Breadth:";
            LengthLbl.Text = "Length:";

            Reset();        

            formulaLbl.Text = "Formular for area of square =  Length * Length";

            rectWidth = 250;
            rectHeight = 250;
            Invalidate();
        }

        private void rectBtn_Click(object sender, EventArgs e)
        {
            Visibility(true, true, false, false);

            breadthLbl.Text = "Breadth:";
            LengthLbl.Text = "Length:";

            mode = 1;

            formulaLbl.Text = "Formular for area of rectangle =  Length * Breadth";

            Reset();

            rectWidth = 400;
            rectHeight = 250;
            Invalidate();          
        }

        private void triBtn_Click(object sender, EventArgs e)
        {
            Visibility(true, true, false, false);

            breadthLbl.Text = "Height:";
            LengthLbl.Text = "Length:";

            mode = 2;

            formulaLbl.Text = "Formular for area of triangle =  (Length * Height) / 2";

            Reset();

            Invalidate();
        }

        private void trapBtn_Click(object sender, EventArgs e)
        {
            Visibility(true, true, true, true);

            breadthLbl.Text = "Height:";
            LengthLbl.Text = "Base 1:";
            baseLbl.Text = "Base 2:";

            mode = 3;

            formulaLbl.Text = "Formular for area of trapezium =  ((Base 1 + Base 2) / 2) * Height";

            Reset();

            Invalidate();
        }

        private void circleBtn_Click(object sender, EventArgs e)
        {
            Visibility(false, false, false, false);

            LengthLbl.Text = "Radius:";

            mode = 4;

            formulaLbl.Text = "Formular for area of circle =  pi * radius * radius";

            Reset();

            rectWidth = 250;
            rectHeight = 250;

            Invalidate();
        }   

        private void Reset()
        {
            answerLbl.Text = string.Empty;
            lengthTbx.Text = string.Empty;
            breadthTbx.Text = string.Empty;
            baseTbx.Text = string.Empty;
        }

        private void Visibility(bool breaLbl, bool breaTbx, bool basLbl, bool basTbx)
        {
            breadthLbl.Visible = breaLbl;
            breadthTbx.Visible = breaTbx;
            baseLbl.Visible = basLbl;
            baseTbx.Visible = basTbx;
        }


        //Only allow numbers and . in textbox
        #region Textbox
        private void lengthTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(sender, e);
        }

        private void breadthTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(sender, e);
        }

        private void baseTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(sender, e);
        }

        private static void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                        && !char.IsDigit(e.KeyChar)
                        && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
