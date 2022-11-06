using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyTest.Data;

namespace MyTest.Models
{
    public class ApplicationModel
    {


        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PinCode { get; set; }

        public string SaveApplication(ApplicationModel model)
        {
            string msg = "";
            MyTestEntities Db = new MyTestEntities();
            {
                var ApplicationData = new tblApplication()
                {
                  ApplicationName=model.ApplicationName,
                  Email=model.Email,
                  Mobile=model.Mobile,
                  Address=model.Address,
                  City=model.City,
                  State=model.State,
                  PinCode=model.PinCode,
                };
                Db.tblApplications.Add(ApplicationData);
                Db.SaveChanges();
                return msg;
            }
        }
        public List<ApplicationModel> GetApplication()
        {
            MyTestEntities db = new MyTestEntities();
            List<ApplicationModel> lstApplication = new List<ApplicationModel>();
            var Application = db.tblApplications.ToList();
            if (Application != null)
            {
                foreach (var ApplicationData in Application)
                {
                    lstApplication.Add(new ApplicationModel()
                    {
                        ApplicationId = ApplicationData.ApplicationId,
                        Email = ApplicationData.Email,
                        Mobile = ApplicationData.Mobile,
                        Address = ApplicationData.Address,
                        City = ApplicationData.City,
                        State = ApplicationData.State,
                        PinCode = ApplicationData.PinCode,
                    });
                }
            }
            return lstApplication;
        }
    }
}





