using Order_Monato.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Monato.BusinessObjectServices
{
    interface IOfferManagementBo
    {
        List<OfferDto> GetOffers();
    }
}
