using BookCar.Application.Features.Mediator.Results.TestimonialResults;
using MediatR;

namespace BookCar.Application.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialQuery : IRequest<List<GetTestimonialQueryResult>>
    {
    }
}
