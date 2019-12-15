using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AccessOne.Domain.Models;

namespace AccessOne.Service.Requests
{
    public class ComandoCreateRequest
    {
        [Required(ErrorMessage = "Comando deve ser informado")]
        public string ComandoStr { get; set; }
        public Computador Computador { get; set; }
    }
}