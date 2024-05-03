using FirstApp.Logic.DTO;
using FirstApp.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListsController : ControllerBase
    {
        private readonly IListService _listService;
        public ListsController(IListService listService)
        {
            _listService = listService;
        }

        [HttpPost]
        public async Task<ActionResult<ListDTO>> Create(ListDTO listDTO)
        {

            await _listService.Add(listDTO);
            return Ok();
        }
    }
}