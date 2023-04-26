namespace User_Control_Panel_Acitivity
{
    partial class Panel2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inPutTwo = new System.Windows.Forms.Label();
            this.inPutOne = new System.Windows.Forms.Label();
            this.panell2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(27, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 14;
            // 
            // inPutTwo
            // 
            this.inPutTwo.AutoSize = true;
            this.inPutTwo.Location = new System.Drawing.Point(24, 171);
            this.inPutTwo.Name = "inPutTwo";
            this.inPutTwo.Size = new System.Drawing.Size(58, 13);
            this.inPutTwo.TabIndex = 13;
            this.inPutTwo.Text = "Input Two:";
            // 
            // inPutOne
            // 
            this.inPutOne.AutoSize = true;
            this.inPutOne.Location = new System.Drawing.Point(24, 82);
            this.inPutOne.Name = "inPutOne";
            this.inPutOne.Size = new System.Drawing.Size(57, 13);
            this.inPutOne.TabIndex = 12;
            this.inPutOne.Text = "Input One:";
            // 
            // panell2
            // 
            this.panell2.AutoSize = true;
            this.panell2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panell2.Location = new System.Drawing.Point(12, 10);
            this.panell2.Name = "panell2";
            this.panell2.Size = new System.Drawing.Size(119, 25);
            this.panell2.TabIndex = 11;
            this.panell2.Text = "Panel Two!";
            this.panell2.Click += new System.EventHandler(this.panell1_Click);
            // 
            // Panel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.inPutTwo);
            this.Controls.Add(this.inPutOne);
            this.Controls.Add(this.panell2);
            this.Name = "Panel2";
            this.Size = new System.Drawing.Size(292, 310);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label inPutTwo;
        private System.Windows.Forms.Label inPutOne;
        private System.Windows.Forms.Label panell2;

    }
}
