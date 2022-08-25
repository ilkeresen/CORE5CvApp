using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adını Boş Bırakmayınız.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Boş Bırakmayınız.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen Resim Alanını Boş Bırakmayınız.")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Boş Bırakmayınız.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre Boş Bırakmayınız.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre Tekrarını Boş Bırakmayınız.")]
        [Compare("Password", ErrorMessage = "Girilen Şifreler Uyumlu Değil.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen E-Posta Adresini Boş Bırakmayınız.")]
        public string Mail { get; set; }
    }
}
