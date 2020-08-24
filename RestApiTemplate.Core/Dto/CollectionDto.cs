using System.Collections.Generic;

namespace RestApiTemplate.Core.Dto
{
    public class CollectionDto
    {
        public int CollectionId { get; set; }
        public string CollectionName { get; set; }
        public List<int> FunkoPopIds { get; set; }
    }
}