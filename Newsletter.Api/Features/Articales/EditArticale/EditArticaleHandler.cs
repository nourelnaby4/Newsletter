using AutoMapper;
using FluentValidation;
using MediatR;
using Newsletter.Api.Database;
using Newsletter.Api.Entities;
using Newsletter.Api.Shared;
using System;

namespace Newsletter.Api.Features.Articales.EditArticale
{
    internal sealed class EditArticaleHandler : ResponseHandler,
        IRequestHandler<EditArticaleRequest, Response<string>>
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public EditArticaleHandler(
            ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Response< string>> Handle(EditArticaleRequest request, CancellationToken cancellationToken)
        {
           var articale = await _context.Articales.FindAsync(request.ArticaleId);
            if (articale == null)
            {
                return NotFound<string>();
            }
            articale = _mapper.Map(request, articale);
            _context.Update(articale);
            await _context.SaveChangesAsync(cancellationToken);
            return Success("success");

        }
    }
}
