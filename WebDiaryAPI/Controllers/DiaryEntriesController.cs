using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using WebDiaryAPI.Data;
using WebDiaryAPI.Models;

namespace WebDiaryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiaryEntriesController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;

        private readonly IDbConnection _db;

        //public DiaryEntriesController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        public DiaryEntriesController(IDbConnection db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task <ActionResult<IEnumerable<DiaryEntry>>> GetDiaryEntries()
        {
            //return await _context.DiaryEntries.ToListAsync();

            var sql = "SELECT * FROM DiaryEntries";

            var entries = await _db.QueryAsync<DiaryEntry>(sql);

            return Ok(entries);
        }

        [HttpGet("{id}")]
        public async Task <ActionResult<DiaryEntry>> GetDiaryEntry(int id)
        {
            //var diaryEntry = await _context.DiaryEntries.FindAsync(id);

            var sql =
                @"SELECT *
                FROM DiaryEntries
                WHERE Id = @Id";

            var diaryEntry =
                await _db.QueryFirstOrDefaultAsync<DiaryEntry>(sql, new { Id = id });

            if (diaryEntry == null)
            {
                return NotFound();
            }

            return diaryEntry;
        }

        [HttpPost]
        public async Task<ActionResult<DiaryEntry>> PostDiaryEntry(DiaryEntry diaryEntry)
        {
            diaryEntry.Id = 0;

            //_context.DiaryEntries.Add(diaryEntry);

            //await _context.SaveChangesAsync();

            var sql =
                @"
                INSERT INTO DiaryEntries
                (
                Title,
                Content,
                Created
                )
                VALUES
                (
                @Title,
                @Content,
                @Created
                );
 
                SELECT CAST(SCOPE_IDENTITY() as int);
                ";

            var id = await _db.QuerySingleAsync<int>(sql, diaryEntry);

            diaryEntry.Id = id;

            return CreatedAtAction(nameof(GetDiaryEntry), new { id = diaryEntry.Id }, diaryEntry);

            //var resourceUrl = Url.Action(nameof(GetDiaryEntry), new { id = diaryEntry.Id });

            //return Created("", diaryEntry);
        }

        [HttpPut("{id}")]
        public async Task <IActionResult> PutDiaryEntry(int id, [FromBody] DiaryEntry diaryEntry)
        {
            if (id != diaryEntry.Id)
            {
                return BadRequest();
            }

            var sql =
                @"
                UPDATE DiaryEntries
                SET
                Title = @Title,
                Content = @Content,
                Created = @Created
                WHERE Id = @Id;
                ";

            //_context.Entry(diaryEntry).State = EntityState.Modified;

            //try
            //{
            //    //await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!DiaryEntryExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            var rowsAffected = await _db.ExecuteAsync(sql, diaryEntry);

            if (rowsAffected == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiaryEntry(int id)
        {
            //var diaryEntry = await _context.DiaryEntries.FindAsync(id);

            //if (diaryEntry == null)
            //{
            //    return NotFound();
            //}

            //_context.DiaryEntries.Remove(diaryEntry);

            //await _context.SaveChangesAsync();

            var sql =
                @"
                DELETE FROM DiaryEntries
                WHERE Id = @Id;
                ";

            var rowsAffected = await _db.ExecuteAsync(sql, new { Id = id });

            if (rowsAffected == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

        //private bool DiaryEntryExists(int id)
        //{
        //    return _context.DiaryEntries.Any(e => e.Id == id);
        //}
    }
}
