using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductManagementSystem.StevieTV.Data;
using ProductManagementSystem.StevieTV.Helpers;
using ProductManagementSystem.StevieTV.Models;

namespace ProductManagementSystem.StevieTV.Controllers
{
    public class VideoGameController : Controller
    {
        private readonly VideoGameContext _context;

        public VideoGameController(VideoGameContext context)
        {
            _context = context;
        }

        // GET: VideoGame
        // public async Task<IActionResult> Index()
        // {
        //     return View(await _context.VideoGames.ToListAsync());
        // }
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewData["NameSortParm"]= String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"]= sortOrder == "date" ? "date_desc" : "date";
            ViewData["ActiveSortParm"] = sortOrder == "active" ? "active_desc" : "active";
            ViewData["PriceSortParm"] = sortOrder == "price" ? "price_desc" : "price";
            ViewData["CurrentSort"] = sortOrder;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            
            ViewData["CurrentFilter"] = searchString;
            
            var videoGames = from v in _context.VideoGames select v;
            
            if (!string.IsNullOrEmpty(searchString))
            {
                videoGames = videoGames.Where(v => v.Name.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    videoGames = videoGames.OrderByDescending(v => v.Name);
                    break;
                case  "date":
                    videoGames = videoGames.OrderBy(v => v.DateAdded);
                    break;
                case "date_desc":
                    videoGames = videoGames.OrderByDescending(v => v.DateAdded);
                    break;
                case  "active":
                    videoGames = videoGames.OrderBy(v => v.IsActive);
                    break;
                case "active_desc":
                    videoGames = videoGames.OrderByDescending(v => v.IsActive);
                    break;
                case  "price":
                    videoGames = videoGames.OrderBy(v => v.Price);
                    break;
                case "price_desc":
                    videoGames = videoGames.OrderByDescending(v => v.Price);
                    break;
                default:
                    videoGames = videoGames.OrderBy(v => v.Name);
                    break;
            }

            var pageSize = 5;
            return View(await PaginatedList<VideoGame>.CreateAsync(videoGames.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: VideoGame/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoGame = await _context.VideoGames
                .FirstOrDefaultAsync(m => m.Id == id);
            if (videoGame == null)
            {
                return NotFound();
            }

            return View(videoGame);
        }

        // GET: VideoGame/Create
        [Authorize(Policy = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: VideoGame/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "Staff")]
        public async Task<IActionResult> Create([Bind("Id,Name,IsActive,DateAdded,Price")] VideoGame videoGame)
        {
            if (ModelState.IsValid)
            {
                _context.Add(videoGame);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(videoGame);
        }

        // GET: VideoGame/Edit/5
        [Authorize(Policy = "Staff")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoGame = await _context.VideoGames.FindAsync(id);
            if (videoGame == null)
            {
                return NotFound();
            }
            return View(videoGame);
        }

        // POST: VideoGame/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "Staff")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,IsActive,DateAdded,Price")] VideoGame videoGame)
        {
            if (id != videoGame.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(videoGame);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VideoGameExists(videoGame.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(videoGame);
        }

        // GET: VideoGame/Delete/5
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoGame = await _context.VideoGames
                .FirstOrDefaultAsync(m => m.Id == id);
            if (videoGame == null)
            {
                return NotFound();
            }

            return View(videoGame);
        }

        // POST: VideoGame/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var videoGame = await _context.VideoGames.FindAsync(id);
            if (videoGame != null)
            {
                _context.VideoGames.Remove(videoGame);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VideoGameExists(int id)
        {
            return _context.VideoGames.Any(e => e.Id == id);
        }
    }
}
