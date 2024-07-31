﻿using DigitalMealCardSystem.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class TransactionsController : ControllerBase
{
    private readonly MealCardContext _context;

    public TransactionsController(MealCardContext context)
    {
        _context = context;
    }

    // GET: api/Transactions
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Transaction>>> GetTransactions()
    {
        return await _context.Transactions.ToListAsync();
    }

    // GET: api/Transactions/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Transaction>> GetTransaction(int id)
    {
        var transaction = await _context.Transactions.FindAsync(id);

        if (transaction == null)
        {
            return NotFound();
        }

        return transaction;
    }

    // POST: api/Transactions
    [HttpPost]
    public async Task<ActionResult<Transaction>> PostTransaction(Transaction transaction)
    {
        // Add logic to check meal eligibility
        _context.Transactions.Add(transaction);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetTransaction), new { id = transaction.TransactionID }, transaction);
    }

    // PUT: api/Transactions/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutTransaction(int id, Transaction transaction)
    {
        if (id != transaction.TransactionID)
        {
            return BadRequest();
        }

        _context.Entry(transaction).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!TransactionExists(id))
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

    // DELETE: api/Transactions/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTransaction(int id)
    {
        var transaction = await _context.Transactions.FindAsync(id);
        if (transaction == null)
        {
            return NotFound();
        }

        _context.Transactions.Remove(transaction);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool TransactionExists(int id)
    {
        return _context.Transactions.Any(e => e.TransactionID == id);
    }
}
