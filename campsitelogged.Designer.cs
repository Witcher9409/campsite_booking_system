namespace campsite
{
    partial class campsitelogged
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
            this.buttontrendinglogged = new System.Windows.Forms.Button();
            this.buttonpreflogged = new System.Windows.Forms.Button();
            this.buttongoback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttontrendinglogged
            // 
            this.buttontrendinglogged.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttontrendinglogged.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttontrendinglogged.Image = global::campsite.Properties.Resources.trending_f;
            this.buttontrendinglogged.Location = new System.Drawing.Point(-26, -38);
            this.buttontrendinglogged.Name = "buttontrendinglogged";
            this.buttontrendinglogged.Size = new System.Drawing.Size(465, 509);
            this.buttontrendinglogged.TabIndex = 9;
            this.buttontrendinglogged.Text = "trending  Camping sites right now";
            this.buttontrendinglogged.UseVisualStyleBackColor = true;
            this.buttontrendinglogged.Click += new System.EventHandler(this.buttontrendinglogged_Click);
            // 
            // buttonpreflogged
            // 
            this.buttonpreflogged.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonpreflogged.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonpreflogged.Image = global::campsite.Properties.Resources.pref;
            this.buttonpreflogged.Location = new System.Drawing.Point(435, -38);
            this.buttonpreflogged.Name = "buttonpreflogged";
            this.buttonpreflogged.Size = new System.Drawing.Size(451, 509);
            this.buttonpreflogged.TabIndex = 10;
            this.buttonpreflogged.Text = "Camping sites according to preference";
            this.buttonpreflogged.UseVisualStyleBackColor = true;
            this.buttonpreflogged.Click += new System.EventHandler(this.buttonpreflogged_Click);
            // 
            // buttongoback
            // 
            this.buttongoback.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttongoback.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttongoback.Location = new System.Drawing.Point(371, 415);
            this.buttongoback.Name = "buttongoback";
            this.buttongoback.Size = new System.Drawing.Size(127, 56);
            this.buttongoback.TabIndex = 11;
            this.buttongoback.Text = "go back";
            this.buttongoback.UseVisualStyleBackColor = true;
            this.buttongoback.Click += new System.EventHandler(this.buttongoback_Click);
            // 
            // campsitelogged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 468);
            this.Controls.Add(this.buttongoback);
            this.Controls.Add(this.buttonpreflogged);
            this.Controls.Add(this.buttontrendinglogged);
            this.Name = "campsitelogged";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "campsitelogged";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttontrendinglogged;
        private Button buttonpreflogged;
        private Button buttongoback;
    }
}