using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Newtonsoft.Json;

namespace WebApi.Models
{
    public class Employee 
    {
        public Employee()
        {
            
        }

        [JsonProperty("id")]
        [Key, Column(Order = 0)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(120)]
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(120)]
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [JsonProperty("birthDate")]
        public DateTime BirthDate { get; set; }

        

        [ForeignKey("Department")]
        [JsonProperty("departmentId")]
        public int DepartmentId { get; set; }

        
    }

    
}
