using LojaComercial.dao;
using LojaComercial.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComercial.controller
{
    static class FornecedorController
    {
        public static Boolean cadastrar(Fornecedor fornecedor)
        {
            FornecedorDao fornecedorDao = null;
            Boolean resultado = false;

            try
            {
                fornecedorDao = new FornecedorDao();

                resultado = fornecedorDao.cadastrar(fornecedor);
            }
            catch
            {
                resultado = false;
            }
            finally
            {
                if (fornecedorDao != null)
                {
                    fornecedorDao.close();
                }
            }

            return resultado;
        }

        public static Boolean editar(Fornecedor fornecedor)
        {
            FornecedorDao fornecedorDao = null;
            Boolean resultado = false;

            try
            {
                fornecedorDao = new FornecedorDao();

                resultado = fornecedorDao.editar(fornecedor);
            }
            catch
            {
                resultado = false;
            }
            finally
            {
                if (fornecedorDao != null)
                {
                    fornecedorDao.close();
                }
            }

            return resultado;
        }

        public static Boolean deletar(Fornecedor fornecedor)
        {
            FornecedorDao fornecedorDao = null;
            Boolean resultado = false;

            try
            {
                fornecedorDao = new FornecedorDao();

                resultado = fornecedorDao.deletar(fornecedor);
            }
            catch
            {
                resultado = false;
            }
            finally
            {
                if (fornecedorDao != null)
                {
                    fornecedorDao.close();
                }
            }

            return resultado;
        }

    }
}
