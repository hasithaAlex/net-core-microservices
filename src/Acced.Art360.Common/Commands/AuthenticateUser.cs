using Acced.Art360.Commons;

namespace Acced.Art360.Common.Commands
{
    public class AuthenticateUser : ICommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}