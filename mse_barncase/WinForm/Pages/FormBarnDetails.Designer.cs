
namespace WinForm.Pages
{
    partial class FormBarnDetails
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chartProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlGridProduct = new System.Windows.Forms.Panel();
            this.dataGridProductList = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnimalWorth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductWorth = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartAnimal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlGridAnimal = new System.Windows.Forms.Panel();
            this.dataGridAnimalList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.contextAnimal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextProduct = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).BeginInit();
            this.pnlGridProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnimal)).BeginInit();
            this.pnlGridAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnimalList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextAnimal.SuspendLayout();
            this.contextProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 678);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chartProduct);
            this.panel4.Controls.Add(this.pnlGridProduct);
            this.panel4.Controls.Add(this.picRefresh);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(478, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(464, 548);
            this.panel4.TabIndex = 1;
            // 
            // chartProduct
            // 
            chartArea9.Name = "ChartArea1";
            this.chartProduct.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartProduct.Legends.Add(legend9);
            this.chartProduct.Location = new System.Drawing.Point(18, 293);
            this.chartProduct.Name = "chartProduct";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Product Is Sold";
            this.chartProduct.Series.Add(series9);
            this.chartProduct.Size = new System.Drawing.Size(435, 243);
            this.chartProduct.TabIndex = 30;
            this.chartProduct.Text = "chart2";
            title9.Name = "Title1";
            title9.Text = "Products Chart";
            this.chartProduct.Titles.Add(title9);
            // 
            // pnlGridProduct
            // 
            this.pnlGridProduct.Controls.Add(this.dataGridProductList);
            this.pnlGridProduct.Location = new System.Drawing.Point(18, 42);
            this.pnlGridProduct.Name = "pnlGridProduct";
            this.pnlGridProduct.Size = new System.Drawing.Size(435, 234);
            this.pnlGridProduct.TabIndex = 29;
            // 
            // dataGridProductList
            // 
            this.dataGridProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProductList.Location = new System.Drawing.Point(0, 0);
            this.dataGridProductList.MainView = this.gridView2;
            this.dataGridProductList.Name = "dataGridProductList";
            this.dataGridProductList.Size = new System.Drawing.Size(435, 234);
            this.dataGridProductList.TabIndex = 8;
            this.dataGridProductList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.dataGridProductList;
            this.gridView2.GroupPanelText = " ";
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView2_MouseUp);
            // 
            // picRefresh
            // 
            this.picRefresh.Image = global::WinForm.Properties.Resources.refresh;
            this.picRefresh.Location = new System.Drawing.Point(419, 2);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(43, 40);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRefresh.TabIndex = 28;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "PRODUCTS LIST";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtAnimalWorth);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtProductWorth);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtCurrent);
            this.panel3.Location = new System.Drawing.Point(12, 556);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(930, 100);
            this.panel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(74, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "ANIMALS WORTH";
            // 
            // txtAnimalWorth
            // 
            this.txtAnimalWorth.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.txtAnimalWorth.Location = new System.Drawing.Point(78, 45);
            this.txtAnimalWorth.Name = "txtAnimalWorth";
            this.txtAnimalWorth.Size = new System.Drawing.Size(171, 36);
            this.txtAnimalWorth.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(378, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "PRODUCT WORTH";
            // 
            // txtProductWorth
            // 
            this.txtProductWorth.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.txtProductWorth.Location = new System.Drawing.Point(382, 45);
            this.txtProductWorth.Name = "txtProductWorth";
            this.txtProductWorth.Size = new System.Drawing.Size(171, 36);
            this.txtProductWorth.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(686, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "CURRENT BALANCE";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.txtCurrent.Location = new System.Drawing.Point(690, 45);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(171, 36);
            this.txtCurrent.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartAnimal);
            this.panel2.Controls.Add(this.pnlGridAnimal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 548);
            this.panel2.TabIndex = 0;
            // 
            // chartAnimal
            // 
            chartArea10.Name = "ChartArea1";
            this.chartAnimal.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartAnimal.Legends.Add(legend10);
            this.chartAnimal.Location = new System.Drawing.Point(12, 293);
            this.chartAnimal.Name = "chartAnimal";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Animals Is Sold";
            this.chartAnimal.Series.Add(series10);
            this.chartAnimal.Size = new System.Drawing.Size(435, 243);
            this.chartAnimal.TabIndex = 9;
            this.chartAnimal.Text = "chart1";
            title10.Name = "Title1";
            title10.Text = "Animals Chart";
            this.chartAnimal.Titles.Add(title10);
            // 
            // pnlGridAnimal
            // 
            this.pnlGridAnimal.Controls.Add(this.dataGridAnimalList);
            this.pnlGridAnimal.Location = new System.Drawing.Point(12, 42);
            this.pnlGridAnimal.Name = "pnlGridAnimal";
            this.pnlGridAnimal.Size = new System.Drawing.Size(435, 234);
            this.pnlGridAnimal.TabIndex = 8;
            // 
            // dataGridAnimalList
            // 
            this.dataGridAnimalList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAnimalList.Location = new System.Drawing.Point(0, 0);
            this.dataGridAnimalList.MainView = this.gridView1;
            this.dataGridAnimalList.Name = "dataGridAnimalList";
            this.dataGridAnimalList.Size = new System.Drawing.Size(435, 234);
            this.dataGridAnimalList.TabIndex = 1;
            this.dataGridAnimalList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dataGridAnimalList;
            this.gridView1.GroupPanelText = " ";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "ANIMALS LIST";
            // 
            // contextAnimal
            // 
            this.contextAnimal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToExcelToolStripMenuItem});
            this.contextAnimal.Name = "contextAnimal";
            this.contextAnimal.Size = new System.Drawing.Size(153, 26);
            // 
            // contextProduct
            // 
            this.contextProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToExcelToolStripMenuItem1});
            this.contextProduct.Name = "contextProduct";
            this.contextProduct.Size = new System.Drawing.Size(181, 48);
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToExcelToolStripMenuItem.Text = "Export to Excel";
            this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportToExcelToolStripMenuItem_Click);
            // 
            // exportToExcelToolStripMenuItem1
            // 
            this.exportToExcelToolStripMenuItem1.Name = "exportToExcelToolStripMenuItem1";
            this.exportToExcelToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exportToExcelToolStripMenuItem1.Text = "Export to Excel";
            this.exportToExcelToolStripMenuItem1.Click += new System.EventHandler(this.exportToExcelToolStripMenuItem1_Click);
            // 
            // FormBarnDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 678);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBarnDetails";
            this.Text = "FormBarnDetails";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).EndInit();
            this.pnlGridProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnimal)).EndInit();
            this.pnlGridAnimal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnimalList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextAnimal.ResumeLayout(false);
            this.contextProduct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnimalWorth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductWorth;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduct;
        private System.Windows.Forms.Panel pnlGridProduct;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnimal;
        private System.Windows.Forms.Panel pnlGridAnimal;
        private DevExpress.XtraGrid.GridControl dataGridAnimalList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl dataGridProductList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ContextMenuStrip contextAnimal;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextProduct;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem1;
    }
}