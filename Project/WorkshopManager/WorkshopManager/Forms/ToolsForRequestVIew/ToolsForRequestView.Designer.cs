namespace WorkshopManager.Forms.ToolsForRequestView
{
    partial class ToolsForRequestView
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
            this.toolsForRequestLGroupBox = new System.Windows.Forms.GroupBox();
            this.requestPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.allToolsGroupBox = new System.Windows.Forms.GroupBox();
            this.allPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteFromRequestButton = new System.Windows.Forms.Button();
            this.moveToRequestButton = new System.Windows.Forms.Button();
            this.quantityToMoveAtOnceTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel1 = new System.Windows.Forms.Label();
            this.toolsForRequestLGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestPartsDataGridView)).BeginInit();
            this.allToolsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolsForRequestLGroupBox
            // 
            this.toolsForRequestLGroupBox.Controls.Add(this.requestPartsDataGridView);
            this.toolsForRequestLGroupBox.Location = new System.Drawing.Point(13, 13);
            this.toolsForRequestLGroupBox.Name = "toolsForRequestLGroupBox";
            this.toolsForRequestLGroupBox.Size = new System.Drawing.Size(336, 236);
            this.toolsForRequestLGroupBox.TabIndex = 0;
            this.toolsForRequestLGroupBox.TabStop = false;
            this.toolsForRequestLGroupBox.Text = "Order parts";
            // 
            // requestPartsDataGridView
            // 
            this.requestPartsDataGridView.AllowUserToAddRows = false;
            this.requestPartsDataGridView.AllowUserToDeleteRows = false;
            this.requestPartsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.requestPartsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.requestPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestPartsDataGridView.Location = new System.Drawing.Point(7, 20);
            this.requestPartsDataGridView.MultiSelect = false;
            this.requestPartsDataGridView.Name = "requestPartsDataGridView";
            this.requestPartsDataGridView.ReadOnly = true;
            this.requestPartsDataGridView.RowHeadersVisible = false;
            this.requestPartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.requestPartsDataGridView.Size = new System.Drawing.Size(323, 210);
            this.requestPartsDataGridView.TabIndex = 0;
            // 
            // allToolsGroupBox
            // 
            this.allToolsGroupBox.Controls.Add(this.allPartsDataGridView);
            this.allToolsGroupBox.Location = new System.Drawing.Point(365, 13);
            this.allToolsGroupBox.Name = "allToolsGroupBox";
            this.allToolsGroupBox.Size = new System.Drawing.Size(336, 236);
            this.allToolsGroupBox.TabIndex = 1;
            this.allToolsGroupBox.TabStop = false;
            this.allToolsGroupBox.Text = "All parts";
            // 
            // allPartsDataGridView
            // 
            this.allPartsDataGridView.AllowUserToAddRows = false;
            this.allPartsDataGridView.AllowUserToDeleteRows = false;
            this.allPartsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.allPartsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.allPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsDataGridView.Location = new System.Drawing.Point(7, 20);
            this.allPartsDataGridView.MultiSelect = false;
            this.allPartsDataGridView.Name = "allPartsDataGridView";
            this.allPartsDataGridView.ReadOnly = true;
            this.allPartsDataGridView.RowHeadersVisible = false;
            this.allPartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allPartsDataGridView.Size = new System.Drawing.Size(323, 210);
            this.allPartsDataGridView.TabIndex = 1;
            // 
            // DeleteFromRequestButton
            // 
            this.DeleteFromRequestButton.Location = new System.Drawing.Point(20, 268);
            this.DeleteFromRequestButton.Name = "DeleteFromRequestButton";
            this.DeleteFromRequestButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteFromRequestButton.TabIndex = 3;
            this.DeleteFromRequestButton.Text = ">>";
            this.DeleteFromRequestButton.UseVisualStyleBackColor = true;
            this.DeleteFromRequestButton.Click += new System.EventHandler(this.DeleteFromRequestButton_Click);
            // 
            // moveToRequestButton
            // 
            this.moveToRequestButton.Location = new System.Drawing.Point(620, 268);
            this.moveToRequestButton.Name = "moveToRequestButton";
            this.moveToRequestButton.Size = new System.Drawing.Size(75, 23);
            this.moveToRequestButton.TabIndex = 4;
            this.moveToRequestButton.Text = "<<";
            this.moveToRequestButton.UseVisualStyleBackColor = true;
            this.moveToRequestButton.Click += new System.EventHandler(this.moveFewToRequestButton_Click);
            // 
            // quantityToMoveAtOnceTextBox
            // 
            this.quantityToMoveAtOnceTextBox.Location = new System.Drawing.Point(539, 271);
            this.quantityToMoveAtOnceTextBox.Name = "quantityToMoveAtOnceTextBox";
            this.quantityToMoveAtOnceTextBox.Size = new System.Drawing.Size(75, 20);
            this.quantityToMoveAtOnceTextBox.TabIndex = 6;
            // 
            // quantityLabel1
            // 
            this.quantityLabel1.AutoSize = true;
            this.quantityLabel1.Location = new System.Drawing.Point(536, 255);
            this.quantityLabel1.Name = "quantityLabel1";
            this.quantityLabel1.Size = new System.Drawing.Size(38, 13);
            this.quantityLabel1.TabIndex = 8;
            this.quantityLabel1.Text = "Count:";
            // 
            // ToolsForRequestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 301);
            this.Controls.Add(this.quantityLabel1);
            this.Controls.Add(this.quantityToMoveAtOnceTextBox);
            this.Controls.Add(this.moveToRequestButton);
            this.Controls.Add(this.DeleteFromRequestButton);
            this.Controls.Add(this.allToolsGroupBox);
            this.Controls.Add(this.toolsForRequestLGroupBox);
            this.MaximumSize = new System.Drawing.Size(725, 340);
            this.MinimumSize = new System.Drawing.Size(725, 340);
            this.Name = "ToolsForRequestView";
            this.Text = "ToolsForRequestView";
            this.toolsForRequestLGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.requestPartsDataGridView)).EndInit();
            this.allToolsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allPartsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox toolsForRequestLGroupBox;
        private System.Windows.Forms.GroupBox allToolsGroupBox;
        private System.Windows.Forms.Button DeleteFromRequestButton;
        private System.Windows.Forms.Button moveToRequestButton;
        private System.Windows.Forms.DataGridView requestPartsDataGridView;
        private System.Windows.Forms.DataGridView allPartsDataGridView;
        private System.Windows.Forms.TextBox quantityToMoveAtOnceTextBox;
        private System.Windows.Forms.Label quantityLabel1;
    }
}