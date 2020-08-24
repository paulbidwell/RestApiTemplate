using System.Collections.Generic;

namespace RestApiTemplate.Core.Dto
{
    public class FunkoPopDto
    { 
        public int FunkoPopId { get; set; }
        public int MoldNumber { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Category { get; set; }
        public string Feature { get; set; }
        public string License { get; set; }
    }
}