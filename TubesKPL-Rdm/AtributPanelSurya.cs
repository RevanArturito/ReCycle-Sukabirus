using System;
using System.Reflection.Metadata;

namespace LibraryAtributPanelSurya;

public class AtributPanelSurya
{
    public void ConstPanelSurya()
    {
        PrintIDProduk();
        PrintNamaPanelSurya();
        PrintJenisPanelSurya();
        PrintTersediaUnit();
        PrintHarga();
        PrintPanjang();
        PrintLebar();
        PrintDeskripsi();
    }

    private void PrintIDProduk()
    {
        Console.WriteLine("ID Produk : ");
    }

    private void PrintNamaPanelSurya()
    {
        Console.WriteLine("Nama Panel Surya : ");
    }

    private void PrintJenisPanelSurya()
    {
        Console.WriteLine("Jenis Panel Surya : ");
    }

    private void PrintTersediaUnit()
    {
        Console.WriteLine("Tersedia/Unit : ");
    }

    private void PrintHarga()
    {
        Console.WriteLine("Harga : ");
    }

    public void PrintPanjang()
    {
        Console.WriteLine("Panjang/mm : ");
    }

    private void PrintLebar()
    {
        Console.WriteLine("Lebar/mm : ");
    }

    private void PrintDeskripsi()
    {
        Console.WriteLine("Deskripsi : ");
    }
}
