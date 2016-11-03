using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace noexcuses.Models.WeeklystandingsViewModels
{
    public class WeeklystandingsModel
    {
        [Key]
        public int id {get; set;}

        [Required]
        public int wkNumber {get; set;}

        [Required]
        public int wkRank {get; set;}

        [Required]
        public string teanName {get; set;}   
        
    }

}