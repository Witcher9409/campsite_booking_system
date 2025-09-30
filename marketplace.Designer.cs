namespace campsite
{
    partial class marketplace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(marketplace));
            this.buttonCampingequipments = new System.Windows.Forms.Button();
            this.buttonUtilities = new System.Windows.Forms.Button();
            this.buttonFirstaid = new System.Windows.Forms.Button();
            this.buttongoback = new System.Windows.Forms.Button();
            this.buttonFooditems = new System.Windows.Forms.Button();
            this.buttoncartmarket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCampingequipments
            // 
            this.buttonCampingequipments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCampingequipments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCampingequipments.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCampingequipments.ForeColor = System.Drawing.Color.Black;
            this.buttonCampingequipments.Image = ((System.Drawing.Image)(resources.GetObject("buttonCampingequipments.Image")));
            this.buttonCampingequipments.Location = new System.Drawing.Point(396, -16);
            this.buttonCampingequipments.Name = "buttonCampingequipments";
            this.buttonCampingequipments.Size = new System.Drawing.Size(409, 238);
            this.buttonCampingequipments.TabIndex = 1;
            this.buttonCampingequipments.Text = "Camp Equipments";
            this.buttonCampingequipments.UseVisualStyleBackColor = true;
            this.buttonCampingequipments.Click += new System.EventHandler(this.buttonCampingequipments_Click);
            // 
            // buttonUtilities
            // 
            this.buttonUtilities.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUtilities.ForeColor = System.Drawing.Color.Black;
            this.buttonUtilities.Image = ((System.Drawing.Image)(resources.GetObject("buttonUtilities.Image")));
            this.buttonUtilities.Location = new System.Drawing.Point(-2, 221);
            this.buttonUtilities.Name = "buttonUtilities";
            this.buttonUtilities.Size = new System.Drawing.Size(401, 235);
            this.buttonUtilities.TabIndex = 2;
            this.buttonUtilities.Text = "Utilities";
            this.buttonUtilities.UseVisualStyleBackColor = true;
            this.buttonUtilities.Click += new System.EventHandler(this.buttonUtilities_Click);
            // 
            // buttonFirstaid
            // 
            this.buttonFirstaid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFirstaid.Image = ((System.Drawing.Image)(resources.GetObject("buttonFirstaid.Image")));
            this.buttonFirstaid.Location = new System.Drawing.Point(396, 219);
            this.buttonFirstaid.Name = "buttonFirstaid";
            this.buttonFirstaid.Size = new System.Drawing.Size(409, 237);
            this.buttonFirstaid.TabIndex = 3;
            this.buttonFirstaid.Text = "First Aid";
            this.buttonFirstaid.UseVisualStyleBackColor = true;
            this.buttonFirstaid.Click += new System.EventHandler(this.buttonFirstaid_Click);
            // 
            // buttongoback
            // 
            this.buttongoback.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttongoback.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttongoback.Location = new System.Drawing.Point(12, 3);
            this.buttongoback.Name = "buttongoback";
            this.buttongoback.Size = new System.Drawing.Size(108, 38);
            this.buttongoback.TabIndex = 35;
            this.buttongoback.Text = "Go Back";
            this.buttongoback.UseVisualStyleBackColor = true;
            this.buttongoback.Click += new System.EventHandler(this.buttongoback_Click);
            // 
            // buttonFooditems
            // 
            this.buttonFooditems.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFooditems.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonFooditems.Image = ((System.Drawing.Image)(resources.GetObject("buttonFooditems.Image")));
            this.buttonFooditems.Location = new System.Drawing.Point(-2, -16);
            this.buttonFooditems.Name = "buttonFooditems";
            this.buttonFooditems.Size = new System.Drawing.Size(401, 238);
            this.buttonFooditems.TabIndex = 0;
            this.buttonFooditems.Text = "Food and Beverages";
            this.buttonFooditems.UseVisualStyleBackColor = true;
            this.buttonFooditems.Click += new System.EventHandler(this.buttonFooditems_Click);
            // 
            // buttoncartmarket
            // 
            this.buttoncartmarket.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttoncartmarket.Location = new System.Drawing.Point(670, 3);
            this.buttoncartmarket.Name = "buttoncartmarket";
            this.buttoncartmarket.Size = new System.Drawing.Size(118, 29);
            this.buttoncartmarket.TabIndex = 36;
            this.buttoncartmarket.Text = "My Cart🛒";
            this.buttoncartmarket.UseVisualStyleBackColor = true;
            this.buttoncartmarket.Click += new System.EventHandler(this.buttoncartmarket_Click);
            // 
            // marketplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttoncartmarket);
            this.Controls.Add(this.buttongoback);
            this.Controls.Add(this.buttonFirstaid);
            this.Controls.Add(this.buttonUtilities);
            this.Controls.Add(this.buttonCampingequipments);
            this.Controls.Add(this.buttonFooditems);
            this.Name = "marketplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "marketplace";
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonCampingequipments;
        private Button buttonUtilities;
        private Button buttonFirstaid;
        private Button buttongoback;
        private Button buttonFooditems;
        private Button buttoncartmarket;
    }
}