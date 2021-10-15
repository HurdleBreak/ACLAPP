namespace WindowsFormsApplication1
{
    partial class FrmDesignMaster
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYarn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnds = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvDesign = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.rdWarp = new System.Windows.Forms.RadioButton();
            this.rdWeft = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesign)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(59, 48);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(158, 20);
            this.txtColor.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Yarn Count";
            // 
            // txtYarn
            // 
            this.txtYarn.Location = new System.Drawing.Point(316, 48);
            this.txtYarn.Name = "txtYarn";
            this.txtYarn.Size = new System.Drawing.Size(158, 20);
            this.txtYarn.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ends";
            // 
            // txtEnds
            // 
            this.txtEnds.Location = new System.Drawing.Point(540, 47);
            this.txtEnds.Name = "txtEnds";
            this.txtEnds.Size = new System.Drawing.Size(99, 20);
            this.txtEnds.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(850, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 38);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(895, 37);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(39, 38);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "-";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(940, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 38);
            this.button3.TabIndex = 25;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgvDesign
            // 
            this.dgvDesign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesign.Location = new System.Drawing.Point(14, 112);
            this.dgvDesign.Name = "dgvDesign";
            this.dgvDesign.Size = new System.Drawing.Size(965, 346);
            this.dgvDesign.TabIndex = 26;
            this.dgvDesign.Click += new System.EventHandler(this.dgvDesign_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(654, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 27;
            // 
            // rdWarp
            // 
            this.rdWarp.AutoSize = true;
            this.rdWarp.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdWarp.Location = new System.Drawing.Point(689, 37);
            this.rdWarp.Name = "rdWarp";
            this.rdWarp.Size = new System.Drawing.Size(101, 29);
            this.rdWarp.TabIndex = 28;
            this.rdWarp.TabStop = true;
            this.rdWarp.Text = "WARP";
            this.rdWarp.UseVisualStyleBackColor = true;
            // 
            // rdWeft
            // 
            this.rdWeft.AutoSize = true;
            this.rdWeft.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdWeft.Location = new System.Drawing.Point(689, 71);
            this.rdWeft.Name = "rdWeft";
            this.rdWeft.Size = new System.Drawing.Size(96, 29);
            this.rdWeft.TabIndex = 29;
            this.rdWeft.TabStop = true;
            this.rdWeft.Text = "WEFT";
            this.rdWeft.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mastersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mastersToolStripMenuItem
            // 
            this.mastersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorMasterToolStripMenuItem,
            this.countMasterToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
            this.mastersToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.mastersToolStripMenuItem.Text = "Masters";
            // 
            // colorMasterToolStripMenuItem
            // 
            this.colorMasterToolStripMenuItem.Name = "colorMasterToolStripMenuItem";
            this.colorMasterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorMasterToolStripMenuItem.Text = "Color Master";
            this.colorMasterToolStripMenuItem.Click += new System.EventHandler(this.colorMasterToolStripMenuItem_Click);
            // 
            // countMasterToolStripMenuItem
            // 
            this.countMasterToolStripMenuItem.Name = "countMasterToolStripMenuItem";
            this.countMasterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.countMasterToolStripMenuItem.Text = "Count Master";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // FrmDesignMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1000, 470);
            this.Controls.Add(this.rdWeft);
            this.Controls.Add(this.rdWarp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDesign);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEnds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYarn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDesignMaster";
            this.Text = "FrmDesignMaster";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesign)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYarn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnds;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvDesign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdWarp;
        private System.Windows.Forms.RadioButton rdWeft;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}