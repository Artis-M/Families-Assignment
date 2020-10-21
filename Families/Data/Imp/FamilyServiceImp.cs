using System.Collections.Generic;
using System.Linq;
using FileData;
using Models;

namespace Families.Data.Imp
{
    public class FamilyServiceImp : IFamilyService
    {
        private FileContext data = new FileContext();
        
        public void addAdult(Adult adult)
        {
            int id = data.Adults.Count() + 1;
            adult.Id = id;
            data.Adults.Add(adult);
            data.SaveChanges();
        }

        public void removeAdult(Adult adult)
        {
           Adult toRemove = data.Adults.First(Adult => (Adult.FirstName.Equals(adult
                .FirstName) && Adult.LastName.Equals(adult
                .LastName)));
           data.Adults.Remove(toRemove);
           data.SaveChanges();
        }

        public IList<Adult> getAdults()
        {
            return data.Adults;
        }
    }
}