namespace EIMS.UseCases.Interfaces
{
    public interface IDeleteProductUseCase
    {
        Task ExecuteAsync(int productId);
    }
}