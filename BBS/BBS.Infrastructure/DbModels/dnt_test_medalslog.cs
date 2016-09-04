using System;
using System.Linq;
using System.Text;

namespace BBS.Infrastructure.DbModels
{
    public class dnt_test_medalslog
    {
        
     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public int id {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:True 
     /// </summary>
        public string adminname {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:True 
     /// </summary>
        public int? adminid {get;set;}

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
     /// Nullable:True 
     /// </summary>
        public string username {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:True 
     /// </summary>
        public int? uid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:True 
     /// </summary>
        public string actions {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:True 
     /// </summary>
        public int? medals {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:True 
     /// </summary>
        public string reason {get;set;}

    }
}
