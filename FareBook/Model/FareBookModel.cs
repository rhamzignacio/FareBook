using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareBook.Model
{
    public class FareBookModel
    {
        public Guid ID { get; set; }
        public string ClientName { get; set; }
        public string LF { get; set; }
        public string LowFare { get; set; }
        public string RF { get; set; }
        public string ReferenceFare { get; set; }
        public string HotelStandardRate { get; set; }
        public string CarStandardRate { get; set; }
        public string OtherNotes { get; set; }
        public string Status { get; set; }
    }

    public class ClientDropDown
    {
        public string ClientName { get; set; }
    }
}
