using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CTCRestApi.Models
{
    [DataContract]
    public class UipathReportDetails
    {

        [DataMember(Name = "messageDetail")]
        public string MessageDetail { get; set; }

        [DataMember(Name = "messageType")]
        public string MessageType { get; set; }
    }
}