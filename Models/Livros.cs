using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaNoctua.Models
{
    [Table("Livros")]

    public class Livros
    {

        [Display(Name = "Id")]
        [Column("Id")]

        public int ID { get; set; }
        public int Id { get; internal set; }
        [Display(Name = "Nome")]
        [Column("Nome")]

        public string Nome { get; set; }

        [Display(Name = "Autor")]
        [Column("Autor")]
        public string Autor { get; set; }

        [Display(Name = "Editora")]
        [Column("Editora")]
        public string Editora { get; set; }
    }

}