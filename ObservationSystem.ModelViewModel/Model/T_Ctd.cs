using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservationSystem.ModelViewModel.Model
{
    [Table("t_ctd")]
    class T_Ctd
    {
        [Column("id", Order = 0, TypeName = "BIGINT")]
        public long Id { get; set; }

        [Column("ctdSerialNum", Order = 1, TypeName = "VARCHAR")]
        public string CtdSerialNum { get; set; }

        [Column("ctdDateTime", Order = 2, TypeName = "DATETIME")]
        public DateTime CtdDateTime { get; set; }

        [Column("ctdMonth" , Order = 3, TypeName = "INT")]
        public int CtdMonth { get; set; }

        [Column("lon", Order = 4, TypeName = "DOUBLE")]
        public double Lon { get; set; }

        [Column("lat", Order = 5, TypeName = "DOUBLE")]
        public double Lat { get; set; }

        [Column("temp", Order = 6, TypeName = "DOUBLE")]
        public double Temp { get; set; }

        [Column("ctd", Order = 7, TypeName = "DOUBLE")]
        public double Ctd { get; set; }

        [Column("press" , Order = 8, TypeName = "DOUBLE")]
        public double Press { get; set; }

        [Column("depth", Order = 9, TypeName = "DOUBLE")]
        public double Depth { get; set; }

        [Column("salt", Order = 10, TypeName = "DOUBLE")]
        public double Salt { get; set; }

        [Column("sound", Order = 11, TypeName = "DOUBLE")]
        public double Sound { get; set; }

        [Column("denity", Order = 12, TypeName = "DOUBLE")]
        public double Denity { get; set; }

        [Column("flag", Order = 13, TypeName = "INT")]
        public int Flag { get; set; }

        [Column("ctdDate", Order = 14, TypeName = "DATETIME")]
        public DateTime CtdDate { get; set; }
    }
}
