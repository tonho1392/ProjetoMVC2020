using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJETOMVCA03.DALMVC;
using PROJETOMVCA03.BLLMVC;
using PROJETOMVCA03.DTOMVC;

namespace PROJETOMVCA03
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void txt_cpfa03_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            try
            {
                DTOMVCA03 objDTO = new DTOMVCA03();
                BLLMVCA03 objBLL = new BLLMVCA03();

                objDTO.Cpf_cliente = txt_cpfa03.Text.Trim();
                objDTO.Nome_cliente = txt_nomea03.Text.Trim();
                objDTO.Nome_mae = txt_nomemaea03.Text.Trim();

                if (objBLL.Autenticar(objDTO.Cpf_cliente, objDTO.Nome_cliente, objDTO.Nome_mae))
                {
                    MessageBox.Show("Beneficiário localizado no banco de dados. Processo em análise!");
                }
                else
                {
                    MessageBox.Show("Beneficiário não Localizado no banco de dados. Benefício Negado!");
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Erro: \n" + fe.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception fe)
            {
                MessageBox.Show(fe.Message);
            }
        }
    }
}
