using AutoMapper;
using EmployeeManagement.Api.NewFolder2;
using EmployeeManagement.Core;
using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.NewFolder;
using EmployeeManagement.Core.Services;
using EmployeeManagement.Service.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        //private readonly Mapping _mapping;
        private readonly IMapper _mapper;
        public EmployeeController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
          _mapper= mapper;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<ActionResult<Employee>> Get()
        {
            var list = await _employeeService.GetAllAsync();
            var listDto = new List<EmployeeDto>();
            foreach (var employee in list)
            {
                {
                   // listDto.Add(_mapping.MapToEmployeeDto(employee));
                 listDto.Add(_mapper.Map<EmployeeDto>(employee));

                }
            }
            return Ok(listDto);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {

            var employee = await _employeeService.GetByIdAsync(id);

            //var employeeDto = _mapper.Map<EmployeeDto>(employee);
            //return Ok(employeeDto);
           return Ok(employee);


        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task Post([FromBody] EmployeePostModel value)
        {
            var employeeToAdd = new Employee() { DateOfBirth = value.DateOfBirth, FirstName = value.FirstName, LastName = value.LastName, DateOfStartingWork = value.DateOfStartingWork, Gender = value.Gender,EmployeeId=value.EmployeeId,RoleList=value.RoleList };
            await _employeeService.AddEmployeeAsync(employeeToAdd);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] EmployeePostModel value)
        {
           
            var employeeToEdit = new Employee() { DateOfBirth = value.DateOfBirth, FirstName = value.FirstName, LastName = value.LastName, DateOfStartingWork = value.DateOfStartingWork, Gender = value.Gender,EmployeeId=value.EmployeeId,IsActivate=true, RoleList = value.RoleList };
            await _employeeService.UpdateEmployeeAsync(id, employeeToEdit);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _employeeService.DeleteEmployeeAsync(id);
        }
    }
}
