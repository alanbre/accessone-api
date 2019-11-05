using System;
using System.ComponentModel.DataAnnotations;

namespace AccessOne.Service.Responses
{
    public class GrupoResponse
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}