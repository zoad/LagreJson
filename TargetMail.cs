using System;

public partial class TargetMail
{
    public int Id { get; set; }
    public long CustomerKey { get; set; }


    public long GeographyKey { get; set; }


    public string CustomerAlternateKey { get; set; }


    public string Title { get; set; }


    public string FirstName { get; set; }


    public string MiddleName { get; set; }


    public string LastName { get; set; }


    public long NameStyle { get; set; }


    public DateTimeOffset BirthDate { get; set; }


    public string MaritalStatus { get; set; }


    public string Suffix { get; set; }


    public string Gender { get; set; }


    public string EmailAddress { get; set; }


    public double YearlyIncome { get; set; }


    public long TotalChildren { get; set; }


    public long NumberChildrenAtHome { get; set; }


    public string EnglishEducation { get; set; }


    public string SpanishEducation { get; set; }


    public string FrenchEducation { get; set; }


    public string EnglishOccupation { get; set; }


    public string SpanishOccupation { get; set; }


    public string FrenchOccupation { get; set; }


    public long HouseOwnerFlag { get; set; }


    public long NumberCarsOwned { get; set; }


    public string AddressLine1 { get; set; }


    public string AddressLine2 { get; set; }


    public string Phone { get; set; }


    public DateTimeOffset DateFirstPurchase { get; set; }


    public string CommuteDistance { get; set; }


    public string Region { get; set; }


    public long Age { get; set; }


    public long BikeBuyer { get; set; }

    public override string ToString()
    {
        return $"{Id} - {CustomerKey} - {EmailAddress}";
    }
}