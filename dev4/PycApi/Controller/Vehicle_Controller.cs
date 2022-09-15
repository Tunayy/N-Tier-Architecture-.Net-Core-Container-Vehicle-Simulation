using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PycApi.Base;
using PycApi.Dto;
using PycApi.Service;
using System.Collections.Generic;

namespace PycApi.Controllers
{
    [ApiController]
    [Route("api/nhb/[controller]")]

    public class Vehicle_Controller : ControllerBase
    {
        private readonly IVehicle_Service vehicleService;
        private readonly IMapper mapper;


        public Vehicle_Controller(IVehicle_Service vehicleService, IMapper mapper)
        {
            this.vehicleService = vehicleService;
            this.mapper = mapper;
        }


        [HttpGet]
        public BaseResponse<IEnumerable<VehicleDto>> GetAll()
        {
            var response = vehicleService.GetAll();
            return response;
        }

        [HttpGet("{id}")]
        public BaseResponse<VehicleDto> GetById(int id)
        {
            var response = vehicleService.GetById(id);
            return response;
        }

        [HttpDelete("{id}")]
        public BaseResponse<VehicleDto> Delete(int id)
        {
            var response = vehicleService.Remove(id);
            return response;
        }

        [HttpPost]
        public BaseResponse<VehicleDto> Create([FromBody] VehicleDto dto)
        {
            var response = vehicleService.Insert(dto);
            return response;
        }

        [HttpPut("{id}")]
        public BaseResponse<VehicleDto> Update(int id, [FromBody] VehicleDto dto)
        {
            var response = vehicleService.Update(id, dto);
            return response;
        }
    }
}
