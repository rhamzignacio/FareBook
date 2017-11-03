using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FareBook.Model;

namespace FareBook.Service
{
    public class FareBookService
    {
        public static List<FareBookModel> GetAll(out string message)
        {
            try
            {
                using (var db = new QuickipediaEntities())
                {
                    message = "";

                    var query = from f in db.vw_FareComparison
                                orderby f.ClientName ascending
                                select new FareBookModel
                                {
                                    ID = f.ID,
                                    ClientName = f.ClientName,
                                    LF = f.LF,
                                    LowFare = f.LowFare,
                                    RF = f.RF,
                                    ReferenceFare = f.ReferenceFare,
                                    CarStandardRate = f.CarStandardFare,
                                    HotelStandardRate = f.HotelStandardFare,
                                    Status = ""
                                };

                    return query.ToList();
                }
            }
            catch(Exception error)
            {
                message = error.Message;

                return null;
            }
        }

        public static List<ClientDropDown> GetClient(out string message)
        {
            try
            {
                using (var db = new QuickipediaEntities())
                {
                    message = "";

                    var query = from c in db.ClientProfile
                                orderby c.ClientName ascending
                                select new ClientDropDown
                                {
                                    ClientName = c.ClientName
                                };

                    return query.ToList();
                }
            }
            catch(Exception error)
            {
                message = error.Message;

                return null;
            }
        }

        public static FareBookModel Get(string _parameter, out string message)
        {
            try
            {
                using (var db = new QuickipediaEntities())
                {
                    message = "";

                    var query = db.vw_FareComparison.FirstOrDefault(r => r.ClientName.ToLower().Contains(_parameter.ToLower()));

                    if(query != null)
                    {
                        FareBookModel newFare = new FareBookModel
                        {
                            ID = query.ID,
                            ClientName = query.ClientName,
                            LF = query.LF,
                            LowFare = query.LowFare,
                            RF = query.RF,
                            ReferenceFare = query.ReferenceFare,
                            CarStandardRate = query.CarStandardFare,
                            HotelStandardRate = query.HotelStandardFare
                        };

                        return newFare;
                    }
                    else
                    {
                        message = "No record found";

                        return null;
                    }
                }
            }
            catch(Exception error)
            {
                message = error.Message;

                return null;
            }
        }
    }
}
