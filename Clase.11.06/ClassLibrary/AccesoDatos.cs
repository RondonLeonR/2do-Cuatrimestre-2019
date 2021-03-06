﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ClassLibrary;

namespace ClassLibrary
{
    public class AccesoDatos
    {
        private SqlConnection _conexion;
        private SqlCommand _comando ;

        public AccesoDatos()
        {
            this._conexion = new SqlConnection(Properties.Settings.Default.Conexion_db);
        }

        public List<Persona> TraerTodos()
        {
            List<Persona> Personas = new List<Persona>();
            this._comando = new SqlCommand();
            this._comando.Connection = this._conexion;
            /*Tipo de cosa a ejecutar*/
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "SELECT id,nombre,apellido,edad FROM Padron.dbo.Personas";

            try
            {
                this._conexion.Open();
                SqlDataReader oDr = this._comando.ExecuteReader();

                while(oDr.Read())
                {
                    int id = (int)oDr["id"];
                    string cadenaNombre =(string) oDr["nombre"];
                    string cadenaApellido = (string) oDr["apellido"];
                    int edad = (int)oDr["edad"];
                    Persona p = new Persona(id, cadenaNombre, cadenaApellido, edad);
                    Personas.Add(p);
                }
                this._conexion.Close();
            }
            catch (Exception e)
            {
                throw e;
                //Console.WriteLine("Error.");
                //Console.Read();
            }
            return Personas;
        }

        public bool AgregarPersona(Persona p)
        {
            bool retorno = false;
            this._comando = new SqlCommand();
            this._comando.Connection = this._conexion;
            this._comando.CommandType = System.Data.CommandType.Text;
            this._comando.CommandText = "INSERT INTO Padron.dbo.Personas (nombre, apellido, edad) VALUES('" + p.nombre + "','" + p.apellido + "'," + p.edad.ToString() + ")";

            try
            {
                this._conexion.Open();
                if(this._comando.ExecuteNonQuery() > 0)
                {
                    retorno = true;
                }
                this._conexion.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return retorno;
        }

        public bool ModificarPersona(Persona p)
        {
            bool retorno = false;
            this._comando = new SqlCommand();
            this._comando.Connection = this._conexion;
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "UPDATE Padron.dbo.Personas SET nombre = '" + p.nombre + "' , apellido = '" + p.apellido + "' , edad = " + p.edad + " WHERE id = " + p.id;
            try
            {
                this._conexion.Open();
                if(this._comando.ExecuteNonQuery() > 0)
                {
                    retorno = true;
                }
                this._conexion.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return retorno;
        }
        
        public bool EliminarPersona(int ind)
        {
            bool retorno = false;
            this._comando = new SqlCommand();
            this._comando.Connection = this._conexion;
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "DELETE FROM Padron.dbo.Personas WHERE id = " + ind;
            try
            {
                this._conexion.Open();
                if(this._comando.ExecuteNonQuery() == 1 )
                {
                    retorno = true;
                }
                this._conexion.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return retorno;
        }

        /*System.Data representa a una tabla de base de datos
         * 
         */
        public DataTable TraerTablaPersonas()
        {
            DataTable dt = new DataTable("Padron.dbo.Personas");
            
            this._comando = new SqlCommand();
            this._comando.Connection = this._conexion;
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "SELECT id,nombre,apellido,edad FROM Padron.dbo.Personas";

            try
            {
                this._conexion.Open();
                SqlDataReader dr = this._comando.ExecuteReader();
                dt.Load(dr);
                this._conexion.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }
    }
}
