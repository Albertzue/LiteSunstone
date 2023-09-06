using Microsoft.AspNetCore.Mvc;
using LiteSunstone.Domain;
using LiteSunstone.Persistance;
using LiteSunstone.Api.Services;

namespace LiteSunstone.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    { 
        private readonly IPatientService patientService;
        public PatientController( IPatientService patientService)
        {
            this.patientService = patientService;
        }

        [HttpGet("patients")]
        public IEnumerable<Patient> Get()
        {
            return patientService.GetPatients();
        }

        [HttpPost("patient")]
        public async Task<IActionResult> AddPatient(Patient patient) 
        {
            try
            {
                await patientService.AddPatient(patient);
                return Ok();
            }
            catch (ArgumentException ex)
            { 
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("patient")]
        public async Task<IActionResult> DeletePatient(string id)
        {
            try
            {
                await patientService.DeletePatient(id);
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}