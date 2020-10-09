using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore_API.Contracts;
using BookStore_API.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore_API.Controllers
{
    /// <summary>
    /// Endpoint used to interact with the Authors in the book store's database
    /// </summary>
    [Route("api/[controller]")]//in url: /api/authors
    [ApiController]
    //This allows the user when them pull this api that Status 200 can return
    [ProducesResponseType(StatusCodes.Status200OK)]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        public AuthorsController(IAuthorRepository authorRepository,
            ILoggerService logger,
            IMapper mapper)
        {
            _authorRepository = authorRepository;
            _logger = logger;
            _mapper = mapper;
        }
        /// <summary>
        /// Get all Authors
        /// </summary>
        /// <returns>Lists of Authors</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> GetAuthors()
        {
            try
            {
                _logger.LogInfo("Attempted Get All Authors");
                var authors = await _authorRepository.FindAll();
                var response = _mapper.Map<IList<AuthorDTO>>(authors);
                _logger.LogInfo("Successfully got Authors");
                return Ok(response);//return status code 200
            }
            catch (Exception e)
            {
               return InternalError($"{e.Message} - {e.InnerException}");
            }

        }
        /// <summary>
        /// Get an Author by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An Author's record</returns>
        //Let API controller know it requires a parameter int named id
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAuthor(int id)
        {
            try
            {
                _logger.LogInfo($"Attempted Get Author with id: {id}");
                var author = await _authorRepository.FindById(id);
                if (author == null)
                {
                    _logger.LogWarn($"Author with id: {id} was not found");
                    return NotFound();
                }
                var response = _mapper.Map<AuthorDTO>(author);
                _logger.LogInfo($"Successfully got author with id {id}");
                return Ok(response);
            }
            catch (Exception e)
            {
                return InternalError($"{e.Message} - {e.InnerException}");
            }
        }

        public async Task<IActionResult> Create([FromBody] AuthorCreateDTO author)
        {
            try
            {
                _logger.LogInfo($"Author Submission Attempted");
                //if user submits request and no author is listed or data
                if (author == null)
                {
                    _logger.LogWarn($"Empty Request was Submitted");
                    return BadRequest(ModelState);//ModelState tracks the status of the data values
                }
                //if the data doesn't meet the criteria of the AuthorCreateDTO properties
                if (!ModelState.IsValid)
                {
                    
                }
            }
            catch (Exception e)
            {
                return InternalError($"{e.Message} - {e.InnerException}");
            }
        }
        private ObjectResult InternalError(string message)
        {
            _logger.LogError(message);
            return StatusCode(500, "Something went wrong, please contact the Administration");//500 is internal server error
        }
    }

}
