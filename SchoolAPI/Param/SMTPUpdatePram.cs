using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolAPI.Param
{
    public class SMTPUpdatePram
    {
        public long ConfigurationID { get; set; }

        public int Port { get; set; }
      
        public string Secure { get; set; }

        public string Host { get; set; }

    
        public string UserName { get; set; }

        
        public string Password { get; set; }

        public long CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public long ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int Status { get; set; }
    }
}