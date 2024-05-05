using System.Diagnostics;

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
            Debug.Assert(index <= items.Count, "Pilihan tidak seusai");

            if (index >= 0 && index < items.Count)
            {
                    
                T deletedItem = items[index];
                items.RemoveAt(index);
                Console.WriteLine(" ");
                Console.WriteLine($"({deletedItem}) telah dihapus.");
                Console.WriteLine(" ");

            }
            else
            {
                Console.WriteLine("Indeks tidak valid.");
            } 
        }
    }
}
