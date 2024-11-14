using CapivaraBeer.Domain.Enums;

namespace CapivaraBeer.Domain.Entities
{
    public class Usuarios : Base
    {
        public required string NomeUsuario { get; set; }
        public required string EmailUsuario { get; set; }
        public required string SenhaUsuario { get; set; }
        public required string PerfilUsuario { get; set; }
        public required string TelefoneUsuario { get; set; }
        public required string CelularUsuario { get; set; }
        public required string EnderecoUsuario { get; set; }
        public required string CidadeUsuario { get; set; }
        public required EstadoEnum EstadoUsuario { get; set; }
        public required string CepUsuario { get; set; }
        public required string CpfUsuario { get; set; }
        public required string RgUsuario { get; set; }
        public required SexoUsuarioEnum SexoUsuario { get; set; }
        public required string FotoUsuario { get; set; }
        public required DateTime DataNascimentoUsuario { get; set; }
        public required DateTime DataCadastroUsuario { get; set; }
        public required DateTime DataAlteracaoUsuario { get; set; }
        public required UsuarioEnum TipoUsuario { get; set; }
        public required StatusUsuarioEnum StatusUsuario{ get; set; }

        public Usuarios(){}

        public Usuarios(string nomeUsuario, string emailUsuario, string senhaUsuario, string perfilUsuario, string telefoneUsuario,
            string celularUsuario, string enderecoUsuario, string cidadeUsuario, EstadoEnum estadoUsuario, string cepUsuario,
            string cpfUsuario, string rgUsuario, SexoUsuarioEnum sexoUsuario, string fotoUsuario, DateTime dataNascimentoUsuario, 
            DateTime dataCadastroUsuario, DateTime dataAlteracaoUsuario, UsuarioEnum tipoUsuario, StatusUsuarioEnum statusUsuario)
        {
            NomeUsuario = nomeUsuario;
            EmailUsuario = emailUsuario;
            SenhaUsuario = senhaUsuario;
            PerfilUsuario = perfilUsuario;
            TelefoneUsuario = telefoneUsuario;
            CelularUsuario = celularUsuario;
            EnderecoUsuario = enderecoUsuario;
            CidadeUsuario = cidadeUsuario;
            EstadoUsuario = estadoUsuario;
            CepUsuario = cepUsuario;
            CpfUsuario = cpfUsuario;
            RgUsuario = rgUsuario;
            SexoUsuario = sexoUsuario;
            FotoUsuario = fotoUsuario;
            DataNascimentoUsuario = dataNascimentoUsuario;
            DataCadastroUsuario = dataCadastroUsuario;
            DataAlteracaoUsuario = dataAlteracaoUsuario;
            TipoUsuario = tipoUsuario;
            StatusUsuario = statusUsuario;
        }
    }
}
