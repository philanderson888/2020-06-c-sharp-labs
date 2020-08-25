﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using lab_48_to_do_app.Models;

namespace lab_48_to_do_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDosController : ControllerBase
    {
        private readonly ToDoDbContext _context;

        public ToDosController(ToDoDbContext context)
        {
            _context = context;
        }

        // GET: api/ToDos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DisplayToDoWithUserName>>> GetToDos()
        {
            var returnObject =
                (from todo in _context.ToDos
                 select new DisplayToDoWithUserName()
                 {
                     Id = todo.ToDoId,
                     Item = todo.ToDoName,
                     Username = todo.User.UserName
                 }).ToListAsync<DisplayToDoWithUserName>();

            // return await _context.ToDos.Include(todo=>todo.User.UserName).ToListAsync();

            return await returnObject;
        }

        // GET: api/ToDos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DisplayToDoWithUserName>> GetToDo(int id)
        {
            var toDo = await _context.ToDos.FindAsync(id);

            if (toDo == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(toDo.UserId);

            var returnObject = new DisplayToDoWithUserName()
            {
                Id = toDo.ToDoId,
                Item = toDo.ToDoName,
                Username = user.UserName
            };

            return returnObject;
        }

        // PUT: api/ToDos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToDo(int id, ToDo toDo)
        {
            if (id != toDo.ToDoId)
            {
                return BadRequest();
            }

            _context.Entry(toDo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToDoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ToDos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ToDo>> PostToDo(ToDo toDo)
        {
            _context.ToDos.Add(toDo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetToDo", new { id = toDo.ToDoId }, toDo);
        }

        // DELETE: api/ToDos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ToDo>> DeleteToDo(int id)
        {
            var toDo = await _context.ToDos.FindAsync(id);
            if (toDo == null)
            {
                return NotFound();
            }

            _context.ToDos.Remove(toDo);
            await _context.SaveChangesAsync();

            return toDo;
        }

        private bool ToDoExists(int id)
        {
            return _context.ToDos.Any(e => e.ToDoId == id);
        }
    }
}
