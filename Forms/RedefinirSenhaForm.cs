using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Group.Forms
{
    public partial class RedefinirSenhaForm : Form
    {
        public RedefinirSenhaForm()
        {
            InitializeComponent();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();

            //realizar restante de validações no banco de dados
        }
    }
}
