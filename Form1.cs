using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piXel_UBS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttongoruntule_Click(object sender, EventArgs e)
        {
            goruntu goruntufrm = new goruntu();
            goruntufrm.Show();

        }

        private void buttonkayıt_Click(object sender, EventArgs e)
        {
            kayıt kayıtfrm = new kayıt();
            kayıtfrm.Show();
        }
    }
}
