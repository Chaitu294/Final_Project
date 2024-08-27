using System; 
using System.ComponentModel.DataAnnotations;

namespace Final_Project.ViewModels
{
    public class RoleFormViewModel
    {
        [Required,StringLength(256)]
        public string Name {  get; set; }
    }
}
