namespace Service
{
    public interface IDatabaseConnection
    {

        void Delete(object obj);

        T Get<T>(int id);
        T[] Get<T>();

        void Save(object obj);

        void Update(object obj);

    }
}