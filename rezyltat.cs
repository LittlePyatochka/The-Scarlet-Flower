using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class rezyltat : Form
    {
       
        public rezyltat()
        {
            InitializeComponent();
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Камышанская Ксения.\r\nУченица 10 класса.\r\nСлушательгруппы К06-04.", "Автор", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnzakonpr_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
