using CourseLibrary.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CourseLibrary.API.Controllers
{
    [ApiController] // optional, useful
    public class AuthorsController : ControllerBase
    {
        private readonly ICourseLibraryRepository _courseLibraryRepository;

        public AuthorsController(ICourseLibraryRepository courseLibraryRepository)
        {
            this._courseLibraryRepository = courseLibraryRepository ?? throw new ArgumentNullException(nameof(courseLibraryRepository));
        }
        [HttpGet("api/authors")]
        public IActionResult GetAuthors()
        {
            var authorsFromRepo = _courseLibraryRepository.GetAuthors();

            return new JsonResult(authorsFromRepo); // formats object as JSON
        }
    }
}
