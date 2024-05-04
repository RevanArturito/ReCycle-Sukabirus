namespace Library
{
    public class DeletAsAdmin<T>
    {
        private List<T> items;

        public DeletAsAdmin(List<T> items ) 
        {
            this.items = items;
        }

        public void DeleteByIndex(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                T deletedItem = items[index];
                items.RemoveAt(index);
                Console.WriteLine($"({deletedItem}) telah dihapus.");
            }
            else
            {
                Console.WriteLine("Indeks tidak valid.");
            } 
        }
    }
}
