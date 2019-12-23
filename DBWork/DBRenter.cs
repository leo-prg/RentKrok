using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentKrok.DataModel;

namespace RentKrok.DBWork
{
    public class DBRenter
    {
        Lazy<RentModel> context = new Lazy<RentModel>();

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

        //public RenterRect GetAreaRenter(AreaRect area)
        //{
        //    context.Value.Renters.Where().se
        //    return null;
        //}

    }
}
