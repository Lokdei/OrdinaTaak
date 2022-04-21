namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFileLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbFileTypes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lsbEncryption = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResultText = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbReadText = new System.Windows.Forms.CheckBox();
            this.cbReadXml = new System.Windows.Forms.CheckBox();
            this.cbReadJson = new System.Windows.Forms.CheckBox();
            this.lblOperationResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFileLocation
            // 
            this.txtFileLocation.Location = new System.Drawing.Point(53, 69);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.Size = new System.Drawing.Size(720, 27);
            this.txtFileLocation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Location";
            // 
            // lsbFileTypes
            // 
            this.lsbFileTypes.FormattingEnabled = true;
            this.lsbFileTypes.ItemHeight = 20;
            this.lsbFileTypes.Location = new System.Drawing.Point(53, 145);
            this.lsbFileTypes.Name = "lsbFileTypes";
            this.lsbFileTypes.Size = new System.Drawing.Size(150, 104);
            this.lsbFileTypes.TabIndex = 2;
            this.lsbFileTypes.SelectedValueChanged += new System.EventHandler(this.lsbFileTypes_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Encryption";
            // 
            // lsbEncryption
            // 
            this.lsbEncryption.FormattingEnabled = true;
            this.lsbEncryption.ItemHeight = 20;
            this.lsbEncryption.Items.AddRange(new object[] {
            "None",
            "Reverse"});
            this.lsbEncryption.Location = new System.Drawing.Point(289, 145);
            this.lsbEncryption.Name = "lsbEncryption";
            this.lsbEncryption.Size = new System.Drawing.Size(150, 104);
            this.lsbEncryption.TabIndex = 5;
            this.lsbEncryption.SelectedValueChanged += new System.EventHandler(this.lsbEncryption_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "File Text";
            // 
            // txtResultText
            // 
            this.txtResultText.Location = new System.Drawing.Point(53, 293);
            this.txtResultText.Multiline = true;
            this.txtResultText.Name = "txtResultText";
            this.txtResultText.Size = new System.Drawing.Size(720, 145);
            this.txtResultText.TabIndex = 9;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(679, 547);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(94, 29);
            this.btnRead.TabIndex = 10;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enabled Roles";
            // 
            // cbReadText
            // 
            this.cbReadText.AutoSize = true;
            this.cbReadText.Location = new System.Drawing.Point(563, 156);
            this.cbReadText.Name = "cbReadText";
            this.cbReadText.Size = new System.Drawing.Size(96, 24);
            this.cbReadText.TabIndex = 12;
            this.cbReadText.Text = "Read Text";
            this.cbReadText.UseVisualStyleBackColor = true;
            this.cbReadText.CheckedChanged += new System.EventHandler(this.cbReadText_CheckedChanged);
            // 
            // cbReadXml
            // 
            this.cbReadXml.AutoSize = true;
            this.cbReadXml.Location = new System.Drawing.Point(563, 186);
            this.cbReadXml.Name = "cbReadXml";
            this.cbReadXml.Size = new System.Drawing.Size(98, 24);
            this.cbReadXml.TabIndex = 13;
            this.cbReadXml.Text = "Read XML";
            this.cbReadXml.UseVisualStyleBackColor = true;
            this.cbReadXml.CheckedChanged += new System.EventHandler(this.cbReadXml_CheckedChanged);
            // 
            // cbReadJson
            // 
            this.cbReadJson.AutoSize = true;
            this.cbReadJson.Location = new System.Drawing.Point(563, 216);
            this.cbReadJson.Name = "cbReadJson";
            this.cbReadJson.Size = new System.Drawing.Size(104, 24);
            this.cbReadJson.TabIndex = 14;
            this.cbReadJson.Text = "Read JSON";
            this.cbReadJson.UseVisualStyleBackColor = true;
            this.cbReadJson.CheckedChanged += new System.EventHandler(this.cbReadJson_CheckedChanged);
            // 
            // lblOperationResult
            // 
            this.lblOperationResult.AutoSize = true;
            this.lblOperationResult.Location = new System.Drawing.Point(53, 471);
            this.lblOperationResult.Name = "lblOperationResult";
            this.lblOperationResult.Size = new System.Drawing.Size(127, 20);
            this.lblOperationResult.TabIndex = 15;
            this.lblOperationResult.Text = "Operation Result: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.lblOperationResult);
            this.Controls.Add(this.cbReadJson);
            this.Controls.Add(this.cbReadXml);
            this.Controls.Add(this.cbReadText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtResultText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lsbEncryption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsbFileTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileLocation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFileLocation;
        private Label label1;
        private ListBox lsbFileTypes;
        private Label label2;
        private Label label3;
        private ListBox lsbEncryption;
        private Label label5;
        private TextBox txtResultText;
        private Button btnRead;
        private Label label4;
        private CheckBox cbReadText;
        private CheckBox cbReadXml;
        private CheckBox cbReadJson;
        private Label lblOperationResult;
    }
}