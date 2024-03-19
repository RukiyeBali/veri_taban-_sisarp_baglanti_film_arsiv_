namespace filmArsivim
{
    partial class FormElestiriler
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
            this.dgvElestiriler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElestiriler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvElestiriler
            // 
            this.dgvElestiriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvElestiriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElestiriler.Location = new System.Drawing.Point(12, 224);
            this.dgvElestiriler.Name = "dgvElestiriler";
            this.dgvElestiriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvElestiriler.Size = new System.Drawing.Size(776, 214);
            this.dgvElestiriler.TabIndex = 0;
            // 
            // FormElestiriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvElestiriler);
            this.Name = "FormElestiriler";
            this.Text = "FormElestiriler";
            this.Load += new System.EventHandler(this.FormElestiriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElestiriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvElestiriler;
    }
}