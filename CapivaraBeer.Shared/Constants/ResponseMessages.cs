namespace CapivaraBeer.Shared.Constants
{
    public class ResponseMessages<Entity>
    {
        public Entity Dados { get; set; }
        public string Mensagem { get; set; }
        public bool Sucesso { get; set; }

        public ResponseMessages() { }

        public ResponseMessages(Entity dados, string mensagem, bool sucesso)
        {
            Dados = dados;
            Mensagem = mensagem;
            Sucesso = sucesso;
        }
    }
}
 