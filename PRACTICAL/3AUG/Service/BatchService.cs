using _3AUG.Model;
using _3AUG.Repository;

namespace _3AUG.Service
{
    public class BatchService : IBatchService
    {
        private static List<Batch> batches = new List<Batch>()
        {
            new Batch{ Id = 1,Name = "Batch A",Course = ".NET",StartDate = "01-09-2026",Capacity = 30 },
            new Batch{ Id = 2,Name = "Batch A",Course = "Java",StartDate = "01-09-2026",Capacity = 40},
            new Batch{ Id = 3,Name = "Batch A",Course = "python",StartDate = "09-09-2026",Capacity = 35 },

        };
        public void AddBatch(Batch batch)
        {
           batches.Add(batch);
        }

        public void DeleteBatch(int id)
        {
            var existing = GetBatch(id);

            if (existing == null)
                throw new Exception("Course not found");

            batches.Remove(existing);
        }

        public List<Batch> GetAll()
        {
           return batches;
        }

        public Batch? GetBatch(int id)
        {
            return batches.FirstOrDefault(s => s.Id == id);
        }

        public void UpdateBatch(Batch batch)
        {
            var existing = GetBatch(batch.Id);

            if (existing == null)
                throw new Exception("Student not found");

            existing.Capacity = batch.Capacity;
        }
    }
}
