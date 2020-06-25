using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJETOMVCA03.DALMVC;

namespace PROJETOMVCA03.BLLMVC
{
    class BLLMVCA03
    {

        private DALMVCA03 DaoBanco = new DALMVCA03();
        public Boolean Autenticar(string cpf, string nome, string mae)
        {
            string consulta = string.Format($"select * from tbl_clientea03 where cpf_cliente = '{cpf}' and nome_cliente = '{nome}' and nome_mae = '{mae}';");
            DataTable dt = DaoBanco.executarConsulta(consulta);

            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
