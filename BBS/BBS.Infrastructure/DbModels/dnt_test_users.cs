using System;
using System.Linq;
using System.Text;

namespace BBS.Infrastructure.DbModels
{
    public class dnt_test_users
    {
        
     /// <summary>
     /// Desc:- 
     /// Default:- 
     /// Nullable:False 
     /// </summary>
        public int uid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string username {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string nickname {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string password {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string secques {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public int spaceid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public int gender {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public int adminid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public Int16 groupid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public int groupexpiry {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string extgroupids {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string regip {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:(getdate()) 
     /// Nullable:False 
     /// </summary>
        public DateTime joindate {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string lastip {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:(getdate()) 
     /// Nullable:False 
     /// </summary>
        public DateTime lastvisit {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:(getdate()) 
     /// Nullable:False 
     /// </summary>
        public DateTime lastactivity {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:(getdate()) 
     /// Nullable:False 
     /// </summary>
        public DateTime lastpost {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public int lastpostid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string lastposttitle {get;set;}

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
        public Int16 digestposts {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int oltime {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int pageviews {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int credits {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public Decimal extcredits1 {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public Decimal extcredits2 {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public Decimal extcredits3 {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public Decimal extcredits4 {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public Decimal extcredits5 {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public Decimal extcredits6 {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public Decimal extcredits7 {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public Decimal extcredits8 {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int avatarshowid {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string email {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string bday {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int sigstatus {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int tpp {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int ppp {get;set;}

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
        public int pmsound {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int showemail {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int invisible {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int newpm {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public int newpmcount {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('0') 
     /// Nullable:False 
     /// </summary>
        public int accessmasks {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:((0)) 
     /// Nullable:False 
     /// </summary>
        public int onlinestate {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('7') 
     /// Nullable:False 
     /// </summary>
        public int newsletter {get;set;}

     /// <summary>
     /// Desc:- 
     /// Default:('') 
     /// Nullable:False 
     /// </summary>
        public string salt {get;set;}

    }
}
