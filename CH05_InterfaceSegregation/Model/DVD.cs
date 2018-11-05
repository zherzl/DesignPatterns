namespace Model
{
    public class DVD : IProduct, IMovie
    {
        public decimal Price { get; set; }
        public decimal WeightInKg { get; set; }
        public int Stock { get; set; }
        public int Certification { get; set; }
        public int RunningTime { get; set; }
    }
}