using System;
using System.Linq;
using System.Text;

namespace BBS.Infrastructure.DbModels
{
    public class dnt_test_medals
    {
        
     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public Int16 medalid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public string name {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public int available {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string image {get;set;}

    }
}
