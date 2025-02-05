// Controllers\PersonsController.cs

using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using ServiceContracts.DTO;
using ServiceContracts.Enums;

namespace CRUDExample.Controllers
{
  public class PersonsController : Controller
  {
    //private fields
    private readonly IPersonsService _personsService;
    private readonly ICountriesService _countriesService;

    //constructor
    public PersonsController(IPersonsService personsService, ICountriesService countriesService)
    {
      _personsService = personsService;
      _countriesService = countriesService;
    }

    [Route("persons/index")]
    [Route("/")]
    public IActionResult Index(string searchBy, string? searchString, string sortBy = nameof(PersonResponse.PersonName), SortOrderOptions sortOrder = SortOrderOptions.ASC)
    {
      //Search
      ViewBag.SearchFields = new Dictionary<string, string>()
      {
        { nameof(PersonResponse.PersonName), "Person Name" },
        { nameof(PersonResponse.Email), "Email" },
        { nameof(PersonResponse.DateOfBirth), "Date of Birth" },
        { nameof(PersonResponse.Gender), "Gender" },
        { nameof(PersonResponse.CountryID), "Country" },
        { nameof(PersonResponse.Address), "Address" }
      };
      List<PersonResponse> persons = _personsService.GetFilteredPersons(searchBy, searchString);
      ViewBag.CurrentSearchBy = searchBy;
      ViewBag.CurrentSearchString = searchString;

      //Sort
      List<PersonResponse> sortedPersons =  _personsService.GetSortedPersons(persons, sortBy, sortOrder);
      ViewBag.CurrentSortBy = sortBy;
      ViewBag.CurrentSortOrder = sortOrder.ToString();

      return View(sortedPersons); //Views/Persons/Index.cshtml
    }


    //Executes when the user clicks on "Create Person" hyperlink (while opening the create view)
    [Route("persons/create")]
    [HttpGet]
    public IActionResult Create()
    {
      List<CountryResponse> countries = _countriesService.GetAllCountries();
      ViewBag.Countries = countries;

      return View();
    }

    [HttpPost]
    [Route("persons/create")]
    public IActionResult Create(PersonAddRequest personAddRequest)
    {
      if (!ModelState.IsValid)
      {
        List<CountryResponse> countries = _countriesService.GetAllCountries();
        ViewBag.Countries = countries;

        ViewBag.Errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
        return View();
      }

      //call the service method
      PersonResponse personResponse = _personsService.AddPerson(personAddRequest);
      
      //navigate to Index() action method (it makes another get request to "persons/index"
      return RedirectToAction("Index", "Persons");
    }

  [HttpGet]
  [Route("[action]/{personId}")] // Eg /persons/edit/1
  public IActionResult Edit(Guid personId){
    PersonResponse personResponse = _personsService.GetPersonByPersonID(personId);
    if(personResponse == null){
      return RedirectToAction("Index");
    }

    // Convert person response to person update request
    PersonUpdateRequest personUpdateRequest = personResponse.ToPersonUpdateRequest();

    // Populate countries
    List<CountryResponse> countries = _countriesService.GetAllCountries();
    ViewBag.Countries = countries;

    // Return the view
    return View(personUpdateRequest);
  }

  
  [HttpPost]
  [Route("[action]/{personId}")]
  public IActionResult Edit(PersonUpdateRequest personUpdateRequest){
    PersonResponse? personResponse = _personsService.GetPersonByPersonID(personUpdateRequest.PersonID);
    if(personResponse == null){
      return RedirectToAction("Index");
    }

    // Check valid
    if(ModelState.IsValid){
      PersonResponse updatedResponse = _personsService.UpdatePerson(personUpdateRequest);
      return RedirectToAction("Index");
    }
    else{
      List<CountryResponse> countries = _countriesService.GetAllCountries();
      ViewBag.Countries = countries;

      ViewBag.Errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
      return View();
    }

  }

  } // PersonsController : Controller
} // CRUDExample.Controllers
