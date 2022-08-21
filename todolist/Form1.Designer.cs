namespace todolist
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb1 = new System.Windows.Forms.TextBox();
            this.add_bttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.thing1label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(109, 116);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(220, 23);
            this.tb1.TabIndex = 0;
            this.tb1.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            // 
            // add_bttn
            // 
            this.add_bttn.Location = new System.Drawing.Point(254, 214);
            this.add_bttn.Name = "add_bttn";
            this.add_bttn.Size = new System.Drawing.Size(75, 23);
            this.add_bttn.TabIndex = 1;
            this.add_bttn.Text = "Add";
            this.add_bttn.UseVisualStyleBackColor = true;
            this.add_bttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "things to do ";
            // 
            // thing1label
            // 
            this.thing1label.AutoSize = true;
            this.thing1label.Location = new System.Drawing.Point(41, 124);
            this.thing1label.Name = "thing1label";
            this.thing1label.Size = new System.Drawing.Size(41, 15);
            this.thing1label.TabIndex = 5;
            this.thing1label.Text = "thing1";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 318);
            this.Controls.Add(this.thing1label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_bttn);
            this.Controls.Add(this.tb1);
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb1;
        private Button add_bttn;
        private Label label1;
        private Label thing1label;
    }
}