using BookCar.Application.Features.Mediator.Commands.TestimonialCommands;
using BookCar.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace BookCar.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class RemovePricingCommandHandler : IRequestHandler<RemoveTestimonialCommand>
    {
        private readonly IRepository<Testimonial> _repository;

        public RemovePricingCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveTestimonialCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
