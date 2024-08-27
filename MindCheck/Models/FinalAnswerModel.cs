using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindCheck.Models
{
    public class FinalAnswerModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int TestId { get; set; }
        [Required]
        public string ResultText { get; set; }
        [Required]
        public string ScoreRange { get; set; }
    }
}
