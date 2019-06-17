using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonDTO.Models_DTO;

namespace DatabaseStorage
{
    public class DataBaseStorage
    {
        public List<ContactDTO> GetAllPersonas()
        {
            List<ContactDTO> lstPersona = new List<ContactDTO>();
            return lstPersona;
        }

        public List<PhoneDTO> GetAllTelefonos()
        {
            List<PhoneDTO> lstTelefono = new List<PhoneDTO>();
            return lstTelefono;
        }
    }
}