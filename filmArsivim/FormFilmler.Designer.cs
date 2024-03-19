namespace filmArsivim
{
    partial class FormFilmler
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
            this.dgvFilmler = new System.Windows.Forms.DataGridView();
            this.elestiriler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFilmler
            // 
            this.dgvFilmler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmler.Location = new System.Drawing.Point(12, 169);
            this.dgvFilmler.Name = "dgvFilmler";
            this.dgvFilmler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmler.Size = new System.Drawing.Size(776, 269);
            this.dgvFilmler.TabIndex = 0;
            // 
            // elestiriler
            // 
            this.elestiriler.Location = new System.Drawing.Point(629, 140);
            this.elestiriler.Name = "elestiriler";
            this.elestiriler.Size = new System.Drawing.Size(159, 23);
            this.elestiriler.TabIndex = 1;
            this.elestiriler.Text = "Elestiri Tablosu";
            this.elestiriler.UseVisualStyleBackColor = true;
            this.elestiriler.Click += new System.EventHandler(this.elestiriler_Click);
            // 
            // FormFilmler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.elestiriler);
            this.Controls.Add(this.dgvFilmler);
            this.Name = "FormFilmler";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFilmler;
        private System.Windows.Forms.Button elestiriler;
    }
}

