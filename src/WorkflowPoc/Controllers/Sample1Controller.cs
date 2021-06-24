using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using WorkflowPoc.Workflows;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace WorkflowPoc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Sample1Controller: Controller
    {
    }
}
