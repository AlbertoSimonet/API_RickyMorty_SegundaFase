namespace API_RickyMorty.Model
{
    public class Character
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public Origin Origin { get; set; }
        public string Image { get; set; }
    }
    public class Origin
    {
        public string name { get; set; }
    }
}