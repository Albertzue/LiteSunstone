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
        private readonly DataInMemory dataInMemory;
        private readonly IPatientService patientService;
        public PatientController(DataInMemory dataInMemory, IPatientService patientService)
        {
            this.dataInMemory = dataInMemory;
            this.patientService = patientService;
        }

        [HttpGet("patients")]
        public IEnumerable<Patient> Get()
        {
            return patientService.GetPatients();
        }

        [HttpPost("patient")]
        public IActionResult AddPatient(Patient patient) 
        {
            patientService.AddPatient(patient);
            return Ok();
        }
    }
}