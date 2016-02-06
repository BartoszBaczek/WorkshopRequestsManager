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
            this.moveSingleToAllButton = new System.Windows.Forms.Button();
            this.moveFewToAllButton = new System.Windows.Forms.Button();
            this.moveFewToRequestButton = new System.Windows.Forms.Button();
            this.mvoeSingleToRequestButton = new System.Windows.Forms.Button();
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
            this.toolsForRequestLGroupBox.Text = "Narzędzia zlecenia";
            // 
            // requestPartsDataGridView
            // 
            this.requestPartsDataGridView.AllowUserToAddRows = false;
            this.requestPartsDataGridView.AllowUserToDeleteRows = false;
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
            this.allToolsGroupBox.Text = "Wszystkie narzędzia";
            // 
            // allPartsDataGridView
            // 
            this.allPartsDataGridView.AllowUserToAddRows = false;
            this.allPartsDataGridView.AllowUserToDeleteRows = false;
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
            // moveSingleToAllButton
            // 
            this.moveSingleToAllButton.Location = new System.Drawing.Point(19, 256);
            this.moveSingleToAllButton.Name = "moveSingleToAllButton";
            this.moveSingleToAllButton.Size = new System.Drawing.Size(75, 23);
            this.moveSingleToAllButton.TabIndex = 2;
            this.moveSingleToAllButton.Text = ">";
            this.moveSingleToAllButton.UseVisualStyleBackColor = true;
            this.moveSingleToAllButton.Click += new System.EventHandler(this.moveSingleToAllButton_Click);
            // 
            // moveFewToAllButton
            // 
            this.moveFewToAllButton.Location = new System.Drawing.Point(186, 256);
            this.moveFewToAllButton.Name = "moveFewToAllButton";
            this.moveFewToAllButton.Size = new System.Drawing.Size(75, 23);
            this.moveFewToAllButton.TabIndex = 3;
            this.moveFewToAllButton.Text = ">>";
            this.moveFewToAllButton.UseVisualStyleBackColor = true;
            this.moveFewToAllButton.Click += new System.EventHandler(this.moveFewToAllButton_Click);
            // 
            // moveFewToRequestButton
            // 
            this.moveFewToRequestButton.Location = new System.Drawing.Point(441, 256);
            this.moveFewToRequestButton.Name = "moveFewToRequestButton";
            this.moveFewToRequestButton.Size = new System.Drawing.Size(75, 23);
            this.moveFewToRequestButton.TabIndex = 4;
            this.moveFewToRequestButton.Text = "<<";
            this.moveFewToRequestButton.UseVisualStyleBackColor = true;
            this.moveFewToRequestButton.Click += new System.EventHandler(this.moveFewToRequestButton_Click);
            // 
            // mvoeSingleToRequestButton
            // 
            this.mvoeSingleToRequestButton.Location = new System.Drawing.Point(611, 256);
            this.mvoeSingleToRequestButton.Name = "mvoeSingleToRequestButton";
            this.mvoeSingleToRequestButton.Size = new System.Drawing.Size(75, 23);
            this.mvoeSingleToRequestButton.TabIndex = 5;
            this.mvoeSingleToRequestButton.TabStop = false;
            this.mvoeSingleToRequestButton.Text = "<";
            this.mvoeSingleToRequestButton.UseVisualStyleBackColor = true;
            this.mvoeSingleToRequestButton.Click += new System.EventHandler(this.mvoeSingleToRequestButton_Click);
            // 
            // quantityToMoveAtOnceTextBox
            // 
            this.quantityToMoveAtOnceTextBox.Location = new System.Drawing.Point(326, 270);
            this.quantityToMoveAtOnceTextBox.Name = "quantityToMoveAtOnceTextBox";
            this.quantityToMoveAtOnceTextBox.Size = new System.Drawing.Size(75, 20);
            this.quantityToMoveAtOnceTextBox.TabIndex = 6;
            // 
            // quantityLabel1
            // 
            this.quantityLabel1.AutoSize = true;
            this.quantityLabel1.Location = new System.Drawing.Point(323, 254);
            this.quantityLabel1.Name = "quantityLabel1";
            this.quantityLabel1.Size = new System.Drawing.Size(64, 13);
            this.quantityLabel1.TabIndex = 8;
            this.quantityLabel1.Text = "Liczebność:";
            // 
            // ToolsForRequestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 312);
            this.Controls.Add(this.quantityLabel1);
            this.Controls.Add(this.quantityToMoveAtOnceTextBox);
            this.Controls.Add(this.mvoeSingleToRequestButton);
            this.Controls.Add(this.moveFewToRequestButton);
            this.Controls.Add(this.moveFewToAllButton);
            this.Controls.Add(this.moveSingleToAllButton);
            this.Controls.Add(this.allToolsGroupBox);
            this.Controls.Add(this.toolsForRequestLGroupBox);
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
        private System.Windows.Forms.Button moveSingleToAllButton;
        private System.Windows.Forms.Button moveFewToAllButton;
        private System.Windows.Forms.Button moveFewToRequestButton;
        private System.Windows.Forms.Button mvoeSingleToRequestButton;
        private System.Windows.Forms.DataGridView requestPartsDataGridView;
        private System.Windows.Forms.DataGridView allPartsDataGridView;
        private System.Windows.Forms.TextBox quantityToMoveAtOnceTextBox;
        private System.Windows.Forms.Label quantityLabel1;
    }
}