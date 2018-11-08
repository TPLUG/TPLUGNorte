using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
        }

        private void búsquedaPorSignaturaTopográficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaSignaturaTopografica busquedaST = new BusquedaSignaturaTopografica();
            busquedaST.MdiParent = this;
            busquedaST.Show();
        }

        private void autoridadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autoridades autoridadUI = new Autoridades();
            autoridadUI.MdiParent = this;
            autoridadUI.Show();
        }
    }
}
