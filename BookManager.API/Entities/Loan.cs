namespace BookManager.API.Entities
{
    public class Loan : BaseEntity
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateOnly LoanDate { get; set; } = new DateOnly();
    }
}
