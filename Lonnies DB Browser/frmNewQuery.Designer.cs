namespace Lonnies_DB_Browser
{
    partial class frmNewQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewQuery));
            this.txtQRY = new System.Windows.Forms.TextBox();
            this.BtnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQRY
            // 
            this.txtQRY.Location = new System.Drawing.Point(12, 12);
            this.txtQRY.Multiline = true;
            this.txtQRY.Name = "txtQRY";
            this.txtQRY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQRY.Size = new System.Drawing.Size(524, 332);
            this.txtQRY.TabIndex = 18;
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(461, 350);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 19;
            this.BtnNext.Text = "Next >>";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // frmNewQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 390);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.txtQRY);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewQuery";
            this.Text = "frmNewQuery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQRY;
        private System.Windows.Forms.Button BtnNext;
    }
}