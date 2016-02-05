namespace WorkshopManager.Forms.RequestsModifierView
{
    partial class RequestsModifierView
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
            this.descriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.carMarkTextBox = new System.Windows.Forms.TextBox();
            this.carMarkModel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.carModelTextBox = new System.Windows.Forms.TextBox();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.carModelLabel = new System.Windows.Forms.Label();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.toolsForRequestButton = new System.Windows.Forms.Button();
            this.descriptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionGroupBox
            // 
            this.descriptionGroupBox.Controls.Add(this.toolsForRequestButton);
            this.descriptionGroupBox.Controls.Add(this.carMarkTextBox);
            this.descriptionGroupBox.Controls.Add(this.carMarkModel);
            this.descriptionGroupBox.Controls.Add(this.descriptionTextBox);
            this.descriptionGroupBox.Controls.Add(this.carModelTextBox);
            this.descriptionGroupBox.Controls.Add(this.ownerTextBox);
            this.descriptionGroupBox.Controls.Add(this.descriptionLabel);
            this.descriptionGroupBox.Controls.Add(this.carModelLabel);
            this.descriptionGroupBox.Controls.Add(this.ownerLabel);
            this.descriptionGroupBox.Location = new System.Drawing.Point(12, 12);
            this.descriptionGroupBox.Name = "descriptionGroupBox";
            this.descriptionGroupBox.Size = new System.Drawing.Size(275, 286);
            this.descriptionGroupBox.TabIndex = 0;
            this.descriptionGroupBox.TabStop = false;
            this.descriptionGroupBox.Text = "Description";
            // 
            // carMarkTextBox
            // 
            this.carMarkTextBox.Location = new System.Drawing.Point(103, 72);
            this.carMarkTextBox.Name = "carMarkTextBox";
            this.carMarkTextBox.Size = new System.Drawing.Size(166, 20);
            this.carMarkTextBox.TabIndex = 9;
            // 
            // carMarkModel
            // 
            this.carMarkModel.AutoSize = true;
            this.carMarkModel.Location = new System.Drawing.Point(7, 75);
            this.carMarkModel.Name = "carMarkModel";
            this.carMarkModel.Size = new System.Drawing.Size(52, 13);
            this.carMarkModel.TabIndex = 8;
            this.carMarkModel.Text = "Car mark:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(103, 98);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(166, 125);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.Location = new System.Drawing.Point(103, 46);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.Size = new System.Drawing.Size(166, 20);
            this.carModelTextBox.TabIndex = 4;
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.Location = new System.Drawing.Point(103, 19);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.Size = new System.Drawing.Size(166, 20);
            this.ownerTextBox.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(7, 101);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description:";
            // 
            // carModelLabel
            // 
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Location = new System.Drawing.Point(7, 49);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(57, 13);
            this.carModelLabel.TabIndex = 1;
            this.carModelLabel.Text = "Car model:";
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Location = new System.Drawing.Point(7, 22);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(58, 13);
            this.ownerLabel.TabIndex = 0;
            this.ownerLabel.Text = "Car owner:";
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(7, 304);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "OK";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(207, 304);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // toolsForRequestButton
            // 
            this.toolsForRequestButton.Location = new System.Drawing.Point(10, 241);
            this.toolsForRequestButton.Name = "toolsForRequestButton";
            this.toolsForRequestButton.Size = new System.Drawing.Size(75, 23);
            this.toolsForRequestButton.TabIndex = 10;
            this.toolsForRequestButton.Text = "Parts";
            this.toolsForRequestButton.UseVisualStyleBackColor = true;
            this.toolsForRequestButton.Click += new System.EventHandler(this.toolsForRequestButton_Click);
            // 
            // RequestsModifierView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 339);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.descriptionGroupBox);
            this.Name = "RequestsModifierView";
            this.Text = "RequestsModifierView";
            this.descriptionGroupBox.ResumeLayout(false);
            this.descriptionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox descriptionGroupBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox carModelTextBox;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label carModelLabel;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox carMarkTextBox;
        private System.Windows.Forms.Label carMarkModel;
        private System.Windows.Forms.Button toolsForRequestButton;
    }
}