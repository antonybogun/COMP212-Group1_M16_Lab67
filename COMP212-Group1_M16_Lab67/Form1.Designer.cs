namespace COMP212_Group1_M16_Lab67
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLives = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score:";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(596, 15);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(100, 20);
            this.txtScore.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lives:";
            // 
            // txtLives
            // 
            this.txtLives.Location = new System.Drawing.Point(596, 41);
            this.txtLives.Name = "txtLives";
            this.txtLives.ReadOnly = true;
            this.txtLives.Size = new System.Drawing.Size(100, 20);
            this.txtLives.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Message:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(545, 90);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(150, 150);
            this.txtMessage.TabIndex = 1;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(545, 246);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(151, 140);
            this.btnPlayAgain.TabIndex = 0;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(545, 394);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(150, 140);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = "Start the Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(10, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(520, 529);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtLives);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Guess the Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLives;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

