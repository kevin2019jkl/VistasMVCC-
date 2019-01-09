using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Vistas.Models
{
    public class DatosPersonales
    {
        [Required(ErrorMessage="El siguiente dato es requerido")]
        public String nombre { get; set; }

        [Required(ErrorMessage = "El siguiente dato es requerido")]
        public String apellido { get; set; }

        [Required(ErrorMessage = "El siguiente dato es requerido")]
        public String edad { get; set; }
    }
    public class DatosEmail
    {
        [Required(ErrorMessage = "El email es requerido")]
        [Display(Name = "Correo Electronico")]
        public String email { get; set; }

        [Required(ErrorMessage = "La Contraseña es requerida")]
        [Display(Name = "Contraseña")]
        public String password { get; set; }

    }
}