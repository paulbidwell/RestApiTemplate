namespace RestApiTemplate.Core.Domain
{
    public class CollectionFunkoPop
    {
        public int CollectionId { get; set; }
        public Collection Collection { get; set; }
        public int FunkoPopId { get; set; }
        public FunkoPop FunkoPop { get; set; }
    }
}