namespace RockPaperScissors
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
            this.paperBtn = new System.Windows.Forms.Button();
            this.ProgramAnswerTxt = new System.Windows.Forms.TextBox();
            this.ResultTxt = new System.Windows.Forms.TextBox();
            this.rockBtn = new System.Windows.Forms.Button();
            this.scissorsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paperBtn
            // 
            this.paperBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paperBtn.ForeColor = System.Drawing.Color.Green;
            this.paperBtn.Location = new System.Drawing.Point(280, 153);
            this.paperBtn.Name = "paperBtn";
            this.paperBtn.Size = new System.Drawing.Size(235, 58);
            this.paperBtn.TabIndex = 1;
            this.paperBtn.Text = "PAPER";
            this.paperBtn.UseVisualStyleBackColor = true;
            this.paperBtn.Click += new System.EventHandler(this.PaperBtn_Click);
            // 
            // ProgramAnswerTxt
            // 
            this.ProgramAnswerTxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ProgramAnswerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramAnswerTxt.ForeColor = System.Drawing.Color.Red;
            this.ProgramAnswerTxt.HideSelection = false;
            this.ProgramAnswerTxt.Location = new System.Drawing.Point(280, 50);
            this.ProgramAnswerTxt.Name = "ProgramAnswerTxt";
            this.ProgramAnswerTxt.ReadOnly = true;
            this.ProgramAnswerTxt.Size = new System.Drawing.Size(235, 47);
            this.ProgramAnswerTxt.TabIndex = 0;
            this.ProgramAnswerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResultTxt
            // 
            this.ResultTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTxt.Location = new System.Drawing.Point(205, 286);
            this.ResultTxt.Name = "ResultTxt";
            this.ResultTxt.ReadOnly = true;
            this.ResultTxt.Size = new System.Drawing.Size(379, 80);
            this.ResultTxt.TabIndex = 2;
            this.ResultTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rockBtn
            // 
            this.rockBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockBtn.ForeColor = System.Drawing.Color.Green;
            this.rockBtn.Location = new System.Drawing.Point(39, 153);
            this.rockBtn.Name = "rockBtn";
            this.rockBtn.Size = new System.Drawing.Size(235, 58);
            this.rockBtn.TabIndex = 3;
            this.rockBtn.Text = "ROCK";
            this.rockBtn.UseVisualStyleBackColor = true;
            this.rockBtn.Click += new System.EventHandler(this.RockBtn_Click);
            // 
            // scissorsBtn
            // 
            this.scissorsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scissorsBtn.ForeColor = System.Drawing.Color.Green;
            this.scissorsBtn.Location = new System.Drawing.Point(521, 153);
            this.scissorsBtn.Name = "scissorsBtn";
            this.scissorsBtn.Size = new System.Drawing.Size(235, 58);
            this.scissorsBtn.TabIndex = 4;
            this.scissorsBtn.Text = "SCISSORS";
            this.scissorsBtn.UseVisualStyleBackColor = true;
            this.scissorsBtn.Click += new System.EventHandler(this.ScissorsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scissorsBtn);
            this.Controls.Add(this.rockBtn);
            this.Controls.Add(this.ResultTxt);
            this.Controls.Add(this.paperBtn);
            this.Controls.Add(this.ProgramAnswerTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button paperBtn;
        private System.Windows.Forms.TextBox ProgramAnswerTxt;
        private System.Windows.Forms.TextBox ResultTxt;
        private System.Windows.Forms.Button rockBtn;
        private System.Windows.Forms.Button scissorsBtn;
    }
}

