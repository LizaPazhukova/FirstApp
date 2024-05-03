using FirstApp.Logic.DTO;
using FirstApp.Logic.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    [EnableCors("OpenCORSPolicy")]
    [ApiController]
    [Route("api/[controller]")]
    public class ListsController : ControllerBase
    {
        private readonly IListService _listService;
        public ListsController(IListService listService)
        {
            _listService = listService;
        }

        [HttpGet]
        public async Task<ActionResult<ListDTO>> Get()
        {

            var lists = await _listService.GetAll();
            return Ok(lists);
        }

        [HttpPost]
        public async Task<ActionResult<ListDTO>> Create(ListDTO listDTO)
        {

            await _listService.Add(listDTO);
            return Ok();
        }
    }
}