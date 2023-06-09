﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Library.Data.Models
{
    [Comment("User Books")]
    public class IdentityUserBook
    {
        [Comment("Book Collector")]
        public string CollectorId { get; set; } = null!;

        [Comment("Collector")]
        [ForeignKey(nameof(CollectorId))]
        public IdentityUser Collector { get; set; } = null!;

        [Comment("Book Id")]
        public int BookId { get; set; }

        [Comment("Book")]
        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; } = null!;

    }

    //  CollectorId – a string, Primary Key, foreign key(required)
    //• Collector – IdentityUser
    //• BookId – an integer, Primary Key, foreign key(required)
    //• Book – Book
}
