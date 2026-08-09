using _3AUG.Model;

namespace _3AUG.Repository
{
    public interface IBatchService
    {
        List<Batch> GetAll();

        Batch? GetBatch(int id);

        void AddBatch(Batch batch);

        void UpdateBatch(Batch batch);

        void DeleteBatch(int id);
    }
}
