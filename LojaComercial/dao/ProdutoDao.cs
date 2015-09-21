using LojaComercial.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
    }
}
