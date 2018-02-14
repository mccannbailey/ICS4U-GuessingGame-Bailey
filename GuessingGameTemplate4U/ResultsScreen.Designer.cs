namespace GuessingGameTemplate4U
{
    partial class ResultsScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultLabel = new System.Windows.Forms.Label();
            this.guessnumLabel = new System.Windows.Forms.Label();
            this.guesslistLabel = new System.Windows.Forms.Label();
            this.sortedLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.White;
            this.resultLabel.Location = new System.Drawing.Point(130, 44);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(61, 20);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "Result";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guessnumLabel
            // 
            this.guessnumLabel.AutoSize = true;
            this.guessnumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessnumLabel.ForeColor = System.Drawing.Color.White;
            this.guessnumLabel.Location = new System.Drawing.Point(46, 98);
            this.guessnumLabel.Name = "guessnumLabel";
            this.guessnumLabel.Size = new System.Drawing.Size(84, 16);
            this.guessnumLabel.TabIndex = 1;
            this.guessnumLabel.Text = "# of guesses";
            // 
            // guesslistLabel
            // 
            this.guesslistLabel.AutoSize = true;
            this.guesslistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guesslistLabel.ForeColor = System.Drawing.Color.White;
            this.guesslistLabel.Location = new System.Drawing.Point(46, 146);
            this.guesslistLabel.Name = "guesslistLabel";
            this.guesslistLabel.Size = new System.Drawing.Size(64, 16);
            this.guesslistLabel.TabIndex = 2;
            this.guesslistLabel.Text = "guess list";
            // 
            // sortedLabel
            // 
            this.sortedLabel.AutoSize = true;
            this.sortedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortedLabel.ForeColor = System.Drawing.Color.White;
            this.sortedLabel.Location = new System.Drawing.Point(46, 194);
            this.sortedLabel.Name = "sortedLabel";
            this.sortedLabel.Size = new System.Drawing.Size(101, 16);
            this.sortedLabel.TabIndex = 3;
            this.sortedLabel.Text = "guesses sorted";
            // 
            // playButton
            // 
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(49, 263);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Play Again!";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.sortedLabel);
            this.Controls.Add(this.guesslistLabel);
            this.Controls.Add(this.guessnumLabel);
            this.Controls.Add(this.resultLabel);
            this.Name = "ResultsScreen";
            this.Size = new System.Drawing.Size(300, 300);
            this.Load += new System.EventHandler(this.ResultsScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label guessnumLabel;
        private System.Windows.Forms.Label guesslistLabel;
        private System.Windows.Forms.Label sortedLabel;
        private System.Windows.Forms.Button playButton;
    }
}
