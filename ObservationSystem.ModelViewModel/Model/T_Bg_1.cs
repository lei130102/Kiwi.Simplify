using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservationSystem.ModelViewModel.Model
{
    [Table("t_bg_1")]
    class T_Bg_1
    {
        [Column("lon", Order = 0, TypeName = "DOUBLE")]
        public double Lon { get; set; }

        [Column("lat", Order = 1, TypeName = "DOUBLE")]
        public double Lat { get; set; }

        [Column("depth", Order = 2, TypeName = "DOUBLE")]
        public double Depth { get; set; }

        [Column("temp", Order = 3, TypeName = "DOUBLE")]
        public double Temp { get; set; }

        [Column("salt", Order = 4, TypeName = "DOUBLE")]
        public double Salt { get; set; }

        [Column("denity", Order = 5, TypeName = "DOUBLE")]
        public double Denity { get; set; }

        [Column("sound", Order = 6, TypeName = "DOUBLE")]
        public double Sound { get; set; }
    }
}
