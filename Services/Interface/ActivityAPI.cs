using API.Domain;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Interface
{
    //REST Resource DTO
    //[Route("/todos")]
    //[Route("/todos/{Ids}")]
    //public class Todos : IReturn<List<Todo>>
    //{
    //    public long[] Ids { get; set; }
    //    public Todos(params long[] ids)
    //    {
    //        this.Ids = ids;
    //    }
    //}

    [Route("/activity", "GET")]
    [Route("/activity", "POST")]
    public class ActivityAPI : IReturn<Activity>
    {
        public string Description { get; set; }
    }
}