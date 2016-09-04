using System;
using System.Linq;
using System.Text;

namespace BBS.Infrastructure.DbModels
{
    public class dnt_test_locations
    {
        
     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public int lid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string city {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string state {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string country {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string zipcode {get;set;}

    }
}
