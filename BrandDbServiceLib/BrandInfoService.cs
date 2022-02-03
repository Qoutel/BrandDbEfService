using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BrandDbServiceLib
{
    public class BrandInfoService : IBrandInfoService
    {
        private List<CarBrand> _carBrands;
        public BrandInfoService()
        {
            using (AppContext db = new AppContext())
            {
                _carBrands = db.CarBrands.ToList();
            }
        }
        public CarBrand GetData(string name)
        {
            return _carBrands.FirstOrDefault(b => b.Name == name);
        }
    }
}
