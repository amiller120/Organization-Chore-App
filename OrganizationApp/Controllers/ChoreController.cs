﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganizationApp.Data;
using OrganizationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChoreController : ControllerBase
    {
        private DataContext _dataContext;

        public ChoreController(DataContext dataContext)
        {
            _dataContext = dataContext;                                                
        }

        // Get: api/Chore
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChoreItem>>> GetChoreItems()
        {
            var chores = await _dataContext.choreItems.Include(chore => chore.AssignedTo).ToListAsync();
            return chores;
        }

        // GET: api/Chore/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ChoreItem>> GetChoreItem(int id)
        {
            var choreItem = await _dataContext.choreItems.Include(chore => chore.AssignedTo).Where(x => x.Id == id).FirstOrDefaultAsync();

            if (choreItem == null)
            {
                return NotFound();
            }

            return choreItem;
        }

        // POST: api/Chore
        [HttpPost]
        public async Task<ActionResult<ChoreItem>> PostChoreItem(ChoreItem chore)
        {
            var assigned = _dataContext.AssignedPerson.Where(x => x.Id == chore.AssignedTo.Id).FirstOrDefault();
            chore.AssignedTo = assigned;
            _dataContext.choreItems.Add(chore);
            await _dataContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetChoreItem), new { id = chore.Id }, chore);
        }

        // PUT: api/chore/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChoreItem(int id, ChoreItem chore)
        {
            if (id != chore.Id)
            {
                return BadRequest();
            }

            _dataContext.Entry(chore).State = EntityState.Modified;
            await _dataContext.SaveChangesAsync();

            return NoContent();
        }



    }
}
