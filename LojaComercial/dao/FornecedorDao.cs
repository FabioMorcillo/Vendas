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

        public List<Fornecedor> lista()
        {
            List<Fornecedor> lista = new List<Fornecedor>();

            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = SqlConn;

                sqlCommand.CommandText = "select * from fornecedores";

                try
                {
                    SqlDataReader dataReader;

                    dataReader = sqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Fornecedor fornecedor = new Fornecedor();

                        fornecedor.Id   = Int32.Parse(dataReader["id"].ToString());
                        fornecedor.Nome = dataReader["nome"].ToString();

                        lista.Add(fornecedor);
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }

            return lista;
        }

        public Fornecedor busca(int id)
        {
            Fornecedor fornecedor = null;

            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = SqlConn;

                sqlCommand.CommandText = "select * from fornecedores where id = @PId";

                sqlCommand.Parameters.AddWithValue("PId", id);

                try
                {
                    SqlDataReader dataReader;

                    dataReader = sqlCommand.ExecuteReader();

                    if (dataReader.Read())
                    {
                        fornecedor = new Fornecedor();

                        fornecedor.Id   = Int32.Parse(dataReader["id"].ToString());
                        fornecedor.Nome = dataReader["nome"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }

            return fornecedor;
        }
    }
}
