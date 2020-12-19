using CTCRestApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UIPathValidator.UIPath;
using UIPathValidator.Validation;

namespace CTCRestApi.Controllers
{
    public class UipathProjectDetailController : ApiController
    {
        // GET: api/UipathProjectDetail
        public IEnumerable<UipathProjectDetails> GetProjectDetail(string path)
        {
            Project project = new Project(path);
            project.Load();

            var resultList = new List<UipathProjectDetails>();

            if (project != null)
            {

                    var uipathReportDetails = new UipathProjectDetails
                    {
                        FilePath = project.Name,
                        ProjectVersion = project.Version,
                        StudioVersion = project.StudioVersion,
                    };
                    resultList.Add(uipathReportDetails);

            }


            return resultList;
        }


        // GET: api/UipathProjectDetail/5
        public string Get(int id)
        {
            return "value";
        }

       
    }
}
