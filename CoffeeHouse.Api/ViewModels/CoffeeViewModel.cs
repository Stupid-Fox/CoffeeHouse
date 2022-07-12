namespace CoffeeHouse.Api.ViewModels
{
    public class CoffeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Coffee";
        public int Cost { get; set; }
        public int Temperature { get; set; }
        public int MakeTime { get; set; }
    }
}
