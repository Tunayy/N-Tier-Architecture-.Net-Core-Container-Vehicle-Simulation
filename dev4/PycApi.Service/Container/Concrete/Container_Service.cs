using AutoMapper;
using NHibernate;
using PycApi.Base;
using PycApi.Data;
using PycApi.Dto;
using System;
using System.Collections.Generic;

namespace PycApi.Service
{
    public class Container_Service : BaseService<ContainerDto, Container>, IContainer_Service
    {

        protected readonly ISession session;
        protected readonly IMapper mapper;
        protected readonly IHibernateRepository<Container> hibernateRepository;

        public Container_Service(ISession session, IMapper mapper) : base(session, mapper)
        {
            this.session = session;
            this.mapper = mapper;

            hibernateRepository = new HibernateRepository<Container>(session);
        }

        public override BaseResponse<IEnumerable<ContainerDto>> GetAll()
        {
            return base.GetAll();
        }

        public override BaseResponse<ContainerDto> GetById(long id)
        {
            return base.GetById(id);
        }

        public override BaseResponse<ContainerDto> Insert(ContainerDto insertResource)
        {
            return base.Insert(insertResource);
        }
    }
}