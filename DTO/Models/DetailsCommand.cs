using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class DetailsCommand
    {
        public int Id { get; set; }
        public DateTime? DateOfCommand { get; set; }
        public Client Client { get; set; }
        public Address Address { get; set; }
        public List<CommandWine> Commandwine { get; set; }
    }
}
