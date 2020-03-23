using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Yetenek_Kartı.Models.Siniflar
{
    public class Yetenek
    {
        [Key]
        public int Id { get; set; }
        public  string Açiklama { get; set; }
        public byte deger { get; set; }

    }
}