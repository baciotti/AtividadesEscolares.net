using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace AtividadesEscolares.Models
{
    public class Tarefa
    {
        public int ID { get; set; }

        [Display (Name="Nome")]
        [StringLength(50, ErrorMessage = "O nome da tarefa pode ter no máximo 50 caracteres")]
        [Required]
        public String nome { get; set; }

        [Display(Name = "Descrição")]
        public String descricao { get; set; }

        [Display(Name = "Data Entrega")]
        [DataType(DataType.Date)]
        public DateTime data { get; set; }



    }

    public class TarefaDBContext : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}