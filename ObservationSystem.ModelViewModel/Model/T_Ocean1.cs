using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservationSystem.ModelViewModel.Model
{
    /// <summary>
    /// 海表1
    /// </summary>
    [Table("t_ocean1")]
    public class T_Ocean1
    {
        [Column("id", Order = 0, TypeName = "BIGINT")]
        public long Id { get; set; }

        [Column("stId", Order = 1, TypeName = "VARCHAR")]
        public string Stld { get; set; }

        [Column("odate", Order = 2, TypeName = "DATETIME")]
        public DateTime Odate { get; set; }

        [Column("ltime", Order = 3, TypeName = "INT")]
        public int Ltime { get; set; }

        [Column("temp", Order = 4, TypeName = "DOUBLE")]
        public double Temp { get; set; }

        [Column("salc", Order = 5, TypeName = "DOUBLE")]
        public double Salc { get; set; }

        [Column("salt", Order = 6, TypeName = "DOUBLE")]
        public double Salt { get; set; }

        [Column("rout", Order = 7, TypeName = "DOUBLE")]
        public double Rout { get; set; }

        [Column("at1", Order = 8, TypeName = "DOUBLE")]
        public double At1 { get; set; }

        [Column("at2", Order = 9, TypeName = "DOUBLE")]
        public double At2 { get; set; }

        [Column("rou175", Order = 10, TypeName = "DOUBLE")]
        public double Rou175 { get; set; }
    }
}
