namespace MovieBooking_Backend.Dtos.UserDtos.GetDtos
{
    public class UserListDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string? MembershipLevel { get; set; }
    }
}
