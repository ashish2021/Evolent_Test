using Evolent.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Evolent.Data
{
    public class ContactSeedData : DropCreateDatabaseIfModelChanges<ContactEntities>
    {
        protected override void Seed(ContactEntities context)
        {
            GetContacts().ForEach(c => context.Contacts.Add(c));

            context.Commit();
        }

        private static List<Contact> GetContacts()
        {
            return new List<Contact>
            {
                new Contact {
                    FirstName = "First Name 1",
                    Email = "fname@gmail.com",
                    LastName= "Last Name 1",
                    MobileNumber="1212121212",
                    ID=1

                },
                new Contact {
                    FirstName = "First Name 2",
                    Email = "fname2@gmail.com",
                    LastName= "Last Name 2",
                    MobileNumber="1212121212",
                    ID=2
                },
                new Contact {
                    FirstName = "First Name 3",
                    Email = "fname3@gmail.com",
                    LastName= "Last Name 3",
                    MobileNumber="1212121212",
                    ID=3
                },
                new Contact {
                     FirstName = "First Name 4",
                    Email = "fname4@gmail.com",
                    LastName= "Last Name 4",
                    MobileNumber="1212121212",
                    ID=4
                },
                new Contact {
                     FirstName = "First Name 5",
                    Email = "fname5@gmail.com",
                    LastName= "Last Name 5",
                    MobileNumber="1212121212",
                    ID=5
                },
                new Contact {
                    FirstName = "First Name 6",
                    Email = "fname6@gmail.com",
                    LastName= "Last Name 6",
                    MobileNumber="1212121212",
                    ID=6
                }
            };
        }
    }
}
