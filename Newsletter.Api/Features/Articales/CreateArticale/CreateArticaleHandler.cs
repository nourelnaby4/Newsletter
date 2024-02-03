using AutoMapper;
using FluentValidation;
using MediatR;
using Newsletter.Api.Database;
using Newsletter.Api.Entities;
using Newsletter.Api.Shared;
using System;

namespace Newsletter.Api.Features.Articales.CreateArticale
{
    internal sealed class CreateArticaleHandler : ResponseHandler,
        IRequestHandler<CreateArticaleRequest, Response<string>>
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public CreateArticaleHandler(
            ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Response< string>> Handle(CreateArticaleRequest request, CancellationToken cancellationToken)
        {
           
            var articale = _mapper.Map<Articale>(request);
            _context.Add(articale);
            await _context.SaveChangesAsync(cancellationToken);
            return Success("success");

        }
    }
}
