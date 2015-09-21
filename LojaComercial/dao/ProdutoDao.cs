using LojaComercial.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LojaComercial.controller;

namespace LojaComercial.dao
{
    class ProdutoDao : GenericDao
    {
        public Boolean cadastrar(Produto produto)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = SqlConn;

                sqlCommand.CommandText = "insert into produtos(codBarras, descricao, fornecedor_id, dataValidade, quantidade, precoCompra, precoVenda) values(@PCodBarras,@PDescricao,@PFornecedor_id,@PDataValidade,@PQuantidade,@PPrecoCompra,@PPrecoVenda)";

                sqlCommand.Parameters.AddWithValue("PCodBarras", produto.CodBarras);
                sqlCommand.Parameters.AddWithValue("PDescricao", produto.Descricao);
                sqlCommand.Parameters.AddWithValue("PFornecedor_id", produto.Fornecedor.Id);
                sqlCommand.Parameters.AddWithValue("PDataValidade", produto.DataValidade);
                sqlCommand.Parameters.AddWithValue("PQuantidade", produto.Quantidade);
                sqlCommand.Parameters.AddWithValue("PPrecoCompra", produto.PrecoCompra);
                sqlCommand.Parameters.AddWithValue("PPrecoVenda", produto.PrecoVenda);

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

        public Boolean editar(Produto produto)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = SqlConn;

                sqlCommand.CommandText = "update produtos set codBarras = @PCodBarras, descricao = @PDescricao, fornecedor_id = @PFornecedor_id, dataValidade = @PDataValidade, quantidade = @PQuantidade, precoCompra = @PPrecoCompra, precoVenda = @PPrecoVenda where id = @PId";

                sqlCommand.Parameters.AddWithValue("PId", produto.Id);
                sqlCommand.Parameters.AddWithValue("PCodBarras", produto.CodBarras);
                sqlCommand.Parameters.AddWithValue("PDescricao", produto.Descricao);
                sqlCommand.Parameters.AddWithValue("PFornecedor_id", produto.Fornecedor.Id);
                sqlCommand.Parameters.AddWithValue("PDataValidade", produto.DataValidade);
                sqlCommand.Parameters.AddWithValue("PQuantidade", produto.Quantidade);
                sqlCommand.Parameters.AddWithValue("PPrecoCompra", produto.PrecoCompra);
                sqlCommand.Parameters.AddWithValue("PPrecoVenda", produto.PrecoVenda);

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

        public Boolean deletar(Produto produto)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = SqlConn;

                sqlCommand.CommandText = "delete from produtos where id = @PId";

                sqlCommand.Parameters.AddWithValue("PId", produto.Id);

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

        public List<Produto> lista()
        {
            List<Produto> lista = new List<Produto>();

            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = SqlConn;

                sqlCommand.CommandText = "select * from produtos";

                try
                {
                    SqlDataReader dataReader;

                    dataReader = sqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Produto produto = new Produto();

                        produto.Id              = Int32.Parse(dataReader["id"].ToString());
                        produto.CodBarras       = dataReader["codBarras"].ToString();
                        produto.Descricao       = dataReader["descricao"].ToString();

                        produto.Fornecedor      = FornecedorController.busca(Int32.Parse(dataReader["fornecedor_id"].ToString()));

                        produto.DataValidade    = DateTime.Parse(dataReader["dataValidade"].ToString());

                        produto.Quantidade      = Int32.Parse(dataReader["quantidade"].ToString());

                        produto.PrecoCompra     = Double.Parse(dataReader["precoCompra"].ToString());
                        produto.PrecoVenda      = Double.Parse(dataReader["precoVenda"].ToString());

                        lista.Add(produto);
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }

            return lista;
        }

        public Produto busca(int id)
        {
            Produto produto = null;

            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = SqlConn;

                sqlCommand.CommandText = "select * from produtos where id = @PId";

                sqlCommand.Parameters.AddWithValue("PId", id);

                try
                {
                    SqlDataReader dataReader;

                    dataReader = sqlCommand.ExecuteReader();

                    if (dataReader.Read())
                    {
                        produto = new Produto();

                        produto.Id              = Int32.Parse(dataReader["id"].ToString());
                        produto.CodBarras       = dataReader["codBarras"].ToString();
                        produto.Descricao       = dataReader["descricao"].ToString();

                        produto.Fornecedor      = FornecedorController.busca(Int32.Parse(dataReader["fornecedor_id"].ToString()));

                        produto.DataValidade    = DateTime.Parse(dataReader["dataValidade"].ToString());

                        produto.Quantidade      = Int32.Parse(dataReader["quantidade"].ToString());

                        produto.PrecoCompra     = Double.Parse(dataReader["precoCompra"].ToString());
                        produto.PrecoVenda      = Double.Parse(dataReader["precoVenda"].ToString());     
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }

            return produto;
        }
    }
}
