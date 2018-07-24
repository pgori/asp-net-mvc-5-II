using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Financas.Entidades
{
    public class Movimentacao
    {
        public int Id { get; set; }
        [Required]
        public decimal Valor { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public Tipo Tipo { get; set; }
        [Required]
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}