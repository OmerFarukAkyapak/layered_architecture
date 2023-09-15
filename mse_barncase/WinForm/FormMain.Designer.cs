
namespace WinForm
{
    partial class FormMain
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTab = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnBarnDetails = new System.Windows.Forms.Button();
            this.btnProductPage = new System.Windows.Forms.Button();
            this.btnAnimalPage = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTab.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlTab);
            this.pnlMain.Controls.Add(this.pnlMenu);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1184, 761);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlTab
            // 
            this.pnlTab.Controls.Add(this.tabControl1);
            this.pnlTab.Location = new System.Drawing.Point(218, 74);
            this.pnlTab.Name = "pnlTab";
            this.pnlTab.Size = new System.Drawing.Size(954, 675);
            this.pnlTab.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 675);
            this.tabControl1.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnBarnDetails);
            this.pnlMenu.Controls.Add(this.btnProductPage);
            this.pnlMenu.Controls.Add(this.btnAnimalPage);
            this.pnlMenu.Controls.Add(this.btnHomePage);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Location = new System.Drawing.Point(12, 74);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 675);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnBarnDetails
            // 
            this.btnBarnDetails.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBarnDetails.Location = new System.Drawing.Point(31, 481);
            this.btnBarnDetails.Name = "btnBarnDetails";
            this.btnBarnDetails.Size = new System.Drawing.Size(135, 72);
            this.btnBarnDetails.TabIndex = 5;
            this.btnBarnDetails.Text = "Barn Details";
            this.btnBarnDetails.UseVisualStyleBackColor = true;
            this.btnBarnDetails.Click += new System.EventHandler(this.btnBarnDetails_Click);
            // 
            // btnProductPage
            // 
            this.btnProductPage.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductPage.Location = new System.Drawing.Point(31, 358);
            this.btnProductPage.Name = "btnProductPage";
            this.btnProductPage.Size = new System.Drawing.Size(135, 72);
            this.btnProductPage.TabIndex = 4;
            this.btnProductPage.Text = "Product Page";
            this.btnProductPage.UseVisualStyleBackColor = true;
            this.btnProductPage.Click += new System.EventHandler(this.btnProductPage_Click);
            // 
            // btnAnimalPage
            // 
            this.btnAnimalPage.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnimalPage.Location = new System.Drawing.Point(31, 243);
            this.btnAnimalPage.Name = "btnAnimalPage";
            this.btnAnimalPage.Size = new System.Drawing.Size(135, 72);
            this.btnAnimalPage.TabIndex = 3;
            this.btnAnimalPage.Text = "Animal Page";
            this.btnAnimalPage.UseVisualStyleBackColor = true;
            this.btnAnimalPage.Click += new System.EventHandler(this.btnAnimalPage_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHomePage.Location = new System.Drawing.Point(31, 136);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(135, 72);
            this.btnHomePage.TabIndex = 2;
            this.btnHomePage.Text = "Home Page";
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(56, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "MENU";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1160, 56);
            this.pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(452, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "FARM MANAGEMENT SYSTEM";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlMain.ResumeLayout(false);
            this.pnlTab.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnBarnDetails;
        private System.Windows.Forms.Button btnProductPage;
        private System.Windows.Forms.Button btnAnimalPage;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

