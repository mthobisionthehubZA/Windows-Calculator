
namespace Calculator
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            buttonEquals = new Button();
            buttonEight = new Button();
            buttonNine = new Button();
            buttonDivide = new Button();
            buttonCE = new Button();
            buttonC = new Button();
            buttonMultiply = new Button();
            buttonSix = new Button();
            buttonFive = new Button();
            buttonFour = new Button();
            buttonSubtract = new Button();
            buttonThree = new Button();
            buttonTwo = new Button();
            buttonOne = new Button();
            buttonSeven = new Button();
            buttonAdd = new Button();
            buttonComma = new Button();
            buttonZero = new Button();
            txtResults = new TextBox();
            labelCurrentOperation = new Label();
            SuspendLayout();
            // 
            // buttonEquals
            // 
            buttonEquals.BackColor = Color.LightGreen;
            buttonEquals.FlatStyle = FlatStyle.Popup;
            buttonEquals.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonEquals.ForeColor = Color.Black;
            buttonEquals.Location = new Point(249, 273);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(54, 123);
            buttonEquals.TabIndex = 0;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = false;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // buttonEight
            // 
            buttonEight.FlatStyle = FlatStyle.Popup;
            buttonEight.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonEight.ForeColor = Color.Black;
            buttonEight.Location = new Point(77, 144);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(54, 54);
            buttonEight.TabIndex = 1;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = true;
            buttonEight.Click += button_click;
            // 
            // buttonNine
            // 
            buttonNine.FlatStyle = FlatStyle.Popup;
            buttonNine.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonNine.ForeColor = Color.Black;
            buttonNine.Location = new Point(133, 144);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(54, 54);
            buttonNine.TabIndex = 2;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = true;
            buttonNine.Click += button_click;
            // 
            // buttonDivide
            // 
            buttonDivide.FlatStyle = FlatStyle.Popup;
            buttonDivide.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonDivide.ForeColor = Color.Black;
            buttonDivide.Location = new Point(189, 144);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(54, 54);
            buttonDivide.TabIndex = 3;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += operator_click;
            // 
            // buttonCE
            // 
            buttonCE.FlatStyle = FlatStyle.Popup;
            buttonCE.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonCE.ForeColor = Color.Black;
            buttonCE.Location = new Point(245, 144);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(54, 54);
            buttonCE.TabIndex = 4;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = true;
            buttonCE.Click += buttonCE_Click;
            // 
            // buttonC
            // 
            buttonC.FlatStyle = FlatStyle.Popup;
            buttonC.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonC.ForeColor = Color.Black;
            buttonC.Location = new Point(245, 207);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(54, 54);
            buttonC.TabIndex = 9;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            // 
            // buttonMultiply
            // 
            buttonMultiply.FlatStyle = FlatStyle.Popup;
            buttonMultiply.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonMultiply.ForeColor = Color.Black;
            buttonMultiply.Location = new Point(189, 207);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(54, 54);
            buttonMultiply.TabIndex = 8;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += operator_click;
            // 
            // buttonSix
            // 
            buttonSix.FlatStyle = FlatStyle.Popup;
            buttonSix.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonSix.ForeColor = Color.Black;
            buttonSix.Location = new Point(133, 207);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(54, 54);
            buttonSix.TabIndex = 7;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = true;
            buttonSix.Click += button_click;
            // 
            // buttonFive
            // 
            buttonFive.FlatStyle = FlatStyle.Popup;
            buttonFive.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonFive.ForeColor = Color.Black;
            buttonFive.Location = new Point(77, 207);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(54, 54);
            buttonFive.TabIndex = 6;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = true;
            buttonFive.Click += button_click;
            // 
            // buttonFour
            // 
            buttonFour.FlatStyle = FlatStyle.Popup;
            buttonFour.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonFour.ForeColor = Color.Black;
            buttonFour.Location = new Point(21, 207);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(54, 54);
            buttonFour.TabIndex = 5;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = true;
            buttonFour.Click += button_click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.FlatStyle = FlatStyle.Popup;
            buttonSubtract.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonSubtract.ForeColor = Color.Black;
            buttonSubtract.Location = new Point(189, 273);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(54, 54);
            buttonSubtract.TabIndex = 13;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += operator_click;
            // 
            // buttonThree
            // 
            buttonThree.FlatStyle = FlatStyle.Popup;
            buttonThree.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonThree.ForeColor = Color.Black;
            buttonThree.Location = new Point(133, 273);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(54, 54);
            buttonThree.TabIndex = 12;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = true;
            buttonThree.Click += button_click;
            // 
            // buttonTwo
            // 
            buttonTwo.FlatStyle = FlatStyle.Popup;
            buttonTwo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonTwo.ForeColor = Color.Black;
            buttonTwo.Location = new Point(77, 273);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(54, 54);
            buttonTwo.TabIndex = 11;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = true;
            buttonTwo.Click += button_click;
            // 
            // buttonOne
            // 
            buttonOne.FlatStyle = FlatStyle.Popup;
            buttonOne.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonOne.ForeColor = Color.Black;
            buttonOne.Location = new Point(21, 273);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(54, 54);
            buttonOne.TabIndex = 10;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = true;
            buttonOne.Click += button_click;
            // 
            // buttonSeven
            // 
            buttonSeven.FlatStyle = FlatStyle.Popup;
            buttonSeven.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonSeven.ForeColor = Color.Black;
            buttonSeven.Location = new Point(21, 144);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(54, 54);
            buttonSeven.TabIndex = 19;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = true;
            buttonSeven.Click += button_click;
            // 
            // buttonAdd
            // 
            buttonAdd.FlatStyle = FlatStyle.Popup;
            buttonAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.Black;
            buttonAdd.Location = new Point(189, 342);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(54, 54);
            buttonAdd.TabIndex = 18;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += operator_click;
            // 
            // buttonComma
            // 
            buttonComma.FlatStyle = FlatStyle.Popup;
            buttonComma.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonComma.ForeColor = Color.Black;
            buttonComma.Location = new Point(133, 342);
            buttonComma.Name = "buttonComma";
            buttonComma.Size = new Size(54, 54);
            buttonComma.TabIndex = 17;
            buttonComma.Text = ".";
            buttonComma.UseVisualStyleBackColor = true;
            buttonComma.Click += button_click;
            // 
            // buttonZero
            // 
            buttonZero.FlatStyle = FlatStyle.Popup;
            buttonZero.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonZero.ForeColor = Color.Black;
            buttonZero.Location = new Point(21, 342);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(110, 54);
            buttonZero.TabIndex = 15;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = true;
            buttonZero.Click += button_click;
            // 
            // txtResults
            // 
            txtResults.Font = new Font("Cambria", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResults.Location = new Point(21, 73);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.Size = new Size(278, 44);
            txtResults.TabIndex = 20;
            txtResults.Text = "0";
            txtResults.TextAlign = HorizontalAlignment.Right;
            txtResults.KeyPress += txtResults_KeyPress;
            // 
            // labelCurrentOperation
            // 
            labelCurrentOperation.AutoSize = true;
            labelCurrentOperation.BackColor = SystemColors.Window;
            labelCurrentOperation.Font = new Font("Cambria", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCurrentOperation.ForeColor = SystemColors.ButtonShadow;
            labelCurrentOperation.Location = new Point(21, 36);
            labelCurrentOperation.Name = "labelCurrentOperation";
            labelCurrentOperation.Size = new Size(0, 34);
            labelCurrentOperation.TabIndex = 21;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(320, 419);
            Controls.Add(labelCurrentOperation);
            Controls.Add(txtResults);
            Controls.Add(buttonSeven);
            Controls.Add(buttonAdd);
            Controls.Add(buttonComma);
            Controls.Add(buttonZero);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonThree);
            Controls.Add(buttonTwo);
            Controls.Add(buttonOne);
            Controls.Add(buttonC);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSix);
            Controls.Add(buttonFive);
            Controls.Add(buttonFour);
            Controls.Add(buttonCE);
            Controls.Add(buttonDivide);
            Controls.Add(buttonNine);
            Controls.Add(buttonEight);
            Controls.Add(buttonEquals);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CalculatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private Button buttonEquals;
        private Button buttonEight;
        private Button buttonNine;
        private Button buttonDivide;
        private Button buttonCE;
        private Button buttonC;
        private Button buttonMultiply;
        private Button buttonSix;
        private Button buttonFive;
        private Button buttonFour;
        private Button buttonSubtract;
        private Button buttonThree;
        private Button buttonTwo;
        private Button buttonOne;
        private Button buttonSeven;
        private Button buttonAdd;
        private Button buttonComma;
        private Button buttonZero;
        private TextBox txtResults;
        private Label labelCurrentOperation;
    }
}