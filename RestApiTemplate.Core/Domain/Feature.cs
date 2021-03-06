﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApiTemplate.Core.Domain
{
    public class Feature
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FeatureId { get; set; }

        [Column(TypeName = "varchar(255)")]
        [StringLength(255)]
        public string FeatureName { get; set; }
    }
}