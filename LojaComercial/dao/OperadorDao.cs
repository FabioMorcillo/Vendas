using LojaComercial.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;

namespace LojaComercial.dao
{
    class OperadorDao : GenericDao
    {
        public Boolean cadastrar(Operador operador)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = SqlConn;

                sqlCommand.CommandText = "insert into operadores(senha,tipo,nome,endereco,telefone) values(@PSenha, @PTipo, @PNome, @PEndereco, @PTelefone)";

                sqlCommand.Parameters.AddWithValue("PSenha", operador.Senha);
                sqlCommand.Parameters.AddWithValue("PTipo", operador.Tipo);
                sqlCommand.Parameters.AddWithValue("PNome", operador.Nome);
                sqlCommand.Parameters.AddWithValue("PEndereco", operador.Endereco);
                sqlCommand.Parameters.AddWithValue("PTelefone", operador.Telefone);

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

        public Boolean editar(Operador operador)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = SqlConn;

                sqlCommand.CommandText = "update operadores set senha = @PSenha, tipo = @PTipo, nome = @PNome, endereco = @PEndereco, telefone = @PTelefone where id = @PId";

                sqlCommand.Parameters.AddWithValue("PId", operador.Id);
                sqlCommand.Parameters.AddWithValue("PSenha", operador.Senha);
                sqlCommand.Parameters.AddWithValue("PTipo", operador.Tipo);
                sqlCommand.Parameters.AddWithValue("PNome", operador.Nome);
                sqlCommand.Parameters.AddWithValue("PEndereco", operador.Endereco);
                sqlCommand.Parameters.AddWithValue("PTelefone", operador.Telefone);

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

        public Boolean deletar(Operador operador)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = SqlConn;

                sqlCommand.CommandText = "delete from operadores where id = @PId";

                sqlCommand.Parameters.AddWithValue("PId", operador.Id);

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

        public Boolean credencialValida(Operador operador)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = SqlConn;

                sqlCommand.CommandText = "select * from operadores where upper(nome) = upper(@PNome) and senha = @PSenha";

                sqlCommand.Parameters.AddWithValue("PNome", operador.Nome);
                sqlCommand.Parameters.AddWithValue("PSenha", operador.Senha);

                try
                {
                    SqlDataReader dataReader;

                    dataReader = sqlCommand.ExecuteReader();

                    if (dataReader.Read())
                    {
                        operador.Id         = Int32.Parse(dataReader["id"].ToString());
                        operador.Nome       = dataReader["nome"].ToString();
                        operador.Tipo       = Int32.Parse(dataReader["tipo"].ToString());
                        operador.Endereco   = dataReader["endereco"].ToString();
                        operador.Telefone   = dataReader["telefone"].ToString();

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

        public List<Operador> lista()
        {
            List<Operador> lista = new List<Operador>(); 

            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = SqlConn;

                sqlCommand.CommandText = "select * from operadores";

                try
                {
                    SqlDataReader dataReader;

                    dataReader = sqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Operador operador = new Operador();

                        operador.Id = Int32.Parse(dataReader["id"].ToString());
                        operador.Senha = dataReader["senha"].ToString();
                        operador.Nome = dataReader["nome"].ToString();
                        operador.Tipo = Int32.Parse(dataReader["tipo"].ToString());
                        operador.Endereco = dataReader["endereco"].ToString();
                        operador.Telefone = dataReader["telefone"].ToString();

                        lista.Add(operador);
                    }
               }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }

            return lista;
        }

        public Operador busca(int id)
        {
            Operador operador = null;

            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = SqlConn;

                sqlCommand.CommandText = "select * from operadores where id = @PId";

                sqlCommand.Parameters.AddWithValue("PId", id);

                try
                {
                    SqlDataReader dataReader;

                    dataReader = sqlCommand.ExecuteReader();

                    if (dataReader.Read())
                    {
                        operador = new Operador();

                        operador.Id         = Int32.Parse(dataReader["id"].ToString());
                        operador.Senha      = dataReader["senha"].ToString();
                        operador.Nome       = dataReader["nome"].ToString();
                        operador.Tipo       = Int32.Parse(dataReader["tipo"].ToString());
                        operador.Endereco   = dataReader["endereco"].ToString();
                        operador.Telefone   = dataReader["telefone"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }

            return operador;
        }
    }
}
