namespace FootballMathces
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
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.tbHomeTeam = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddMatchResult = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAwayTeam = new System.Windows.Forms.TextBox();
            this.tbHomeScore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHomeTeam
            // 
            this.lblHomeTeam.AutoSize = true;
            this.lblHomeTeam.Location = new System.Drawing.Point(30, 70);
            this.lblHomeTeam.Name = "lblHomeTeam";
            this.lblHomeTeam.Size = new System.Drawing.Size(96, 20);
            this.lblHomeTeam.TabIndex = 0;
            this.lblHomeTeam.Text = "Home Team";
            // 
            // tbHomeTeam
            // 
            this.tbHomeTeam.Location = new System.Drawing.Point(34, 93);
            this.tbHomeTeam.Name = "tbHomeTeam";
            this.tbHomeTeam.Size = new System.Drawing.Size(100, 26);
            this.tbHomeTeam.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(176, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(551, 344);
            this.listBox1.TabIndex = 2;
            // 
            // btnAddMatchResult
            // 
            this.btnAddMatchResult.Location = new System.Drawing.Point(12, 363);
            this.btnAddMatchResult.Name = "btnAddMatchResult";
            this.btnAddMatchResult.Size = new System.Drawing.Size(140, 56);
            this.btnAddMatchResult.TabIndex = 3;
            this.btnAddMatchResult.Text = "Add Match";
            this.btnAddMatchResult.UseVisualStyleBackColor = true;
            this.btnAddMatchResult.Click += new System.EventHandler(this.btnAddMatchResult_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "AwayTeam";
            // 
            // tbAwayTeam
            // 
            this.tbAwayTeam.Location = new System.Drawing.Point(34, 164);
            this.tbAwayTeam.Name = "tbAwayTeam";
            this.tbAwayTeam.Size = new System.Drawing.Size(100, 26);
            this.tbAwayTeam.TabIndex = 5;
            // 
            // tbHomeScore
            // 
            this.tbHomeScore.Location = new System.Drawing.Point(34, 238);
            this.tbHomeScore.Name = "tbHomeScore";
            this.tbHomeScore.Size = new System.Drawing.Size(100, 26);
            this.tbHomeScore.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "HomeScore";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(773, 83);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 26);
            this.textBox4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(769, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Team Name";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(750, 155);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(180, 127);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "AwayScore";

            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 316);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "Matches :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 486);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.tbHomeScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAwayTeam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddMatchResult);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbHomeTeam);
            this.Controls.Add(this.lblHomeTeam);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHomeTeam;
        private System.Windows.Forms.TextBox tbHomeTeam;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAddMatchResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAwayTeam;
        private System.Windows.Forms.TextBox tbHomeScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}

