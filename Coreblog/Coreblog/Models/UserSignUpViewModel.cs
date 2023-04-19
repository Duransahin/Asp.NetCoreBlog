using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coreblog.Models
{
    public  class UserSignUpViewModel
    {

        [Display(Name = "Ad Soyad")]
        [Required(ErrorMessage ="Lütfen Ad Soyad giriniz")]
        public string NameSurname { get; set; }
        
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage ="Lütfen kullanıcı adınızı giriniz")]
        public string UserName { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage ="Lütfen Şifrenizi giriniz")]
        public string Password { get; set; }

        [Display(Name ="Şifre Tekrars")]    
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage ="Lütfen Mailadresinizi giriniz")]
        public string Mail { get; set; } 

    }
}
