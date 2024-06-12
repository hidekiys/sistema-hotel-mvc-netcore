using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Hotel.Models
{
    public class QuartoModel
    {
        public int Id { get; set; }

        public int NumQuarto { get; set; }
        public bool Status { get; set; }
        public DateOnly DataIn { get; set; }
        public DateOnly DataOut { get; set; }
        public double? Tipo { get; set; }
        public double Valor { get; set; }
        public int? AtualCPF { get; set; }
        public string? AtualNome { get; set; }
        public HospedeModel? ObjHospede { get; set; }
    }
}
