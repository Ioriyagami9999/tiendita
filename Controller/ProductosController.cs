using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TienditaApi.Data;
using TienditaApi.Models;

namespace TienditaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductosController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProductosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Producto>>> GetProductos()
        => await _context.Productos.ToListAsync();

[HttpPost]
public async Task<ActionResult<Producto>> PostProducto(Producto producto)
{
    if (producto.Precio < 0)
        return BadRequest(new { mensaje = "No se admite precio negativo" });

    _context.Productos.Add(producto);
    await _context.SaveChangesAsync();
    return CreatedAtAction(nameof(GetProductos), new { id = producto.Id }, producto);
}


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProducto(int id)
    {
        var producto = await _context.Productos.FindAsync(id);
        if (producto == null) return NotFound();

        _context.Productos.Remove(producto);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
