using BookCar.Application.Features.Mediator.Queries.TestimonialQueries;
using BookCar.Application.Features.Mediator.Results.TestimonialResults;
using BookCar.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace BookCar.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
    {
        private readonly IRepository<Testimonial> _repository;
        public GetServiceQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetTestimonialQueryResult
            {
                Name = x.Name,
                TestimonialID = x.TestimonialID,
                ImageUrl = x.ImageUrl,
                Title = x.Title,
                Comment = x.Comment
            }).ToList();
        }
    }
}
