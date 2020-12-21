using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirLiquide.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        [Required(ErrorMessage = "O Nome é Origatório")]
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
