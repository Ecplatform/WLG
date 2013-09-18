using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WLG.Model
{
    public class Register
    {
        [Required(ErrorMessage="用户名不能为空")]
        public string Username { get; set; }

        public string Nickname {get;set;}

        public string Email { get; set; }

        public string Password { get; set; }

        public string BirthDate { get; set; }



    }
}