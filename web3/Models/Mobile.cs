namespace web3.Models
{
    public class Mobile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Price { get; set; }
        public string OS { get; set; }
        public string ScreenSize { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string Battery { get; set; }
        public string Camera { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        //ManyToOne
        public Category Category { get; set; }
    }
}
