using LojaComercial.dao;
using LojaComercial.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComercial.controller
{
    static class ProdutoController
    {
        public static Boolean cadastrar(Produto produto)
        {
            ProdutoDao produtoDao = null;
            Boolean resultado = false;

            try
            {
                produtoDao = new ProdutoDao();

                resultado = produtoDao.cadastrar(produto);
            }
            catch
            {
                resultado = false;
            }
            finally
            {
                if (produtoDao != null)
                {
                    produtoDao.close();
                }
            }

            return resultado;
        }

        public static Boolean editar(Produto produto)
        {
            ProdutoDao produtoDao = null;
            Boolean resultado = false;

            try
            {
                produtoDao = new ProdutoDao();

                resultado = produtoDao.editar(produto);
            }
            catch
            {
                resultado = false;
            }
            finally
            {
                if (produtoDao != null)
                {
                    produtoDao.close();
                }
            }

            return resultado;
        }

        public static Boolean deletar(Produto produto)
        {
            ProdutoDao produtoDao = null;
            Boolean resultado = false;

            try
            {
                produtoDao = new ProdutoDao();

                resultado = produtoDao.deletar(produto);
            }
            catch
            {
                resultado = false;
            }
            finally
            {
                if (produtoDao != null)
                {
                    produtoDao.close();
                }
            }

            return resultado;
        }

        public static List<Produto> lista()
        {
            ProdutoDao produtoDao = null;
            List<Produto> resultado = null;

            try
            {
                produtoDao = new ProdutoDao();

                resultado = produtoDao.lista();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally
            {
                if (produtoDao != null)
                {
                    produtoDao.close();
                }
            }

            return resultado;
        }

        public static Produto busca(int id)
        {
            ProdutoDao produtoDao = null;
            Produto produto = null;

            try
            {
                produtoDao = new ProdutoDao();

                produto = produtoDao.busca(id);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally
            {
                if (produtoDao != null)
                {
                    produtoDao.close();
                }
            }

            return produto;
        }
    }
}
