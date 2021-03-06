﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using gratisAPI.Data;
using gratisAPI.Model;

namespace gratisAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly gratisAPIContext _context;
        private IQueryable<Basket> ProductInBasket;

        public BasketsController(gratisAPIContext context)
        {
            _context = context;
        }

        // GET: api/Baskets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Basket>>> GetBasket()
        {
            return await _context.Basket.ToListAsync();
        }

        // GET: api/Baskets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Basket>> GetBasket(int id)
        {
            var basket = await _context.Basket.FindAsync(id);

            if (basket == null)
            {
                return NotFound();
            }

            return basket;
        }

        // PUT: api/Baskets/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBasket(int id, Basket basket)
        {
            if (id != basket.Id)
            {
                return BadRequest();
            }

            _context.Entry(basket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BasketExists(id))
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

        // POST: api/Baskets
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Basket>> PostBasket(int id,Basket basket, bool isPurchased, int CustomerId, int ProductId, int pCustomerId, int pProductId, int ProductCount)
        {
            ProductInBasket = _context.Basket.Where(x => x.ProductId == pProductId & x.CustomerId == pCustomerId & x.isPurchased == false);
            //ProductInBasket.FirstOrDefault(x => x.ProductId > 0);
            

            if (ProductInBasket.FirstOrDefault() != null)
            {
                ProductCount = ProductInBasket.Count();
                ProductCount++;
                basket.ProductCount = ProductCount;
                await _context.SaveChangesAsync();
                
                return CreatedAtAction("Product in Basket", id = basket.Id, basket);
            }
            else
            {
                _context.Basket.Add(basket);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetBasket", new { id = basket.Id }, basket);
            }
        }




        // DELETE: api/Baskets/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Basket>> BuyBasket(int id)
        {
            var basket = await _context.Basket.FindAsync(id);
            if (basket == null)
            {
                return NotFound();
            }

            _context.Basket.Remove(basket);
            await _context.SaveChangesAsync();

            return basket;
        }

        private bool BasketExists(int id)
        {
            return _context.Basket.Any(e => e.Id == id);
        }
    }
}
