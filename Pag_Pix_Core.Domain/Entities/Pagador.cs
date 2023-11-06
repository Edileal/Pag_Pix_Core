namespace Pag_Pix_Core.Domain.Entities
{
    public class Pagador
    {
        public Guid Id { get; set; }
        public string cnpj { get; set; }
        public string chavePix { get; set; }
    }
}