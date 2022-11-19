using Common.StandardInfrastructure;
using Lookups.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lookups.Data.SeedData
{
    public class DataInitialize : IDataInitialize
    {

        public IEnumerable<Country> AddCountries()
        {
            return new List<Country>()
            {
                new Country{ Id = new Guid("5C60F693-BEF5-E011-A485-80EE7300C695"),NameSl="مصر", NameFl = "Egypt"},
                new Country{ Id = new Guid("5C60F693-BEF5-E011-A485-80EE7300C696"), NameSl = "الكويت", NameFl = "Kuwait"},
                new Country{ Id = new Guid("5C60F693-BEF5-E011-A485-90EE7300C695"),NameSl="السعودية", NameFl = "Ksa"},
                new Country{ Id = new Guid("5C60F693-BEF5-E011-A485-82EE7300C695"),NameSl="الأمارات", NameFl = "UAE"},
                new Country{ Id = new Guid("5C60F693-BEF5-E011-A485-84EE7300C695"),NameSl="اليمن", NameFl = "Yamen"},
                new Country{ Id = new Guid("5C60F693-BEF5-E011-A485-86EE7300C695"),NameSl="الأردن", NameFl = "Jordon"}

            };
        }
       
        public IEnumerable<Gender> AddGenders()
        {
            var enums = Enum.GetValues(typeof(GenderEnum));
            return (from object enumItem in enums
                    select new Gender
                    {
                        Id = ((GenderEnum)enumItem).GetEnumGuid(),
                        NameFl = ((GenderEnum)enumItem).GetName(true)[0],
                        NameSl = ((GenderEnum)enumItem).GetName(true)[1],
                        IsShown = ((GenderEnum)enumItem).GetEnumGuid() == GenderEnum.Both.GetEnumGuid() ? false : true
                    }).ToList();


        }

       

    }
}
