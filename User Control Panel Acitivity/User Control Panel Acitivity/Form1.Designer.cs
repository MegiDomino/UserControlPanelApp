namespace User_Control_Panel_Acitivity
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.palButt2 = new System.Windows.Forms.Button();
            this.palButt1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inPutTwo = new System.Windows.Forms.Label();
            this.inPutOne = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.ucpa = new System.Windows.Forms.Label();
            this.panel21 = new User_Control_Panel_Acitivity.Panel2();
            this.panel11 = new User_Control_Panel_Acitivity.Panel1();
            this.inbPutTwo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.palButt2);
            this.panel1.Controls.Add(this.palButt1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 420);
            this.panel1.TabIndex = 0;
            // 
            // palButt2
            // 
            this.palButt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palButt2.Location = new System.Drawing.Point(39, 218);
            this.palButt2.Name = "palButt2";
            this.palButt2.Size = new System.Drawing.Size(122, 34);
            this.palButt2.TabIndex = 3;
            this.palButt2.Text = "Panel Two";
            this.palButt2.UseVisualStyleBackColor = true;
            this.palButt2.Click += new System.EventHandler(this.palButt2_Click);
            // 
            // palButt1
            // 
            this.palButt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palButt1.Location = new System.Drawing.Point(40, 131);
            this.palButt1.Name = "palButt1";
            this.palButt1.Size = new System.Drawing.Size(121, 33);
            this.palButt1.TabIndex = 2;
            this.palButt1.Text = "Panel One";
            this.palButt1.UseVisualStyleBackColor = true;
            this.palButt1.Click += new System.EventHandler(this.palButt1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.inbPutTwo);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.inPutTwo);
            this.panel2.Controls.Add(this.inPutOne);
            this.panel2.Controls.Add(this.data);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(659, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 420);
            this.panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 5;
            // 
            // inPutTwo
            // 
            this.inPutTwo.Location = new System.Drawing.Point(0, 0);
            this.inPutTwo.Name = "inPutTwo";
            this.inPutTwo.Size = new System.Drawing.Size(100, 23);
            this.inPutTwo.TabIndex = 7;
            // 
            // inPutOne
            // 
            this.inPutOne.AutoSize = true;
            this.inPutOne.Location = new System.Drawing.Point(25, 104);
            this.inPutOne.Name = "inPutOne";
            this.inPutOne.Size = new System.Drawing.Size(57, 13);
            this.inPutOne.TabIndex = 3;
            this.inPutOne.Text = "Input One:";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.Location = new System.Drawing.Point(13, 27);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(80, 31);
            this.data.TabIndex = 2;
            this.data.Text = "Data:";
            // 
            // ucpa
            // 
            this.ucpa.AutoSize = true;
            this.ucpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucpa.Location = new System.Drawing.Point(206, 9);
            this.ucpa.Name = "ucpa";
            this.ucpa.Size = new System.Drawing.Size(383, 31);
            this.ucpa.TabIndex = 0;
            this.ucpa.Text = "User Control Panel Application";
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.Tomato;
            this.panel21.Location = new System.Drawing.Point(206, 43);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(447, 365);
            this.panel21.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel11.Location = new System.Drawing.Point(206, 43);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(447, 365);
            this.panel11.TabIndex = 2;
            // 
            // inbPutTwo
            // 
            this.inbPutTwo.AutoSize = true;
            this.inbPutTwo.Location = new System.Drawing.Point(25, 193);
            this.inbPutTwo.Name = "inbPutTwo";
            this.inbPutTwo.Size = new System.Drawing.Size(58, 13);
            this.inbPutTwo.TabIndex = 8;
            this.inbPutTwo.Text = "Input Two:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 420);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.ucpa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label inPutTwo;
        private System.Windows.Forms.Label inPutOne;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label ucpa;
        private Panel1 panel11;
        private Panel2 panel21;
        private System.Windows.Forms.Button palButt2;
        private System.Windows.Forms.Button palButt1;
        private System.Windows.Forms.Label inbPutTwo;
    }
}

