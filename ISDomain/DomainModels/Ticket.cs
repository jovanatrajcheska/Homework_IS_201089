using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISDomain.DomainModels
{
    public enum Genre
    {
        Drama,
        Comedy,
        Horror,
        Thriller,
        SoapOpera,
        ScienceFiction,
    }
    public class Ticket : BaseEntity
    {
        [Required]
        [DisplayName("Movie Name")]
        public string MovieName { get; set; }

        [Required]
        [DisplayName("Genre")]
        public Genre MovieGenre { get; set; }

        [Required]
        [DisplayName("Year")]
        public string MovieYear { get; set; }

        [Required]
        [DisplayName("Description")]
        public string MovieDescription { get; set; }

        [Required]
        [DisplayName("Image")]
        public string MovieImage { get; set; }

        [Required]
        [DisplayName("Ticket Price")]
        public int TicketPrice { get; set; }

        [Required]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }

        public virtual ICollection<TicketInShoppingCart> TicketsInShoppingCart { get; set; }
        public virtual ICollection<TicketInOrder> TicketsInOrder { get; set; }
    }
}
