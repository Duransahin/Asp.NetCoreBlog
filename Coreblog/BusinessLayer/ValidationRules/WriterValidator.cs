using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            //RuleFor(x => x.WriterImage).NotEmpty().WithMessage("Yazar Adı Soyadı Boş Geçilemez");
            //RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi Boş Geçilemez");
            //RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre  Boş Geçilemez");
            //RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");

        }
    }
}
