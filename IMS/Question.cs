﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IMS
{
    public partial class Question
    {
        [Key]
        [Column("sno")]
        public int Sno { get; set; }
        public int? CustId { get; set; }
        [Column("question")]
        [StringLength(500)]
        [Unicode(false)]
        public string Question1 { get; set; }
        [Column("answer")]
        [StringLength(500)]
        [Unicode(false)]
        public string Answer { get; set; }

        [ForeignKey("CustId")]
        [InverseProperty("Questions")]
        public virtual Customer Cust { get; set; }
    }
}