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
    public IActionResult Index(string searchBy, string? searchString)
    {
      // Search
      ViewBag.SearchFields = new Dictionary<string, string>(){
        {nameof(PersonResponse.PersonName), "Person Name"},
        {nameof(PersonResponse.Email), "Email"},
        {nameof(PersonResponse.DateOfBirth), "Date of Birth"},
        {nameof(PersonResponse.Gender), "Gender"},
        {nameof(PersonResponse.CountryID), "Country"},
        {nameof(PersonResponse.Address), "Address"},
      };

      // View users
      // List <PersonResponse> persons = _personService.GetAllPersons();
      List <PersonResponse> persons = _personService.GetFilteredPersons(searchBy, searchString);

      // Send values to the view
      ViewBag.CurrentSearchBy = searchBy;
      ViewBag.CurrentSearchString = searchString;

      // Show persons
      return View(persons); // Views/Persons/Index.cshtml
    }
  }
}
