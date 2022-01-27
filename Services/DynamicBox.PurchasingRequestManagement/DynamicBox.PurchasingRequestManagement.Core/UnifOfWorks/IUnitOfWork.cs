namespace DynamicBox.PurchasingManagement.Core.UnifOfWorks
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();
    }
}
