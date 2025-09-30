namespace campsite
{
    partial class prefcamp
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
            this.buttonlakecamp = new System.Windows.Forms.Button();
            this.buttonhillside = new System.Windows.Forms.Button();
            this.buttonbeachside = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonlakecamp
            // 
            this.buttonlakecamp.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonlakecamp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonlakecamp.Image = global::campsite.Properties.Resources.lakeside;
            this.buttonlakecamp.Location = new System.Drawing.Point(0, 0);
            this.buttonlakecamp.Name = "buttonlakecamp";
            this.buttonlakecamp.Size = new System.Drawing.Size(275, 450);
            this.buttonlakecamp.TabIndex = 0;
            this.buttonlakecamp.Text = "Lakeshore Camps";
            this.buttonlakecamp.UseVisualStyleBackColor = true;
            this.buttonlakecamp.Click += new System.EventHandler(this.buttonlakecamp_Click);
            // 
            // buttonhillside
            // 
            this.buttonhillside.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonhillside.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonhillside.Image = global::campsite.Properties.Resources.mountainffffff;
            this.buttonhillside.Location = new System.Drawing.Point(272, 0);
            this.buttonhillside.Name = "buttonhillside";
            this.buttonhillside.Size = new System.Drawing.Size(284, 450);
            this.buttonhillside.TabIndex = 1;
            this.buttonhillside.Text = " hillside camps";
            this.buttonhillside.UseVisualStyleBackColor = true;
            this.buttonhillside.Click += new System.EventHandler(this.buttonhillside_Click);
            // 
            // buttonbeachside
            // 
            this.buttonbeachside.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonbeachside.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonbeachside.Image = global::campsite.Properties.Resources.beachsideffff;
            this.buttonbeachside.Location = new System.Drawing.Point(539, 0);
            this.buttonbeachside.Name = "buttonbeachside";
            this.buttonbeachside.Size = new System.Drawing.Size(262, 450);
            this.buttonbeachside.TabIndex = 2;
            this.buttonbeachside.Text = "Beachside camps";
            this.buttonbeachside.UseVisualStyleBackColor = true;
            this.buttonbeachside.Click += new System.EventHandler(this.buttonbeachside_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Go Back 🚪";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prefcamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonbeachside);
            this.Controls.Add(this.buttonhillside);
            this.Controls.Add(this.buttonlakecamp);
            this.Name = "prefcamp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "preferedcamp";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonlakecamp;
        private Button buttonhillside;
        private Button buttonbeachside;
        private Button button1;
    }
}