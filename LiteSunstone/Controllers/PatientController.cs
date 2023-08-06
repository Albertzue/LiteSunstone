using Microsoft.AspNetCore.Mvc;
using LiteSunstone.Domain;
using LiteSunstone.Persistance;

namespace LiteSunstone.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
       

        private readonly ILogger<PatientController> logger;
        private readonly DataInMemory dataInMemory;

        public PatientController(ILogger<PatientController> logger, DataInMemory dataInMemory)
        {
            this.logger = logger;
            this.dataInMemory = dataInMemory;
        }

        [HttpGet("patients")]
        public IEnumerable<Patient> Get()
        {
            return dataInMemory.GetPatients();
        }
    }
}