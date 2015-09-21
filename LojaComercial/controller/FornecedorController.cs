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

        public static List<Fornecedor> lista()
        {
            FornecedorDao fornecedorDao = null;
            List<Fornecedor> resultado = null;

            try
            {
                fornecedorDao = new FornecedorDao();

                resultado = fornecedorDao.lista();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
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

        public static Fornecedor busca(int id)
        {
            FornecedorDao fornecedorDao = null;
            Fornecedor fornecedor = null;

            try
            {
                fornecedorDao = new FornecedorDao();

                fornecedor = fornecedorDao.busca(id);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally
            {
                if (fornecedorDao != null)
                {
                    fornecedorDao.close();
                }
            }

            return fornecedor;
        }

    }
}
