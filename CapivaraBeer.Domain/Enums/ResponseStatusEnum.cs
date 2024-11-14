using System.ComponentModel;

namespace CapivaraBeer.Domain.Enums
{
    public enum ResponseStatusEnum
    {
        [Description("Recurso criado com sucesso.")]
        Created,

        [Description("Recurso atualizado com sucesso.")]
        Updated,

        [Description("Recurso deletado com sucesso.")]
        Deleted,

        [Description("Operação realizada com sucesso.")]
        OperationSucceeded,

        [Description("Usuário autorizado com sucesso.")]
        UserAuthorized,

        [Description("Recurso validado com sucesso.")]
        DataValidated,

        [Description("Recurso não encontrado.")]
        NotFound,

        [Description("Os dados fornecidos são inválidos.")]
        InvalidData,

        [Description("Usuário não autorizado.")]
        Unauthorized,

        [Description("Erro interno do servidor.")]
        InternalServerError,

        [Description("Ocorreu um erro inesperado. Por favor, tente novamente mais tarde.")]
        ServerError,

        [Description("A validação falhou para uma ou mais propriedades.")]
        ValidationFailed,

        [Description("A operação não pôde ser concluída.")]
        OperationFailed,

        [Description("O Id de usuário fornecido é inválido.")]
        InvalidUserId,

        [Description("O formato de entrada é inválido.")]
        InvalidInputFormat
    }
}
