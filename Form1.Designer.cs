namespace Magic8Ball
{
    partial class FormMagic8Ball
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMagic8Ball));
            this.buttonSubmitQuestion = new System.Windows.Forms.Button();
            this.buttonResetForm = new System.Windows.Forms.Button();
            this.buttonExitApplication = new System.Windows.Forms.Button();
            this.textBoxAskQusestion = new System.Windows.Forms.TextBox();
            this.pictureBoxMagic8Ball = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.submitQuestionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetFormMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagic8Ball)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSubmitQuestion
            // 
            this.buttonSubmitQuestion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSubmitQuestion.Location = new System.Drawing.Point(111, 449);
            this.buttonSubmitQuestion.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSubmitQuestion.Name = "buttonSubmitQuestion";
            this.buttonSubmitQuestion.Size = new System.Drawing.Size(205, 108);
            this.buttonSubmitQuestion.TabIndex = 1;
            this.buttonSubmitQuestion.Text = "Submit Question";
            this.buttonSubmitQuestion.UseVisualStyleBackColor = true;
            this.buttonSubmitQuestion.Click += new System.EventHandler(this.buttonSubmitQuestion_Click);
            // 
            // buttonResetForm
            // 
            this.buttonResetForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonResetForm.Location = new System.Drawing.Point(441, 449);
            this.buttonResetForm.Margin = new System.Windows.Forms.Padding(5);
            this.buttonResetForm.Name = "buttonResetForm";
            this.buttonResetForm.Size = new System.Drawing.Size(205, 108);
            this.buttonResetForm.TabIndex = 2;
            this.buttonResetForm.Text = "Reset Form";
            this.buttonResetForm.UseVisualStyleBackColor = true;
            this.buttonResetForm.Click += new System.EventHandler(this.buttonResetForm_Click);
            // 
            // buttonExitApplication
            // 
            this.buttonExitApplication.Location = new System.Drawing.Point(784, 449);
            this.buttonExitApplication.Margin = new System.Windows.Forms.Padding(5);
            this.buttonExitApplication.Name = "buttonExitApplication";
            this.buttonExitApplication.Size = new System.Drawing.Size(205, 108);
            this.buttonExitApplication.TabIndex = 3;
            this.buttonExitApplication.Text = "Exit Application";
            this.buttonExitApplication.UseVisualStyleBackColor = true;
            this.buttonExitApplication.Click += new System.EventHandler(this.buttonExitApplication_Click);
            // 
            // textBoxAskQusestion
            // 
            this.textBoxAskQusestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxAskQusestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAskQusestion.Location = new System.Drawing.Point(117, 275);
            this.textBoxAskQusestion.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAskQusestion.Multiline = true;
            this.textBoxAskQusestion.Name = "textBoxAskQusestion";
            this.textBoxAskQusestion.Size = new System.Drawing.Size(876, 99);
            this.textBoxAskQusestion.TabIndex = 0;
            // 
            // pictureBoxMagic8Ball
            // 
            this.pictureBoxMagic8Ball.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMagic8Ball.Image")));
            this.pictureBoxMagic8Ball.Location = new System.Drawing.Point(427, 41);
            this.pictureBoxMagic8Ball.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxMagic8Ball.Name = "pictureBoxMagic8Ball";
            this.pictureBoxMagic8Ball.Size = new System.Drawing.Size(249, 203);
            this.pictureBoxMagic8Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMagic8Ball.TabIndex = 4;
            this.pictureBoxMagic8Ball.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submitQuestionMenuItem,
            this.resetFormMenuItem,
            this.exitMenuItem,
            this.helpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1125, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // submitQuestionMenuItem
            // 
            this.submitQuestionMenuItem.Name = "submitQuestionMenuItem";
            this.submitQuestionMenuItem.Size = new System.Drawing.Size(108, 19);
            this.submitQuestionMenuItem.Text = "Submit Question";
            this.submitQuestionMenuItem.Click += new System.EventHandler(this.submitQuestionMenuItem_Click);
            // 
            // resetFormMenuItem
            // 
            this.resetFormMenuItem.Name = "resetFormMenuItem";
            this.resetFormMenuItem.Size = new System.Drawing.Size(78, 19);
            this.resetFormMenuItem.Text = "Reset Form";
            this.resetFormMenuItem.Click += new System.EventHandler(this.resetFormMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(37, 19);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpMenuItem.Text = "Help";
            this.helpMenuItem.Click += new System.EventHandler(this.helpMenuItem_Click);
            // 
            // FormMagic8Ball
            // 
            this.AcceptButton = this.buttonSubmitQuestion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonResetForm;
            this.ClientSize = new System.Drawing.Size(1125, 918);
            this.Controls.Add(this.pictureBoxMagic8Ball);
            this.Controls.Add(this.textBoxAskQusestion);
            this.Controls.Add(this.buttonExitApplication);
            this.Controls.Add(this.buttonResetForm);
            this.Controls.Add(this.buttonSubmitQuestion);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMagic8Ball";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Magic 8 Ball - Sees All Knows All Tells All";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagic8Ball)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmitQuestion;
        private System.Windows.Forms.Button buttonResetForm;
        private System.Windows.Forms.Button buttonExitApplication;
        private System.Windows.Forms.TextBox textBoxAskQusestion;
        private System.Windows.Forms.PictureBox pictureBoxMagic8Ball;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem submitQuestionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetFormMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
    }
}

