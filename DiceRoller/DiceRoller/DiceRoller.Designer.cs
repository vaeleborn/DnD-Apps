namespace DiceRoller
{
    partial class DiceRoller
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
            this.inNumRolls = new System.Windows.Forms.TextBox();
            this.inDieType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inAdvantage = new System.Windows.Forms.ComboBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.outRolls = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inPlus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inNumRolls
            // 
            this.inNumRolls.Location = new System.Drawing.Point(59, 13);
            this.inNumRolls.Margin = new System.Windows.Forms.Padding(4);
            this.inNumRolls.Name = "inNumRolls";
            this.inNumRolls.Size = new System.Drawing.Size(57, 23);
            this.inNumRolls.TabIndex = 0;
            this.inNumRolls.Text = "1";
            this.inNumRolls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inDieType
            // 
            this.inDieType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inDieType.FormattingEnabled = true;
            this.inDieType.Items.AddRange(new object[] {
            "d3",
            "d4",
            "d6",
            "d8",
            "d10",
            "d12",
            "d20",
            "d100"});
            this.inDieType.Location = new System.Drawing.Point(191, 12);
            this.inDieType.Name = "inDieType";
            this.inDieType.Size = new System.Drawing.Size(73, 24);
            this.inDieType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "(dis)Advantage:";
            // 
            // inAdvantage
            // 
            this.inAdvantage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inAdvantage.FormattingEnabled = true;
            this.inAdvantage.Items.AddRange(new object[] {
            "Normal",
            "Advantage",
            "Disadvantage"});
            this.inAdvantage.Location = new System.Drawing.Point(506, 13);
            this.inAdvantage.Name = "inAdvantage";
            this.inAdvantage.Size = new System.Drawing.Size(121, 24);
            this.inAdvantage.TabIndex = 10;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(91, 288);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(173, 48);
            this.btnRoll.TabIndex = 21;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(394, 288);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(173, 48);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear Rolls";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // outRolls
            // 
            this.outRolls.FormattingEnabled = true;
            this.outRolls.ItemHeight = 16;
            this.outRolls.Location = new System.Drawing.Point(49, 73);
            this.outRolls.Name = "outRolls";
            this.outRolls.Size = new System.Drawing.Size(578, 180);
            this.outRolls.TabIndex = 8;
            this.outRolls.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = " + ";
            // 
            // inPlus
            // 
            this.inPlus.Location = new System.Drawing.Point(312, 13);
            this.inPlus.Name = "inPlus";
            this.inPlus.Size = new System.Drawing.Size(68, 23);
            this.inPlus.TabIndex = 9;
            this.inPlus.Text = "0";
            this.inPlus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DiceRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 348);
            this.Controls.Add(this.inPlus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outRolls);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.inAdvantage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inDieType);
            this.Controls.Add(this.inNumRolls);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DiceRoller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inNumRolls;
        private System.Windows.Forms.ComboBox inDieType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox inAdvantage;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox outRolls;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inPlus;
    }
}

