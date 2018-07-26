using Evolent.Data.Infrastructure;
using Evolent.Data.Repositories;
using Evolent.Model.Models;
using System;
using System.Collections.Generic;

namespace Evolent.Service
{
    public interface IContactService
    {
        IEnumerable<Contact> GetContacts();
        Contact GetContact(int id);
        void CreateContact(Contact gadget);

        void UpdateContact(Contact gadget);

        void DeleteContact(int id);
        void SaveContact();
    }

    public class ContactService : IContactService
    {
        private readonly IContactRepository contactsRepository;
        private readonly IUnitOfWork unitOfWork;

        public ContactService(IContactRepository contactsRepository, IUnitOfWork unitOfWork)
        {
            this.contactsRepository = contactsRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IcontactService Members

        public IEnumerable<Contact> GetContacts()
        {
            var contacts = contactsRepository.GetAll();
            return contacts;
        }

        public Contact GetContact(int id)
        {
            var contact = contactsRepository.GetById(id);
            return contact;
        }

        public void CreateContact(Contact contact)
        {
            contactsRepository.Add(contact);
        }

        public void UpdateContact(Contact contact)
        {
            contactsRepository.Update(contact);
            //unitOfWork.Commit();
        }

        public void DeleteContact(int id)
        {
            contactsRepository.Delete(contactsRepository.GetById(id));
        }

        public void SaveContact()
        {
            unitOfWork.Commit();
        }

        #endregion

    }
}
