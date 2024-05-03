using BookCar.Application.Features.Mediator.Commands.TestimonialCommands;
using BookCar.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace BookCar.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class CreatePricingCommandHandler : IRequestHandler<CreateTestimonialCommand>
    {
        private readonly IRepository<Testimonial> _repository;
        public CreatePricingCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Testimonial
            {
                Name = request.Name,
                Comment = request.Comment,
                ImageUrl = request.ImageUrl,
                Title = request.Title
            });
        }
    }
}
