using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CTCRestApi.Models
{
    [DataContract]
    public class UipathProjectDetails
    {
        [DataMember(Name = "filepath")]
        public string FilePath { get; set; }

        [DataMember(Name = "studioversion")]
        public string StudioVersion { get; set; }

        [DataMember(Name = "projectversion")]
        public string ProjectVersion { get; set; }
    }
}