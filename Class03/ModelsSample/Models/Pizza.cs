namespace ModelsSample.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsOnPromotion { get; set; }
        public bool HasExtras { get; set; }
        public PizaSize PizaSize { get; set; }
    }

    public enum PizaSize 
    { 
        Familiy,
        Normal
    }
}
