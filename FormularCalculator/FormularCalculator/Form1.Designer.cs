namespace FormularCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LengthLbl = new System.Windows.Forms.Label();
            this.lengthTbx = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.formulaLbl = new System.Windows.Forms.Label();
            this.squareBtn = new System.Windows.Forms.Button();
            this.rectBtn = new System.Windows.Forms.Button();
            this.trapBtn = new System.Windows.Forms.Button();
            this.triBtn = new System.Windows.Forms.Button();
            this.answerLbl = new System.Windows.Forms.Label();
            this.breadthTbx = new System.Windows.Forms.TextBox();
            this.breadthLbl = new System.Windows.Forms.Label();
            this.baseTbx = new System.Windows.Forms.TextBox();
            this.baseLbl = new System.Windows.Forms.Label();
            this.circleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LengthLbl
            // 
            this.LengthLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LengthLbl.Font = new System.Drawing.Font("Arial", 20F);
            this.LengthLbl.ForeColor = System.Drawing.Color.White;
            this.LengthLbl.Location = new System.Drawing.Point(42, 400);
            this.LengthLbl.Name = "LengthLbl";
            this.LengthLbl.Size = new System.Drawing.Size(113, 38);
            this.LengthLbl.TabIndex = 0;
            this.LengthLbl.Text = "Length:";
            this.LengthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lengthTbx
            // 
            this.lengthTbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.lengthTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lengthTbx.ForeColor = System.Drawing.Color.White;
            this.lengthTbx.Location = new System.Drawing.Point(156, 399);
            this.lengthTbx.Name = "lengthTbx";
            this.lengthTbx.Size = new System.Drawing.Size(80, 38);
            this.lengthTbx.TabIndex = 1;
            this.lengthTbx.Text = "1";
            this.lengthTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lengthTbx_KeyPress);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.calculateBtn.ForeColor = System.Drawing.Color.White;
            this.calculateBtn.Location = new System.Drawing.Point(675, 403);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(113, 35);
            this.calculateBtn.TabIndex = 2;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // formulaLbl
            // 
            this.formulaLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formulaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.formulaLbl.ForeColor = System.Drawing.Color.White;
            this.formulaLbl.Location = new System.Drawing.Point(43, 31);
            this.formulaLbl.Name = "formulaLbl";
            this.formulaLbl.Size = new System.Drawing.Size(749, 39);
            this.formulaLbl.TabIndex = 4;
            this.formulaLbl.Text = "Formular for area of square = Length * Length";
            this.formulaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // squareBtn
            // 
            this.squareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.squareBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.squareBtn.ForeColor = System.Drawing.Color.White;
            this.squareBtn.Location = new System.Drawing.Point(12, 35);
            this.squareBtn.Name = "squareBtn";
            this.squareBtn.Size = new System.Drawing.Size(113, 35);
            this.squareBtn.TabIndex = 5;
            this.squareBtn.Text = "Square";
            this.squareBtn.UseVisualStyleBackColor = true;
            this.squareBtn.Click += new System.EventHandler(this.squareBtn_Click);
            // 
            // rectBtn
            // 
            this.rectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rectBtn.ForeColor = System.Drawing.Color.White;
            this.rectBtn.Location = new System.Drawing.Point(12, 76);
            this.rectBtn.Name = "rectBtn";
            this.rectBtn.Size = new System.Drawing.Size(113, 35);
            this.rectBtn.TabIndex = 6;
            this.rectBtn.Text = "Rectangle";
            this.rectBtn.UseVisualStyleBackColor = true;
            this.rectBtn.Click += new System.EventHandler(this.rectBtn_Click);
            // 
            // trapBtn
            // 
            this.trapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.trapBtn.ForeColor = System.Drawing.Color.White;
            this.trapBtn.Location = new System.Drawing.Point(12, 158);
            this.trapBtn.Name = "trapBtn";
            this.trapBtn.Size = new System.Drawing.Size(113, 35);
            this.trapBtn.TabIndex = 8;
            this.trapBtn.Text = "Trapezium";
            this.trapBtn.UseVisualStyleBackColor = true;
            this.trapBtn.Click += new System.EventHandler(this.trapBtn_Click);
            // 
            // triBtn
            // 
            this.triBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.triBtn.ForeColor = System.Drawing.Color.White;
            this.triBtn.Location = new System.Drawing.Point(12, 117);
            this.triBtn.Name = "triBtn";
            this.triBtn.Size = new System.Drawing.Size(113, 35);
            this.triBtn.TabIndex = 7;
            this.triBtn.Text = "Triangle";
            this.triBtn.UseVisualStyleBackColor = true;
            this.triBtn.Click += new System.EventHandler(this.triBtn_Click);
            // 
            // answerLbl
            // 
            this.answerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answerLbl.BackColor = System.Drawing.Color.Transparent;
            this.answerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.answerLbl.ForeColor = System.Drawing.Color.Black;
            this.answerLbl.Location = new System.Drawing.Point(17, 201);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.answerLbl.Size = new System.Drawing.Size(775, 40);
            this.answerLbl.TabIndex = 3;
            this.answerLbl.Text = "1";
            this.answerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // breadthTbx
            // 
            this.breadthTbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.breadthTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.breadthTbx.ForeColor = System.Drawing.Color.White;
            this.breadthTbx.Location = new System.Drawing.Point(589, 399);
            this.breadthTbx.Name = "breadthTbx";
            this.breadthTbx.Size = new System.Drawing.Size(80, 38);
            this.breadthTbx.TabIndex = 10;
            this.breadthTbx.Text = "1";
            this.breadthTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.breadthTbx_KeyPress);
            // 
            // breadthLbl
            // 
            this.breadthLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.breadthLbl.Font = new System.Drawing.Font("Arial", 20F);
            this.breadthLbl.ForeColor = System.Drawing.Color.White;
            this.breadthLbl.Location = new System.Drawing.Point(465, 399);
            this.breadthLbl.Name = "breadthLbl";
            this.breadthLbl.Size = new System.Drawing.Size(118, 38);
            this.breadthLbl.TabIndex = 9;
            this.breadthLbl.Text = "Breadth:";
            this.breadthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baseTbx
            // 
            this.baseTbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.baseTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.baseTbx.ForeColor = System.Drawing.Color.White;
            this.baseTbx.Location = new System.Drawing.Point(379, 399);
            this.baseTbx.Name = "baseTbx";
            this.baseTbx.Size = new System.Drawing.Size(80, 38);
            this.baseTbx.TabIndex = 12;
            this.baseTbx.Visible = false;
            this.baseTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.baseTbx_KeyPress);
            // 
            // baseLbl
            // 
            this.baseLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.baseLbl.Font = new System.Drawing.Font("Arial", 20F);
            this.baseLbl.ForeColor = System.Drawing.Color.White;
            this.baseLbl.Location = new System.Drawing.Point(255, 399);
            this.baseLbl.Name = "baseLbl";
            this.baseLbl.Size = new System.Drawing.Size(118, 38);
            this.baseLbl.TabIndex = 11;
            this.baseLbl.Text = "Base 2:";
            this.baseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.baseLbl.Visible = false;
            // 
            // circleBtn
            // 
            this.circleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.circleBtn.ForeColor = System.Drawing.Color.White;
            this.circleBtn.Location = new System.Drawing.Point(12, 199);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(113, 35);
            this.circleBtn.TabIndex = 13;
            this.circleBtn.Text = "Circle";
            this.circleBtn.UseVisualStyleBackColor = true;
            this.circleBtn.Click += new System.EventHandler(this.circleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.circleBtn);
            this.Controls.Add(this.baseTbx);
            this.Controls.Add(this.baseLbl);
            this.Controls.Add(this.breadthTbx);
            this.Controls.Add(this.breadthLbl);
            this.Controls.Add(this.trapBtn);
            this.Controls.Add(this.triBtn);
            this.Controls.Add(this.rectBtn);
            this.Controls.Add(this.squareBtn);
            this.Controls.Add(this.formulaLbl);
            this.Controls.Add(this.answerLbl);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.lengthTbx);
            this.Controls.Add(this.LengthLbl);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geometry Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LengthLbl;
        private System.Windows.Forms.TextBox lengthTbx;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label formulaLbl;
        private System.Windows.Forms.Button squareBtn;
        private System.Windows.Forms.Button rectBtn;
        private System.Windows.Forms.Button trapBtn;
        private System.Windows.Forms.Button triBtn;
        private System.Windows.Forms.Label answerLbl;
        private System.Windows.Forms.TextBox breadthTbx;
        private System.Windows.Forms.Label breadthLbl;
        private System.Windows.Forms.TextBox baseTbx;
        private System.Windows.Forms.Label baseLbl;
        private System.Windows.Forms.Button circleBtn;
    }
}

