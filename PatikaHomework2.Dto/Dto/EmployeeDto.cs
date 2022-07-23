using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaHomework2.Dto.Dto
{
    public  class Employee
    {
      

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }

        //nav
        public ICollection<DepartmentDto> Department { get; set; }
    }
}
