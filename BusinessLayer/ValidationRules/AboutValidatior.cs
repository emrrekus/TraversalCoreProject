using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidatior : AbstractValidator<About>
    {
        public AboutValidatior()
        {
            RuleFor(x => x.Title)
             .NotEmpty().WithMessage("Title alanı boş bırakılamaz.")
             .MaximumLength(100).WithMessage("Title en fazla 100 karakter olabilir.");

           
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Description alanı boş bırakılamaz.")
                .MaximumLength(500).WithMessage("Description en fazla 500 karakter olabilir.");

         
            RuleFor(x => x.ImageUrl)
                .NotEmpty().WithMessage("Image URL boş bırakılamaz.")
                .Must(url => Uri.TryCreate(url, UriKind.Absolute, out _)).WithMessage("Geçerli bir URL formatı girin.");

           
            RuleFor(x => x.SecondaryTitle)
                .NotEmpty().WithMessage("Secondary Title boş bırakılamaz.")
                .MaximumLength(100).WithMessage("Secondary Title en fazla 100 karakter olabilir.");

            RuleFor(x => x.SecondaryDescription)
                .NotEmpty().WithMessage("Secondary Description boş bırakılamaz.")
                .MaximumLength(500).WithMessage("Secondary Description en fazla 500 karakter olabilir.");

            
            RuleFor(x => x.Status)
                .NotNull().WithMessage("Status değeri boş bırakılamaz.");
        }
    }
}
