namespace ReadExcelToWinForm
{
    partial class Form1
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
            this.dataExcelGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataExcelGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataExcelGridView
            // 
            this.dataExcelGridView.AllowUserToAddRows = false;
            this.dataExcelGridView.AllowUserToDeleteRows = false;
            this.dataExcelGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataExcelGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataExcelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataExcelGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataExcelGridView.Location = new System.Drawing.Point(0, 0);
            this.dataExcelGridView.Name = "dataExcelGridView";
            this.dataExcelGridView.ReadOnly = true;
            this.dataExcelGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataExcelGridView.Size = new System.Drawing.Size(674, 469);
            this.dataExcelGridView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 469);
            this.Controls.Add(this.dataExcelGridView);
            this.Name = "Form1";
            this.Text = "Import Excel File to DataGrid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataExcelGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataExcelGridView;
    }
}

