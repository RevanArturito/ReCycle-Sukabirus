using Library;

class Program
{
    static void Main(string[] args)
    {
        List<string> itemsList = new List<string> { "Profile barang 1", "Profile barang 2", "Profile barang 3", "Profile barang 4 " };

        Console.WriteLine("Daftar item:");
        for (int i = 0; i < itemsList.Count; i++)
        {
            Console.WriteLine((i+1) + ": " + itemsList[i]);
        }

        Console.WriteLine("Masukkan indeks item yang ingin dihapus:");

        // Membaca input dari pengguna
        string input = Console.ReadLine();

        // Konversi input menjadi bilangan bulat
        int index;
        if (int.TryParse(input, out index))
        {
            index = index - 1;
            // Membuat instance dari kelas DeletAsAdmin dengan list itemsList
            DeletAsAdmin<string> deletableList = new DeletAsAdmin<string>(itemsList);

            // Memanggil metode DeleteByIndex untuk menghapus item dari list berdasarkan indeks yang dimasukkan oleh pengguna
            deletableList.DeleteByIndex(index);

            // Tampilkan isi list setelah penghapusan
            Console.WriteLine("Setelah dihapus:");
            Console.WriteLine(string.Join(", ", itemsList));
        }
        else
        {
            Console.WriteLine("Input tidak valid. Harap masukkan bilangan bulat.");
        }
    }
}