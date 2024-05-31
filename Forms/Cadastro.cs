using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desafio_Group.Validacoes;
namespace Desafio_Group.Forms
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void TipoCPF_CheckedChanged(object sender, EventArgs e)
        {
            DocumentTxt.Mask = TipoCPF.Checked ? @"000\.000\.000\-00" : @"00\.000\.000\/0000\-00";
        }
    }
}
