using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaHomework2.Dto.Dto
{
    public class DepartmentDto
    {
       

        [MaxLength(10)]
        public string DeptName { get; set; }

        [ForeignKey("CountryId")]
        public int CountryId { get; set; }

        //nav

        public ICollection<CountryDto> Country { get; set; }
    }
}
