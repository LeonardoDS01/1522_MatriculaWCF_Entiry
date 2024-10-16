﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Matriculas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioSecciones" en el código y en el archivo de configuración a la vez.
    public class ServicioSecciones : IServicioSecciones
    {
        public Boolean ActualizarSeccion(SeccionDC objSeccionDC)
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //***********************************************************//

                MisMatriculas.usp_ActualizarSeccion
                    (
                        objSeccionDC.Id_Seccion,
                        objSeccionDC.Cod_Cur,
                        objSeccionDC.Cod_Hor,
                        objSeccionDC.Cod_Pro,
                        objSeccionDC.Cod_Sed,
                        Convert.ToBoolean(objSeccionDC.Modalidad),
                        objSeccionDC.Num_Aula,
                        objSeccionDC.cupo,
                        objSeccionDC.Usu_Reg,
                        Convert.ToBoolean(objSeccionDC.Est_Sec)
                    );
                //***********************************************************//
                //retornamos la coleccion
                MisMatriculas.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean EliminarSeccion(String strCodigo)
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //***********************************************************//

                MisMatriculas.usp_EliminarSeccion(strCodigo);

                MisMatriculas.SaveChanges();

                //***********************************************************//
                //retornamos la coleccion
                return true;
            }

            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean InsertarSeccion(SeccionDC objSeccionDC)
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //***********************************************************//

                MisMatriculas.usp_InsertarSeccion
                    (
                        objSeccionDC.Cod_Cur,
                        objSeccionDC.Cod_Hor,
                        objSeccionDC.Cod_Pro,
                        objSeccionDC.Cod_Sed,
                        Convert.ToBoolean(objSeccionDC.Modalidad),
                        objSeccionDC.Num_Aula,
                        objSeccionDC.cupo,
                        objSeccionDC.Usu_Reg,
                        objSeccionDC.Fec_Reg.ToString(),
                        Convert.ToBoolean(objSeccionDC.Est_Sec)
                    );
                MisMatriculas.SaveChanges();

                //***********************************************************//
                //retornamos la coleccion
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public SeccionDC ConsultarSeccion(String strCodigo)
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //creamos la cosa a retornar
                SeccionDC objSeccionDC = new SeccionDC();
                //***********************************************************//

                var query = MisMatriculas.usp_ConsultarSeccion(strCodigo);

                foreach (var item in query)
                {
                    objSeccionDC.Id_Seccion = item.Id_Seccion;
                    objSeccionDC.Cod_Cur = item.Cod_Cur;
                    objSeccionDC.Cod_Hor = item.Cod_Hor;
                    objSeccionDC.Cod_Pro = item.Cod_Pro;
                    objSeccionDC.Cod_Sed = item.Cod_Sed;
                    objSeccionDC.Modalidad = Convert.ToInt16(item.Modalidad);
                    objSeccionDC.Num_Aula = item.Num_Aula;
                    objSeccionDC.cupo = Convert.ToInt16(item.cupo);
                    objSeccionDC.Usu_Reg = item.Usu_Reg;
                    objSeccionDC.Fec_Reg = Convert.ToDateTime(item.Fec_Reg);
                    objSeccionDC.Usu_Ult_Mod = item.Usu_Ult_Mod;
                    objSeccionDC.Fec_Ult_Mod = Convert.ToDateTime(item.Fec_Ult_Mod);
                    objSeccionDC.Est_Sec = Convert.ToInt16(item.Est_Sec);
                }
                //***********************************************************//
                //retornamos la coleccion
                return objSeccionDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<SeccionDC> ListarSeccion()
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //creamos la cosa a retornar
                List<SeccionDC> objListaSecciones = new List<SeccionDC>();
                //***********************************************************//

                var query = MisMatriculas.usp_ListarSeccion();

                foreach (var item in query)
                {
                    SeccionDC objSeccionDC = new SeccionDC();

                    objSeccionDC.Id_Seccion = item.Id_Seccion;
                    objSeccionDC.Cod_Cur = item.Cod_Cur;
                    objSeccionDC.Cod_Hor = item.Cod_Hor;
                    objSeccionDC.Cod_Pro = item.Cod_Pro;
                    objSeccionDC.Cod_Sed = item.Cod_Sed;
                    objSeccionDC.Modalidad = Convert.ToInt16(item.Modalidad);
                    objSeccionDC.Num_Aula = item.Num_Aula;
                    objSeccionDC.cupo = Convert.ToInt16(item.cupo);
                    objSeccionDC.Usu_Reg = item.Usu_Reg;
                    objSeccionDC.Fec_Reg = Convert.ToDateTime(item.Fec_Reg);
                    objSeccionDC.Usu_Ult_Mod = item.Usu_Ult_Mod;
                    objSeccionDC.Fec_Ult_Mod = Convert.ToDateTime(item.Fec_Ult_Mod);
                    objSeccionDC.Est_Sec = Convert.ToInt16(item.Est_Sec);

                    objListaSecciones.Add(objSeccionDC);
                }
                //***********************************************************//
                //retornamos la coleccion
                return objListaSecciones;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

