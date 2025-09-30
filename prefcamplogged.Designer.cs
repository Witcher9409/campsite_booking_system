namespace campsite
{
    partial class prefcamplogged
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prefcamplogged));
            this.buttonlakecamplogged = new System.Windows.Forms.Button();
            this.buttonhillsidelogged = new System.Windows.Forms.Button();
            this.buttonbeachsidelogged = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonlakecamplogged
            // 
            this.buttonlakecamplogged.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonlakecamplogged.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonlakecamplogged.Image = global::campsite.Properties.Resources.lakeside;
            this.buttonlakecamplogged.Location = new System.Drawing.Point(-2, -1);
            this.buttonlakecamplogged.Name = "buttonlakecamplogged";
            this.buttonlakecamplogged.Size = new System.Drawing.Size(275, 450);
            this.buttonlakecamplogged.TabIndex = 1;
            this.buttonlakecamplogged.Text = "Lakeshore Camps";
            this.buttonlakecamplogged.UseVisualStyleBackColor = true;
            this.buttonlakecamplogged.Click += new System.EventHandler(this.buttonlakecamplogged_Click);
            // 
            // buttonhillsidelogged
            // 
            this.buttonhillsidelogged.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonhillsidelogged.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonhillsidelogged.Image = global::campsite.Properties.Resources.mountainffffff;
            this.buttonhillsidelogged.Location = new System.Drawing.Point(269, -1);
            this.buttonhillsidelogged.Name = "buttonhillsidelogged";
            this.buttonhillsidelogged.Size = new System.Drawing.Size(284, 450);
            this.buttonhillsidelogged.TabIndex = 2;
            this.buttonhillsidelogged.Text = " hillside camps";
            this.buttonhillsidelogged.UseVisualStyleBackColor = true;
            this.buttonhillsidelogged.Click += new System.EventHandler(this.buttonhillsidelogged_Click);
            // 
            // buttonbeachsidelogged
            // 
            this.buttonbeachsidelogged.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonbeachsidelogged.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonbeachsidelogged.Image = global::campsite.Properties.Resources.beachsideffff;
            this.buttonbeachsidelogged.Location = new System.Drawing.Point(539, -1);
            this.buttonbeachsidelogged.Name = "buttonbeachsidelogged";
            this.buttonbeachsidelogged.Size = new System.Drawing.Size(262, 450);
            this.buttonbeachsidelogged.TabIndex = 3;
            this.buttonbeachsidelogged.Text = "Beachside camps";
            this.buttonbeachsidelogged.UseVisualStyleBackColor = true;
            this.buttonbeachsidelogged.Click += new System.EventHandler(this.buttonbeachsidelogged_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(-2, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Go Back 🚪";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(371, -1);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(63, 40);
            this.buttonHome.TabIndex = 20;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // prefcamplogged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonbeachsidelogged);
            this.Controls.Add(this.buttonhillsidelogged);
            this.Controls.Add(this.buttonlakecamplogged);
            this.Name = "prefcamplogged";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "prefcamplogged";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonlakecamplogged;
        private Button buttonhillsidelogged;
        private Button buttonbeachsidelogged;
        private Button button1;
        private Button buttonHome;
    }
}