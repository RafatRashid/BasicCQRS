using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccessors.Query.Interfaces;
using Core.Dtos;
using Core.Entities;
using CQDomain.Commands;
using CQDomain.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PracticalCQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IQueryRepository<Employee> _empRepository;
        public EmployeeController(IMediator mediator, IQueryRepository<Employee> repository)
        {
            _mediator = mediator;
            _empRepository = repository;
        }

        [HttpGet]
        public async Task<ResponseDto> Get()
        {
            var resp = new ResponseDto();
            try
            {
                var employees = await _mediator.Send(new GetAllEmployee());
                resp.Success = true;
                resp.Data = employees;
            }
            catch(Exception ex)
            {
                resp.Success = false;
                resp.Message = ex.Message;
            }

            return resp;
        }

        [HttpPost]
        public async Task<ResponseDto> Post([FromBody]Employee employee)
        {
            var resp = new ResponseDto();
            try
            {
                await _mediator.Send(new CreateEmployee(0, employee.FirstName, employee.LastName, employee.DateOfBirth));
                resp.Success = true;
                resp.Message = "Employee created";
            }
            catch (Exception ex)
            {
                resp.Message = ex.Message;
            }

            return resp;
        }
    }
}