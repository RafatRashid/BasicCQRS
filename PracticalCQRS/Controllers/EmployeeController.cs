using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Dtos;
using Core.Entities;
using CQDomain.Commands;
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
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }


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