
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheConfectionery.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The Treat Name is the most important information!")]
    public string TreatName { get; set; }

    public string TreatInstructions {get;set;}

    public List<TreatFlavor> JoinEntities { get; set; }

    public ApplicationUser User { get; set; } 
  }
}