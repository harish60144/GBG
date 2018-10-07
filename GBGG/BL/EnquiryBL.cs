using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using gobabygo.DL;
using gobabygo.Models;
using System.Data;

namespace gobabygo.BL
{
    public class EnquiryBL
    {
        dlTransaction objDL = new dlTransaction();

        internal bool SaveEnquiry(EnquiryDTO enquiry)
        {
            objDL.dlExecuteNonQuery("sp_addNewEnquiry",
                "_rFirstName", "varchar", enquiry.rFirstName,
                "_rLastName", "varchar", enquiry.rLastName,
                "_rRelation", "varchar", enquiry.rRelation,
                "_rEmail", "varchar", enquiry.rEmail,
                "_rPhoneNo", "varchar", enquiry.rPhoneNo,
                "_rPhoneType", "varchar", enquiry.rPhoneType,
                "_rAddress", "varchar", enquiry.rAddress,
                "_rAddress1", "varchar", enquiry.rAddress1,
                "_rCity", "varchar", enquiry.rCity,
                "_rState", "varchar", enquiry.rState,
                "_rPin", "varchar", enquiry.rPin,
                "_g1FirstName", "varchar", enquiry.g1FirstName,
                "_g1LastName", "varchar", enquiry.g1LastName,
                "_g1Relation", "varchar", enquiry.g1Relation,
                "_g1Email", "varchar", enquiry.g1Email,
                "_g1PhoneNo", "varchar", enquiry.g1PhoneNo,
                "_g1PhoneType", "varchar", enquiry.g1PhoneType,
                "_g1Address", "varchar", enquiry.g1Address,
                "_g1Address1", "varchar", enquiry.g1Address1,
                "_g1City", "varchar", enquiry.g1City,
                "_g1State", "varchar", enquiry.g1State,
                "_g1Pin", "varchar", enquiry.g1Pin,
                "_g2FirstName", "varchar", enquiry.g2FirstName,
                "_g2LastName", "varchar", enquiry.g2LastName,
                "_g2Relation", "varchar", enquiry.g2Relation,
                "_g2Email", "varchar", enquiry.g2Email,
                "_g2PhoneNo", "varchar", enquiry.g2PhoneNo,
                "_g2PhoneType", "varchar", enquiry.g2PhoneType,
                "_g2Address", "varchar", enquiry.g2Address,
                "_g2Address1", "varchar", enquiry.g2Address1,
                "_g2City", "varchar", enquiry.g2City,
                "_g2State", "varchar", enquiry.g2State,
                "_g2Pin", "varchar", enquiry.g2Pin,
                "_hearreason", "varchar", enquiry.hearreason,
                "_fname", "varchar", enquiry.fname,
                "_mname", "varchar", enquiry.mname,
                "_lname", "varchar", enquiry.lname,
                "_gender", "varchar", enquiry.gender,
                "_dob", "varchar", enquiry.dob,
                "_isAddSame", "varchar", enquiry.isAddSame,
                "_address1", "varchar", enquiry.address1,
                "_address2", "varchar", enquiry.address2,
                "_city", "varchar", enquiry.city,
                "_cstate", "varchar", enquiry.cstate,
                "_czip", "varchar", enquiry.czip,
                "_hospitalName", "varchar", enquiry.hospitalName,
                "_primaryDiagnosis", "varchar", enquiry.primaryDiagnosis,
                "_secondaryDiagnosis", "varchar", enquiry.secondaryDiagnosis,
                "_allergies", "varchar", enquiry.allergies,
                "_equipment", "varchar", enquiry.equipment,
                "_measurement1", "varchar", enquiry.measurement1,
                "_measurement2", "varchar", enquiry.measurement2,
                "_cancrawl", "varchar", enquiry.cancrawl,
                "_cansit", "varchar", enquiry.cansit,
                "_canstand", "varchar", enquiry.canstand,
                "_canwalk", "varchar", enquiry.canwalk,
                "_priorexperience", "varchar", enquiry.priorexperience,
                "_currentSupportings", "varchar", enquiry.currentSupportings,
                "_canpress", "varchar", enquiry.canpress,
                "_picUrl", "varchar", enquiry.picUrl,
                "_aboutChild", "varchar", enquiry.aboutChild,
                "_addinfo1", "varchar", enquiry.addinfo1,
                "_addinfo2", "varchar", enquiry.addinfo2,
                "_addinfo3", "varchar", enquiry.addinfo3);
            return true;
        }

