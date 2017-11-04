using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionDemoInCSharp
{
    public partial class frmExceptionHandling : Form
    {
        public frmExceptionHandling()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(Convert.ToInt32(txtANumber.Text) + 42);
        }
    }
}
