using LojaComercial.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LojaComercial.dao
{
    class FornecedorDao : GenericDao
    {
        public Boolean cadastrar(Fornecedor fornecedor)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = SqlConn;

                sqlCommand.CommandText = "insert into fornecedores(nome) values(@PNome)";

                sqlCommand.Parameters.AddWithValue("PNome", fornecedor.Nome);

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

        public Boolean editar(Fornecedor fornecedor)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = SqlConn;

                sqlCommand.CommandText = "update fornecedores set nome = @PNome where id = @PId";

                sqlCommand.Parameters.AddWithValue("PId", fornecedor.Id);
                sqlCommand.Parameters.AddWithValue("PNome", fornecedor.Nome);

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

        public Boolean deletar(Fornecedor fornecedor)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = SqlConn;

                sqlCommand.CommandText = "delete from fornecedores where id = @PId";

                sqlCommand.Parameters.AddWithValue("PId", fornecedor.Id);

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
    }
}
