using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NorthwindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShipperService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ShipperService.svc or ShipperService.svc.cs at the Solution Explorer and start debugging.
    public class ShipperService : IShipperService
    {
        public Shipper GetShipperById(int id)
        {
            using (var context = new NORTHWNDEntities())
            {
                try
                {
                    return context.Shippers.Where(x => x.ShipperID == id).Select(x => new Shipper
                    {
                        CompanyName = x.CompanyName,
                        Phone = x.Phone,
                        ShipperId = x.ShipperID
                    }).FirstOrDefault();
                }
                catch (Exception e)
                {

                    throw;
                }
                
            }
        }

        public bool UpdateShipper(Shipper shipper)
        {
            using (var context = new NORTHWNDEntities())
            {
                try
                {
                    var shipperToUpdate = context.Shippers.FirstOrDefault(x => x.ShipperID == shipper.ShipperId);
                    if (shipperToUpdate != null)
                    {
                        shipperToUpdate.ShipperID = shipper.ShipperId;
                        shipperToUpdate.CompanyName = shipper.CompanyName;
                        shipperToUpdate.Phone = shipper.Phone;
                    }
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
                
            }
        }
    }
}
