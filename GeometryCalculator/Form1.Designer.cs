namespace GeometryCalculator
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
            this.grpShapes = new System.Windows.Forms.GroupBox();
            this.rbtnCircle = new System.Windows.Forms.RadioButton();
            this.rbtnTrapezoid = new System.Windows.Forms.RadioButton();
            this.rbtnRhombus = new System.Windows.Forms.RadioButton();
            this.rbtnParallelogram = new System.Windows.Forms.RadioButton();
            this.rbtnRectange = new System.Windows.Forms.RadioButton();
            this.rbtnSquare = new System.Windows.Forms.RadioButton();
            this.rbtnTriangle = new System.Windows.Forms.RadioButton();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.rbtnBothAreaPerimeter = new System.Windows.Forms.RadioButton();
            this.rbtnPerimeter = new System.Windows.Forms.RadioButton();
            this.rbtnArea = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbShape = new System.Windows.Forms.PictureBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.txtInput3 = new System.Windows.Forms.TextBox();
            this.txtInput4 = new System.Windows.Forms.TextBox();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.lblInput2 = new System.Windows.Forms.Label();
            this.lblInput3 = new System.Windows.Forms.Label();
            this.lblInput4 = new System.Windows.Forms.Label();
            this.pbFormula = new System.Windows.Forms.PictureBox();
            this.lblCredits = new System.Windows.Forms.Label();
            this.btnModulus = new System.Windows.Forms.Button();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.btnExponent = new System.Windows.Forms.Button();
            this.grpShapes.SuspendLayout();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // grpShapes
            // 
            this.grpShapes.Controls.Add(this.rbtnCircle);
            this.grpShapes.Controls.Add(this.rbtnTrapezoid);
            this.grpShapes.Controls.Add(this.rbtnRhombus);
            this.grpShapes.Controls.Add(this.rbtnParallelogram);
            this.grpShapes.Controls.Add(this.rbtnRectange);
            this.grpShapes.Controls.Add(this.rbtnSquare);
            this.grpShapes.Controls.Add(this.rbtnTriangle);
            this.grpShapes.Location = new System.Drawing.Point(12, 50);
            this.grpShapes.Name = "grpShapes";
            this.grpShapes.Size = new System.Drawing.Size(200, 112);
            this.grpShapes.TabIndex = 0;
            this.grpShapes.TabStop = false;
            this.grpShapes.Text = "Shapes";
            // 
            // rbtnCircle
            // 
            this.rbtnCircle.AutoSize = true;
            this.rbtnCircle.Location = new System.Drawing.Point(68, 88);
            this.rbtnCircle.Name = "rbtnCircle";
            this.rbtnCircle.Size = new System.Drawing.Size(51, 17);
            this.rbtnCircle.TabIndex = 6;
            this.rbtnCircle.TabStop = true;
            this.rbtnCircle.Text = "Circle";
            this.rbtnCircle.UseVisualStyleBackColor = true;
            this.rbtnCircle.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbtnTrapezoid
            // 
            this.rbtnTrapezoid.AutoSize = true;
            this.rbtnTrapezoid.Location = new System.Drawing.Point(109, 65);
            this.rbtnTrapezoid.Name = "rbtnTrapezoid";
            this.rbtnTrapezoid.Size = new System.Drawing.Size(72, 17);
            this.rbtnTrapezoid.TabIndex = 5;
            this.rbtnTrapezoid.TabStop = true;
            this.rbtnTrapezoid.Text = "Trapezoid";
            this.rbtnTrapezoid.UseVisualStyleBackColor = true;
            this.rbtnTrapezoid.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbtnRhombus
            // 
            this.rbtnRhombus.AutoSize = true;
            this.rbtnRhombus.Location = new System.Drawing.Point(109, 42);
            this.rbtnRhombus.Name = "rbtnRhombus";
            this.rbtnRhombus.Size = new System.Drawing.Size(70, 17);
            this.rbtnRhombus.TabIndex = 4;
            this.rbtnRhombus.TabStop = true;
            this.rbtnRhombus.Text = "Rhombus";
            this.rbtnRhombus.UseVisualStyleBackColor = true;
            this.rbtnRhombus.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbtnParallelogram
            // 
            this.rbtnParallelogram.AutoSize = true;
            this.rbtnParallelogram.Location = new System.Drawing.Point(109, 19);
            this.rbtnParallelogram.Name = "rbtnParallelogram";
            this.rbtnParallelogram.Size = new System.Drawing.Size(88, 17);
            this.rbtnParallelogram.TabIndex = 3;
            this.rbtnParallelogram.TabStop = true;
            this.rbtnParallelogram.Text = "Parallelogram";
            this.rbtnParallelogram.UseVisualStyleBackColor = true;
            this.rbtnParallelogram.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbtnRectange
            // 
            this.rbtnRectange.AutoSize = true;
            this.rbtnRectange.Location = new System.Drawing.Point(6, 65);
            this.rbtnRectange.Name = "rbtnRectange";
            this.rbtnRectange.Size = new System.Drawing.Size(74, 17);
            this.rbtnRectange.TabIndex = 2;
            this.rbtnRectange.TabStop = true;
            this.rbtnRectange.Text = "Rectangle";
            this.rbtnRectange.UseVisualStyleBackColor = true;
            this.rbtnRectange.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbtnSquare
            // 
            this.rbtnSquare.AutoSize = true;
            this.rbtnSquare.Location = new System.Drawing.Point(6, 42);
            this.rbtnSquare.Name = "rbtnSquare";
            this.rbtnSquare.Size = new System.Drawing.Size(59, 17);
            this.rbtnSquare.TabIndex = 1;
            this.rbtnSquare.TabStop = true;
            this.rbtnSquare.Text = "Square";
            this.rbtnSquare.UseVisualStyleBackColor = true;
            this.rbtnSquare.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbtnTriangle
            // 
            this.rbtnTriangle.AutoSize = true;
            this.rbtnTriangle.Location = new System.Drawing.Point(6, 19);
            this.rbtnTriangle.Name = "rbtnTriangle";
            this.rbtnTriangle.Size = new System.Drawing.Size(63, 17);
            this.rbtnTriangle.TabIndex = 0;
            this.rbtnTriangle.TabStop = true;
            this.rbtnTriangle.Text = "Triangle";
            this.rbtnTriangle.UseVisualStyleBackColor = true;
            this.rbtnTriangle.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.rbtnBothAreaPerimeter);
            this.grpOptions.Controls.Add(this.rbtnPerimeter);
            this.grpOptions.Controls.Add(this.rbtnArea);
            this.grpOptions.Location = new System.Drawing.Point(12, 161);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(87, 117);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // rbtnBothAreaPerimeter
            // 
            this.rbtnBothAreaPerimeter.Location = new System.Drawing.Point(6, 65);
            this.rbtnBothAreaPerimeter.Name = "rbtnBothAreaPerimeter";
            this.rbtnBothAreaPerimeter.Size = new System.Drawing.Size(69, 46);
            this.rbtnBothAreaPerimeter.TabIndex = 2;
            this.rbtnBothAreaPerimeter.TabStop = true;
            this.rbtnBothAreaPerimeter.Text = "Area and Perimeter";
            this.rbtnBothAreaPerimeter.UseVisualStyleBackColor = true;
            this.rbtnBothAreaPerimeter.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged2);
            // 
            // rbtnPerimeter
            // 
            this.rbtnPerimeter.AutoSize = true;
            this.rbtnPerimeter.Location = new System.Drawing.Point(6, 49);
            this.rbtnPerimeter.Name = "rbtnPerimeter";
            this.rbtnPerimeter.Size = new System.Drawing.Size(69, 17);
            this.rbtnPerimeter.TabIndex = 1;
            this.rbtnPerimeter.TabStop = true;
            this.rbtnPerimeter.Text = "Perimeter";
            this.rbtnPerimeter.UseVisualStyleBackColor = true;
            this.rbtnPerimeter.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged2);
            // 
            // rbtnArea
            // 
            this.rbtnArea.AutoSize = true;
            this.rbtnArea.Location = new System.Drawing.Point(6, 19);
            this.rbtnArea.Name = "rbtnArea";
            this.rbtnArea.Size = new System.Drawing.Size(47, 17);
            this.rbtnArea.TabIndex = 0;
            this.rbtnArea.TabStop = true;
            this.rbtnArea.Text = "Area";
            this.rbtnArea.UseVisualStyleBackColor = true;
            this.rbtnArea.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged2);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(16, 284);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(59, 29);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(16, 319);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 29);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(16, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 29);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbShape
            // 
            this.pbShape.Image = global::GeometryCalculator.Properties.Resources.imgTriangle;
            this.pbShape.InitialImage = null;
            this.pbShape.Location = new System.Drawing.Point(218, 50);
            this.pbShape.Name = "pbShape";
            this.pbShape.Size = new System.Drawing.Size(134, 112);
            this.pbShape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShape.TabIndex = 5;
            this.pbShape.TabStop = false;
            // 
            // lblArea
            // 
            this.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArea.Location = new System.Drawing.Point(252, 242);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(100, 65);
            this.lblArea.TabIndex = 8;
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(185, 168);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(61, 20);
            this.txtInput1.TabIndex = 10;
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(185, 194);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(61, 20);
            this.txtInput2.TabIndex = 11;
            // 
            // txtInput3
            // 
            this.txtInput3.Location = new System.Drawing.Point(185, 220);
            this.txtInput3.Name = "txtInput3";
            this.txtInput3.Size = new System.Drawing.Size(61, 20);
            this.txtInput3.TabIndex = 12;
            // 
            // txtInput4
            // 
            this.txtInput4.Location = new System.Drawing.Point(185, 246);
            this.txtInput4.Name = "txtInput4";
            this.txtInput4.Size = new System.Drawing.Size(61, 20);
            this.txtInput4.TabIndex = 13;
            // 
            // lblInput1
            // 
            this.lblInput1.Location = new System.Drawing.Point(105, 175);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.Size = new System.Drawing.Size(74, 13);
            this.lblInput1.TabIndex = 14;
            this.lblInput1.Text = "label3";
            // 
            // lblInput2
            // 
            this.lblInput2.Location = new System.Drawing.Point(105, 201);
            this.lblInput2.Name = "lblInput2";
            this.lblInput2.Size = new System.Drawing.Size(74, 13);
            this.lblInput2.TabIndex = 15;
            this.lblInput2.Text = "label4";
            // 
            // lblInput3
            // 
            this.lblInput3.Location = new System.Drawing.Point(105, 227);
            this.lblInput3.Name = "lblInput3";
            this.lblInput3.Size = new System.Drawing.Size(74, 13);
            this.lblInput3.TabIndex = 16;
            this.lblInput3.Text = "label5";
            // 
            // lblInput4
            // 
            this.lblInput4.Location = new System.Drawing.Point(105, 253);
            this.lblInput4.Name = "lblInput4";
            this.lblInput4.Size = new System.Drawing.Size(74, 13);
            this.lblInput4.TabIndex = 17;
            this.lblInput4.Text = "label6";
            // 
            // pbFormula
            // 
            this.pbFormula.Location = new System.Drawing.Point(252, 167);
            this.pbFormula.Name = "pbFormula";
            this.pbFormula.Size = new System.Drawing.Size(100, 62);
            this.pbFormula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFormula.TabIndex = 18;
            this.pbFormula.TabStop = false;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(343, 0);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(197, 26);
            this.lblCredits.TabIndex = 19;
            this.lblCredits.Text = "Heather, Joe, Stephanie, Kayla\r\nGeometry Formulas Calculator & extended";
            // 
            // btnModulus
            // 
            this.btnModulus.Location = new System.Drawing.Point(81, 284);
            this.btnModulus.Name = "btnModulus";
            this.btnModulus.Size = new System.Drawing.Size(81, 29);
            this.btnModulus.TabIndex = 20;
            this.btnModulus.Text = "Remainder";
            this.btnModulus.UseVisualStyleBackColor = true;
            this.btnModulus.Click += new System.EventHandler(this.btnModulus_Click);
            // 
            // btnPercentage
            // 
            this.btnPercentage.Location = new System.Drawing.Point(81, 319);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(81, 29);
            this.btnPercentage.TabIndex = 21;
            this.btnPercentage.Text = "Percentage";
            this.btnPercentage.UseVisualStyleBackColor = true;
            this.btnPercentage.Click += new System.EventHandler(this.btnPercentage_Click);
            // 
            // btnExponent
            // 
            this.btnExponent.Location = new System.Drawing.Point(81, 354);
            this.btnExponent.Name = "btnExponent";
            this.btnExponent.Size = new System.Drawing.Size(81, 29);
            this.btnExponent.TabIndex = 22;
            this.btnExponent.Text = "X^Y";
            this.btnExponent.UseVisualStyleBackColor = true;
            this.btnExponent.Click += new System.EventHandler(this.btnExponent_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(547, 391);
            this.Controls.Add(this.btnExponent);
            this.Controls.Add(this.btnPercentage);
            this.Controls.Add(this.btnModulus);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.pbFormula);
            this.Controls.Add(this.lblInput4);
            this.Controls.Add(this.lblInput3);
            this.Controls.Add(this.lblInput2);
            this.Controls.Add(this.lblInput1);
            this.Controls.Add(this.txtInput4);
            this.Controls.Add(this.txtInput3);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.pbShape);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpShapes);
            this.Name = "Form1";
            this.Text = "Geometry Calculator";
            this.grpShapes.ResumeLayout(false);
            this.grpShapes.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpShapes;
        private System.Windows.Forms.RadioButton rbtnCircle;
        private System.Windows.Forms.RadioButton rbtnTrapezoid;
        private System.Windows.Forms.RadioButton rbtnRhombus;
        private System.Windows.Forms.RadioButton rbtnParallelogram;
        private System.Windows.Forms.RadioButton rbtnRectange;
        private System.Windows.Forms.RadioButton rbtnSquare;
        private System.Windows.Forms.RadioButton rbtnTriangle;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.RadioButton rbtnBothAreaPerimeter;
        private System.Windows.Forms.RadioButton rbtnPerimeter;
        private System.Windows.Forms.RadioButton rbtnArea;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbShape;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.TextBox txtInput3;
        private System.Windows.Forms.TextBox txtInput4;
        private System.Windows.Forms.Label lblInput1;
        private System.Windows.Forms.Label lblInput2;
        private System.Windows.Forms.Label lblInput3;
        private System.Windows.Forms.Label lblInput4;
        private System.Windows.Forms.PictureBox pbFormula;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Button btnModulus;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button btnExponent;
    }
}

