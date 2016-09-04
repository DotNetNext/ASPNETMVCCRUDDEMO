using System;
using System.Linq;
using System.Text;

namespace BBS.Infrastructure.DbModels
{
    public class dnt_test_forums
    {
        
     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public int fid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int parentid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public Int16 layer {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string pathlist {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public string parentidlist {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public int subforumcount {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public string name {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int status {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('1') 
     /// Nullable:False 
     /// </summary>
        public Int16 colcount {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int displayorder {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public Int16 templateid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int topics {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int curtopics {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int posts {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int todayposts {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int lasttid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string lasttitle {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public DateTime lastpost {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public int lastposterid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string lastposter {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int allowsmilies {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int allowrss {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int allowhtml {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int allowbbcode {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int allowimgcode {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int allowblog {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int istrade {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public int allowpostspecial {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:True 
     /// </summary>
        public int? allowspecialonly {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int alloweditrules {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int allowthumbnail {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public int allowtag {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int recyclebin {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int modnewposts {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public int modnewtopics {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int jammer {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int disablewatermark {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int inheritedmod {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public Int16 autoclose {get;set;}

    }
}