        internal EnquiryDTO[] getEnauiry()
        {
            DataSet dsEnquiry = objDL.dlFillDataSet("sp_getenquiry");
            EnquiryDTO[] enquiryList = new EnquiryDTO[dsEnquiry.Tables[0].Rows.Count];
            for (int i = 0; i < dsEnquiry.Tables[0].Rows.Count; i++)
            {
                enquiryList[i] = new EnquiryDTO
                {
                    id = Convert.ToInt32(dsEnquiry.Tables[0].Rows[i]["id"].ToString()),
                    fname = dsEnquiry.Tables[0].Rows[i]["fname"].ToString(),
                    mname = dsEnquiry.Tables[0].Rows[i]["mname"].ToString(),
                    lname = dsEnquiry.Tables[0].Rows[i]["lname"].ToString(),
                    dob = dsEnquiry.Tables[0].Rows[i]["dob"].ToString(),
                    cstate = dsEnquiry.Tables[0].Rows[i]["cstate"].ToString(),
                    czip = dsEnquiry.Tables[0].Rows[i]["czip"].ToString(),
                    city = dsEnquiry.Tables[0].Rows[i]["city"].ToString()
                };
            }
            return enquiryList;
        }

        internal workshop[] getWorkshop()
        {
            DataSet dsWorkshop = objDL.dlFillDataSet("sp_getWorkshop");
            workshop[] workshopList = new workshop[dsWorkshop.Tables[0].Rows.Count];
            for (int i = 0; i < dsWorkshop.Tables[0].Rows.Count; i++)
            {
                workshopList[i] = new workshop
                {
                    WorkshopId = Convert.ToInt32(dsWorkshop.Tables[0].Rows[i]["WorkshopId"].ToString()),
                    WorkshopName = dsWorkshop.Tables[0].Rows[i]["WorkshopName"].ToString(),
                    WorkshopStatus = dsWorkshop.Tables[0].Rows[i]["WorkshopStatus"].ToString(),
                    WorkshopDate = Convert.ToDateTime(dsWorkshop.Tables[0].Rows[i]["WorkshopDate"].ToString()),
                    Venue = dsWorkshop.Tables[0].Rows[i]["Venue"].ToString(),
                    IsLive = Convert.ToInt32(dsWorkshop.Tables[0].Rows[i]["IsLive"].ToString()),
                    CreatedDate = Convert.ToDateTime(dsWorkshop.Tables[0].Rows[i]["CreatedDate"].ToString()),
                    LastActivityDate = Convert.ToDateTime(dsWorkshop.Tables[0].Rows[i]["LastActivityDate"].ToString())
                };
            }
            return workshopList;
        }

        internal kids[] getKids()
        {
            DataSet dsKids = objDL.dlFillDataSet("sp_getKids");
            kids[] KidsList = new kids[dsKids.Tables[0].Rows.Count];
            for (int i = 0; i < dsKids.Tables[0].Rows.Count; i++)
            {
                KidsList[i] = new kids
                {
                    KidId = Convert.ToInt32(dsKids.Tables[0].Rows[i]["KidId"].ToString()),
                    FirstName = dsKids.Tables[0].Rows[i]["FirstName"].ToString(),
                    MiddleName = dsKids.Tables[0].Rows[i]["MiddleName"].ToString(),
                    LastName = dsKids.Tables[0].Rows[i]["LastName"].ToString(),
                    DateOfBirth = Convert.ToDateTime(dsKids.Tables[0].Rows[i]["DateOfBirth"].ToString()),
                    CreatedDate = Convert.ToDateTime(dsKids.Tables[0].Rows[i]["CreatedDate"].ToString())
                };
            }
            return KidsList;
        }

        internal Person[] getPersons()
        {
            DataSet dsPersons = objDL.dlFillDataSet("sp_getPersons");
            Person[] PersonList = new Person[dsPersons.Tables[0].Rows.Count];
            for (int i = 0; i < dsPersons.Tables[0].Rows.Count; i++)
            {
                PersonList[i] = new Person
                {
                    PersonId = Convert.ToInt32(dsPersons.Tables[0].Rows[i]["PersonId"].ToString()),
                    PersonType = Convert.ToInt32(dsPersons.Tables[0].Rows[i]["PersonType"].ToString()),
                    RelationshipToKid = Convert.ToInt32(dsPersons.Tables[0].Rows[i]["RelationshipToKid"].ToString()),
                    FirstName = dsPersons.Tables[0].Rows[i]["FirstName"].ToString(),
                    LastName = dsPersons.Tables[0].Rows[i]["LastName"].ToString(),
                    Suffix = dsPersons.Tables[0].Rows[i]["Suffix"].ToString(),
                    Occupation = dsPersons.Tables[0].Rows[i]["Occupation"].ToString(),
                    PlaceOfEmployment = dsPersons.Tables[0].Rows[i]["PlaceOfEmployment"].ToString(),
                    Email = dsPersons.Tables[0].Rows[i]["Email"].ToString(),
                    PhoneNumber = dsPersons.Tables[0].Rows[i]["PhoneNumber"].ToString(),
                    CreatedDate = Convert.ToDateTime(dsPersons.Tables[0].Rows[i]["CreatedDate"].ToString())
                };
            }
            return PersonList;
        }

