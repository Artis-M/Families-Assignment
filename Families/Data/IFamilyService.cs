using System.Collections.Generic;
using Models;

namespace Families.Data
{
    public interface IFamilyService
    {
        void addAdult(Adult adult);
        void removeAdult(Adult adult);
        IList<Adult> getAdults();
    }
}