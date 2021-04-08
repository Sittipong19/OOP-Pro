
namespace oopproject
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuControl11 = new oopproject.MenuControl1();
            this.userControl11 = new oopproject.UserControl1();
            this.beveragesControl11 = new oopproject.BeveragesControl1();
            this.main1 = new oopproject.Main();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Location = new System.Drawing.Point(135, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Main";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MintCream;
            this.button2.Location = new System.Drawing.Point(305, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "User";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MintCream;
            this.button3.Location = new System.Drawing.Point(477, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Beverages";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MintCream;
            this.button4.Location = new System.Drawing.Point(655, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "Menu";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuControl11
            // 
            this.menuControl11.Location = new System.Drawing.Point(-2, 92);
            this.menuControl11.Name = "menuControl11";
            this.menuControl11.Size = new System.Drawing.Size(926, 398);
            this.menuControl11.TabIndex = 7;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(-2, 92);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(926, 398);
            this.userControl11.TabIndex = 6;
            // 
            // beveragesControl11
            // 
            this.beveragesControl11.Location = new System.Drawing.Point(-2, 92);
            this.beveragesControl11.Name = "beveragesControl11";
            this.beveragesControl11.Size = new System.Drawing.Size(926, 398);
            this.beveragesControl11.TabIndex = 4;
            // 
            // main1
            // 
            this.main1.Location = new System.Drawing.Point(-2, 92);
            this.main1.Name = "main1";
            this.main1.Size = new System.Drawing.Size(926, 398);
            this.main1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(924, 483);
            this.Controls.Add(this.main1);
            this.Controls.Add(this.menuControl11);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.beveragesControl11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private BeveragesControl1 beveragesControl11;
        private UserControl1 userControl11;
        private MenuControl1 menuControl11;
        private Main main1;
    }
}

