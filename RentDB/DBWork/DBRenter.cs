using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentLibrary;

namespace RentDB
{
    public class DBRenter
    {
        readonly Lazy<RentModel> context = new Lazy<RentModel>();


        public void AddRenter(RenterRect renter)
        {
            context.Value.Renters.Add(new Renter()
            {
                RenterName = renter.RenterName,
                Contract = renter.Contract,
                StartDate = renter.StartDate,
                EndDate = renter.EndDate,
                ContactPerson = renter.ContactPerson,
                ContactPhone = renter.ContactPhone,
                Annotation = renter.Annotation                
            });
            context.Value.SaveChanges();
        }

        public List<RenterRect> GetAllRenters()
        {
            return context.Value.Renters.Select(r => new RenterRect() 
                            { Id = r.Id, RenterName = r.RenterName, Contract = r.Contract, 
                              StartDate = r.StartDate, EndDate = r.EndDate, 
                              ContactPerson = r.ContactPerson, ContactPhone = r.ContactPhone, Annotation = r.Annotation
                            }).ToList();
        }

        public void UpdateRenter(RenterRect oldR, RenterRect newR)
        {
            var rU = context.Value.Renters.Where(r => r.Id == oldR.Id).FirstOrDefault();
            rU.RenterName = newR.RenterName;
            rU.Contract = newR.Contract;
            rU.StartDate = newR.StartDate;
            rU.EndDate = newR.EndDate;
            rU.ContactPerson = newR.ContactPerson;
            rU.ContactPhone = newR.ContactPhone;
            rU.Annotation = newR.Annotation;
            context.Value.SaveChanges();
        }


        public void DropRenter(RenterRect renter)
        {
            // найти все площади в которых айди арендатора удаляется -  и очистить
            var areasOfRenter = context.Value.RentAreas.Where(r => r.Renter.Id == renter.Id).Select(s => s);

            foreach (var area in areasOfRenter)
            {
                area.Renter = null;
                context.Value.SaveChanges();
            }

            // затем уже удалить 
                context.Value.Renters.Remove(context.Value.Renters.Find(renter.Id));
                context.Value.SaveChanges();
        }

    }
}
