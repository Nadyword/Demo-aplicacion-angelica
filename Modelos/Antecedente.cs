namespace HitoriaClinica.Modelos
{
    public class Antecedente
    {
        public int ClienteId { get; set; }
        public string? Enfermedad { get; set; }
        public string? AlergiaMedicamentos { get; set; }
        public string? AlergiaAlimentos { get; set; }
        public string? Cirugias { get; set; }
        public string? Tratamientos { get; set; }
        public string? Biopsias { get; set; }
    }
}
