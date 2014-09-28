using API.Domain;
using API.Interface;
using MongoRepository;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Services
{
    public class ActivityService : IService
    {
        public MongoRepository<Activity> Repository { get; set; }  //Injected by IOC

        public object Get(ActivityAPI request)
        {
            return Repository.Where(x => x.Description == request.Description);
        }

        public object Post(ActivityAPI request)
        {
            var activity = new Activity { Description = request.Description };
            return Repository.Add(activity);
        }


    }
}