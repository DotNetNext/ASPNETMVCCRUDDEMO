using System;
using System.Linq;
using System.Text;

namespace BBS.Infrastructure.DbModels
{
    public class dnt_test_polloptions
    {
        
     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public int polloptionid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public int tid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public int pollid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public int votes {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public int displayorder {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string polloption {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string voternames {get;set;}

    }
}
