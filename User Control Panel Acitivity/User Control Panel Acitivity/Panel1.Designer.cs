namespace User_Control_Panel_Acitivity
{
    partial class Panel1
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
            this.panell1 = new System.Windows.Forms.Label();
            this.inPutBoxTwo = new System.Windows.Forms.TextBox();
            this.inPutBoxOne = new System.Windows.Forms.TextBox();
            this.inPutTwo = new System.Windows.Forms.Label();
            this.inPutOne = new System.Windows.Forms.Label();
            this.subButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panell1
            // 
            this.panell1.AutoSize = true;
            this.panell1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panell1.Location = new System.Drawing.Point(18, 14);
            this.panell1.Name = "panell1";
            this.panell1.Size = new System.Drawing.Size(119, 25);
            this.panell1.TabIndex = 0;
            this.panell1.Text = "Panel One!";
            // 
            // inPutBoxTwo
            // 
            this.inPutBoxTwo.Location = new System.Drawing.Point(23, 167);
            this.inPutBoxTwo.Name = "inPutBoxTwo";
            this.inPutBoxTwo.Size = new System.Drawing.Size(146, 20);
            this.inPutBoxTwo.TabIndex = 10;
            // 
            // inPutBoxOne
            // 
            this.inPutBoxOne.Location = new System.Drawing.Point(23, 105);
            this.inPutBoxOne.Name = "inPutBoxOne";
            this.inPutBoxOne.Size = new System.Drawing.Size(146, 20);
            this.inPutBoxOne.TabIndex = 9;
            // 
            // inPutTwo
            // 
            this.inPutTwo.AutoSize = true;
            this.inPutTwo.Location = new System.Drawing.Point(20, 151);
            this.inPutTwo.Name = "inPutTwo";
            this.inPutTwo.Size = new System.Drawing.Size(58, 13);
            this.inPutTwo.TabIndex = 8;
            this.inPutTwo.Text = "Input Two:";
            // 
            // inPutOne
            // 
            this.inPutOne.AutoSize = true;
            this.inPutOne.Location = new System.Drawing.Point(20, 89);
            this.inPutOne.Name = "inPutOne";
            this.inPutOne.Size = new System.Drawing.Size(57, 13);
            this.inPutOne.TabIndex = 7;
            this.inPutOne.Text = "Input One:";
            // 
            // subButt
            // 
            this.subButt.Location = new System.Drawing.Point(23, 209);
            this.subButt.Name = "subButt";
            this.subButt.Size = new System.Drawing.Size(75, 23);
            this.subButt.TabIndex = 11;
            this.subButt.Text = "Submit";
            this.subButt.UseVisualStyleBackColor = true;
            this.subButt.Click += new System.EventHandler(this.subButt_Click);
            // 
            // Panel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.Controls.Add(this.subButt);
            this.Controls.Add(this.inPutBoxTwo);
            this.Controls.Add(this.inPutBoxOne);
            this.Controls.Add(this.inPutTwo);
            this.Controls.Add(this.inPutOne);
            this.Controls.Add(this.panell1);
            this.Name = "Panel1";
            this.Size = new System.Drawing.Size(318, 326);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label panell1;
        private System.Windows.Forms.TextBox inPutBoxTwo;
        private System.Windows.Forms.TextBox inPutBoxOne;
        private System.Windows.Forms.Label inPutTwo;
        private System.Windows.Forms.Label inPutOne;
        private System.Windows.Forms.Button subButt;
    }
}
