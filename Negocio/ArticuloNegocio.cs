using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using Dominio;
using Negocio;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace TPFinalNivel2_Apellido
{
    public class ArticuloNegocio
    {
        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;



            try
            {
                conexion.ConnectionString = "server=DESKTOP-0MT9AT6\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Descripcion, A.Id, A.ImagenUrl, A.Codigo,A.Nombre, A.Precio, C.Descripcion AS Categoria, A.IdCategoria, A.IdMarca, M.Descripcion AS Marca FROM ARTICULOS A LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id LEFT JOIN MARCAS M ON A.IdMarca = M.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)lector["Id"];
                    aux.Nombre = (String)lector["Nombre"];
                    aux.codigoArticulo = (string)lector["Codigo"];
                    aux.Descripcion = (String)lector["Descripcion"];

                    if (lector["ImagenUrl"] is DBNull)
                        aux.Imagen = (string)lector["ImagenUrl"];

                    aux.precio = (decimal)lector["Precio"];
                    aux.Imagen = (string)lector["ImagenUrl"];

                    aux.Marca = new Marca();
                    aux.Marca.id = (int)lector["idMarca"];
                    aux.Marca.Decripcion = (string)lector["Marca"];


                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)lector["Categoria"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }

        }

        // Insertar registros
        public void agregar(Articulos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.seterConsulta("insert into ARTICULOS (Nombre,Precio,Codigo,ImagenUrl,Descripcion,IdMarca,IdCategoria)values('" + nuevo.Nombre + "','" + nuevo.precio + "','" + nuevo.codigoArticulo + "','" + nuevo.Imagen + "','" + nuevo.Descripcion + "',@IdMarca, @IdCategoria )");


                datos.setearParametro("@IdMarca", nuevo.Marca.id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);

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

        public void modificar(Articulos modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.seterConsulta("UPDATE ARTICULOS SET Nombre = @Nombre, Codigo = @Codigo, Precio = @Precio, Descripcion = @Descripcion, ImagenUrl = @Imagen, IdMarca = @IdMarca, IdCategoria = @IdCategoria WHERE Id = @Id");

                // Asignación de parámetros
                datos.setearParametro("@Nombre", modificar.Nombre);
                datos.setearParametro("@Codigo", modificar.codigoArticulo);
                datos.setearParametro("@Precio", modificar.precio);
                datos.setearParametro("@Descripcion", modificar.Descripcion);
                datos.setearParametro("@Imagen", modificar.Imagen);
                datos.setearParametro("@IdMarca", modificar.Marca.id); // Asegúrate de usar el nombre correcto de la propiedad
                datos.setearParametro("@IdCategoria", modificar.Categoria.Id); // Asegúrate de usar el nombre correcto de la propiedad
                datos.setearParametro("@Id", modificar.Id); // Agrega el Id del objeto para la cláusula WHERE

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
        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.seterConsulta("delete from ARTICULOS where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Articulos> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Consulta base
                string consulta = "SELECT A.Descripcion, A.Id, A.ImagenUrl, A.Codigo, A.Nombre, A.Precio, " +
                                  "C.Descripcion AS Categoria, A.IdCategoria, A.IdMarca, M.Descripcion AS Marca " +
                                  "FROM ARTICULOS A " +
                                  "LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id " +
                                  "LEFT JOIN MARCAS M ON A.IdMarca = M.Id ";

                // Construcción dinámica de filtros
                if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "WHERE A.Precio > @Filtro ";
                            break;
                        case "Menor a":
                            consulta += "WHERE A.Precio < @Filtro ";
                            break;
                        default:
                            consulta += "WHERE A.Precio = @Filtro ";
                            break;
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "WHERE A.Nombre LIKE @Filtro ";
                            filtro += "%";
                            break;
                        case "Termina con":
                            consulta += "WHERE A.Nombre LIKE @Filtro ";
                            filtro = "%" + filtro;
                            break;
                        default:
                            consulta += "WHERE A.Nombre LIKE @Filtro ";
                            filtro = "%" + filtro + "%";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "WHERE A.Descripcion LIKE @Filtro ";
                            filtro += "%";
                            break;
                        case "Termina con":
                            consulta += "WHERE A.Descripcion LIKE @Filtro ";
                            filtro = "%" + filtro;
                            break;
                        default:
                            consulta += "WHERE A.Descripcion LIKE @Filtro ";
                            filtro = "%" + filtro + "%";
                            break;
                    }
                }

                datos.seterConsulta(consulta);
                datos.setearParametro("@Filtro", filtro); // Uso de parámetros para evitar inyección SQL
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.codigoArticulo = (string)datos.Lector["Codigo"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    // Manejo seguro de DBNull
                    aux.Imagen = datos.Lector["ImagenUrl"] is DBNull ? null : (string)datos.Lector["ImagenUrl"];
                    aux.precio = (decimal)datos.Lector["Precio"];

                    aux.Marca = new Marca
                    {
                        id = (int)datos.Lector["IdMarca"],
                        Decripcion = (string)datos.Lector["Marca"]
                    };

                    aux.Categoria = new Categoria
                    {
                        Id = (int)datos.Lector["IdCategoria"],
                        Descripcion = (string)datos.Lector["Categoria"]
                    };

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al filtrar los artículos: " + ex.Message, ex);
            }
        }


    }
}

