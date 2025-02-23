﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DataAccessLayer;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var c = new ContextAPI();
            var values = c.Employees.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult EmployeeAdd(Employee employee)
        {
            using var c = new ContextAPI();
            c.Add(employee);
            c.SaveChanges();
            return Ok();
        }

        [HttpGet("id")]
        public IActionResult EmployeeGet(int id)
        {
            using var c = new ContextAPI();
            var employee = c.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(employee);
            }
        }

        [HttpDelete("id")]
        public IActionResult EmployeeDelete(int id)
        {
            using var c = new ContextAPI();
            var employee = c.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(employee);
                c.SaveChanges();
                return Ok(employee);
            }
        }

        [HttpPut]
        public IActionResult EmployeeDelete(Employee employee)
        {
            using var c = new ContextAPI();
            var emp = c.Find<Employee>(employee.Id);

            if (emp == null)
            {
                return NotFound();
            }
            else
            {
                emp.Name = employee.Name;
                c.Update(emp);
                c.SaveChanges();
                return Ok();
            }
        }
    }
}
