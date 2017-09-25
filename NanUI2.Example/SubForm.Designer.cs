namespace NanUIFirst
{
    partial class SubForm
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
            this.subControl1 = new NanUIFirst.SubControl();
            this.SuspendLayout();
            // 
            // subControl1
            // 
            this.subControl1.BorderColor = System.Drawing.Color.DarkGray;
            this.subControl1.Borderless = true;
            this.subControl1.BorderSize = 1;
            this.subControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subControl1.Location = new System.Drawing.Point(0, 0);
            this.subControl1.Name = "subControl1";
            this.subControl1.NonclientModeDropShadow = true;
            this.subControl1.Resizable = true;
            this.subControl1.Size = new System.Drawing.Size(569, 412);
            this.subControl1.SplashBackColor = System.Drawing.Color.Transparent;
            this.subControl1.SplashImage = null;
            this.subControl1.SplashImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.subControl1.TabIndex = 0;
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 412);
            this.Controls.Add(this.subControl1);
            this.Name = "SubForm";
            this.Text = "SubForm";
            this.Load += new System.EventHandler(this.SubForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SubControl subControl1;


    }
}