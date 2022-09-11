using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade1_Repeticao
{
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void Btn_Exe1_Click(object sender, EventArgs e)
        {
            frm_Exe1 frm_exe1 = new frm_Exe1();
            frm_exe1.Show();
        }

        private void Btn_Exe2_Click(object sender, EventArgs e)
        {
            frm_Exe2 frm_exe2 = new frm_Exe2();
            frm_exe2.Show();
        }
    }
}
