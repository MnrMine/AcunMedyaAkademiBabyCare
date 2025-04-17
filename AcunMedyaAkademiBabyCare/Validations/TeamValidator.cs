using AcunMedyaAkademiBabyCare.Entities;
using FluentValidation;

namespace AcunMedyaAkademiBabyCare.Validations
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("İsim-Soyisim boş bırakılamaz");
            RuleFor(x => x.NameSurname).MinimumLength(3).WithMessage("Lütfen isim-soyisim bilgilerini en az 3 karakter olarak giriniz.");
            RuleFor(x => x.NameSurname).MaximumLength(20).WithMessage("Lütfen isim-soyisim bilgilerini en fazla 20 karakter olarak giriniz.");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Yaş bilgisini boş bırakılmaz.");
            RuleFor(x => x.City).NotEmpty().WithMessage("Lütfen  şehir bilgisi giriniz.");
            RuleFor(x => x.ImagerUrl).NotEmpty().WithMessage("Lütfen  resim bilgisi giriniz.");
            RuleFor(x => x.BranchId).NotEmpty().WithMessage("Lütfen  kayıt için bir branş  seçiniz.");
        }

    }
}
