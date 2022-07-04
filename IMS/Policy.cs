﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IMS
{
    [Table("policies")]
    public partial class Policy
    {
        public Policy()
        {
            AppliedPolicies = new HashSet<AppliedPolicy>();
        }

        [Key]
        public int Pid { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string Pname { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string Pcategory { get; set; }
        public int? Totalamount { get; set; }
        public int? Premium { get; set; }
        public int? Tenure { get; set; }
        [Column("DOC", TypeName = "date")]
        public DateTime? Doc { get; set; }

        [InverseProperty("PidNavigation")]
        public virtual ICollection<AppliedPolicy> AppliedPolicies { get; set; }
    }
}