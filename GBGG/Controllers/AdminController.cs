using gobabygo.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using gobabygo.Models;

namespace gobabygo.Controllers
{
    public class AdminController : ApiController
    {
        EnquiryBL objBL = new EnquiryBL();
        [HttpPost]
        [Route("api/getEnquiry")]
        public EnquiryDTO[] getEnauiry()
        {
            return objBL.getEnauiry();
        }
        [HttpPost]
        [Route("api/AddWorkshop")]
        public workshop[] AddWorkshop(workshop wshop)
        {
            return objBL.AddWorkshop(wshop);
        }
        [HttpPost]
        [Route("api/getWorkshops")]
        public workshop[] getWorkshop()
        {
            return objBL.getWorkshop();
        }
        [HttpPost]
        [Route("api/getKids")]
        public kids[] getKids()
        {
            return objBL.getKids();
        }
        [HttpPost]
        [Route("api/getPersons")]
        public Person[] getPersons()
        {
            return objBL.getPersons();
        }
        [HttpPost]
        [Route("api/getCars")]
        public Cars[] getCars()
        {
            return objBL.getCars();
        }
        [HttpPost]
        [Route("api/getCarTypes")]
        public CarTypes[] getCarTypes()
        {
            return objBL.getCarTypes();
        }
        [HttpPost]
        [Route("api/addCar")]
        public void addCar(Cars car)
        {
            objBL.addCar(car);
        }
        [HttpPost]
        [Route("api/addCarType")]
        public void addCarType(CarTypes cartyp)
        {
            objBL.addCarType(cartyp);
        }
    }
}
