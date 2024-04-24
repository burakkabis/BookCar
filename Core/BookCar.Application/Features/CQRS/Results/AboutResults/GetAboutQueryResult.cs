using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Results.AboutResults
{
    //About sinifinda listeleme islemi yaparken gelmesini istedigimiz propertyleri buraya yaziyoruz.
    public class GetAboutQueryResult
    {
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
