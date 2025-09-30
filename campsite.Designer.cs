namespace campsite
{
    partial class campsite
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
            this.buttonLogin2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttongoback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogin2
            // 
            this.buttonLogin2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin2.Image = global::campsite.Properties.Resources.pref;
            this.buttonLogin2.Location = new System.Drawing.Point(458, -5);
            this.buttonLogin2.Name = "buttonLogin2";
            this.buttonLogin2.Size = new System.Drawing.Size(467, 464);
            this.buttonLogin2.TabIndex = 7;
            this.buttonLogin2.Text = "Camping sites according to preference";
            this.buttonLogin2.UseVisualStyleBackColor = true;
            this.buttonLogin2.Click += new System.EventHandler(this.buttonLogin2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::campsite.Properties.Resources.trending_f;
            this.button1.Location = new System.Drawing.Point(0, -5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(465, 464);
            this.button1.TabIndex = 8;
            this.button1.Text = "trending  Camping sites right now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttongoback
            // 
            this.buttongoback.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttongoback.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttongoback.Location = new System.Drawing.Point(397, 395);
            this.buttongoback.Name = "buttongoback";
            this.buttongoback.Size = new System.Drawing.Size(127, 56);
            this.buttongoback.TabIndex = 9;
            this.buttongoback.Text = "go back";
            this.buttongoback.UseVisualStyleBackColor = true;
            this.buttongoback.Click += new System.EventHandler(this.buttongoback_Click);
            // 
            // campsite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(922, 454);
            this.Controls.Add(this.buttongoback);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLogin2);
            this.Name = "campsite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "campsite";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonLogin2;
        private Button button1;
        private Button buttongoback;
    }
}