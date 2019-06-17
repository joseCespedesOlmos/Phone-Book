using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonDTO.Common_Interfaces;
using CommonDTO.Models_DTO;
namespace DatabaseStorage
{
    class DataBaseProvider : IPhoneBookProvider
    {
        private DataBaseStorage _dataBaseProvider;
        private object con;

        public object CommandType { get; private set; }
        public object Persona { get; private set; }
       

        public DataBaseProvider()
        {
             _dataBaseProvider = new DataBaseStorage();
        }

        

        public bool DeleteContact(Guid contactId)
        {

            var entity3 = this.ObjectContext.FirstOrDefault(row => row.IdContact == Persona.IdContact);

            this.ObjectContext.DeleteObject(result);
            this.ObjectContext.SaveChanges();

            return true;

        }

       
        public bool DeletePhone(string phoneNumber)
        {
            var entity4 = this.ObjectContext.FirstOrDefault(row => row.PhoneNumber == Telefono.PhoneNumber);

            this.ObjectContext.DeleteObject(result);
            this.ObjectContext.SaveChanges();

            return true;

        }

        
        public ContactDTO GetContact(Guid contactId)
        {
            throw new NotImplementedException();
        }

        public List<ContactDTO> GetContactList()
        {
            return this.ObjectContext.Persona;
        }

  
        public List<PhoneDTO> GetPhoneList(Guid contactId)
        {
            return this.ObjectContext.Telefono;
        }

  
        public bool InsertContact(ContactDTO contact)
        {
            if ((contact.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(contact, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Persona.AddObject(contact);
            }
            return true;
        }

        private void SqlCommand(string v, object con)
        {
            throw new NotImplementedException();
        }

        

        public bool InsertPhone(PhoneDTO phone)
        {
            if ((phone.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(phone, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Telefono.AddObject(phone);
            }
            return true;
        }

        

        public bool UpdateContact(ContactDTO contact)
        
        {
              var entity = this.ObjectContext.Persona.FirstOrDefault(row => row.IdContact == Persona.IdContact);
              entity.Name = Persona.Name;
              entity.LastName = Persona.LastName;
              entity.Gender = Persona.Gender;
              entity.BirdtDate = Persona.BirdtDate;
              
              Context.SaveChanges();

              return true;
        
        }



        public bool UpdatePhone(PhoneDTO phone)

        {
            var entity2 = this.ObjectContext.Telefono.FirstOrDefault(row => row.IdContact == Telefono.IdContact);
            entity2.PhoneNumber = Telefono.PhoneNumber;
            entity2.PhoneType = Telefono.PhoneType;
            
            Context.SaveChanges();

            return true;
        }

        List<ContactDTO> IPhoneBookProvider.GetContactList()
        {
            throw new NotImplementedException();
        }

        ContactDTO IPhoneBookProvider.GetContact(Guid contactId)
        {
            throw new NotImplementedException();
        }

        bool IPhoneBookProvider.InsertContact(ContactDTO contact)
        {
            throw new NotImplementedException();
        }

        bool IPhoneBookProvider.UpdateContact(ContactDTO contact)
        {
            throw new NotImplementedException();
        }

        bool IPhoneBookProvider.DeleteContact(Guid contactId)
        {
            throw new NotImplementedException();
        }

        List<PhoneDTO> IPhoneBookProvider.GetPhoneList(Guid contactId)
        {
            throw new NotImplementedException();
        }

        bool IPhoneBookProvider.InsertPhone(PhoneDTO phone)
        {
            throw new NotImplementedException();
        }

        bool IPhoneBookProvider.UpdatePhone(PhoneDTO phone)
        {
            throw new NotImplementedException();
        }

        bool IPhoneBookProvider.DeletePhone(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        List<PhoneDTO> IPhoneBookProvider.GetEmailList(Guid contactId)
        {
            throw new NotImplementedException();
        }

     

 

        List<PhoneDTO> IPhoneBookProvider.GetAddressList(Guid contactId)
        {
            throw new NotImplementedException();
        }

        bool IPhoneBookProvider.InsertAddress(AddressDTO address)
        {
            throw new NotImplementedException();
        }

        bool IPhoneBookProvider.UpdateAddress(AddressDTO address)
        {
            throw new NotImplementedException();
        }

        bool IPhoneBookProvider.DeleteAddress(string address)
        {
            throw new NotImplementedException();
        }

        public bool InsertEmail(E_MailAddressDTO email)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmail(E_MailAddressDTO email)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEmail(string emailAdress)
        {
            throw new NotImplementedException();
        }
    }
}
