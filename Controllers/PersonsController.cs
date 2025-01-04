using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using ServiceContracts.DTO;

namespace CRUDExample.Controllers
{
  public class PersonsController : Controller
  {
    // Private fields
    private readonly IPersonsService _personService;

    // Contructor
    public PersonsController(IPersonsService personsService){
      _personService = personsService;
    }

    [Route("persons/index")]
    public IActionResult Index()
    {
      List <PersonResponse> persons = _personService.GetAllPersons();

      return View(persons); // Views/Persons/Index.cshtml
    }
  }
}
