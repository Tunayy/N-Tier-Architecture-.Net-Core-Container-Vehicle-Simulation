using AutoMapper;
using NHibernate;
using PycApi.Base;
using PycApi.Data;
using PycApi.Dto;
using System;
using System.Collections.Generic;
namespace PycApi.Service
{
    public class Vehicle_Service : BaseService<VehicleDto, Vehicle>, IVehicle_Service
    {
        protected readonly ISession session;
        protected readonly IMapper mapper;
        protected readonly IHibernateRepository<Vehicle> hibernateRepository;

        public Vehicle_Service(ISession session, IMapper mapper) : base(session, mapper)
        {
            this.session = session;
            this.mapper = mapper;

            hibernateRepository = new HibernateRepository<Vehicle>(session);
        }

        public override BaseResponse<IEnumerable<VehicleDto>> GetAll()
        {
            return base.GetAll();
        }

        public override BaseResponse<VehicleDto> GetById(long id)
        {
            return base.GetById(id);
        }

        public override BaseResponse<VehicleDto> Insert(VehicleDto insertResource)
        {
            return base.Insert(insertResource);
        }
    }
}
