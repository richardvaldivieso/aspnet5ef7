using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace aspnetefdemo {
  public class Country {
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id {get; set;}
    public string CountryName { get; set; }
  }
}
