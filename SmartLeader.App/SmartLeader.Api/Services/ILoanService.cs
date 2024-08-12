namespace SmartLeader.Api.Services
{
    public class ILoanService
    {
        Task<LoanQualification> GetLoanQualificationAsync(int userId);
    }
}
