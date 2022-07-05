using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEF.Models
{
    public class Categoria
    {
        [Key]
        public Guid CategoriaId {get;set;}

        [Required]
        [MaxLength(150)]
        public String Nombre {get;set;}

        public String Descripcion {get;set;}

//RELACION CON LAS OTRAS CLASES O TABLAS EN EL MODELO - virtual
        public virtual ICollection<Tarea> Tareas {get;set;}

    }
}