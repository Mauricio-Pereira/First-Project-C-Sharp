using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodeFirstEF.Infrastructure.Database;
using CodeFirstEF.Models;

namespace CodeFirstEF.Controllers
{
    public class PodcastController : Controller
    {
        private readonly PodcastDbContext _context;

        public PodcastController(PodcastDbContext context)
        {
            _context = context;
        }

        // GET: Podcast
        public async Task<IActionResult> Index()
        {
            return View(await _context.Podcasts.ToListAsync());
        }

        // GET: Podcast/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var podcast = await _context.Podcasts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (podcast == null)
            {
                return NotFound();
            }

            return View(podcast);
        }

        // GET: Podcast/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Podcast/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,Url")] Podcast podcast)
        {
            if (ModelState.IsValid)
            {
                _context.Add(podcast);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(podcast);
        }

        // GET: Podcast/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var podcast = await _context.Podcasts.FindAsync(id);
            if (podcast == null)
            {
                return NotFound();
            }
            return View(podcast);
        }

        // POST: Podcast/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Url")] Podcast podcast)
        {
            if (id != podcast.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(podcast);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PodcastExists(podcast.Id))
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
            return View(podcast);
        }

        // GET: Podcast/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var podcast = await _context.Podcasts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (podcast == null)
            {
                return NotFound();
            }

            return View(podcast);
        }

        // POST: Podcast/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var podcast = await _context.Podcasts.FindAsync(id);
            if (podcast != null)
            {
                _context.Podcasts.Remove(podcast);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PodcastExists(int id)
        {
            return _context.Podcasts.Any(e => e.Id == id);
        }
    }
}
