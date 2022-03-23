
namespace CSForms
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.LaunchConsoleButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LaunchConsoleButton
            // 
            this.LaunchConsoleButton.AccessibleName = "";
            this.LaunchConsoleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LaunchConsoleButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchConsoleButton.Location = new System.Drawing.Point(432, 183);
            this.LaunchConsoleButton.Name = "LaunchConsoleButton";
            this.LaunchConsoleButton.Size = new System.Drawing.Size(105, 50);
            this.LaunchConsoleButton.TabIndex = 0;
            this.LaunchConsoleButton.Text = "Console";
            this.LaunchConsoleButton.UseVisualStyleBackColor = true;
            this.LaunchConsoleButton.Click += new System.EventHandler(this.LaunchConsoleButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.DisabledLinkColor = System.Drawing.Color.Black;
            this.Title.Font = new System.Drawing.Font("Franklin Gothic Heavy", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.LinkColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(335, 32);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(302, 61);
            this.Title.TabIndex = 1;
            this.Title.TabStop = true;
            this.Title.Text = "Presto Suite";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.VisitedLinkColor = System.Drawing.Color.Black;
            this.Title.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Title_LinkClicked);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 543);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.LaunchConsoleButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LaunchConsoleButton;
        private System.Windows.Forms.LinkLabel Title;
    }
}

