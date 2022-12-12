﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BL
{
    public class Libro
    {
        public static ML.Result Add(ML.Libro libro)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "LibroAdd";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = context;

                        SqlParameter[] collection = new SqlParameter[7];

                        collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                        collection[0].Value = libro.Nombre;
                        collection[1] = new SqlParameter("@IdAutor", SqlDbType.Int);
                        collection[1].Value = libro.Autor.IdAutor;
                        collection[2] = new SqlParameter("@NumeroPaginas", SqlDbType.Int);
                        collection[2].Value = libro.NumeroPaginas;
                        collection[3] = new SqlParameter("@FechaPublicacion", SqlDbType.VarChar);
                        collection[3].Value = libro.FechaPublicacion;
                        collection[4] = new SqlParameter("@IdEditorial", SqlDbType.Int);
                        collection[4].Value = libro.Editorial.IdEditorial;
                        collection[5] = new SqlParameter("@Edicion", SqlDbType.VarChar);
                        collection[5].Value = libro.Editorial;
                        collection[6] = new SqlParameter("@IdGenero", SqlDbType.Int);
                        collection[6].Value = libro.Genero.IdGenero;

                        cmd.Parameters.AddRange(collection);
                        cmd.Connection.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = true;
                result.Ex = ex;
                result.Message = "Ocurrio un error al cargar la información" + result.Ex;
                throw;
            }
            return result;
        }
    
        public static ML.Result Update(ML.Libro libro)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "LibroUpdate";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = context;

                        SqlParameter[] collection = new SqlParameter[7];

                        collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                        collection[0].Value = libro.Nombre;
                        collection[1] = new SqlParameter("@IdAutor", SqlDbType.Int);
                        collection[1].Value = libro.Autor.IdAutor;
                        collection[2] = new SqlParameter("@NumeroPaginas", SqlDbType.Int);
                        collection[2].Value = libro.NumeroPaginas;
                        collection[3] = new SqlParameter("@FechaPublicacion", SqlDbType.VarChar);
                        collection[3].Value = libro.FechaPublicacion;
                        collection[4] = new SqlParameter("@IdEditorial", SqlDbType.Int);
                        collection[4].Value = libro.Editorial.IdEditorial;
                        collection[5] = new SqlParameter("@Edicion", SqlDbType.VarChar);
                        collection[5].Value = libro.Editorial;
                        collection[6] = new SqlParameter("@IdGenero", SqlDbType.Int);
                        collection[6].Value = libro.Genero.IdGenero;

                        cmd.Parameters.AddRange(collection);
                        cmd.Connection.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "Ocurrio un error al cargar la información" + result.Ex;
                throw;
            }
            return result;
        }
    
        public static ML.Result Delete(ML.Libro libro)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "LirboDelete";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = query;
                        cmd.CommandType = CommandType.StoredProcedure;

                        context.Open();

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("IdLibro", System.Data.SqlDbType.Int);
                        collection[0].Value = libro.IdLibro;

                        cmd.Parameters.AddRange(collection);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected >= 1)
                        {
                            result.Message = "El libro se elimino correctamente";
                        }
                    }
                }
                result.Correct = true;
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "Ocurrio un porblema al cargar la información" + result.Ex;
                throw;
            }
            return result;
        }


    }
}