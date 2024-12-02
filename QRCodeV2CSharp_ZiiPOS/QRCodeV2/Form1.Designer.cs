
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.QRcodeType = new System.Windows.Forms.TabControl();
            this.TableOrderTBPage = new System.Windows.Forms.TabPage();
            this.tableQRcodelist = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.branchIDBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OnlineOrderTBPage = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.OnlineOrderPathBox = new System.Windows.Forms.TextBox();
            this.OnlineOrderBranchBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TakeAwayTBPage = new System.Windows.Forms.TabPage();
            this.TKGButton = new System.Windows.Forms.Button();
            this.TKPathSelectButton = new System.Windows.Forms.Button();
            this.TKPathBox = new System.Windows.Forms.TextBox();
            this.TakeAwayBranchIDBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LoyaltyTabPage = new System.Windows.Forms.TabPage();
            this.LoyaltyGenerateButton = new System.Windows.Forms.Button();
            this.LoyaltyPathSelectButton = new System.Windows.Forms.Button();
            this.LoyaltyPathBox = new System.Windows.Forms.TextBox();
            this.LoyaltyMerchantBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OtherQRTBPage = new System.Windows.Forms.TabPage();
            this.QRCodeList = new System.Windows.Forms.TextBox();
            this.QRCodePathBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.QRcodeType.SuspendLayout();
            this.TableOrderTBPage.SuspendLayout();
            this.OnlineOrderTBPage.SuspendLayout();
            this.TakeAwayTBPage.SuspendLayout();
            this.LoyaltyTabPage.SuspendLayout();
            this.OtherQRTBPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QRcodeType
            // 
            this.QRcodeType.Controls.Add(this.TableOrderTBPage);
            this.QRcodeType.Controls.Add(this.OnlineOrderTBPage);
            this.QRcodeType.Controls.Add(this.TakeAwayTBPage);
            this.QRcodeType.Controls.Add(this.LoyaltyTabPage);
            this.QRcodeType.Controls.Add(this.OtherQRTBPage);
            this.QRcodeType.Location = new System.Drawing.Point(12, 27);
            this.QRcodeType.Name = "QRcodeType";
            this.QRcodeType.SelectedIndex = 0;
            this.QRcodeType.Size = new System.Drawing.Size(776, 524);
            this.QRcodeType.TabIndex = 1;
            // 
            // TableOrderTBPage
            // 
            this.TableOrderTBPage.BackColor = System.Drawing.SystemColors.Control;
            this.TableOrderTBPage.Controls.Add(this.tableQRcodelist);
            this.TableOrderTBPage.Controls.Add(this.button2);
            this.TableOrderTBPage.Controls.Add(this.OutputBox);
            this.TableOrderTBPage.Controls.Add(this.branchIDBox);
            this.TableOrderTBPage.Controls.Add(this.button1);
            this.TableOrderTBPage.Controls.Add(this.label2);
            this.TableOrderTBPage.Controls.Add(this.label1);
            this.TableOrderTBPage.Location = new System.Drawing.Point(4, 22);
            this.TableOrderTBPage.Name = "TableOrderTBPage";
            this.TableOrderTBPage.Padding = new System.Windows.Forms.Padding(3);
            this.TableOrderTBPage.Size = new System.Drawing.Size(768, 498);
            this.TableOrderTBPage.TabIndex = 0;
            this.TableOrderTBPage.Text = "Table Order";
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
            this.OutputBox.Location = new System.Drawing.Point(141, 67);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(408, 20);
            this.OutputBox.TabIndex = 4;
            this.OutputBox.Text = "C:\\Ziitech";
            // 
            // branchIDBox
            // 
            this.branchIDBox.Location = new System.Drawing.Point(141, 30);
            this.branchIDBox.Name = "branchIDBox";
            this.branchIDBox.Size = new System.Drawing.Size(100, 20);
            this.branchIDBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 67);
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
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch ID (Number)";
            // 
            // OnlineOrderTBPage
            // 
            this.OnlineOrderTBPage.BackColor = System.Drawing.SystemColors.Control;
            this.OnlineOrderTBPage.Controls.Add(this.button3);
            this.OnlineOrderTBPage.Controls.Add(this.OnlineOrderPathBox);
            this.OnlineOrderTBPage.Controls.Add(this.OnlineOrderBranchBox);
            this.OnlineOrderTBPage.Controls.Add(this.button4);
            this.OnlineOrderTBPage.Controls.Add(this.label3);
            this.OnlineOrderTBPage.Controls.Add(this.label4);
            this.OnlineOrderTBPage.Location = new System.Drawing.Point(4, 22);
            this.OnlineOrderTBPage.Name = "OnlineOrderTBPage";
            this.OnlineOrderTBPage.Padding = new System.Windows.Forms.Padding(3);
            this.OnlineOrderTBPage.Size = new System.Drawing.Size(768, 498);
            this.OnlineOrderTBPage.TabIndex = 1;
            this.OnlineOrderTBPage.Text = "Online Order";
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
            this.OnlineOrderPathBox.Location = new System.Drawing.Point(141, 67);
            this.OnlineOrderPathBox.Name = "OnlineOrderPathBox";
            this.OnlineOrderPathBox.Size = new System.Drawing.Size(408, 20);
            this.OnlineOrderPathBox.TabIndex = 11;
            this.OnlineOrderPathBox.Text = "C:\\Ziitech";
            // 
            // OnlineOrderBranchBox
            // 
            this.OnlineOrderBranchBox.Location = new System.Drawing.Point(141, 30);
            this.OnlineOrderBranchBox.Name = "OnlineOrderBranchBox";
            this.OnlineOrderBranchBox.Size = new System.Drawing.Size(100, 20);
            this.OnlineOrderBranchBox.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(639, 67);
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
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Branch ID (Number)";
            // 
            // TakeAwayTBPage
            // 
            this.TakeAwayTBPage.BackColor = System.Drawing.SystemColors.Control;
            this.TakeAwayTBPage.Controls.Add(this.TKGButton);
            this.TakeAwayTBPage.Controls.Add(this.TKPathSelectButton);
            this.TakeAwayTBPage.Controls.Add(this.TKPathBox);
            this.TakeAwayTBPage.Controls.Add(this.TakeAwayBranchIDBox);
            this.TakeAwayTBPage.Controls.Add(this.label7);
            this.TakeAwayTBPage.Controls.Add(this.label6);
            this.TakeAwayTBPage.Location = new System.Drawing.Point(4, 22);
            this.TakeAwayTBPage.Name = "TakeAwayTBPage";
            this.TakeAwayTBPage.Padding = new System.Windows.Forms.Padding(3);
            this.TakeAwayTBPage.Size = new System.Drawing.Size(768, 498);
            this.TakeAwayTBPage.TabIndex = 3;
            this.TakeAwayTBPage.Text = "TakeAway";
            // 
            // TKGButton
            // 
            this.TKGButton.Location = new System.Drawing.Point(639, 149);
            this.TKGButton.Name = "TKGButton";
            this.TKGButton.Size = new System.Drawing.Size(75, 23);
            this.TKGButton.TabIndex = 13;
            this.TKGButton.Text = "Generate";
            this.TKGButton.UseVisualStyleBackColor = true;
            this.TKGButton.Click += new System.EventHandler(this.TKGButton_Click);
            // 
            // TKPathSelectButton
            // 
            this.TKPathSelectButton.Location = new System.Drawing.Point(639, 67);
            this.TKPathSelectButton.Name = "TKPathSelectButton";
            this.TKPathSelectButton.Size = new System.Drawing.Size(75, 23);
            this.TKPathSelectButton.TabIndex = 10;
            this.TKPathSelectButton.Text = "Select";
            this.TKPathSelectButton.UseVisualStyleBackColor = true;
            this.TKPathSelectButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // TKPathBox
            // 
            this.TKPathBox.Location = new System.Drawing.Point(141, 67);
            this.TKPathBox.Name = "TKPathBox";
            this.TKPathBox.Size = new System.Drawing.Size(408, 20);
            this.TKPathBox.TabIndex = 3;
            this.TKPathBox.Text = "C:\\Ziitech";
            // 
            // TakeAwayBranchIDBox
            // 
            this.TakeAwayBranchIDBox.Location = new System.Drawing.Point(141, 30);
            this.TakeAwayBranchIDBox.Name = "TakeAwayBranchIDBox";
            this.TakeAwayBranchIDBox.Size = new System.Drawing.Size(100, 20);
            this.TakeAwayBranchIDBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Output Path";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Branch ID (Number)";
            // 
            // LoyaltyTabPage
            // 
            this.LoyaltyTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.LoyaltyTabPage.Controls.Add(this.LoyaltyGenerateButton);
            this.LoyaltyTabPage.Controls.Add(this.LoyaltyPathSelectButton);
            this.LoyaltyTabPage.Controls.Add(this.LoyaltyPathBox);
            this.LoyaltyTabPage.Controls.Add(this.LoyaltyMerchantBox);
            this.LoyaltyTabPage.Controls.Add(this.label9);
            this.LoyaltyTabPage.Controls.Add(this.label8);
            this.LoyaltyTabPage.Location = new System.Drawing.Point(4, 22);
            this.LoyaltyTabPage.Name = "LoyaltyTabPage";
            this.LoyaltyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoyaltyTabPage.Size = new System.Drawing.Size(768, 498);
            this.LoyaltyTabPage.TabIndex = 4;
            this.LoyaltyTabPage.Text = "LoyaltyQR";
            // 
            // LoyaltyGenerateButton
            // 
            this.LoyaltyGenerateButton.Location = new System.Drawing.Point(639, 149);
            this.LoyaltyGenerateButton.Name = "LoyaltyGenerateButton";
            this.LoyaltyGenerateButton.Size = new System.Drawing.Size(75, 23);
            this.LoyaltyGenerateButton.TabIndex = 15;
            this.LoyaltyGenerateButton.Text = "Generate";
            this.LoyaltyGenerateButton.UseVisualStyleBackColor = true;
            this.LoyaltyGenerateButton.Click += new System.EventHandler(this.LoyaltyGenerateButton_Click);
            // 
            // LoyaltyPathSelectButton
            // 
            this.LoyaltyPathSelectButton.Location = new System.Drawing.Point(639, 67);
            this.LoyaltyPathSelectButton.Name = "LoyaltyPathSelectButton";
            this.LoyaltyPathSelectButton.Size = new System.Drawing.Size(75, 23);
            this.LoyaltyPathSelectButton.TabIndex = 14;
            this.LoyaltyPathSelectButton.Text = "Select";
            this.LoyaltyPathSelectButton.UseVisualStyleBackColor = true;
            this.LoyaltyPathSelectButton.Click += new System.EventHandler(this.LoyaltyPathSelectButton_Click);
            // 
            // LoyaltyPathBox
            // 
            this.LoyaltyPathBox.Location = new System.Drawing.Point(183, 67);
            this.LoyaltyPathBox.Name = "LoyaltyPathBox";
            this.LoyaltyPathBox.Size = new System.Drawing.Size(408, 20);
            this.LoyaltyPathBox.TabIndex = 4;
            this.LoyaltyPathBox.Text = "C:\\Ziitech";
            // 
            // LoyaltyMerchantBox
            // 
            this.LoyaltyMerchantBox.Location = new System.Drawing.Point(183, 30);
            this.LoyaltyMerchantBox.Name = "LoyaltyMerchantBox";
            this.LoyaltyMerchantBox.Size = new System.Drawing.Size(223, 20);
            this.LoyaltyMerchantBox.TabIndex = 3;
            this.LoyaltyMerchantBox.Text = "ABCD-PTY-LTD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Output Path";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Merchant Name (LongString)";
            // 
            // OtherQRTBPage
            // 
            this.OtherQRTBPage.BackColor = System.Drawing.SystemColors.Control;
            this.OtherQRTBPage.Controls.Add(this.QRCodeList);
            this.OtherQRTBPage.Controls.Add(this.QRCodePathBox);
            this.OtherQRTBPage.Controls.Add(this.button6);
            this.OtherQRTBPage.Controls.Add(this.label5);
            this.OtherQRTBPage.Controls.Add(this.button5);
            this.OtherQRTBPage.Location = new System.Drawing.Point(4, 22);
            this.OtherQRTBPage.Name = "OtherQRTBPage";
            this.OtherQRTBPage.Padding = new System.Windows.Forms.Padding(3);
            this.OtherQRTBPage.Size = new System.Drawing.Size(768, 498);
            this.OtherQRTBPage.TabIndex = 2;
            this.OtherQRTBPage.Text = "Other QR Code";
            // 
            // QRCodeList
            // 
            this.QRCodeList.Location = new System.Drawing.Point(27, 102);
            this.QRCodeList.Multiline = true;
            this.QRCodeList.Name = "QRCodeList";
            this.QRCodeList.Size = new System.Drawing.Size(705, 294);
            this.QRCodeList.TabIndex = 12;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 611);
            this.Controls.Add(this.QRcodeType);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZiiPOS QRCode Generator V2.5";
            this.QRcodeType.ResumeLayout(false);
            this.TableOrderTBPage.ResumeLayout(false);
            this.TableOrderTBPage.PerformLayout();
            this.OnlineOrderTBPage.ResumeLayout(false);
            this.OnlineOrderTBPage.PerformLayout();
            this.TakeAwayTBPage.ResumeLayout(false);
            this.TakeAwayTBPage.PerformLayout();
            this.LoyaltyTabPage.ResumeLayout(false);
            this.LoyaltyTabPage.PerformLayout();
            this.OtherQRTBPage.ResumeLayout(false);
            this.OtherQRTBPage.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl QRcodeType;
        private System.Windows.Forms.TabPage TableOrderTBPage;
        private System.Windows.Forms.TabPage OnlineOrderTBPage;
        private System.Windows.Forms.TabPage OtherQRTBPage;
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
        
        private System.Windows.Forms.TabPage TakeAwayTBPage;
        private System.Windows.Forms.TabPage LoyaltyTabPage;
        private System.Windows.Forms.TextBox QRCodeList;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.TextBox TKPathBox;
        private System.Windows.Forms.TextBox TakeAwayBranchIDBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button TKGButton;
        private System.Windows.Forms.Button TKPathSelectButton;
        private System.Windows.Forms.Button LoyaltyGenerateButton;
        private System.Windows.Forms.Button LoyaltyPathSelectButton;
        private System.Windows.Forms.TextBox LoyaltyPathBox;
        private System.Windows.Forms.TextBox LoyaltyMerchantBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

