using System;
using System.Linq;
using System.Text;

namespace BBS.Infrastructure.DbModels
{
    public class dnt_test_onlinelist
    {
        
     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public Int16 groupid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:True 
     /// </summary>
        public int? displayorder {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public string title {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:True 
     /// </summary>
        public string img {get;set;}

    }
}
