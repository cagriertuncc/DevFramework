using DevFramework.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DevFramework.Northwind.Entities.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityReporsitoryBase<Product , NorthwindContext> ,IProductDal
    {
       
    }
}
