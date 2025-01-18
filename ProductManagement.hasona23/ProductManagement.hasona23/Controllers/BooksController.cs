using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductManagement.hasona23.Constants;
using ProductManagement.hasona23.Data;
using ProductManagement.hasona23.Models;

namespace ProductManagement.hasona23.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Books
        public async Task<IActionResult> Index(string? bookName, int? maxPrice, int? minPrice, int page = 1)
        {
            var bookSearchModel = new BookSearchModel
            {
                BookName = bookName,
                MaxPrice = maxPrice,
                MinPrice = minPrice,
                CurrentPage = page
            };

            const int pageSize = 4;
            var books = await _context.Books.ToListAsync() ?? new List<BookModel>();

            // Create paginated list

            // Assign the books and apply search filters
            bookSearchModel.Books = books; // Ensure it's not null
            bookSearchModel.Books = bookSearchModel.SearchBooks().OrderBy(b => b.Name);
            var paginatedBooks = new PaginatedList<BookModel>(bookSearchModel.Books.ToList(), page, pageSize);
            bookSearchModel.Books = paginatedBooks.GetItems();
            bookSearchModel.TotalPages = paginatedBooks.TotalPages;
            return View(bookSearchModel);
        }


        // GET: Books/Details/5    
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookModel = await _context.Books
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookModel == null)
            {
                return NotFound();
            }

            return View(bookModel);
        }

        // GET: Books/Create
        [Authorize(Roles = $"{Roles.Admin} , {Roles.Staff}")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin , Staff")]
        public async Task<IActionResult> Create([Bind("Id,Name,Price")] BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(bookModel);
        }

        // GET: Books/Edit/5
        [Authorize(Roles = $"{Roles.Admin} , {Roles.Staff}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookModel = await _context.Books.FindAsync(id);
            if (bookModel == null)
            {
                return NotFound();
            }

            return View(bookModel);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = $"{Roles.Admin} , {Roles.Staff}")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price")] BookModel bookModel)
        {
            if (id != bookModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookModelExists(bookModel.Id))
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

            return View(bookModel);
        }

        // GET: Books/Delete/5
        [Authorize(Roles = "Admin , Staff")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookModel = await _context.Books
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookModel == null)
            {
                return NotFound();
            }

            return View(bookModel);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = $"{Roles.Admin} , {Roles.Staff}")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookModel = await _context.Books.FindAsync(id);
            if (bookModel != null)
            {
                _context.Books.Remove(bookModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookModelExists(int id)
        {
            return _context.Books.Any(e => e.Id == id);
        }
    }
}