        internal Cars[] getCars()
        {
            DataSet dsCars = objDL.dlFillDataSet("sp_getCars");
            Cars[] CarsList = new Cars[dsCars.Tables[0].Rows.Count];
            for (int i = 0; i < dsCars.Tables[0].Rows.Count; i++)
            {
                CarsList[i] = new Cars
                {
                    CarId = Convert.ToInt32(dsCars.Tables[0].Rows[i]["CarId"].ToString()),
                    Purpose = dsCars.Tables[0].Rows[i]["Purpose"].ToString(),
                    CreatedDate = Convert.ToDateTime(dsCars.Tables[0].Rows[i]["CreatedDate"].ToString()),
                    Location = dsCars.Tables[0].Rows[i]["Location"].ToString()
                };
            }
            return CarsList;
        }

        internal CarTypes[] getCarTypes()
        {
            DataSet dsCarTypes = objDL.dlFillDataSet("sp_getCarTypes");
            CarTypes[] CarTypesList = new CarTypes[dsCarTypes.Tables[0].Rows.Count];
            for (int i = 0; i < dsCarTypes.Tables[0].Rows.Count; i++)
            {
                CarTypesList[i] = new CarTypes
                {
                    CarTypeId = Convert.ToInt32(dsCarTypes.Tables[0].Rows[i]["CarTypeId"].ToString()),
                    Make = dsCarTypes.Tables[0].Rows[i]["Make"].ToString(),
                    Model = dsCarTypes.Tables[0].Rows[i]["Model"].ToString(),
                    Owner = dsCarTypes.Tables[0].Rows[i]["Owner"].ToString(),
                    Voltage = dsCarTypes.Tables[0].Rows[i]["Voltage"].ToString(),
                    CreatedDate = Convert.ToDateTime(dsCarTypes.Tables[0].Rows[i]["CreatedDate"].ToString()),
                    CreatedBy = Convert.ToInt32(dsCarTypes.Tables[0].Rows[i]["CreatedBy"].ToString())
                };
            }
            return CarTypesList;
        }

        internal workshop[] AddWorkshop(workshop wshop)
        {
            DataSet dsWorkshop = objDL.dlFillDataSet("sp_AddWorkshop", "_WorkshopName", "varchar", wshop.WorkshopName,
                "_WorkshopStatus", "varchar", wshop.WorkshopStatus, "_WorkshopDate", "datetime", wshop.WorkshopDate,
                "_Venue", "varchar", wshop.Venue, "_AddressId", "int", wshop.AddressId, "_IsLive", "int", wshop.IsLive,
                "_CreatedDate", "datetime", wshop.CreatedDate, "_CreatedBy", "int", wshop.CreatedBy, "_ModifiedDate", "datetime", wshop.ModifiedDate,
                "_Modifiedby", "int", wshop.Modifiedby, "_SponsorPersonId", "int", wshop.SponsorPersonId, "_LastActivityDate", "datetime", wshop.LastActivityDate);
            workshop[] workshopList = new workshop[dsWorkshop.Tables[0].Rows.Count];
            for (int i = 0; i < dsWorkshop.Tables[0].Rows.Count; i++)
            {
                workshopList[i] = new workshop
                {
                    WorkshopId = Convert.ToInt32(dsWorkshop.Tables[0].Rows[i]["WorkshopId"].ToString()),
                    WorkshopName = dsWorkshop.Tables[0].Rows[i]["WorkshopName"].ToString(),
                    WorkshopStatus = dsWorkshop.Tables[0].Rows[i]["WorkshopStatus"].ToString(),
                    WorkshopDate = Convert.ToDateTime(dsWorkshop.Tables[0].Rows[i]["WorkshopDate"].ToString()),
                    Venue = dsWorkshop.Tables[0].Rows[i]["Venue"].ToString(),
                    IsLive = Convert.ToInt32(dsWorkshop.Tables[0].Rows[i]["IsLive"].ToString()),
                    CreatedDate = Convert.ToDateTime(dsWorkshop.Tables[0].Rows[i]["CreatedDate"].ToString()),
                    LastActivityDate = Convert.ToDateTime(dsWorkshop.Tables[0].Rows[i]["LastActivityDate"].ToString())
                };
            }
            return workshopList;
        }

        internal void addCar(Cars car)
        {
            objDL.dlExecuteNonQuery("sp_AddCar", "_Purpose", "varchar", car.Purpose,
                "_TypeId", "int", 1, "_IsActive", "int", 1, "_Location", "varchar", car.Location);
        }

        internal void addCarType(CarTypes cartyp)
        {
            objDL.dlExecuteNonQuery("sp_addCarType", "_Make", "varchar", cartyp.Make,
               "_Model", "varchar", cartyp.Model, "_Color", "varchar", 
               cartyp.Color, "_Voltage", "varchar", 
               cartyp.Voltage, "_Owner", "varchar", cartyp.Owner);
        }
    }
}