using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppNi_2.Shared.Model.BaseClass
{
    public class Borrow
    {
        public int BorrowId { get; set; }
        [Required]
        public int MemberId { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public DateTime BorrowDate { get; set; } = DateTime.Today;
        [Required]
        public DateTime BorrowDeadline { get; set; } = DateTime.Today;
    }
}
