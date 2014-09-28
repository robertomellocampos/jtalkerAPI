using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Domain
{
    public class Activity: Entity, IDomain
    {
        public string Description { get; set; }
    }
}