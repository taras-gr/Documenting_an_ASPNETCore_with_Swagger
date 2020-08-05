using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Library.API.Entities;
using Library.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [ApiController]
    [Produces("application/json", 
            "application/xml")]
    [Route("api/v{version:apiVersion}/authors")]
    [ApiVersion("2.0")]
    public class AuthorsControllerV2 : ControllerBase
    {
        private readonly IAuthorRepository _authorsRepository;
        private readonly IMapper _mapper;

        public AuthorsControllerV2(
            IAuthorRepository authorsRepository,
            IMapper mapper)
        {
            _authorsRepository = authorsRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Get the authors (V2)
        /// </summary>
        /// <returns>An ActionResult object</returns>
        /// <response code="200">An author collection</response>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthors()
        {
            var authorsFromRepo = await _authorsRepository.GetAuthorsAsync();
            return Ok(_mapper.Map<IEnumerable<Author>>(authorsFromRepo));
        }
    }
}