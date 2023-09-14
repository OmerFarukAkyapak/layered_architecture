
namespace barn_case.Forms
{
    partial class FormBarnDetail
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
            this.pnlBarnDetail = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlBarnDetail
            // 
            this.pnlBarnDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBarnDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlBarnDetail.Name = "pnlBarnDetail";
            this.pnlBarnDetail.Size = new System.Drawing.Size(995, 609);
            this.pnlBarnDetail.TabIndex = 0;
            // 
            // FormBarnDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(995, 609);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBarnDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBarnDetail";
            this.Text = "FormBarnDetail";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarnDetail;
    }
}