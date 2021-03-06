﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab17Erik.Model;
using Lab17Erik.Models;

namespace Lab17Erik.Controllers
{
    public class DestenationsController : Controller
    {
        private readonly Lab17ErikContext _context;

        public DestenationsController(Lab17ErikContext context)
        {
            _context = context;
        }

        // GET: Destenations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Destenation.ToListAsync());
        }

        // GET: Destenations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destenation = await _context.Destenation
                .SingleOrDefaultAsync(m => m.ID == id);
            if (destenation == null)
            {
                return NotFound();
            }

            return View(destenation);
        }

        // GET: Destenations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Destenations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Country,ClimateType")] Destenation destenation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(destenation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(destenation);
        }

        // GET: Destenations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destenation = await _context.Destenation.SingleOrDefaultAsync(m => m.ID == id);
            if (destenation == null)
            {
                return NotFound();
            }
            return View(destenation);
        }

        // POST: Destenations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Country,ClimateType")] Destenation destenation)
        {
            if (id != destenation.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(destenation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DestenationExists(destenation.ID))
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
            return View(destenation);
        }

        // GET: Destenations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destenation = await _context.Destenation
                .SingleOrDefaultAsync(m => m.ID == id);
            if (destenation == null)
            {
                return NotFound();
            }

            return View(destenation);
        }

        // POST: Destenations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var destenation = await _context.Destenation.SingleOrDefaultAsync(m => m.ID == id);
            _context.Destenation.Remove(destenation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DestenationExists(int id)
        {
            return _context.Destenation.Any(e => e.ID == id);
        }
    }
}
