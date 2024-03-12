namespace Katharsis.Bots.Voice.Repositories.Interfaces
{
    public interface ICRUD<T>
    {
        public int Create(T entity);
        public void Read(int entityId);
        public T Update(T entity);
        public void Delete(T entity);
    }
}
