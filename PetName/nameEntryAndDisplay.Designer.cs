namespace PetName
{
    partial class nameEntryAndDisplay
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
            this.btnPetName = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblPetName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msitFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msitExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msitHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msitAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.cbPetType = new System.Windows.Forms.ComboBox();
            this.errInfo = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPetName
            // 
            this.btnPetName.Location = new System.Drawing.Point(12, 172);
            this.btnPetName.Name = "btnPetName";
            this.btnPetName.Size = new System.Drawing.Size(75, 23);
            this.btnPetName.TabIndex = 0;
            this.btnPetName.Text = "&Pet Name";
            this.btnPetName.UseVisualStyleBackColor = true;
            this.btnPetName.Click += new System.EventHandler(this.btnPetName_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(93, 172);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(174, 172);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(9, 58);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(233, 13);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Please Choose a Pet Type and Press Pet Name";
            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.Location = new System.Drawing.Point(12, 135);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(35, 13);
            this.lblPetName.TabIndex = 4;
            this.lblPetName.Text = "label2";
            this.lblPetName.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msitFile,
            this.msitHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "msMain";
            // 
            // msitFile
            // 
            this.msitFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msitExit});
            this.msitFile.Name = "msitFile";
            this.msitFile.Size = new System.Drawing.Size(37, 20);
            this.msitFile.Text = "&File";
            // 
            // msitExit
            // 
            this.msitExit.Name = "msitExit";
            this.msitExit.Size = new System.Drawing.Size(92, 22);
            this.msitExit.Text = "E&xit";
            this.msitExit.Click += new System.EventHandler(this.msitExit_Click);
            // 
            // msitHelp
            // 
            this.msitHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msitAbout});
            this.msitHelp.Name = "msitHelp";
            this.msitHelp.Size = new System.Drawing.Size(44, 20);
            this.msitHelp.Text = "&Help";
            // 
            // msitAbout
            // 
            this.msitAbout.Name = "msitAbout";
            this.msitAbout.Size = new System.Drawing.Size(107, 22);
            this.msitAbout.Text = "A&bout";
            this.msitAbout.Click += new System.EventHandler(this.msitAbout_Click);
            // 
            // cbPetType
            // 
            this.cbPetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPetType.FormattingEnabled = true;
            this.cbPetType.Items.AddRange(new object[] {
            "Dog",
            "Cat",
            "Fish"});
            this.cbPetType.Location = new System.Drawing.Point(12, 91);
            this.cbPetType.Name = "cbPetType";
            this.cbPetType.Size = new System.Drawing.Size(237, 21);
            this.cbPetType.TabIndex = 6;
            // 
            // errInfo
            // 
            this.errInfo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errInfo.ContainerControl = this;
            // 
            // ttInfo
            // 
            this.ttInfo.IsBalloon = true;
            // 
            // nameEntryAndDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 218);
            this.Controls.Add(this.cbPetType);
            this.Controls.Add(this.lblPetName);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPetName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "nameEntryAndDisplay";
            this.ShowIcon = false;
            this.Text = "Pet Name Generator";
            this.Load += new System.EventHandler(this.nameEntryAndDisplay_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPetName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblPetName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msitFile;
        private System.Windows.Forms.ToolStripMenuItem msitExit;
        private System.Windows.Forms.ToolStripMenuItem msitHelp;
        private System.Windows.Forms.ToolStripMenuItem msitAbout;
        private System.Windows.Forms.ComboBox cbPetType;
        private System.Windows.Forms.ErrorProvider errInfo;
        private System.Windows.Forms.ToolTip ttInfo;
    }
}

