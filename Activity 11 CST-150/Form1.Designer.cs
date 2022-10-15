namespace Activity_11_CST_150
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
            this.btnRollDice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picDie2 = new System.Windows.Forms.PictureBox();
            this.picDie1 = new System.Windows.Forms.PictureBox();
            this.rtxStatistics = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRollDice
            // 
            this.btnRollDice.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDice.Location = new System.Drawing.Point(152, 360);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(426, 45);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "ROLL YOUR DICE";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(215, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "DICE ROLLER";
            // 
            // picDie2
            // 
            this.picDie2.BackgroundImage = global::Activity_11_CST_150.Properties.Resources.perspective_dice_six_faces_random;
            this.picDie2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDie2.Location = new System.Drawing.Point(378, 142);
            this.picDie2.Name = "picDie2";
            this.picDie2.Size = new System.Drawing.Size(200, 200);
            this.picDie2.TabIndex = 3;
            this.picDie2.TabStop = false;
            // 
            // picDie1
            // 
            this.picDie1.BackgroundImage = global::Activity_11_CST_150.Properties.Resources.perspective_dice_six_faces_random;
            this.picDie1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDie1.Location = new System.Drawing.Point(152, 142);
            this.picDie1.Name = "picDie1";
            this.picDie1.Size = new System.Drawing.Size(200, 200);
            this.picDie1.TabIndex = 2;
            this.picDie1.TabStop = false;
            // 
            // rtxStatistics
            // 
            this.rtxStatistics.BackColor = System.Drawing.SystemColors.Desktop;
            this.rtxStatistics.ForeColor = System.Drawing.Color.Lime;
            this.rtxStatistics.Location = new System.Drawing.Point(60, 431);
            this.rtxStatistics.Name = "rtxStatistics";
            this.rtxStatistics.Size = new System.Drawing.Size(617, 189);
            this.rtxStatistics.TabIndex = 5;
            this.rtxStatistics.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(774, 671);
            this.Controls.Add(this.rtxStatistics);
            this.Controls.Add(this.picDie2);
            this.Controls.Add(this.picDie1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRollDice);
            this.Name = "Form1";
            this.Text = "Activity 11 - CST-150 - Dice Roller";
            ((System.ComponentModel.ISupportInitialize)(this.picDie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picDie1;
        private System.Windows.Forms.PictureBox picDie2;
        private System.Windows.Forms.RichTextBox rtxStatistics;
    }
}

