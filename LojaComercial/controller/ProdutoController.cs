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

    }
}
