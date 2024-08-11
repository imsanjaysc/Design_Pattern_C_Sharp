using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Behavioural.Observer.Examples.ProductPrice
{
    // Subject Interface
    public interface IProduct
    {
        void AddConsultant(IConsultant consultant);
        void RemoveConsultants(IConsultant consultant);
        void NotifyConsultants();
    }
}
