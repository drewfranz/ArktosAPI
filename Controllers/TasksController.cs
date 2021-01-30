using ArktosAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArktosAPI.Classes;

namespace ArktosAPI.Controllers
{
    [ApiVersion("1.0")]
    [Route("[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ProjectContext _context;

        public TasksController(ProjectContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }

        // GET: TaskItems
        [HttpGet]
        public async Task<IActionResult> GetTaskItems([FromQuery] TaskItemQueryParameters queryParameters)
        {
            IQueryable<TaskItem> taskItems = _context.TaskItems;

            // Filter by UserID.
            if (queryParameters.UserId != null)
            {
                taskItems = taskItems.Where(ti => ti.UserId == queryParameters.UserId);
            }
            // Filter by ProjectId
            if (queryParameters.ProjectId != null)
            {
                taskItems = taskItems.Where(ti => ti.ProjectId == queryParameters.ProjectId);
            }
            // Filter by IsBlocked
            if (queryParameters.IsBlocked != null)
            {
                taskItems = taskItems.Where(ti => ti.IsBlocked == queryParameters.IsBlocked);
            }
            // Filter by IsPriority
            if (queryParameters.IsPriority != null)
            {
                taskItems = taskItems.Where(ti => ti.IsPriority == queryParameters.IsPriority);
            }

            // Set Sort Order. Default is asc.
            if (!string.IsNullOrEmpty(queryParameters.SortBy))
            {
                if (typeof(TaskItem).GetProperty(queryParameters.SortBy) != null)
                {
                    taskItems = taskItems.OrderByCustom(queryParameters.SortBy, queryParameters.SortOrder);
                }
            }

            taskItems = taskItems
                .Skip(queryParameters.PageSize * (queryParameters.Page -1))
                .Take(queryParameters.PageSize);

            return Ok(await taskItems.ToArrayAsync());
        }

        // GET: TaskItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTaskItem(int id)
        {
            var taskItem = await _context.TaskItems.FindAsync(id);

            if (taskItem == null)
            {
                return NotFound();
            }

            return Ok(taskItem);
        }

        // POST: TaskItem
        [HttpPost]
        public async Task<ActionResult<TaskItem>> PostTaskItem([FromBody] TaskItem taskItem)
        {
            taskItem.createdDate = taskItem.updatedDate = DateTime.Now;
            _context.TaskItems.Add(taskItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetTaskItem),
                new { Id = taskItem.Id},
                taskItem
            );
        }

        // PUT: TaskItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskItem([FromRoute] int id, [FromBody] TaskItem taskItem)
        {
            if (id != taskItem.Id)
            {
                return BadRequest();
            }

            taskItem.updatedDate = DateTime.Now;
            _context.Entry(taskItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_context.TaskItems.Find(id) == null)
                {
                    return NotFound();
                }

                throw;
            }

            return NoContent();
        }

        // DELETE: TaskItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaskItem(int id)
        {
            var taskItem = await _context.TaskItems.FindAsync(id);
            if (taskItem == null)
            {
                return NotFound();
            }

            _context.TaskItems.Remove(taskItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
