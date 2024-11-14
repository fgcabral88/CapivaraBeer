namespace CapivaraBeer.Shared.Constants
{
    public class ResponseMessages<Entity>
    {
        public const string Created = "Recurso criado com sucesso.";
        public const string Updated = "Recurso atualizado com sucesso.";
        public const string Deleted = "Recurso excluído com sucesso.";
        public const string OperationSucceeded = "A operação foi concluída com sucesso.";
        public const string UserAuthorized = "O usuário está autorizado.";
        public const string DataValidated = "Os dados foram validados com sucesso.";

        public const string NotFound = "Recurso não encontrado.";
        public const string InvalidData = "Os dados fornecidos são inválidos.";
        public const string Unauthorized = "O usuário não está autorizado a realizar esta ação.";
        public const string ServerError = "Ocorreu um erro inesperado. Por favor, tente novamente mais tarde.";
        public const string ValidationFailed = "A validação falhou para uma ou mais propriedades.";
        public const string OperationFailed = "A operação não pôde ser concluída.";
        public const string InvalidUserId = "O ID de usuário fornecido é inválido.";
        public const string InvalidInputFormat = "O formato de entrada é inválido.";
    }
}
 