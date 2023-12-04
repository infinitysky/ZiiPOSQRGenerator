
namespace QRCodeV2
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
            this.QRcodeType = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableQRcodelist = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.branchIDBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.OnlineOrderPathBox = new System.Windows.Forms.TextBox();
            this.OnlineOrderBranchBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.QRCodePathBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.QRCodeList = new System.Windows.Forms.TextBox();
            this.QRcodeType.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QRcodeType
            // 
            this.QRcodeType.Controls.Add(this.tabPage1);
            this.QRcodeType.Controls.Add(this.tabPage2);
            this.QRcodeType.Controls.Add(this.tabPage3);
            this.QRcodeType.Location = new System.Drawing.Point(12, 31);
            this.QRcodeType.Name = "QRcodeType";
            this.QRcodeType.SelectedIndex = 0;
            this.QRcodeType.Size = new System.Drawing.Size(776, 524);
            this.QRcodeType.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.tableQRcodelist);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.OutputBox);
            this.tabPage1.Controls.Add(this.branchIDBox);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Table Order";
            // 
            // tableQRcodelist
            // 
            this.tableQRcodelist.Location = new System.Drawing.Point(37, 144);
            this.tableQRcodelist.Multiline = true;
            this.tableQRcodelist.Name = "tableQRcodelist";
            this.tableQRcodelist.Size = new System.Drawing.Size(677, 294);
            this.tableQRcodelist.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(639, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(123, 72);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(426, 20);
            this.OutputBox.TabIndex = 4;
            this.OutputBox.Text = "C:\\Ziitech";
            // 
            // branchIDBox
            // 
            this.branchIDBox.Location = new System.Drawing.Point(123, 33);
            this.branchIDBox.Name = "branchIDBox";
            this.branchIDBox.Size = new System.Drawing.Size(100, 20);
            this.branchIDBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch ID";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.OnlineOrderPathBox);
            this.tabPage2.Controls.Add(this.OnlineOrderBranchBox);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Online Order";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(639, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Generate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OnlineOrderPathBox
            // 
            this.OnlineOrderPathBox.Location = new System.Drawing.Point(123, 72);
            this.OnlineOrderPathBox.Name = "OnlineOrderPathBox";
            this.OnlineOrderPathBox.Size = new System.Drawing.Size(426, 20);
            this.OnlineOrderPathBox.TabIndex = 11;
            this.OnlineOrderPathBox.Text = "C:\\Ziitech";
            // 
            // OnlineOrderBranchBox
            // 
            this.OnlineOrderBranchBox.Location = new System.Drawing.Point(123, 33);
            this.OnlineOrderBranchBox.Name = "OnlineOrderBranchBox";
            this.OnlineOrderBranchBox.Size = new System.Drawing.Size(100, 20);
            this.OnlineOrderBranchBox.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(639, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Select";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Branch ID";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.QRCodeList);
            this.tabPage3.Controls.Add(this.QRCodePathBox);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 498);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "QR Code";
            // 
            // QRCodePathBox
            // 
            this.QRCodePathBox.Location = new System.Drawing.Point(133, 41);
            this.QRCodePathBox.Name = "QRCodePathBox";
            this.QRCodePathBox.Size = new System.Drawing.Size(426, 20);
            this.QRCodePathBox.TabIndex = 11;
            this.QRCodePathBox.Text = "C:\\Ziitech";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(657, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Select";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Output Path";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(657, 416);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Generate";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // QRCodeList
            // 
            this.QRCodeList.Location = new System.Drawing.Point(27, 102);
            this.QRCodeList.Multiline = true;
            this.QRCodeList.Name = "QRCodeList";
            this.QRCodeList.Size = new System.Drawing.Size(705, 294);
            this.QRCodeList.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 611);
            this.Controls.Add(this.QRcodeType);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRCode Generator";
            this.QRcodeType.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl QRcodeType;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.TextBox branchIDBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox OnlineOrderPathBox;
        private System.Windows.Forms.TextBox OnlineOrderBranchBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox QRCodePathBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tableQRcodelist;
        private System.Windows.Forms.TextBox QRCodeList;
    }
}

