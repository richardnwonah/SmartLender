namespace SmartLeader.Api.Models
{
    public class LoanQualification
    {
        public int Id { get; set; }
        public bool IsQualified { get; set; }
        public decimal LoanAmount { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
