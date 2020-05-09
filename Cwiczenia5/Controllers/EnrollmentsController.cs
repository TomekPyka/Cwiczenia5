using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia5.DTOs.Requests;
using Cwiczenia5.DTOs.Responses;
using Cwiczenia5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia5.Controllers
{
    [Route("api/enrollments")]
    [ApiController]
    public class EnrollmentsController : ControllerBase
    {
        [HttpPost]
        public IActionResult EnrolStudent(EnrollStudentRequest request)
        {
            if(request.FirstName == null || request.FirstName == null)
            {
                return BadRequest("Żądanie jest niepoprawne");
            }
            
            var st = new Student();
            st.FirstName = request.FirstName;

            var response = new EnrollStudentResponse();
            response.LastName = st.LastName;
            
            return Ok();
        }

    }
}