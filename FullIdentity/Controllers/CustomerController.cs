using AutoMapper;
using FullIdentity.Data.Data;
using FullIdentity.Data.Entities;
using FullIdentity.Dtos.CustomerDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FullIdentity.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public CustomerController(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet("")]
    [Authorize(Roles = "member")]
    public async Task<IActionResult> GetAllCustomer() => Ok(await _context.Customers.AsNoTracking().ToListAsync());

    [HttpPost("")]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> CreateCustomer(CustomerCreateDto customerCreateDto)
    {
        Customer customer = _mapper.Map<Customer>(customerCreateDto);
        await _context.Customers.AddAsync(customer);
        await _context.SaveChangesAsync();
        return NoContent();
    }

}
