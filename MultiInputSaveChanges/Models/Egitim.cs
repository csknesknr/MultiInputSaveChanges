using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MultiInputSaveChanges.Models
{
    public class Egitim
    {
        public int Id { get; set; }
        public string EgitimAdi { get; set; }
        [NotMapped]
        public DateTime[] GrupTarihi { get; set; }
        [NotMapped]
        public int[] GrupSayisi { get; set; }
        [NotMapped]
        public int[] GrupNo { get; set; }
    }
}
