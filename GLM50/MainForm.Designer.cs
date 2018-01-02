namespace GLM50
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.getListOfDevicesBtn = new System.Windows.Forms.Button();
            this.measuredValueLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.devicesList = new System.Windows.Forms.ListBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.sendMeasuredValueCb = new System.Windows.Forms.CheckBox();
            this.sendMeasuredValueFormat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scaleValueBy = new System.Windows.Forms.NumericUpDown();
            this.calculationsDropDown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.scaleValueBy)).BeginInit();
            this.SuspendLayout();
            // 
            // getListOfDevicesBtn
            // 
            this.getListOfDevicesBtn.Location = new System.Drawing.Point(12, 12);
            this.getListOfDevicesBtn.Name = "getListOfDevicesBtn";
            this.getListOfDevicesBtn.Size = new System.Drawing.Size(347, 23);
            this.getListOfDevicesBtn.TabIndex = 0;
            this.getListOfDevicesBtn.Text = "Get list of devices";
            this.getListOfDevicesBtn.UseVisualStyleBackColor = true;
            this.getListOfDevicesBtn.Click += new System.EventHandler(this.getListOfDevicesBtn_Click);
            // 
            // measuredValueLabel
            // 
            this.measuredValueLabel.AutoSize = true;
            this.measuredValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measuredValueLabel.Location = new System.Drawing.Point(12, 245);
            this.measuredValueLabel.Name = "measuredValueLabel";
            this.measuredValueLabel.Size = new System.Drawing.Size(32, 16);
            this.measuredValueLabel.TabIndex = 1;
            this.measuredValueLabel.Text = "???";
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(286, 245);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(73, 13);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Disconnected";
            // 
            // devicesList
            // 
            this.devicesList.FormattingEnabled = true;
            this.devicesList.Location = new System.Drawing.Point(12, 41);
            this.devicesList.Name = "devicesList";
            this.devicesList.Size = new System.Drawing.Size(347, 95);
            this.devicesList.TabIndex = 3;
            this.devicesList.SelectedIndexChanged += new System.EventHandler(this.devicesList_SelectedIndexChanged);
            // 
            // connectButton
            // 
            this.connectButton.Enabled = false;
            this.connectButton.Location = new System.Drawing.Point(12, 142);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(347, 23);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // sendMeasuredValueCb
            // 
            this.sendMeasuredValueCb.AutoSize = true;
            this.sendMeasuredValueCb.Checked = true;
            this.sendMeasuredValueCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sendMeasuredValueCb.Location = new System.Drawing.Point(15, 172);
            this.sendMeasuredValueCb.Name = "sendMeasuredValueCb";
            this.sendMeasuredValueCb.Size = new System.Drawing.Size(353, 17);
            this.sendMeasuredValueCb.TabIndex = 5;
            this.sendMeasuredValueCb.Text = "Send measured value to the active application in the following format:";
            this.sendMeasuredValueCb.UseVisualStyleBackColor = true;
            // 
            // sendMeasuredValueFormat
            // 
            this.sendMeasuredValueFormat.Location = new System.Drawing.Point(36, 196);
            this.sendMeasuredValueFormat.Name = "sendMeasuredValueFormat";
            this.sendMeasuredValueFormat.Size = new System.Drawing.Size(323, 20);
            this.sendMeasuredValueFormat.TabIndex = 6;
            this.sendMeasuredValueFormat.Text = "{0}m{ENTER}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Multiply value by:";
            // 
            // scaleValueBy
            // 
            this.scaleValueBy.DecimalPlaces = 5;
            this.scaleValueBy.Location = new System.Drawing.Point(102, 223);
            this.scaleValueBy.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.scaleValueBy.Name = "scaleValueBy";
            this.scaleValueBy.Size = new System.Drawing.Size(88, 20);
            this.scaleValueBy.TabIndex = 8;
            this.scaleValueBy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // calculationsDropDown
            // 
            this.calculationsDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.calculationsDropDown.FormattingEnabled = true;
            this.calculationsDropDown.Location = new System.Drawing.Point(229, 222);
            this.calculationsDropDown.Name = "calculationsDropDown";
            this.calculationsDropDown.Size = new System.Drawing.Size(130, 21);
            this.calculationsDropDown.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 270);
            this.Controls.Add(this.calculationsDropDown);
            this.Controls.Add(this.scaleValueBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendMeasuredValueFormat);
            this.Controls.Add(this.sendMeasuredValueCb);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.devicesList);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.measuredValueLabel);
            this.Controls.Add(this.getListOfDevicesBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GLM 50 C";
            ((System.ComponentModel.ISupportInitialize)(this.scaleValueBy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getListOfDevicesBtn;
        private System.Windows.Forms.Label measuredValueLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ListBox devicesList;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.CheckBox sendMeasuredValueCb;
        private System.Windows.Forms.TextBox sendMeasuredValueFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown scaleValueBy;
        private System.Windows.Forms.ComboBox calculationsDropDown;
    }
}

