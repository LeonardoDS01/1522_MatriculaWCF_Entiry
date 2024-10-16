using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Matriculas
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioSecciones" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioSecciones
    {
        [OperationContract]
        Boolean ActualizarSeccion(SeccionDC objSeccionDC);
        [OperationContract]
        SeccionDC ConsultarSeccion(String strCodigo);
        [OperationContract]
        Boolean EliminarSeccion(String strCodigo);
        [OperationContract]
        Boolean InsertarSeccion(SeccionDC objSeccionDC);
        [OperationContract]
        List<SeccionDC> ListarSeccion();
    }
    [DataContract]
    [Serializable]
    public class SeccionDC
    {
        [DataMember]
        public String Id_Seccion { get; set; }
        [DataMember]
        public String Cod_Cur { get; set; }
        [DataMember]
        public String Cod_Hor { get; set; }
        [DataMember]
        public String Cod_Pro { get; set; }
        [DataMember]
        public String Cod_Sed { get; set; }
        [DataMember]
        public Int16 Modalidad { get; set; }
        [DataMember]
        public String Num_Aula { get; set; }
        [DataMember]
        public Int16 cupo { get; set; }
        [DataMember]
        public String Usu_Reg { get; set; }
        [DataMember]
        public DateTime Fec_Reg { get; set; }
        [DataMember]
        public String Usu_Ult_Mod { get; set; }
        [DataMember]
        public DateTime Fec_Ult_Mod { get; set; }
        [DataMember]
        public Int32? Est_Sec { get; set; }

    }
}
