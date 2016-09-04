using System;
using System.Linq;
using System.Text;

namespace BBS.Infrastructure.DbModels
{
    public class dnt_test_polls
    {
        
     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public int pollid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public int tid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public int displayorder {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public Byte multiple {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public Byte visible {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public Byte allowview {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public Int16 maxchoices {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public DateTime expiration {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public int uid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string voternames {get;set;}

    }
}
