namespace CinemAPI.Data
{
    public interface IRepository<T>
    {
        void Insert(T item);
    }
}