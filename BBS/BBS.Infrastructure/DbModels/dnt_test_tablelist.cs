using System;
using System.Linq;
using System.Text;

namespace BBS.Infrastructure.DbModels
{
    public class dnt_test_tablelist
    {
        
     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public int id {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:(getdate()) 
     /// Nullable:False 
     /// </summary>
        public DateTime createdatetime {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string description {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((-1)) 
     /// Nullable:False 
     /// </summary>
        public int mintid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((-1)) 
     /// Nullable:False 
     /// </summary>
        public int maxtid {get;set;}

    }
}
