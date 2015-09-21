using LojaComercial.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LojaComercial.dao
{
    class VendaDao : GenericDao
    {
        public Boolean cadastrar(Venda venda)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = SqlConn;

                String sql = "insert into vendas(codNota,operador_id,data) values(@PCodNota,@POperador_id,@PData);";
                sql += "Set @id = scope_identity();";

                int conta = 1;
                foreach (VendaProduto vendaProduto in venda.VendaProdutos)
                {
                    sql += "insert into vendasprodutos(vendas_id,produtos_id,quantidade,precoVenda) ";
                    sql += "values(@id,@PProduto" + @conta + ",@PQuantidade" + @conta + ",@PPrecoVenda" + @conta + ");";

                    sqlCommand.Parameters.AddWithValue("PProduto"+@conta, vendaProduto.Produto.Id);
                    sqlCommand.Parameters.AddWithValue("PQuantidade"+@conta, vendaProduto.Quantidade);
                    sqlCommand.Parameters.AddWithValue("PPrecoVenda"+@conta, vendaProduto.PrecoVenda);
                }

                sqlCommand.CommandText = "";

                sqlCommand.Parameters.AddWithValue("PCodNota", venda.CodNota);
                sqlCommand.Parameters.AddWithValue("POperador_id", venda.Operador.Id);
                sqlCommand.Parameters.AddWithValue("PData", venda.Data);

                try
                {
                    if (sqlCommand.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);

                    return false;
                }
            }
        }

        public int numeroUltimaNota()
        {
            int resultado = -1;

            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = SqlConn;

                sqlCommand.CommandText = "select isnull(max(codNota),0) from vendas";

                try
                {
                    resultado = (int)sqlCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);

                    return -1;
                }
            }

            return resultado;
        }
    }
}
