using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MessageBoard.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName {get;set;}
    }
}