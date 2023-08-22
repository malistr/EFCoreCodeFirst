﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteZ.Models
{
    [Table("ReceteIlaclari")]
    public class ReceteIlac : BaseModel
    {
        public int IlacId { get; set; }
        public int RecetId { get; set; }
        public int KullanimSekliId { get; set; }
        public int Periyot { get; set; }
        public int Doz { get; set; }
        public int Adet { get; set; }


        public virtual Ilac Ilac { get; set; }
        public virtual Recete Recete { get; set; }
        public virtual KullanimSekli KullanimSekli { get; set; }




    }
}
