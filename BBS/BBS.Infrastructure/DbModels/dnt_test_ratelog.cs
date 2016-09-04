using System;
using System.Linq;
using System.Text;

namespace BBS.Infrastructure.DbModels
{
    public class dnt_test_ratelog
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
     /// Nullable:False 
     /// </summary>
        public int pid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public int uid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public string username {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public Byte extcredits {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:(getdate()) 
     /// Nullable:False 
     /// </summary>
        public DateTime postdatetime {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public Int16 score {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public string reason {get;set;}

    }
}
