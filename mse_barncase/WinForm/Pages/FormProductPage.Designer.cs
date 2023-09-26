
namespace WinForm.Pages
{
    partial class FormProductPage
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
            this.components = new System.ComponentModel.Container();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtProductAomunt = new System.Windows.Forms.TextBox();
            this.txtSellProduct = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridProductList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSelectedID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlProduct.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProduct
            // 
            this.pnlProduct.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlProduct.Controls.Add(this.panel2);
            this.pnlProduct.Controls.Add(this.panel1);
            this.pnlProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProduct.Location = new System.Drawing.Point(0, 0);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(954, 678);
            this.pnlProduct.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSelectedID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.picRefresh);
            this.panel2.Controls.Add(this.txtCurrent);
            this.panel2.Controls.Add(this.txtProductAomunt);
            this.panel2.Controls.Add(this.txtSellProduct);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnSell);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(549, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 654);
            this.panel2.TabIndex = 1;
            // 
            // picRefresh
            // 
            this.picRefresh.Image = global::WinForm.Properties.Resources.refresh;
            this.picRefresh.Location = new System.Drawing.Point(346, 1);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(43, 40);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRefresh.TabIndex = 29;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // txtCurrent
            // 
            this.txtCurrent.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.txtCurrent.Location = new System.Drawing.Point(75, 502);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.ReadOnly = true;
            this.txtCurrent.Size = new System.Drawing.Size(171, 36);
            this.txtCurrent.TabIndex = 28;
            // 
            // txtProductAomunt
            // 
            this.txtProductAomunt.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.txtProductAomunt.Location = new System.Drawing.Point(86, 304);
            this.txtProductAomunt.Name = "txtProductAomunt";
            this.txtProductAomunt.ReadOnly = true;
            this.txtProductAomunt.Size = new System.Drawing.Size(171, 36);
            this.txtProductAomunt.TabIndex = 27;
            // 
            // txtSellProduct
            // 
            this.txtSellProduct.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.txtSellProduct.Location = new System.Drawing.Point(86, 209);
            this.txtSellProduct.Name = "txtSellProduct";
            this.txtSellProduct.ReadOnly = true;
            this.txtSellProduct.Size = new System.Drawing.Size(171, 36);
            this.txtSellProduct.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(71, 463);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 23);
            this.label10.TabIndex = 21;
            this.label10.Text = "CURRENT BALANCE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(82, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "Price:";
            // 
            // btnSell
            // 
            this.btnSell.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSell.Location = new System.Drawing.Point(86, 387);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(135, 37);
            this.btnSell.TabIndex = 23;
            this.btnSell.Text = "SELL";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(82, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Selected Product:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(81, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "SELL PRODUCT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 654);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridProductList);
            this.panel3.Location = new System.Drawing.Point(13, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(515, 566);
            this.panel3.TabIndex = 6;
            // 
            // dataGridProductList
            // 
            this.dataGridProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProductList.Location = new System.Drawing.Point(0, 0);
            this.dataGridProductList.MainView = this.gridView1;
            this.dataGridProductList.Name = "dataGridProductList";
            this.dataGridProductList.Size = new System.Drawing.Size(515, 566);
            this.dataGridProductList.TabIndex = 7;
            this.dataGridProductList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dataGridProductList;
            this.gridView1.GroupPanelText = " ";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "PRODUCTS LIST";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 26);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // txtSelectedID
            // 
            this.txtSelectedID.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.txtSelectedID.Location = new System.Drawing.Point(86, 125);
            this.txtSelectedID.Name = "txtSelectedID";
            this.txtSelectedID.ReadOnly = true;
            this.txtSelectedID.Size = new System.Drawing.Size(171, 36);
            this.txtSelectedID.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(82, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Selected ProductID:";
            // 
            // FormProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 678);
            this.Controls.Add(this.pnlProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductPage";
            this.Text = "FormProductPage";
            this.pnlProduct.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl dataGridProductList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtProductAomunt;
        private System.Windows.Forms.TextBox txtSellProduct;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.TextBox txtSelectedID;
        private System.Windows.Forms.Label label4;
    }
}