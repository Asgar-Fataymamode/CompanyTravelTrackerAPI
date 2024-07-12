namespace CompanyTravelTrackerAPI.Models
{
    public class ForthcomingVisitor
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public DateTime ArrivalDate { get; set; }
        //public string Purpose { get; set; }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeePosition { get; set; }
        public string BranchTravellingFrom { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string PurposeOfVisit { get; set; }
    }
}
