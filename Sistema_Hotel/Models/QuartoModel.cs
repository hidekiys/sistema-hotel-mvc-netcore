namespace Sistema_Hotel.Models
{
    public class QuartoModel
    {
        public int Id { get; set; }

        public int NumQuarto { get; set; }
        public string? Hospede {  get; set; }
        public bool Status {  get; set; }
        public DateTime DataIn { get; set; }
        public DateTime DataOut { get; set; }
        public float Valor { get; set; }
    }
}
