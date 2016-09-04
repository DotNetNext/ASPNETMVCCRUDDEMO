using System;
using System.Linq;
using System.Text;

namespace BBS.Infrastructure.DbModels
{
    public class dnt_test_adminvisitlog
    {
        
     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public int visitid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:True 
     /// </summary>
        public int? uid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public string username {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:True 
     /// </summary>
        public int? groupid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public string grouptitle {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:True 
     /// </summary>
        public string ip {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:(getdate()) 
     /// Nullable:True 
     /// </summary>
        public DateTime? postdatetime {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public string actions {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public string others {get;set;}

    }
}
