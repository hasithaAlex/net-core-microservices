
using System;
using Acced.Art360.Commons;

namespace Acced.Art360.Common.Commands
{
    public interface IAuthenticatedCommand : ICommand
    {
        Guid UserID { get; set; }
    }         
}