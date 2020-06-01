namespace C_Card.Views
{
    partial class NewTransaction
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
        ///
        private void InitializeComponent()
        {
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTransaction));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notesBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.entityBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.conceptBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cardBox = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.itemLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.windowsUIButtonPanel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.panel1);
            this.layoutControl.Controls.Add(this.labelControl);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2436, 236, 650, 400);
            this.layoutControl.Root = this.layoutControlGroup;
            this.layoutControl.Size = new System.Drawing.Size(360, 363);
            this.layoutControl.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.entityBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.conceptBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.amountBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cardBox);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(42, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 325);
            this.panel1.TabIndex = 5;
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "MM/dd/yyyy HH:mm";
            this.datePicker.Enabled = false;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(99, 144);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(174, 21);
            this.datePicker.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.notesBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 142);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notes";
            // 
            // notesBox
            // 
            this.notesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesBox.Location = new System.Drawing.Point(3, 17);
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(261, 122);
            this.notesBox.TabIndex = 0;
            this.notesBox.Text = "";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "$";
            // 
            // entityBox
            // 
            this.entityBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.entityBox.FormattingEnabled = true;
            this.entityBox.Location = new System.Drawing.Point(99, 117);
            this.entityBox.Name = "entityBox";
            this.entityBox.Size = new System.Drawing.Size(174, 21);
            this.entityBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Entity:";
            // 
            // conceptBox
            // 
            this.conceptBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.conceptBox.FormattingEnabled = true;
            this.conceptBox.Location = new System.Drawing.Point(99, 90);
            this.conceptBox.Name = "conceptBox";
            this.conceptBox.Size = new System.Drawing.Size(174, 21);
            this.conceptBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Concept:";
            // 
            // amountBox
            // 
            this.amountBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountBox.Location = new System.Drawing.Point(115, 63);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(158, 21);
            this.amountBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Card #:";
            // 
            // cardBox
            // 
            this.cardBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cardBox.FormattingEnabled = true;
            this.cardBox.Location = new System.Drawing.Point(99, 36);
            this.cardBox.Name = "cardBox";
            this.cardBox.Size = new System.Drawing.Size(174, 21);
            this.cardBox.TabIndex = 2;
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.FormattingEnabled = true;
            this.nameBox.Location = new System.Drawing.Point(99, 9);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(174, 21);
            this.nameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // labelControl
            // 
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.Options.UseFont = true;
            this.labelControl.Appearance.Options.UseForeColor = true;
            this.labelControl.Appearance.Options.UseTextOptions = true;
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Location = new System.Drawing.Point(40, 0);
            this.labelControl.Name = "labelControl";
            this.labelControl.Padding = new System.Windows.Forms.Padding(0, 3, 13, 6);
            this.labelControl.Size = new System.Drawing.Size(280, 34);
            this.labelControl.StyleController = this.layoutControl;
            this.labelControl.TabIndex = 4;
            this.labelControl.Text = "Transaction";
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.itemLabel,
            this.layoutControlItem1});
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(40, 40, 0, 0);
            this.layoutControlGroup.Size = new System.Drawing.Size(360, 363);
            this.layoutControlGroup.TextVisible = false;
            // 
            // itemLabel
            // 
            this.itemLabel.Control = this.labelControl;
            this.itemLabel.Location = new System.Drawing.Point(0, 0);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.itemLabel.Size = new System.Drawing.Size(280, 34);
            this.itemLabel.TextSize = new System.Drawing.Size(0, 0);
            this.itemLabel.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(280, 329);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // windowsUIButtonPanel
            // 
            this.windowsUIButtonPanel.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            windowsUIButtonImageOptions1.ImageUri.Uri = "Refresh;Size32x32;GrayScaled";
            windowsUIButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions1.SvgImage")));
            windowsUIButtonImageOptions2.ImageUri.Uri = "Edit/Delete;Size32x32;GrayScaled";
            this.windowsUIButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "save", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Cancel", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "cancel", -1, false)});
            this.windowsUIButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanel.EnableImageTransparency = true;
            this.windowsUIButtonPanel.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanel.Location = new System.Drawing.Point(0, 363);
            this.windowsUIButtonPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButtonPanel.MaximumSize = new System.Drawing.Size(0, 60);
            this.windowsUIButtonPanel.MinimumSize = new System.Drawing.Size(60, 60);
            this.windowsUIButtonPanel.Name = "windowsUIButtonPanel";
            this.windowsUIButtonPanel.Size = new System.Drawing.Size(360, 60);
            this.windowsUIButtonPanel.TabIndex = 5;
            this.windowsUIButtonPanel.Text = "windowsUIButtonPanel";
            this.windowsUIButtonPanel.UseButtonBackgroundImages = false;
            this.windowsUIButtonPanel.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel_ButtonClick);
            // 
            // NewTransaction
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 423);
            this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.windowsUIButtonPanel);
            this.Name = "NewTransaction";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem itemLabel;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cardBox;
        private System.Windows.Forms.ComboBox conceptBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox entityBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox notesBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label7;
    }
}