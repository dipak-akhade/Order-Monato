using Order_Monato.BusinessObjectServices;
using Order_Monato.DAL;
using Order_Monato.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Order_Monato.BusinessObjects
{
    public class OfferManagementBo : IOfferManagementBo
    {

        public List<OfferDto> GetOffers()
        {
            var result = new List<OfferDto>();

            using (var context = new OrderMonatoContext())
            {
                var offers = context.Offers.ToList();

                offers.ForEach(offer =>
                {
                    result.Add(new OfferDto()
                    {
                        title = offer.title,
                        description = offer.description,
                        endDate = offer.endDate,
                        startDate = offer.startDate,
                        status = offer.status
                    });
                });
            }
            return result;
        }
    }
}