using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Control_Panel_Acitivity
{
    public partial class Panel1 : UserControl
    {
        public Panel1()
        {
            InitializeComponent();
        }

        private void subButt_Click(object sender, EventArgs e)
        {
            var inPutBoxOne = this.inPutBoxOne.Text;
            var inPutBoxTwo = this.inPutBoxTwo.Text;

            var parent = this.Parent as Form1;

            parent.InPutWan = inPutBoxOne;
            parent.InPutToo = inPutBoxTwo;
        }

        
    }
}
