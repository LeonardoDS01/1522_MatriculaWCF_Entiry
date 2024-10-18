using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Matriculas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioProfesores" en el código y en el archivo de configuración a la vez.
    public class ServicioProfesores : IServicioProfesores
    {
        public Boolean ActualizarProfesor(ProfesorDC objProfesorDC)
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //creamos la cosa a retornar
                Boolean boolActualizar = false;
                //***********************************************************//

                MisMatriculas.usp_ActualizarProfesor(
                        objProfesorDC.Cod_Pro,
                        objProfesorDC.Nom_Pro,
                        objProfesorDC.Ape_Pro,
                        objProfesorDC.Foto_Pro,
                        objProfesorDC.Direccion_Pro,
                        objProfesorDC.Email_Pro,
                        Convert.ToDateTime(objProfesorDC.Fec_Nac_Pro),
                        objProfesorDC.DNI_Pro,
                        objProfesorDC.Cod_Espec,
                        objProfesorDC.Id_Ubigeo,
                        objProfesorDC.Usu_Reg,
                        Convert.ToBoolean(objProfesorDC.Est_Pro)

                    );

                MisMatriculas.SaveChanges();

                boolActualizar = true;

                //***********************************************************//
                //retornamos la coleccion
                return boolActualizar;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean EliminarProfesor(string strCodigo)
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //creamos la cosa a retornar
                Boolean boolEliminar = false;
                //***********************************************************//

                MisMatriculas.usp_EliminarProfesor(strCodigo);

                MisMatriculas.SaveChanges();

                boolEliminar = true;

                //***********************************************************//
                //retornamos la coleccion
                return boolEliminar;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean InsertarProfesor(ProfesorDC objProfesorDC)
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //creamos la cosa a retornar
                Boolean boolInsertar = false;
                //***********************************************************//

                MisMatriculas.usp_InsertarProfesor(
                        objProfesorDC.Nom_Pro,
                        objProfesorDC.Ape_Pro,
                        objProfesorDC.Foto_Pro,
                        objProfesorDC.Direccion_Pro,
                        objProfesorDC.Email_Pro,
                        Convert.ToDateTime(objProfesorDC.Fec_Nac_Pro),
                        objProfesorDC.DNI_Pro,
                        objProfesorDC.Cod_Espec,
                        objProfesorDC.Id_Ubigeo,
                        objProfesorDC.Usu_Reg,
                        Convert.ToBoolean(objProfesorDC.Est_Pro)
                 );

                MisMatriculas.SaveChanges();

                boolInsertar = true; 

                //***********************************************************//
                //retornamos la coleccion
                return boolInsertar;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public ProfesorDC ConsultarProfesor(string strCodigo)
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //creamos la cosa a retornar
                ProfesorDC objProfesorDC = new ProfesorDC();
                //***********************************************************//
                //Obtener la información del profesor en consulta

                var query = MisMatriculas.usp_ConsultarProfesor(strCodigo).FirstOrDefault();

                if(query != null)
                {
                    objProfesorDC.Cod_Pro = query.Cod_Pro;
                    objProfesorDC.Nom_Pro = query.Nom_Pro;
                    objProfesorDC.Ape_Pro = query.Ape_Pro;
                    objProfesorDC.Direccion_Pro = query.direccion_Pro;
                    objProfesorDC.Email_Pro = query.email_Pro;
                    objProfesorDC.Fec_Nac_Pro = Convert.ToDateTime(query.Fec_Nac_Pro);
                    objProfesorDC.DNI_Pro = query.DNI_Pro;
                    objProfesorDC.Especialidad = query.Des_Esp;
                    objProfesorDC.Departamento = query.Departamento;
                    objProfesorDC.Provincia = query.Provincia;
                    objProfesorDC.Distrito =  query.Distrito;
                    objProfesorDC.Est_Pro = Convert.ToInt32(query.Est_Pro);

                }
                else
                {
                    objProfesorDC.Cod_Pro = String.Empty;
                }

                //***********************************************************//
                //retornamos el objeto Profesor DC

                return objProfesorDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<ProfesorDC> ListarProfesor()
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //creamos la cosa a retornar
                List<ProfesorDC> objListaProfesorDC = new List<ProfesorDC>();
                //***********************************************************//

                var query = MisMatriculas.usp_ListarProfesor();

                foreach (var profesor in query) {

                    ProfesorDC objProfesorDC = new ProfesorDC();

                    objProfesorDC.Cod_Pro = profesor.Cod_Pro;
                    objProfesorDC.Nom_Pro = profesor.Nom_Pro;
                    objProfesorDC.Ape_Pro = profesor.Ape_Pro;
                    objProfesorDC.Direccion_Pro = profesor.direccion_Pro;
                    objProfesorDC.Email_Pro = profesor.email_Pro;
                    objProfesorDC.Fec_Nac_Pro = Convert.ToDateTime(profesor.Fec_Nac_Pro);
                    objProfesorDC.DNI_Pro = profesor.DNI_Pro;
                    objProfesorDC.Especialidad = profesor.Des_Esp;
                    objProfesorDC.Departamento = profesor.Departamento;
                    objProfesorDC.Provincia = profesor.Provincia;
                    objProfesorDC.Distrito = profesor.Distrito;
                    objProfesorDC.Est_Pro = Convert.ToInt32(profesor.Est_Pro);

                    objListaProfesorDC.Add(objProfesorDC);
                }

                //***********************************************************//
                //retornamos la coleccion
                return objListaProfesorDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ProfesorDC> ObtenerCargaTrabajoProfesor(string periodo)
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //creamos la cosa a retornar
                List<ProfesorDC> objListaProfesorDC = new List<ProfesorDC>();
                //***********************************************************//

                var query = MisMatriculas.usp_ObtenerCargaTrabajoProfesor(periodo);

                foreach (var profesor in query)
                {
                    ProfesorDC objProfesorDC = new ProfesorDC();

                    objProfesorDC.NombreCompleto = profesor.NombreCompletoProfesor;
                    objProfesorDC.Periodo = profesor.Periodo;
                    objProfesorDC.Numero_secciones = Convert.ToInt16(profesor.Numero_Secciones);

                    objListaProfesorDC.Add(objProfesorDC);
                }

                
                //***********************************************************//
                //retornamos la coleccion
                return objListaProfesorDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<ProfesorDC> ObtenerProfesoresPorCurso(string strCodCurso)
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //creamos la cosa a retornar
                List<ProfesorDC> objListaProfesorDC = new List<ProfesorDC>();
                //***********************************************************//

                var query = MisMatriculas.usp_ObtenerProfesoresPorCurso(strCodCurso);

                foreach (var profesor in query)
                {
                    ProfesorDC objProfesorDC = new ProfesorDC();

                    objProfesorDC.Cod_Curso = profesor.CodigoCurso;
                    objProfesorDC.Nom_Curso = profesor.NombreCurso;
                    objProfesorDC.NombreCompleto = profesor.NombreCompletoProfesor;

                    objListaProfesorDC.Add(objProfesorDC);
                }


                //***********************************************************//
                //retornamos la coleccion
                return objListaProfesorDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
