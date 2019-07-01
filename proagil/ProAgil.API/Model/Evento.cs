namespace ProAgil.API.Model
{
    public class Evento
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int EnventoId { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdePessoas { get; set; }
        public string Lote { get; set; }
        public string imagemURL { get; set; }
    }
}