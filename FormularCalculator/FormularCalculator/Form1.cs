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
    //Add settings
    //change the color of the drawing && text using settings

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
        decimal base1Num;
        decimal base2Num;
        decimal heightNum;
        decimal radiusNum;

        public Form1()
        {
            InitializeComponent();
            formHeight = this.Height;
            formWidth = this.Width;
            rectWidth = 250;
            rectHeight = 250;

            breadthLbl.Visible = false;
            breadthTbx.Visible = false;

            LengthLbl.Left = (formWidth / 2) - 115;
            lengthTbx.Left = LengthLbl.Left + 110;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Invalidate();
        }

        //Formulas
        #region Formulas

        //calculate the area of square
        decimal squareArea(decimal length)
        {
            return length * length;
        }

        //calculate the area of rectangle
        decimal rectArea(decimal length, decimal breadth)
        {
            return length * breadth;
        }

        //calculate the are of triangle
        decimal triArea(decimal length, decimal height)
        {
            return (length * height) / 2;
        }

        //calculate the area of trapizium
        decimal trapArea(decimal base1,decimal base2,decimal height)
        {
            return ((base1 + base2) / 2) * height;
        }

        //calculate the area of circle
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

            //Convert the string to length if the string are not empty
            if (lengthTbx.Text != string.Empty)
            {
                lengthNum = Convert.ToDecimal(Length);
                base2Num = lengthNum;
                radiusNum = lengthNum;
                if (breadthTbx.Text != string.Empty)
                {
                    breadthNum = Convert.ToDecimal(Breadth);
                    heightNum = breadthNum;
                    if (baseTbx.Text != string.Empty)
                    {
                        base1Num = Convert.ToDecimal(_base);
                    }
                }
            }
            
            //mode 0 = Area of square
            if (mode == 0)
            {
                realAnswer = squareArea(lengthNum);
            }
            //mode 1 = area of rectangle
            else if(mode == 1)
            {
                realAnswer = rectArea(lengthNum, breadthNum);
            }
            //mode 2 = area of triangle
            else if(mode == 2)
            {
                realAnswer = triArea(lengthNum, heightNum);
            }
            //mode 3 = area of trapizium
            else if (mode == 3)
            {
                realAnswer = trapArea(base2Num, base1Num, heightNum);
            }
            //mode 4 = area of triangle
            else if (mode == 4)
            {
                realAnswer = circleArea(radiusNum);
            }
            //Show answer on label && remove trailing zeros
            answerLbl.Text = realAnswer.ToString("0.############################");
        }

        SolidBrush myBrush = new SolidBrush(Color.White);

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            xPos = (formWidth / 2) - (rectWidth / 2) - 10;
            yPos = (formHeight / 2) - (rectHeight / 2) + 5;

            //draw square / rectangle
            if (mode == 0 || mode == 1)
            {
                e.Graphics.FillRectangle(myBrush, xPos, yPos, rectWidth, rectHeight);
            }

            //draw triangle
            else if (mode == 2)
            {
                Point[] a = { new Point(400, 120), new Point(525, 370), new Point(275, 370) };
                e.Graphics.FillPolygon(myBrush, a);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }

            //draw trapizium
            else if (mode == 3)
            {
                Point[] a = { new Point(300, 120), new Point(500, 120), new Point(600, 370), new Point(200, 370) };
                e.Graphics.FillPolygon(myBrush, a);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }

            //draw circle
            else if (mode == 4)
            {
                e.Graphics.FillEllipse(myBrush, xPos, yPos, rectWidth, rectHeight);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }
        }

        private void squareBtn_Click(object sender, EventArgs e)
        {
            Visibility(false, false, false, false);

            //auto align textbox to equally spreadout
            LengthLbl.Left = (formWidth / 2) - 115;
            lengthTbx.Left = LengthLbl.Left + 110;

            mode = 0;

            breadthLbl.Text = "Breadth:";
            LengthLbl.Text = "Length:";

            Reset();        

            formulaLbl.Text = "Formular for area of square =  Length * Length";

            //set width of rectangle
            rectWidth = 250;
            rectHeight = 250;
            Invalidate();
        }

        private void rectBtn_Click(object sender, EventArgs e)
        {
            Visibility(true, true, false, false);

            //auto align textbox to equally spreadout
            LengthLbl.Left = (formWidth / 2) - 220;
            lengthTbx.Left = LengthLbl.Left + 110;

            breadthLbl.Left = (formWidth / 2) - 15;
            breadthTbx.Left = breadthLbl.Left + 120;

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

            //auto align textbox to equally spreadout
            LengthLbl.Left = (formWidth / 2) - 210;
            lengthTbx.Left = LengthLbl.Left + 110;

            breadthLbl.Left = (formWidth / 2) ;
            breadthTbx.Left = breadthLbl.Left + 120;

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

            //auto align textbox to equally spreadout
            LengthLbl.Left = (formWidth / 2) - 330;
            lengthTbx.Left = LengthLbl.Left + 110;

            breadthLbl.Left = (formWidth / 2) + 60 ;
            breadthTbx.Left = breadthLbl.Left + 120;

            baseLbl.Left = (formWidth / 2) - 140;
            baseTbx.Left = baseLbl.Left + 120;

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

            //auto align textbox to equally spreadout
            LengthLbl.Left = (formWidth / 2) - 115;
            lengthTbx.Left = LengthLbl.Left + 110;

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

        //Move form using panel
        #region MoveForm
        public Point mouseLocation;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point mousePose = MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
        #endregion

        /*
        //Exit the application
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Minimize the application
        private void miniBtn_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
        */
    }
}
