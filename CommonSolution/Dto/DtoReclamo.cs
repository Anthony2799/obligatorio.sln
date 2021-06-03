using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.Dto
{
    public enum Estado {Pendiente,Asignado,En_Proceso,Resuelto,Desestimado};
  public  class DtoReclamo
    {
        public long id;
        public float lat;
        public float lgn;
        public string observaciones;
        public Estado Estado;
        public DateTime fechaHoraReclamo;


    }
}
