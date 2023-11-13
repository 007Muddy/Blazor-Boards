using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BoardsAPI.Model;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Razor.Language;

namespace BoardsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  

    public class BoardsController : ControllerBase
    {
        private readonly BoardAPIContext _context;

        public BoardsController(BoardAPIContext context)
        {
            _context = context;
        }

        // GET: api/Boards
        [HttpGet]
        [Route("GetAllBoards")]
        public async Task<IActionResult> GetAllBoards()
        {
            var resultboard = _context.Board;

            if (resultboard == null)
            {
                return NotFound();
            }

            return Ok(await resultboard.ToListAsync());
        }
        private bool BoardExists(int id)
        {
            return (_context.Board?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
