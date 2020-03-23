using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Yetenek_Kartı.Models.Siniflar
{
    public class Context:DbContext
    {
        public IDbSet<Yetenek> Yeteneks { get; set; }
    }
}