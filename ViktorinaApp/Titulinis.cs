using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViktorinaApp
{
    public partial class Titulinis : Form
    {
        public Titulinis()
        {
            InitializeComponent();
        }

        private void btnZaisti_Click(object sender, EventArgs e)
        {
            this.Hide();
            var zaidimas = new Zaidimas();
            zaidimas.Closed += (s, args) => this.Close();
            zaidimas.Show();
        }

        private void btnLenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            var lenta = new Lenta();
            lenta.Closed += (s, args) => this.Close();
            lenta.Show();
        }
    }
}
