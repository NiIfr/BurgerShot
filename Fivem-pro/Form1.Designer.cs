namespace Fivem_pro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            listSelect = new ListBox();
            numericUpDown1 = new NumericUpDown();
            addbtn = new Button();
            listV = new ListView();
            label3 = new Label();
            totallbl = new Label();
            reset = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 74);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Order :";
            // 
            // listSelect
            // 
            listSelect.FormattingEnabled = true;
            listSelect.ItemHeight = 15;
            listSelect.Items.AddRange(new object[] { "Shot fries", "Shot ring", "Shot nugget", "Coffee", "Coke", "Water", "MilkShake", "Creampie", "RimJob", "MoneyShot", "HeartStopper", "TheBleeder", "MeatFree", "Torpedo", "GoatCheeseWrap", "CheeseWrap" });
            listSelect.Location = new Point(21, 92);
            listSelect.Name = "listSelect";
            listSelect.Size = new Size(120, 259);
            listSelect.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(147, 92);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(67, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // addbtn
            // 
            addbtn.Location = new Point(147, 121);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(67, 23);
            addbtn.TabIndex = 4;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // listV
            // 
            listV.GridLines = true;
            listV.Location = new Point(220, 92);
            listV.Name = "listV";
            listV.Size = new Size(134, 225);
            listV.TabIndex = 5;
            listV.UseCompatibleStateImageBehavior = false;
            listV.View = View.List;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 336);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "Total :";
            // 
            // totallbl
            // 
            totallbl.AutoSize = true;
            totallbl.Location = new Point(264, 336);
            totallbl.Name = "totallbl";
            totallbl.Size = new Size(13, 15);
            totallbl.TabIndex = 7;
            totallbl.Text = "0";
            // 
            // reset
            // 
            reset.Location = new Point(147, 150);
            reset.Name = "reset";
            reset.Size = new Size(67, 23);
            reset.TabIndex = 9;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 23);
            label4.Name = "label4";
            label4.Size = new Size(321, 27);
            label4.TabIndex = 10;
            label4.Text = "Calc Of BurgerShot System ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 382);
            label5.Name = "label5";
            label5.Size = new Size(176, 15);
            label5.TabIndex = 11;
            label5.Text = "Programming By NilooFarVafaei";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(374, 406);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(reset);
            Controls.Add(totallbl);
            Controls.Add(label3);
            Controls.Add(listV);
            Controls.Add(addbtn);
            Controls.Add(numericUpDown1);
            Controls.Add(listSelect);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "BurgerShot";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listSelect;
        private NumericUpDown numericUpDown1;
        private Button addbtn;
        private ListView listV;
        private Label label3;
        private Label totallbl;
        private Button reset;
        private Label label4;
        private Label label5;
    }
}