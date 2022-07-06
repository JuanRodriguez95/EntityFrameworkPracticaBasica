using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEF.Models
{
    public class Tarea
    {
        //[Key]
        public Guid TareaId {get;set;}

       // [ForeignKey("CategoriaId")]
        public Guid CategoriaId {get;set;}

       // [Required]
       // [MaxLength(200)]
        public String Titulo {get;set;}

        public String Descripcion {get;set;}

        public Prioridad PrioridadTarea {get;set;}

        public DateTime FechaCreacion {get;set;}

        public DateTime FechaLimite {get;set;}

//RELACION CON LAS OTRAS CLASES O TABLAS EN EL MODELO - virtual
        public virtual Categoria Categoria {get;set;}

       // [NotMapped]
        public String Resumen {get;set;}

    }

}

public enum Prioridad{
    Baja,
    Media,
    Alta
}