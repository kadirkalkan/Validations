using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Validations.Models.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        static readonly int maxLength = 20;
        static readonly int minYasParam = 20;

        readonly string notNullMessage = "Bu Değerin Girilmesi Zorunludur.";
        readonly string maxLengthMessage = $"Bu Değer Max {maxLength} Uzunluğunda Olmalıdır.";
        readonly string minYasMessage = $"Yaş Değeri Min {minYasParam} Olmalıdır.";
        readonly string emailIncorrectMessage = $"Düzgün Bir Mail Adresi Girin.";

        public UserValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage(notNullMessage)
                .NotEmpty().WithMessage(notNullMessage)
                .MaximumLength(maxLength).WithMessage(maxLengthMessage);

            RuleFor(x => x.Yas)
                .NotNull().WithMessage(notNullMessage)
                .NotEmpty().WithMessage(notNullMessage)
                .InclusiveBetween(minYasParam, int.MaxValue).WithMessage(minYasMessage);

            RuleFor(x => x.Email)
                .EmailAddress().WithMessage(emailIncorrectMessage)
                .NotNull().WithMessage(notNullMessage)
                .NotEmpty().WithMessage(notNullMessage);
        }
    }
}
