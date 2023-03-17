using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeccaUI_THDxIOT.Shared
{
    public class ChargeRecord
    {
        [Key]
        public long ChargeRecord_ID { set; get; }

        public int ChargeLevel { get; set; }

        public bool IsCharging { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateTimeOfRecord { get; set; }

    }
}
