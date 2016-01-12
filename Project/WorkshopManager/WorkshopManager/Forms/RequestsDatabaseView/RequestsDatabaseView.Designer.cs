namespace WorkshopManager.Forms.RequestsDatabaseView
{
    partial class RequestsDatabaseView
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
            this.requestsGroupBox = new System.Windows.Forms.GroupBox();
            this.requestsDataGridView = new System.Windows.Forms.DataGridView();
            this.modifyGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.activeComboBox = new System.Windows.Forms.ComboBox();
            this.activeLabel = new System.Windows.Forms.Label();
            this.requestsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestsDataGridView)).BeginInit();
            this.modifyGroupBox.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // requestsGroupBox
            // 
            this.requestsGroupBox.Controls.Add(this.requestsDataGridView);
            this.requestsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.requestsGroupBox.Name = "requestsGroupBox";
            this.requestsGroupBox.Size = new System.Drawing.Size(386, 278);
            this.requestsGroupBox.TabIndex = 0;
            this.requestsGroupBox.TabStop = false;
            this.requestsGroupBox.Text = "Requests";
            // 
            // requestsDataGridView
            // 
            this.requestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestsDataGridView.Location = new System.Drawing.Point(7, 20);
            this.requestsDataGridView.Name = "requestsDataGridView";
            this.requestsDataGridView.Size = new System.Drawing.Size(373, 252);
            this.requestsDataGridView.TabIndex = 0;
            // 
            // modifyGroupBox
            // 
            this.modifyGroupBox.Controls.Add(this.deleteButton);
            this.modifyGroupBox.Controls.Add(this.editButton);
            this.modifyGroupBox.Controls.Add(this.addButton);
            this.modifyGroupBox.Location = new System.Drawing.Point(418, 12);
            this.modifyGroupBox.Name = "modifyGroupBox";
            this.modifyGroupBox.Size = new System.Drawing.Size(91, 107);
            this.modifyGroupBox.TabIndex = 1;
            this.modifyGroupBox.TabStop = false;
            this.modifyGroupBox.Text = "Modify";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(7, 79);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(7, 50);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(7, 20);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.activeComboBox);
            this.filterGroupBox.Controls.Add(this.activeLabel);
            this.filterGroupBox.Location = new System.Drawing.Point(425, 125);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(200, 100);
            this.filterGroupBox.TabIndex = 2;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Filters:";
            // 
            // activeComboBox
            // 
            this.activeComboBox.FormattingEnabled = true;
            this.activeComboBox.Location = new System.Drawing.Point(60, 28);
            this.activeComboBox.Name = "activeComboBox";
            this.activeComboBox.Size = new System.Drawing.Size(121, 21);
            this.activeComboBox.TabIndex = 1;
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Location = new System.Drawing.Point(7, 31);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(40, 13);
            this.activeLabel.TabIndex = 0;
            this.activeLabel.Text = "Active:";
            // 
            // RequestsDatabaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 290);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.modifyGroupBox);
            this.Controls.Add(this.requestsGroupBox);
            this.Name = "RequestsDatabaseView";
            this.Text = "Form1";
            this.requestsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.requestsDataGridView)).EndInit();
            this.modifyGroupBox.ResumeLayout(false);
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox requestsGroupBox;
        private System.Windows.Forms.DataGridView requestsDataGridView;
        private System.Windows.Forms.GroupBox modifyGroupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.ComboBox activeComboBox;
        private System.Windows.Forms.Label activeLabel;
    }
}

