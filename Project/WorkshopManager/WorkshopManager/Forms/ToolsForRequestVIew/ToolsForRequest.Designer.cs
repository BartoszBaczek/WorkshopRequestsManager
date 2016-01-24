namespace WorkshopManager.Forms.ToolsForRequestView
{
    partial class ToolsForRequest
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
            this.allToolsGroupBox = new System.Windows.Forms.GroupBox();
            this.allToolsListBox = new System.Windows.Forms.ListBox();
            this.toolsForRequestListBox = new System.Windows.Forms.ListBox();
            this.moveSingleToAllButton = new System.Windows.Forms.Button();
            this.moveFewToAllButton = new System.Windows.Forms.Button();
            this.moveFewToRequestButton = new System.Windows.Forms.Button();
            this.mvoeSingleToRequestButton = new System.Windows.Forms.Button();
            this.toolsForRequestLGroupBox.SuspendLayout();
            this.allToolsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolsForRequestLGroupBox
            // 
            this.toolsForRequestLGroupBox.Controls.Add(this.toolsForRequestListBox);
            this.toolsForRequestLGroupBox.Location = new System.Drawing.Point(13, 13);
            this.toolsForRequestLGroupBox.Name = "toolsForRequestLGroupBox";
            this.toolsForRequestLGroupBox.Size = new System.Drawing.Size(200, 236);
            this.toolsForRequestLGroupBox.TabIndex = 0;
            this.toolsForRequestLGroupBox.TabStop = false;
            this.toolsForRequestLGroupBox.Text = "Narzędzia zlecenia";
            // 
            // allToolsGroupBox
            // 
            this.allToolsGroupBox.Controls.Add(this.allToolsListBox);
            this.allToolsGroupBox.Location = new System.Drawing.Point(246, 13);
            this.allToolsGroupBox.Name = "allToolsGroupBox";
            this.allToolsGroupBox.Size = new System.Drawing.Size(200, 236);
            this.allToolsGroupBox.TabIndex = 1;
            this.allToolsGroupBox.TabStop = false;
            this.allToolsGroupBox.Text = "Wszystkie narzędzia";
            // 
            // allToolsListBox
            // 
            this.allToolsListBox.FormattingEnabled = true;
            this.allToolsListBox.Location = new System.Drawing.Point(7, 20);
            this.allToolsListBox.Name = "allToolsListBox";
            this.allToolsListBox.Size = new System.Drawing.Size(187, 212);
            this.allToolsListBox.TabIndex = 0;
            // 
            // toolsForRequestListBox
            // 
            this.toolsForRequestListBox.FormattingEnabled = true;
            this.toolsForRequestListBox.Location = new System.Drawing.Point(6, 20);
            this.toolsForRequestListBox.Name = "toolsForRequestListBox";
            this.toolsForRequestListBox.Size = new System.Drawing.Size(187, 212);
            this.toolsForRequestListBox.TabIndex = 1;
            // 
            // moveSingleToAllButton
            // 
            this.moveSingleToAllButton.Location = new System.Drawing.Point(19, 256);
            this.moveSingleToAllButton.Name = "moveSingleToAllButton";
            this.moveSingleToAllButton.Size = new System.Drawing.Size(75, 23);
            this.moveSingleToAllButton.TabIndex = 2;
            this.moveSingleToAllButton.Text = ">";
            this.moveSingleToAllButton.UseVisualStyleBackColor = true;
            // 
            // moveFewToAllButton
            // 
            this.moveFewToAllButton.Location = new System.Drawing.Point(131, 256);
            this.moveFewToAllButton.Name = "moveFewToAllButton";
            this.moveFewToAllButton.Size = new System.Drawing.Size(75, 23);
            this.moveFewToAllButton.TabIndex = 3;
            this.moveFewToAllButton.Text = ">>";
            this.moveFewToAllButton.UseVisualStyleBackColor = true;
            // 
            // moveFewToRequestButton
            // 
            this.moveFewToRequestButton.Location = new System.Drawing.Point(253, 256);
            this.moveFewToRequestButton.Name = "moveFewToRequestButton";
            this.moveFewToRequestButton.Size = new System.Drawing.Size(75, 23);
            this.moveFewToRequestButton.TabIndex = 4;
            this.moveFewToRequestButton.Text = "<<";
            this.moveFewToRequestButton.UseVisualStyleBackColor = true;
            // 
            // mvoeSingleToRequestButton
            // 
            this.mvoeSingleToRequestButton.Location = new System.Drawing.Point(365, 255);
            this.mvoeSingleToRequestButton.Name = "mvoeSingleToRequestButton";
            this.mvoeSingleToRequestButton.Size = new System.Drawing.Size(75, 23);
            this.mvoeSingleToRequestButton.TabIndex = 5;
            this.mvoeSingleToRequestButton.TabStop = false;
            this.mvoeSingleToRequestButton.Text = "<";
            this.mvoeSingleToRequestButton.UseVisualStyleBackColor = true;
            // 
            // ToolsForRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 288);
            this.Controls.Add(this.mvoeSingleToRequestButton);
            this.Controls.Add(this.moveFewToRequestButton);
            this.Controls.Add(this.moveFewToAllButton);
            this.Controls.Add(this.moveSingleToAllButton);
            this.Controls.Add(this.allToolsGroupBox);
            this.Controls.Add(this.toolsForRequestLGroupBox);
            this.Name = "ToolsForRequest";
            this.Text = "ToolsForRequest";
            this.toolsForRequestLGroupBox.ResumeLayout(false);
            this.allToolsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox toolsForRequestLGroupBox;
        private System.Windows.Forms.ListBox toolsForRequestListBox;
        private System.Windows.Forms.GroupBox allToolsGroupBox;
        private System.Windows.Forms.ListBox allToolsListBox;
        private System.Windows.Forms.Button moveSingleToAllButton;
        private System.Windows.Forms.Button moveFewToAllButton;
        private System.Windows.Forms.Button moveFewToRequestButton;
        private System.Windows.Forms.Button mvoeSingleToRequestButton;
    }
}