using System;

namespace Acced.Art360.Common.Events
{
    public class ActivityCreated : IAuthenticatedCommand
    {
         public Guid Id { get;  }
        public Guid UserID { get;  }
        public string Category { get;  }
        public string Name { get;  }
        public string Description { get;  }
        public DateTime CreatedAt { get;  }

        public ActivityCreated()
        {            
        }

        public ActivityCreated(Guid id, Guid userID, string category, string name, string description, DateTime createdAt)
        {
            Id = id;
            UserID = userID;
            Category = category;
            Name = name;
            Description = description;
            CreatedAt = createdAt;
        }

    }
}