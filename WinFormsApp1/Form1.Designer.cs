namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb1_ = new TextBox();
            tb2_ = new TextBox();
            lb1_frstNumbr = new Label();
            lb2_scndNumbr = new Label();
            lb3_solution = new Label();
            lb4_solValue = new Label();
            btn1_submitCalculation = new Button();
            SuspendLayout();
            // 
            // tb1_
            // 
            tb1_.Location = new Point(170, 37);
            tb1_.Name = "tb1_";
            tb1_.Size = new Size(185, 27);
            tb1_.TabIndex = 0;
            tb1_.TextChanged += textBox1_TextChanged;
            // 
            // tb2_
            // 
            tb2_.Location = new Point(170, 84);
            tb2_.Name = "tb2_";
            tb2_.Size = new Size(185, 27);
            tb2_.TabIndex = 1;
            tb2_.TextChanged += textBox2_TextChanged;
            // 
            // lb1_frstNumbr
            // 
            lb1_frstNumbr.AutoSize = true;
            lb1_frstNumbr.Location = new Point(36, 44);
            lb1_frstNumbr.Name = "lb1_frstNumbr";
            lb1_frstNumbr.Size = new Size(89, 20);
            lb1_frstNumbr.TabIndex = 2;
            lb1_frstNumbr.Text = "first number";
            // 
            // lb2_scndNumbr
            // 
            lb2_scndNumbr.AutoSize = true;
            lb2_scndNumbr.Location = new Point(36, 91);
            lb2_scndNumbr.Name = "lb2_scndNumbr";
            lb2_scndNumbr.Size = new Size(111, 20);
            lb2_scndNumbr.TabIndex = 3;
            lb2_scndNumbr.Text = "second number";
            // 
            // lb3_solution
            // 
            lb3_solution.AutoSize = true;
            lb3_solution.Location = new Point(36, 218);
            lb3_solution.Name = "lb3_solution";
            lb3_solution.Size = new Size(62, 20);
            lb3_solution.TabIndex = 4;
            lb3_solution.Text = "solution";
            // 
            // lb4_solValue
            // 
            lb4_solValue.AutoSize = true;
            lb4_solValue.Location = new Point(170, 218);
            lb4_solValue.Name = "lb4_solValue";
            lb4_solValue.Size = new Size(101, 20);
            lb4_solValue.TabIndex = 5;
            lb4_solValue.Text = "solution value";
            // 
            // btn1_submitCalculation
            // 
            btn1_submitCalculation.Location = new Point(170, 133);
            btn1_submitCalculation.Name = "btn1_submitCalculation";
            btn1_submitCalculation.Size = new Size(185, 59);
            btn1_submitCalculation.TabIndex = 6;
            btn1_submitCalculation.Text = "calculate";
            btn1_submitCalculation.UseVisualStyleBackColor = true;
            btn1_submitCalculation.Click += btn1_submitCalculation_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn1_submitCalculation);
            Controls.Add(lb4_solValue);
            Controls.Add(lb3_solution);
            Controls.Add(lb2_scndNumbr);
            Controls.Add(lb1_frstNumbr);
            Controls.Add(tb2_);
            Controls.Add(tb1_);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb1_;
        private TextBox tb2_;
        private Label lb1_frstNumbr;
        private Label lb2_scndNumbr;
        private Label lb3_solution;
        private Label lb4_solValue;
        private Button btn1_submitCalculation;
    }
}
