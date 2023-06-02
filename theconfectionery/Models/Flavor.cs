
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheConfectionery.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "The Flavor Name is needed information!")]
    public string FlavorName { get; set; }
    
    public List<TreatFlavor> JoinEntities { get; set; }

    public ApplicationUser User { get; set; } 
  }
}