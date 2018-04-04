using System;

namespace Acced.Art360.Common.Events
{    
    public interface IAuthenticatedCommand : IEvent
    {
        Guid UserID { get;  }
    }      
}