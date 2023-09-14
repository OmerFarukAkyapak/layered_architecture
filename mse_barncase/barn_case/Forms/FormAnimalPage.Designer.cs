
namespace barn_case.Forms
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
            this.pnlAnimalPage = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlTransection = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBuy = new System.Windows.Forms.Panel();
            this.pnlSell = new System.Windows.Forms.Panel();
            this.btnBuyAnimal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAnimalPage.SuspendLayout();
            this.pnlTransection.SuspendLayout();
            this.pnlBuy.SuspendLayout();
            this.pnlSell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAnimalPage
            // 
            this.pnlAnimalPage.Controls.Add(this.pnlTransection);
            this.pnlAnimalPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAnimalPage.Location = new System.Drawing.Point(0, 0);
            this.pnlAnimalPage.Name = "pnlAnimalPage";
            this.pnlAnimalPage.Size = new System.Drawing.Size(995, 609);
            this.pnlAnimalPage.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label4.Location = new System.Drawing.Point(11, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Buy Animal";
            // 
            // pnlTransection
            // 
            this.pnlTransection.Controls.Add(this.pnlSell);
            this.pnlTransection.Controls.Add(this.pnlBuy);
            this.pnlTransection.Location = new System.Drawing.Point(12, 12);
            this.pnlTransection.Name = "pnlTransection";
            this.pnlTransection.Size = new System.Drawing.Size(971, 585);
            this.pnlTransection.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Animal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(177, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Gender:";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(181, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 27);
            this.comboBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox1.Location = new System.Drawing.Point(355, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(351, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter Age:";
            // 
            // pnlBuy
            // 
            this.pnlBuy.Controls.Add(this.label5);
            this.pnlBuy.Controls.Add(this.textBox2);
            this.pnlBuy.Controls.Add(this.btnBuyAnimal);
            this.pnlBuy.Controls.Add(this.label3);
            this.pnlBuy.Controls.Add(this.comboBox1);
            this.pnlBuy.Controls.Add(this.label1);
            this.pnlBuy.Controls.Add(this.textBox1);
            this.pnlBuy.Controls.Add(this.comboBox2);
            this.pnlBuy.Controls.Add(this.label4);
            this.pnlBuy.Controls.Add(this.label2);
            this.pnlBuy.Location = new System.Drawing.Point(3, 397);
            this.pnlBuy.Name = "pnlBuy";
            this.pnlBuy.Size = new System.Drawing.Size(484, 185);
            this.pnlBuy.TabIndex = 0;
            // 
            // pnlSell
            // 
            this.pnlSell.Controls.Add(this.dataGridView1);
            this.pnlSell.Controls.Add(this.label6);
            this.pnlSell.Controls.Add(this.textBox3);
            this.pnlSell.Controls.Add(this.button1);
            this.pnlSell.Controls.Add(this.label8);
            this.pnlSell.Controls.Add(this.label9);
            this.pnlSell.Location = new System.Drawing.Point(493, 3);
            this.pnlSell.Name = "pnlSell";
            this.pnlSell.Size = new System.Drawing.Size(475, 579);
            this.pnlSell.TabIndex = 1;
            // 
            // btnBuyAnimal
            // 
            this.btnBuyAnimal.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBuyAnimal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuyAnimal.Location = new System.Drawing.Point(385, 136);
            this.btnBuyAnimal.Name = "btnBuyAnimal";
            this.btnBuyAnimal.Size = new System.Drawing.Size(70, 36);
            this.btnBuyAnimal.TabIndex = 7;
            this.btnBuyAnimal.Text = "Buy";
            this.btnBuyAnimal.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Amount:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox2.Location = new System.Drawing.Point(124, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 27);
            this.textBox2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(16, 539);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Amount:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox3.Location = new System.Drawing.Point(128, 536);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 27);
            this.textBox3.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(389, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Sell";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(16, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Select Animal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label9.Location = new System.Drawing.Point(15, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 27);
            this.label9.TabIndex = 14;
            this.label9.Text = "Sell Animal";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Animal});
            this.dataGridView1.Location = new System.Drawing.Point(20, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 185);
            this.dataGridView1.TabIndex = 24;
            // 
            // Animal
            // 
            this.Animal.HeaderText = "Column1";
            this.Animal.Name = "Animal";
            // 
            // FormAnimalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(995, 609);
            this.ControlBox = false;
            this.Controls.Add(this.pnlAnimalPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAnimalPage";
            this.Text = "FormAnimal";
            this.pnlAnimalPage.ResumeLayout(false);
            this.pnlTransection.ResumeLayout(false);
            this.pnlBuy.ResumeLayout(false);
            this.pnlBuy.PerformLayout();
            this.pnlSell.ResumeLayout(false);
            this.pnlSell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAnimalPage;
        private System.Windows.Forms.Panel pnlTransection;
        private System.Windows.Forms.Panel pnlSell;
        private System.Windows.Forms.Panel pnlBuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnBuyAnimal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Animal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}