namespace SmartLeader.Api.Models
{
    public class CreditScore
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
