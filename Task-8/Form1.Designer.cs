namespace Task_8
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbBase = new System.Windows.Forms.GroupBox();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnTools = new System.Windows.Forms.Button();
            this.btnMetal = new System.Windows.Forms.Button();
            this.btnEat = new System.Windows.Forms.Button();
            this.tbGoods = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.btmClear = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblGoods = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.gbBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBase
            // 
            this.gbBase.Controls.Add(this.splitContainer2);
            this.gbBase.Controls.Add(this.btnItems);
            this.gbBase.Controls.Add(this.btnTools);
            this.gbBase.Controls.Add(this.btnMetal);
            this.gbBase.Controls.Add(this.btnEat);
            this.gbBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbBase.Location = new System.Drawing.Point(0, 0);
            this.gbBase.Name = "gbBase";
            this.gbBase.Size = new System.Drawing.Size(456, 145);
            this.gbBase.TabIndex = 0;
            this.gbBase.TabStop = false;
            this.gbBase.Text = "Выберите категории товаров:";
            // 
            // btnItems
            // 
            this.btnItems.Location = new System.Drawing.Point(225, 64);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(154, 28);
            this.btnItems.TabIndex = 7;
            this.btnItems.Text = "Предметы";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnTools
            // 
            this.btnTools.Location = new System.Drawing.Point(225, 30);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(154, 28);
            this.btnTools.TabIndex = 6;
            this.btnTools.Text = "Инструменты";
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnMetal
            // 
            this.btnMetal.Location = new System.Drawing.Point(65, 64);
            this.btnMetal.Name = "btnMetal";
            this.btnMetal.Size = new System.Drawing.Size(154, 28);
            this.btnMetal.TabIndex = 5;
            this.btnMetal.Text = "Ископаемые";
            this.btnMetal.UseVisualStyleBackColor = true;
            this.btnMetal.Click += new System.EventHandler(this.btnMetal_Click);
            // 
            // btnEat
            // 
            this.btnEat.Location = new System.Drawing.Point(65, 30);
            this.btnEat.Name = "btnEat";
            this.btnEat.Size = new System.Drawing.Size(154, 28);
            this.btnEat.TabIndex = 4;
            this.btnEat.Text = "Еда";
            this.btnEat.UseVisualStyleBackColor = true;
            this.btnEat.Click += new System.EventHandler(this.btnEat_Click);
            // 
            // tbGoods
            // 
            this.tbGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGoods.Location = new System.Drawing.Point(0, 0);
            this.tbGoods.Multiline = true;
            this.tbGoods.Name = "tbGoods";
            this.tbGoods.Size = new System.Drawing.Size(352, 505);
            this.tbGoods.TabIndex = 1;
            // 
            // tbCost
            // 
            this.tbCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCost.Location = new System.Drawing.Point(0, 0);
            this.tbCost.Multiline = true;
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(100, 505);
            this.tbCost.TabIndex = 2;
            // 
            // btmClear
            // 
            this.btmClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btmClear.Location = new System.Drawing.Point(0, 650);
            this.btmClear.Name = "btmClear";
            this.btmClear.Size = new System.Drawing.Size(456, 27);
            this.btmClear.TabIndex = 3;
            this.btmClear.Text = "Очистить список";
            this.btmClear.UseVisualStyleBackColor = true;
            this.btmClear.Click += new System.EventHandler(this.btmClear_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 145);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbGoods);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbCost);
            this.splitContainer1.Size = new System.Drawing.Size(456, 505);
            this.splitContainer1.SplitterDistance = 352;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer2.Location = new System.Drawing.Point(3, 118);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lblGoods);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lblCost);
            this.splitContainer2.Size = new System.Drawing.Size(450, 24);
            this.splitContainer2.SplitterDistance = 347;
            this.splitContainer2.TabIndex = 8;
            // 
            // lblGoods
            // 
            this.lblGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGoods.Location = new System.Drawing.Point(0, 0);
            this.lblGoods.Name = "lblGoods";
            this.lblGoods.Size = new System.Drawing.Size(347, 24);
            this.lblGoods.TabIndex = 0;
            this.lblGoods.Text = "Список товаров:";
            // 
            // lblCost
            // 
            this.lblCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCost.Location = new System.Drawing.Point(0, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(99, 24);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "Цена (медь):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 677);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btmClear);
            this.Controls.Add(this.gbBase);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbBase.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnEat;
        private System.Windows.Forms.Button btnMetal;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.TextBox tbGoods;
        private System.Windows.Forms.GroupBox gbBase;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btmClear;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblGoods;
    }
}