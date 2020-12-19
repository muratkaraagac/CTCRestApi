using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using CTCRestApi.Models;
using UIPathValidator.UIPath;
using UIPathValidator.Validation;

namespace CTCRestApi.Controllers
{
    public class UipathReportController : ApiController
    {
        // GET: api/UipathReport
        public IEnumerable<UipathReportDetails> Get(string path)
        {
            Project project = new Project(path);
            project.Load();
          
            ProjectValidator projectValidator = new ProjectValidator(project);
            projectValidator.Validate();
            var resultList = new List<UipathReportDetails>();

            if (projectValidator != null && project != null)
            {
                foreach (var item in projectValidator.GetResults())
                {
                    var messageType = "";
                    var messageDetail = "";
                    if (item.ToString().Contains("INFO"))
                    {
                        messageType = "info";
                        messageDetail = item.ToString().Replace("INFO:", "");
                    }
                    else if (item.ToString().Contains("WARNİNG"))
                    {
                        messageType = "warning";
                        messageDetail = item.ToString().Replace("WARNİNG:", "");
                    }
                    else
                    {
                        messageType = "error";
                        messageDetail = item.ToString().Replace("ERROR:", "");
                    }


                    var uipathReportDetails = new UipathReportDetails
                    {
                        MessageDetail = messageDetail,
                        MessageType = messageType
                    };
                    resultList.Add(uipathReportDetails);
                }

            }


            return resultList;
        }

        // GET: api/UipathReport/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            var test = 0;
        }
    }
}
