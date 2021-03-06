﻿namespace WorkshopManager.Forms.RequestsDatabaseView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.requestsGroupBox = new System.Windows.Forms.GroupBox();
            this.requestsDataGridView = new System.Windows.Forms.DataGridView();
            this.modifyGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.activeComboBox = new System.Windows.Forms.ComboBox();
            this.activeLabel = new System.Windows.Forms.Label();
            this.generatePDFbutton = new System.Windows.Forms.Button();
            this.archivizeUnarchivizeButton = new System.Windows.Forms.Button();
            this.requestsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestsDataGridView)).BeginInit();
            this.modifyGroupBox.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // requestsGroupBox
            // 
            this.requestsGroupBox.AutoSize = true;
            this.requestsGroupBox.Controls.Add(this.requestsDataGridView);
            this.requestsGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.requestsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.requestsGroupBox.Name = "requestsGroupBox";
            this.requestsGroupBox.Size = new System.Drawing.Size(846, 302);
            this.requestsGroupBox.TabIndex = 0;
            this.requestsGroupBox.TabStop = false;
            this.requestsGroupBox.Text = "Requests";
            // 
            // requestsDataGridView
            // 
            this.requestsDataGridView.AllowUserToAddRows = false;
            this.requestsDataGridView.AllowUserToDeleteRows = false;
            this.requestsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.requestsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.requestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.requestsDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.requestsDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.requestsDataGridView.Location = new System.Drawing.Point(3, 16);
            this.requestsDataGridView.MultiSelect = false;
            this.requestsDataGridView.Name = "requestsDataGridView";
            this.requestsDataGridView.ReadOnly = true;
            this.requestsDataGridView.RowHeadersVisible = false;
            this.requestsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.requestsDataGridView.Size = new System.Drawing.Size(840, 283);
            this.requestsDataGridView.TabIndex = 0;
            // 
            // modifyGroupBox
            // 
            this.modifyGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyGroupBox.Controls.Add(this.deleteButton);
            this.modifyGroupBox.Controls.Add(this.editButton);
            this.modifyGroupBox.Controls.Add(this.addButton);
            this.modifyGroupBox.Location = new System.Drawing.Point(871, 41);
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
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(7, 50);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
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
            this.filterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterGroupBox.Controls.Add(this.activeComboBox);
            this.filterGroupBox.Controls.Add(this.activeLabel);
            this.filterGroupBox.Location = new System.Drawing.Point(871, 154);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(187, 39);
            this.filterGroupBox.TabIndex = 2;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Filters:";
            // 
            // activeComboBox
            // 
            this.activeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activeComboBox.FormattingEnabled = true;
            this.activeComboBox.Location = new System.Drawing.Point(59, 13);
            this.activeComboBox.Name = "activeComboBox";
            this.activeComboBox.Size = new System.Drawing.Size(121, 21);
            this.activeComboBox.TabIndex = 1;
            this.activeComboBox.SelectedIndexChanged += new System.EventHandler(this.activeComboBox_SelectedIndexChanged);
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Location = new System.Drawing.Point(6, 16);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(40, 13);
            this.activeLabel.TabIndex = 0;
            this.activeLabel.Text = "Active:";
            // 
            // generatePDFbutton
            // 
            this.generatePDFbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generatePDFbutton.Location = new System.Drawing.Point(871, 199);
            this.generatePDFbutton.Name = "generatePDFbutton";
            this.generatePDFbutton.Size = new System.Drawing.Size(91, 42);
            this.generatePDFbutton.TabIndex = 3;
            this.generatePDFbutton.Text = "Generate Report";
            this.generatePDFbutton.UseVisualStyleBackColor = true;
            this.generatePDFbutton.Click += new System.EventHandler(this.generatePDFbutton_Click);
            // 
            // archivizeUnarchivizeButton
            // 
            this.archivizeUnarchivizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.archivizeUnarchivizeButton.Location = new System.Drawing.Point(968, 199);
            this.archivizeUnarchivizeButton.Name = "archivizeUnarchivizeButton";
            this.archivizeUnarchivizeButton.Size = new System.Drawing.Size(90, 42);
            this.archivizeUnarchivizeButton.TabIndex = 4;
            this.archivizeUnarchivizeButton.Text = "Archive";
            this.archivizeUnarchivizeButton.UseVisualStyleBackColor = true;
            this.archivizeUnarchivizeButton.Click += new System.EventHandler(this.archivizeUnarchivizeButton_Click);
            // 
            // RequestsDatabaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 302);
            this.Controls.Add(this.archivizeUnarchivizeButton);
            this.Controls.Add(this.generatePDFbutton);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.modifyGroupBox);
            this.Controls.Add(this.requestsGroupBox);
            this.MaximumSize = new System.Drawing.Size(1080, 1080);
            this.MinimumSize = new System.Drawing.Size(1080, 340);
            this.Name = "RequestsDatabaseView";
            this.Text = "Form1";
            this.requestsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.requestsDataGridView)).EndInit();
            this.modifyGroupBox.ResumeLayout(false);
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button generatePDFbutton;
        private System.Windows.Forms.Button archivizeUnarchivizeButton;
    }
}

