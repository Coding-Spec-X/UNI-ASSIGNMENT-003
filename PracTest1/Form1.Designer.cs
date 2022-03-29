namespace PracTest1
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
            this.claculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.diamondTextBox = new System.Windows.Forms.TextBox();
            this.diamondCostTextBox = new System.Windows.Forms.TextBox();
            this.goldTextBox = new System.Windows.Forms.TextBox();
            this.goldCostTextBox = new System.Windows.Forms.TextBox();
            this.baseCostTextBox = new System.Windows.Forms.TextBox();
            this.finalCostTextBox = new System.Windows.Forms.TextBox();
            this.diamondsLabel = new System.Windows.Forms.Label();
            this.goldLabel = new System.Windows.Forms.Label();
            this.diamondCostLabel = new System.Windows.Forms.Label();
            this.goldCostLabel = new System.Windows.Forms.Label();
            this.baseCostLabel = new System.Windows.Forms.Label();
            this.finalCostLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // claculateButton
            // 
            this.claculateButton.Location = new System.Drawing.Point(113, 445);
            this.claculateButton.Name = "claculateButton";
            this.claculateButton.Size = new System.Drawing.Size(120, 45);
            this.claculateButton.TabIndex = 0;
            this.claculateButton.Text = "Calculate";
            this.claculateButton.UseVisualStyleBackColor = true;
            this.claculateButton.Click += new System.EventHandler(this.claculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(254, 445);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 45);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(390, 445);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 45);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // diamondTextBox
            // 
            this.diamondTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diamondTextBox.Location = new System.Drawing.Point(150, 72);
            this.diamondTextBox.Name = "diamondTextBox";
            this.diamondTextBox.Size = new System.Drawing.Size(100, 26);
            this.diamondTextBox.TabIndex = 3;
            // 
            // diamondCostTextBox
            // 
            this.diamondCostTextBox.Location = new System.Drawing.Point(340, 201);
            this.diamondCostTextBox.Name = "diamondCostTextBox";
            this.diamondCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.diamondCostTextBox.TabIndex = 4;
            // 
            // goldTextBox
            // 
            this.goldTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldTextBox.Location = new System.Drawing.Point(384, 72);
            this.goldTextBox.Name = "goldTextBox";
            this.goldTextBox.Size = new System.Drawing.Size(100, 26);
            this.goldTextBox.TabIndex = 5;
            // 
            // goldCostTextBox
            // 
            this.goldCostTextBox.Location = new System.Drawing.Point(340, 250);
            this.goldCostTextBox.Name = "goldCostTextBox";
            this.goldCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.goldCostTextBox.TabIndex = 6;
            // 
            // baseCostTextBox
            // 
            this.baseCostTextBox.Location = new System.Drawing.Point(340, 300);
            this.baseCostTextBox.Name = "baseCostTextBox";
            this.baseCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.baseCostTextBox.TabIndex = 7;
            // 
            // finalCostTextBox
            // 
            this.finalCostTextBox.Location = new System.Drawing.Point(340, 350);
            this.finalCostTextBox.Name = "finalCostTextBox";
            this.finalCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.finalCostTextBox.TabIndex = 8;
            // 
            // diamondsLabel
            // 
            this.diamondsLabel.AutoSize = true;
            this.diamondsLabel.BackColor = System.Drawing.Color.White;
            this.diamondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diamondsLabel.Location = new System.Drawing.Point(23, 78);
            this.diamondsLabel.Name = "diamondsLabel";
            this.diamondsLabel.Size = new System.Drawing.Size(121, 13);
            this.diamondsLabel.TabIndex = 9;
            this.diamondsLabel.Text = "Diamonds Required:";
            // 
            // goldLabel
            // 
            this.goldLabel.AutoSize = true;
            this.goldLabel.BackColor = System.Drawing.Color.White;
            this.goldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldLabel.Location = new System.Drawing.Point(286, 81);
            this.goldLabel.Name = "goldLabel";
            this.goldLabel.Size = new System.Drawing.Size(92, 13);
            this.goldLabel.TabIndex = 10;
            this.goldLabel.Text = "Gold Required:";
            // 
            // diamondCostLabel
            // 
            this.diamondCostLabel.AutoSize = true;
            this.diamondCostLabel.BackColor = System.Drawing.Color.White;
            this.diamondCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diamondCostLabel.Location = new System.Drawing.Point(153, 142);
            this.diamondCostLabel.Name = "diamondCostLabel";
            this.diamondCostLabel.Size = new System.Drawing.Size(110, 13);
            this.diamondCostLabel.TabIndex = 11;
            this.diamondCostLabel.Text = "Cost of Diamonds:";
            // 
            // goldCostLabel
            // 
            this.goldCostLabel.AutoSize = true;
            this.goldCostLabel.BackColor = System.Drawing.Color.White;
            this.goldCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldCostLabel.Location = new System.Drawing.Point(182, 187);
            this.goldCostLabel.Name = "goldCostLabel";
            this.goldCostLabel.Size = new System.Drawing.Size(81, 13);
            this.goldCostLabel.TabIndex = 12;
            this.goldCostLabel.Text = "Cost of Gold:";
            // 
            // baseCostLabel
            // 
            this.baseCostLabel.AutoSize = true;
            this.baseCostLabel.BackColor = System.Drawing.Color.White;
            this.baseCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseCostLabel.Location = new System.Drawing.Point(196, 300);
            this.baseCostLabel.Name = "baseCostLabel";
            this.baseCostLabel.Size = new System.Drawing.Size(113, 13);
            this.baseCostLabel.TabIndex = 13;
            this.baseCostLabel.Text = "Base Cost of Ring:";
            // 
            // finalCostLabel
            // 
            this.finalCostLabel.AutoSize = true;
            this.finalCostLabel.BackColor = System.Drawing.Color.White;
            this.finalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalCostLabel.Location = new System.Drawing.Point(155, 284);
            this.finalCostLabel.Name = "finalCostLabel";
            this.finalCostLabel.Size = new System.Drawing.Size(108, 13);
            this.finalCostLabel.TabIndex = 14;
            this.finalCostLabel.Text = "Final Cost of Ring";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.finalCostLabel);
            this.groupBox1.Controls.Add(this.diamondsLabel);
            this.groupBox1.Controls.Add(this.goldLabel);
            this.groupBox1.Controls.Add(this.goldCostLabel);
            this.groupBox1.Controls.Add(this.diamondCostLabel);
            this.groupBox1.Controls.Add(this.goldTextBox);
            this.groupBox1.Controls.Add(this.diamondTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 441);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jewelry Calculator";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(645, 575);
            this.Controls.Add(this.baseCostLabel);
            this.Controls.Add(this.finalCostTextBox);
            this.Controls.Add(this.baseCostTextBox);
            this.Controls.Add(this.goldCostTextBox);
            this.Controls.Add(this.diamondCostTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.claculateButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jewelery Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button claculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox diamondTextBox;
        private System.Windows.Forms.TextBox diamondCostTextBox;
        private System.Windows.Forms.TextBox goldTextBox;
        private System.Windows.Forms.TextBox goldCostTextBox;
        private System.Windows.Forms.TextBox baseCostTextBox;
        private System.Windows.Forms.TextBox finalCostTextBox;
        private System.Windows.Forms.Label diamondsLabel;
        private System.Windows.Forms.Label goldLabel;
        private System.Windows.Forms.Label diamondCostLabel;
        private System.Windows.Forms.Label goldCostLabel;
        private System.Windows.Forms.Label baseCostLabel;
        private System.Windows.Forms.Label finalCostLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

