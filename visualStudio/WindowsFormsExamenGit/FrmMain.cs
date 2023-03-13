using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExamenGit
{
    public partial class FrmMain : Form
    {
        FrmAnimal frmAnimal = null;
        FrmViatge frmViatge = null;
        FrmMenjar frmMenjar = null;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAnimal = new FrmAnimal();
            frmAnimal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmViatge = new FrmViatge();
            frmViatge.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMenjar=new FrmMenjar();
            frmMenjar.Show();
        }
    }
}
