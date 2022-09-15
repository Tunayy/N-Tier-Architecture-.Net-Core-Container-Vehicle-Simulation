using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PycApi.Base;
using PycApi.Dto;
using PycApi.Service;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PycApi
{
    
    [ApiController]
    [Route("api/nhb/[controller]")]
    public class Container_Controller : ControllerBase
    {
        private readonly IContainer_Service controllerService;
        private readonly IMapper mapper;


        public Container_Controller(IContainer_Service cardService, IMapper mapper)
        {
            this.mapper = mapper;
            this.controllerService = cardService;
        }



        
        [HttpGet]
        public BaseResponse<IEnumerable<ContainerDto>> GetAll()
        {
            var response = controllerService.GetAll();
            return response;
        }


        [HttpGet("{id}")]
        public BaseResponse<ContainerDto> GetById(long id)
        {
            var response = controllerService.GetById(id);
            return response;
        }

       
        [HttpDelete("{id}")]
        public BaseResponse<ContainerDto> Delete(int id)
        {
            var response = controllerService.Remove(id);
            return response;
        }

        
        [HttpPost]
        public BaseResponse<ContainerDto> Create([FromBody] ContainerDto dto)
        {
            var accounId = (User.Identity as ClaimsIdentity).FindFirst("AccountId").Value;
            dto.Id = int.Parse(accounId);
            var response = controllerService.Insert(dto);
            return response;
        }

        
        [HttpPut("{id}")]
        public BaseResponse<ContainerDto> Update(int id, [FromBody] ContainerDto dto)
        {
            var response = controllerService.Update(id, dto);
            return response;
        }



    }
}
