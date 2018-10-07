using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gobabygo.Models
{
    public class MainDTO
    {
    }

    public class kids
    {
        public int KidId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int AddressId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int IsActive { get; set; }
    }
    public class Application
    {
        public int ApplicationId { get; set; }
        public int KidId { get; set; }
        public int ReferringPersonId { get; set; }
        public int FamilyPerson01Id { get; set; }
        public int FamilyPerson02Id { get; set; }
        public string PrimayDiagnosis { get; set; }
        public string SecondaryDianosis { get; set; }
        public string Allergies { get; set; }
        public string MedicalEquiment { get; set; }
        public string LegMeasurement1 { get; set; }
        public string LegMeasurement2 { get; set; }
        public int CanCrawl { get; set; }
        public int CanSit { get; set; }
        public int CanStand { get; set; }
        public int CanWalk { get; set; }
        public string PriorExperience { get; set; }
        public string currentSupportings { get; set; }
        public int CanPress { get; set; }
        public string AboutChild { get; set; }
        public string AboutChildAddlInfo { get; set; }
        public string Comments { get; set; }
        public DateTime AvailableDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class Person
    {
        public int PersonId { get; set; }
        public int PersonType { get; set; }
        public int RelationshipToKid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string Occupation { get; set; }
        public string PlaceOfEmployment { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int PhoneType { get; set; }
        public int AddressId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int IsActive { get; set; }
    }
    public class Address
    {
        public int AddressId { get; set; }
        public string StreetAddress { get; set; }
        public string Addressline1 { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int IsActive { get; set; }
    }
    public class Cars
    {
        public int CarId { get; set; }
        public string Purpose { get; set; }
        public int TypeId { get; set; }
        public int IsActive { get; set; }
        public string Location { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
    }
    public class CarTypes
    {
        public int CarTypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Voltage { get; set; }
        public string Owner { get; set; }
        public int IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
    }
    public class workshop
    {
        public int WorkshopId { get; set; }
        public string WorkshopName { get; set; }
        public string WorkshopStatus { get; set; }
        public DateTime WorkshopDate { get; set; }
        public string Venue { get; set; }
        public int AddressId { get; set; }
        public int IsLive { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int Modifiedby { get; set; }
        public int SponsorPersonId { get; set; }
        public DateTime LastActivityDate { get; set; }
    }
    public class users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PersonId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int IsActive { get; set; }
        public DateTime LastLoginDate { get; set; }
        public int UserRoleId { get; set; }
    }
    public class UserRole
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleType { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int IsActive { get; set; }
    }
}