namespace Acced.Art360.Common.Events
{
    public class UserAuthenticated : IEvent
    {
        public string Email { get; set; }

        public UserAuthenticated()
        {            
        }

        public UserAuthenticated(string email)
        {
            Email = email;
        }
    }
}