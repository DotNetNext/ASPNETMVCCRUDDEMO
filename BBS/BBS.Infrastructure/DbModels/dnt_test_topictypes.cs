using System;
using System.Linq;
using System.Text;

namespace BBS.Infrastructure.DbModels
{
    public class dnt_test_topictypes
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int typeid {get;set;}

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
        public string name {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:('') 
        /// Nullable:False 
        /// </summary>
        public string description {get;set;}

    }
}
