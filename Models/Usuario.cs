using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaNoctua.Models
{
    [Table("Usuario")]

    public class Usuario
    {

        [Display(Name = "Id")]
        [Column("Id")]

        public int ID { get; set; }
        public int Id { get; internal set; }
        [Display(Name = "Nome")]
        [Column("Nome")]

        public string Nome { get; set; }

        [Display(Name = "Celular")]
        [Column("Celular")]
        public string Celular { get; set; }

        [Display(Name = "Email")]
        [Column("Email")]
        public string Email { get; set; }
    }

}