using AutoMapper;
using Evolent.Model.Models;
using Evolent.Service;
using Evolent.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Evolent.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactService contactService;

        /// <summary>
        /// Dependency Injection performed
        /// </summary>
        /// <param name="gadgetService"></param>
        public HomeController(IContactService contactService)
        {
            this.contactService = contactService;
        }

        // GET: Home
        public ActionResult Index()
        {
            try
            {
                IEnumerable<ContactViewModel> viewModelContacts;
                IEnumerable<Contact> contacts;
                contacts = contactService.GetContacts().ToList();

                viewModelContacts = Mapper.Map<IEnumerable<Contact>, IEnumerable<ContactViewModel>>(contacts);
                return View(viewModelContacts);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "_" + ex.InnerException);
            }

        }

        public ActionResult Add()
        {
            IEnumerable<ContactViewModel> viewModelContacts = null;
            return View(viewModelContacts);
        }

        public ActionResult Filter(string name)
        {
            IEnumerable<ContactViewModel> viewModelContacts = null;
            IEnumerable<Contact> contacts;
            return View(viewModelContacts);
        }

        [HttpPost]
        public ActionResult Create(ContactFormViewModel newContact)
        {
            if (ModelState.IsValid)
            {
                var contact = Mapper.Map<ContactFormViewModel, Contact>(newContact);
                contactService.CreateContact(contact);
                contactService.SaveContact();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit(string id)
        {
            ContactViewModel viewModelContacts;
            Contact contact;
            contact = contactService.GetContact(Convert.ToInt32(id));
            viewModelContacts = Mapper.Map<Contact, ContactViewModel>(contact);
            return View(viewModelContacts);
        }

        public ActionResult Delete(string id)
        {
            contactService.DeleteContact(Convert.ToInt32(id));
            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult Edit(ContactFormViewModel contactFormViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Contact contact;
                    contact = Mapper.Map<ContactFormViewModel, Contact>(contactFormViewModel);
                    contactService.UpdateContact(contact);

                    ViewBag.Message = "Edit Opertaion complete !";
                    return Json(contact, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message + "" + ex.InnerException);
                }
            }
            return RedirectToAction("Index");
        }
    }
}