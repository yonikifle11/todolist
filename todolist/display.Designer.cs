namespace todolist
{
    partial class display
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
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.thing1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thing1});
            this.DGV1.Location = new System.Drawing.Point(12, 99);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowTemplate.Height = 25;
            this.DGV1.Size = new System.Drawing.Size(751, 255);
            this.DGV1.TabIndex = 0;
            this.DGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellContentClick);
            // 
            // thing1
            // 
            this.thing1.HeaderText = "thing1";
            this.thing1.Name = "thing1";
            // 
            // display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGV1);
            this.Name = "display";
            this.Text = "display";
            this.Load += new System.EventHandler(this.display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DGV1;
        private DataGridViewTextBoxColumn thing1;
    }
}