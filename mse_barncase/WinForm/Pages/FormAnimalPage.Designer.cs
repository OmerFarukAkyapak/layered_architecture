
namespace WinForm.Pages
{
    partial class FormAnimalPage
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
            this.pnlAnimalPage = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dataGridAnimalList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFarmCurrent = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSellAnimal = new System.Windows.Forms.TextBox();
            this.numAnimalAge = new System.Windows.Forms.NumericUpDown();
            this.btnBuyAnimal = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSellAnimalAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBuyAnimalAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBoxAnimalGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBoxAnimalType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSellAnimal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSelectedID = new System.Windows.Forms.TextBox();
            this.pnlAnimalPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnimalList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimalAge)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAnimalPage
            // 
            this.pnlAnimalPage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlAnimalPage.Controls.Add(this.panel2);
            this.pnlAnimalPage.Controls.Add(this.panel4);
            this.pnlAnimalPage.Controls.Add(this.panel3);
            this.pnlAnimalPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAnimalPage.Location = new System.Drawing.Point(0, 0);
            this.pnlAnimalPage.Name = "pnlAnimalPage";
            this.pnlAnimalPage.Size = new System.Drawing.Size(954, 678);
            this.pnlAnimalPage.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pnlGrid);
            this.panel2.Location = new System.Drawing.Point(482, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 470);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(148, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "ANIMALS LIST";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dataGridAnimalList);
            this.pnlGrid.Location = new System.Drawing.Point(3, 49);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(458, 418);
            this.pnlGrid.TabIndex = 26;
            // 
            // dataGridAnimalList
            // 
            this.dataGridAnimalList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAnimalList.Location = new System.Drawing.Point(0, 0);
            this.dataGridAnimalList.MainView = this.gridView1;
            this.dataGridAnimalList.Name = "dataGridAnimalList";
            this.dataGridAnimalList.Size = new System.Drawing.Size(458, 418);
            this.dataGridAnimalList.TabIndex = 0;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtFarmCurrent);
            this.panel4.Location = new System.Drawing.Point(482, 488);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(464, 178);
            this.panel4.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(149, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "CURRENT BALANCE";
            // 
            // txtFarmCurrent
            // 
            this.txtFarmCurrent.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.txtFarmCurrent.Location = new System.Drawing.Point(153, 83);
            this.txtFarmCurrent.Name = "txtFarmCurrent";
            this.txtFarmCurrent.ReadOnly = true;
            this.txtFarmCurrent.Size = new System.Drawing.Size(171, 36);
            this.txtFarmCurrent.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSelectedID);
            this.panel3.Controls.Add(this.txtSellAnimal);
            this.panel3.Controls.Add(this.numAnimalAge);
            this.panel3.Controls.Add(this.btnBuyAnimal);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtSellAnimalAmount);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtBuyAnimalAmount);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cmbBoxAnimalGender);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cmbBoxAnimalType);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnSellAnimal);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 654);
            this.panel3.TabIndex = 1;
            // 
            // txtSellAnimal
            // 
            this.txtSellAnimal.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.txtSellAnimal.Location = new System.Drawing.Point(22, 84);
            this.txtSellAnimal.Name = "txtSellAnimal";
            this.txtSellAnimal.ReadOnly = true;
            this.txtSellAnimal.Size = new System.Drawing.Size(171, 36);
            this.txtSellAnimal.TabIndex = 25;
            // 
            // numAnimalAge
            // 
            this.numAnimalAge.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.numAnimalAge.Location = new System.Drawing.Point(22, 473);
            this.numAnimalAge.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAnimalAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAnimalAge.Name = "numAnimalAge";
            this.numAnimalAge.ReadOnly = true;
            this.numAnimalAge.Size = new System.Drawing.Size(120, 36);
            this.numAnimalAge.TabIndex = 22;
            this.numAnimalAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBuyAnimal
            // 
            this.btnBuyAnimal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuyAnimal.Location = new System.Drawing.Point(301, 559);
            this.btnBuyAnimal.Name = "btnBuyAnimal";
            this.btnBuyAnimal.Size = new System.Drawing.Size(135, 36);
            this.btnBuyAnimal.TabIndex = 20;
            this.btnBuyAnimal.Text = "BUY";
            this.btnBuyAnimal.UseVisualStyleBackColor = true;
            this.btnBuyAnimal.Click += new System.EventHandler(this.btnBuyAnimal_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(18, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Price:";
            // 
            // txtSellAnimalAmount
            // 
            this.txtSellAnimalAmount.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.txtSellAnimalAmount.Location = new System.Drawing.Point(22, 167);
            this.txtSellAnimalAmount.Name = "txtSellAnimalAmount";
            this.txtSellAnimalAmount.ReadOnly = true;
            this.txtSellAnimalAmount.Size = new System.Drawing.Size(171, 36);
            this.txtSellAnimalAmount.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(18, 532);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Price:";
            // 
            // txtBuyAnimalAmount
            // 
            this.txtBuyAnimalAmount.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.txtBuyAnimalAmount.Location = new System.Drawing.Point(22, 559);
            this.txtBuyAnimalAmount.Name = "txtBuyAnimalAmount";
            this.txtBuyAnimalAmount.ReadOnly = true;
            this.txtBuyAnimalAmount.Size = new System.Drawing.Size(171, 36);
            this.txtBuyAnimalAmount.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(18, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Enter Age:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(261, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Select Gender:";
            // 
            // cmbBoxAnimalGender
            // 
            this.cmbBoxAnimalGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxAnimalGender.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cmbBoxAnimalGender.FormattingEnabled = true;
            this.cmbBoxAnimalGender.Location = new System.Drawing.Point(265, 381);
            this.cmbBoxAnimalGender.Name = "cmbBoxAnimalGender";
            this.cmbBoxAnimalGender.Size = new System.Drawing.Size(171, 37);
            this.cmbBoxAnimalGender.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(18, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Select Animal:";
            // 
            // cmbBoxAnimalType
            // 
            this.cmbBoxAnimalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxAnimalType.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cmbBoxAnimalType.FormattingEnabled = true;
            this.cmbBoxAnimalType.Location = new System.Drawing.Point(22, 381);
            this.cmbBoxAnimalType.Name = "cmbBoxAnimalType";
            this.cmbBoxAnimalType.Size = new System.Drawing.Size(171, 37);
            this.cmbBoxAnimalType.TabIndex = 10;
            this.cmbBoxAnimalType.SelectedIndexChanged += new System.EventHandler(this.cmbBoxAnimalType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "BUY ANIMAL";
            // 
            // btnSellAnimal
            // 
            this.btnSellAnimal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSellAnimal.Location = new System.Drawing.Point(301, 167);
            this.btnSellAnimal.Name = "btnSellAnimal";
            this.btnSellAnimal.Size = new System.Drawing.Size(135, 36);
            this.btnSellAnimal.TabIndex = 8;
            this.btnSellAnimal.Text = "SELL";
            this.btnSellAnimal.UseVisualStyleBackColor = true;
            this.btnSellAnimal.Click += new System.EventHandler(this.btnSellAnimal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Selected Animal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "SELL ANIMAL";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 26);
            // 
            // seçToolStripMenuItem
            // 
            this.seçToolStripMenuItem.Name = "seçToolStripMenuItem";
            this.seçToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.seçToolStripMenuItem.Text = "Select";
            this.seçToolStripMenuItem.Click += new System.EventHandler(this.seçToolStripMenuItem_Click);
            // 
            // txtSelectedID
            // 
            this.txtSelectedID.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.txtSelectedID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSelectedID.Location = new System.Drawing.Point(199, 84);
            this.txtSelectedID.Name = "txtSelectedID";
            this.txtSelectedID.ReadOnly = true;
            this.txtSelectedID.Size = new System.Drawing.Size(103, 36);
            this.txtSelectedID.TabIndex = 26;
            // 
            // FormAnimalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 678);
            this.Controls.Add(this.pnlAnimalPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAnimalPage";
            this.Text = "FormAnimalPage";
            this.pnlAnimalPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnimalList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimalAge)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAnimalPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFarmCurrent;
        private System.Windows.Forms.Button btnBuyAnimal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSellAnimalAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBuyAnimalAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBoxAnimalGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBoxAnimalType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSellAnimal;
        private System.Windows.Forms.NumericUpDown numAnimalAge;
        private System.Windows.Forms.TextBox txtSellAnimal;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seçToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl dataGridAnimalList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txtSelectedID;
    }
}