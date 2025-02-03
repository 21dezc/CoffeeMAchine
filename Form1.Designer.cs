namespace machineCoffe
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
            btnBlackCoffee = new Button();
            btnMocha = new Button();
            btnLatte = new Button();
            btnChocolate = new Button();
            lblWater = new Label();
            lblCoffee = new Label();
            lblChocolate = new Label();
            lblMilk = new Label();
            gbIngredient = new GroupBox();
            btnRefill = new Button();
            lbBlackCoffee = new Label();
            lblBlackCoffeeCount = new TextBox();
            lblMochaCount = new TextBox();
            lbMocha = new Label();
            lblLatteCount = new TextBox();
            lbLatte = new Label();
            lblChocolateCount = new TextBox();
            lbChocolate = new Label();
            gbIngredient.SuspendLayout();
            SuspendLayout();
            // 
            // btnBlackCoffee
            // 
            btnBlackCoffee.BackColor = SystemColors.ActiveBorder;
            btnBlackCoffee.ForeColor = SystemColors.ButtonHighlight;
            btnBlackCoffee.Location = new Point(65, 337);
            btnBlackCoffee.Margin = new Padding(3, 4, 3, 4);
            btnBlackCoffee.Name = "btnBlackCoffee";
            btnBlackCoffee.Size = new Size(118, 49);
            btnBlackCoffee.TabIndex = 12;
            btnBlackCoffee.Text = "BlackCoffee";
            btnBlackCoffee.UseVisualStyleBackColor = false;
            btnBlackCoffee.Click += btnBlackCoffee_Click;
            // 
            // btnMocha
            // 
            btnMocha.BackColor = SystemColors.ActiveBorder;
            btnMocha.ForeColor = SystemColors.ButtonHighlight;
            btnMocha.Location = new Point(361, 337);
            btnMocha.Margin = new Padding(3, 4, 3, 4);
            btnMocha.Name = "btnMocha";
            btnMocha.Size = new Size(122, 49);
            btnMocha.TabIndex = 13;
            btnMocha.Text = "Mocha";
            btnMocha.UseVisualStyleBackColor = false;
            btnMocha.Click += btnMocha_Click;
            // 
            // btnLatte
            // 
            btnLatte.BackColor = SystemColors.ActiveBorder;
            btnLatte.ForeColor = SystemColors.ButtonHighlight;
            btnLatte.Location = new Point(213, 337);
            btnLatte.Margin = new Padding(3, 4, 3, 4);
            btnLatte.Name = "btnLatte";
            btnLatte.Size = new Size(116, 49);
            btnLatte.TabIndex = 14;
            btnLatte.Text = "Latte";
            btnLatte.UseVisualStyleBackColor = false;
            btnLatte.Click += btnLatte_Click;
            // 
            // btnChocolate
            // 
            btnChocolate.BackColor = SystemColors.ActiveBorder;
            btnChocolate.ForeColor = SystemColors.ButtonHighlight;
            btnChocolate.Location = new Point(516, 337);
            btnChocolate.Margin = new Padding(3, 4, 3, 4);
            btnChocolate.Name = "btnChocolate";
            btnChocolate.Size = new Size(128, 49);
            btnChocolate.TabIndex = 15;
            btnChocolate.Text = "Chocolate";
            btnChocolate.UseVisualStyleBackColor = false;
            btnChocolate.Click += btnChocolate_Click;
            // 
            // lblWater
            // 
            lblWater.AutoSize = true;
            lblWater.Location = new Point(18, 37);
            lblWater.Name = "lblWater";
            lblWater.Size = new Size(100, 20);
            lblWater.TabIndex = 16;
            lblWater.Text = "Water: 2000 g";
            // 
            // lblCoffee
            // 
            lblCoffee.AutoSize = true;
            lblCoffee.Location = new Point(18, 71);
            lblCoffee.Name = "lblCoffee";
            lblCoffee.Size = new Size(97, 20);
            lblCoffee.TabIndex = 17;
            lblCoffee.Text = "Coffee: 500 g";
            // 
            // lblChocolate
            // 
            lblChocolate.AutoSize = true;
            lblChocolate.Location = new Point(18, 107);
            lblChocolate.Name = "lblChocolate";
            lblChocolate.Size = new Size(120, 20);
            lblChocolate.TabIndex = 18;
            lblChocolate.Text = "Chocolate: 300 g";
            // 
            // lblMilk
            // 
            lblMilk.AutoSize = true;
            lblMilk.Location = new Point(18, 139);
            lblMilk.Name = "lblMilk";
            lblMilk.Size = new Size(81, 20);
            lblMilk.TabIndex = 19;
            lblMilk.Text = "Milk: 500 g";
            // 
            // gbIngredient
            // 
            gbIngredient.Controls.Add(lblWater);
            gbIngredient.Controls.Add(lblMilk);
            gbIngredient.Controls.Add(lblCoffee);
            gbIngredient.Controls.Add(lblChocolate);
            gbIngredient.ForeColor = SystemColors.ControlDarkDark;
            gbIngredient.Location = new Point(68, 84);
            gbIngredient.Margin = new Padding(3, 4, 3, 4);
            gbIngredient.Name = "gbIngredient";
            gbIngredient.Padding = new Padding(3, 4, 3, 4);
            gbIngredient.Size = new Size(295, 177);
            gbIngredient.TabIndex = 20;
            gbIngredient.TabStop = false;
            gbIngredient.Text = "ingredient";
            // 
            // btnRefill
            // 
            btnRefill.BackColor = SystemColors.ControlDark;
            btnRefill.ForeColor = SystemColors.ButtonHighlight;
            btnRefill.Location = new Point(601, 410);
            btnRefill.Margin = new Padding(3, 4, 3, 4);
            btnRefill.Name = "btnRefill";
            btnRefill.Size = new Size(79, 36);
            btnRefill.TabIndex = 21;
            btnRefill.Text = "Refill";
            btnRefill.UseVisualStyleBackColor = false;
            btnRefill.Click += btnRefill_Click;
            // 
            // lbBlackCoffee
            // 
            lbBlackCoffee.AutoSize = true;
            lbBlackCoffee.Location = new Point(414, 94);
            lbBlackCoffee.Name = "lbBlackCoffee";
            lbBlackCoffee.Size = new Size(88, 20);
            lbBlackCoffee.TabIndex = 22;
            lbBlackCoffee.Text = "BlackCoffee";
            // 
            // lblBlackCoffeeCount
            // 
            lblBlackCoffeeCount.ForeColor = SystemColors.ControlDarkDark;
            lblBlackCoffeeCount.Location = new Point(505, 91);
            lblBlackCoffeeCount.Margin = new Padding(3, 4, 3, 4);
            lblBlackCoffeeCount.Name = "lblBlackCoffeeCount";
            lblBlackCoffeeCount.Size = new Size(139, 27);
            lblBlackCoffeeCount.TabIndex = 23;
            // 
            // lblMochaCount
            // 
            lblMochaCount.BackColor = SystemColors.ButtonFace;
            lblMochaCount.ForeColor = SystemColors.ControlDarkDark;
            lblMochaCount.Location = new Point(505, 138);
            lblMochaCount.Margin = new Padding(3, 4, 3, 4);
            lblMochaCount.Name = "lblMochaCount";
            lblMochaCount.Size = new Size(139, 27);
            lblMochaCount.TabIndex = 25;
            // 
            // lbMocha
            // 
            lbMocha.AutoSize = true;
            lbMocha.Location = new Point(445, 141);
            lbMocha.Name = "lbMocha";
            lbMocha.Size = new Size(54, 20);
            lbMocha.TabIndex = 24;
            lbMocha.Text = "Mocha";
            // 
            // lblLatteCount
            // 
            lblLatteCount.BackColor = SystemColors.ControlLight;
            lblLatteCount.ForeColor = SystemColors.ControlDarkDark;
            lblLatteCount.Location = new Point(505, 188);
            lblLatteCount.Margin = new Padding(3, 4, 3, 4);
            lblLatteCount.Name = "lblLatteCount";
            lblLatteCount.Size = new Size(139, 27);
            lblLatteCount.TabIndex = 27;
            // 
            // lbLatte
            // 
            lbLatte.AutoSize = true;
            lbLatte.Location = new Point(457, 188);
            lbLatte.Name = "lbLatte";
            lbLatte.Size = new Size(42, 20);
            lbLatte.TabIndex = 26;
            lbLatte.Text = "Latte";
            // 
            // lblChocolateCount
            // 
            lblChocolateCount.BackColor = SystemColors.ScrollBar;
            lblChocolateCount.ForeColor = SystemColors.ControlDarkDark;
            lblChocolateCount.Location = new Point(505, 234);
            lblChocolateCount.Margin = new Padding(3, 4, 3, 4);
            lblChocolateCount.Name = "lblChocolateCount";
            lblChocolateCount.Size = new Size(139, 27);
            lblChocolateCount.TabIndex = 29;
            // 
            // lbChocolate
            // 
            lbChocolate.AutoSize = true;
            lbChocolate.Location = new Point(423, 241);
            lbChocolate.Name = "lbChocolate";
            lbChocolate.Size = new Size(76, 20);
            lbChocolate.TabIndex = 28;
            lbChocolate.Text = "Chocolate";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(720, 477);
            Controls.Add(lblChocolateCount);
            Controls.Add(lbChocolate);
            Controls.Add(lblLatteCount);
            Controls.Add(lbLatte);
            Controls.Add(lblMochaCount);
            Controls.Add(lbMocha);
            Controls.Add(lblBlackCoffeeCount);
            Controls.Add(lbBlackCoffee);
            Controls.Add(btnRefill);
            Controls.Add(gbIngredient);
            Controls.Add(btnChocolate);
            Controls.Add(btnLatte);
            Controls.Add(btnMocha);
            Controls.Add(btnBlackCoffee);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            gbIngredient.ResumeLayout(false);
            gbIngredient.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBlackCoffee;
        private Button btnMocha;
        private Button btnLatte;
        private Button btnChocolate;
        private Label lblWater;
        private Label lblCoffee;
        private Label lblChocolate;
        private Label lblMilk;
        private GroupBox gbIngredient;
        private Button btnRefill;
        private Label lbBlackCoffee;
        private TextBox lblBlackCoffeeCount;
        private TextBox lblMochaCount;
        private Label lbMocha;
        private TextBox lblLatteCount;
        private Label lbLatte;
        private TextBox lblChocolateCount;
        private Label lbChocolate;
    }
}
