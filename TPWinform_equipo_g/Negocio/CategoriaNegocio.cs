using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio

{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion from CATEGORIAS");
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    listaCategorias.Add(aux);
                }

                return listaCategorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void nuevaCategoria(Categoria nuevaCategoria)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into CATEGORIAS(Descripcion) values (@desc)");
                datos.setearParametro("@desc", nuevaCategoria.Descripcion);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificarCategoria(Categoria categoria)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update CATEGORIAS set Descripcion = @desc where Id = @id");
                datos.setearParametro("@desc", categoria.Descripcion);
                datos.setearParametro("@id", categoria.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Categoria> filtrarCategorias(string campo, string criterio, string filtro)
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select Id, Descripcion from CATEGORIAS where ";
                if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Empieza con":
                            consulta += "Descripcion like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "Descripcion like '%" + filtro + "'";
                            break;
                        case "Contiene":
                            consulta += "Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Id")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "Id > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "Id < " + filtro;
                            break;
                        case "Igual a":
                            consulta += "Id = " + filtro;
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarConsulta();
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    listaCategorias.Add(aux);
                }

                return listaCategorias;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

