using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetFrameWork
{
    public class Account
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Email bắt buộc phải nhập")]
        [StringLength(100)]
        public string email { get; set; }
        public string password { get; set; }
    }
}
