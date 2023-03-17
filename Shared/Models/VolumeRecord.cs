using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MeccaUI_THDxIOT.Shared
{
    public class VolumeRecord
    {
        [Key][Required]
        public long VolumeRecod_ID { set; get; }

        [Required]
        public int VolumeLevel { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ateTimeOfRecord { get; set; }

    }
}
