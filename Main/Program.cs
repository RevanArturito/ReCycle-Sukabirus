using System.Diagnostics;
using System.Runtime.CompilerServices;

internal class Program
{
    public static void Main(string[] args)
    {
        string name = JenisBarang.SIX_MONOCRYSTALLINE_SOLAR_PANEL.ToString();
        Console.WriteLine("Jenis Panel Surya: " + name);
        int harga_barang = (int)Harga_Barang.SIX_MONOCRYSTALLINE_SOLAR_PANEL;
        Console.WriteLine("Harga Panel Surya: " + harga_barang);


        Payment Pembayaran = new Payment();
        Console.WriteLine("Status saat ini: " + Pembayaran.CurrentState);
        Pembayaran.ActiveTrigger(Trigger.TombolSelectPayment);

        Console.WriteLine("1. " + SelectPaymetMethod.MBanking);
        Console.WriteLine("2. " + SelectPaymetMethod.CreditCard);
        Console.WriteLine("3. " + SelectPaymetMethod.EWallet);
        Console.WriteLine("");
        Console.Write("Pilih Menggunakan Angka Yang Tersedia ");

        state state = state.Memilih_Payment;

        string command = Console.ReadLine();

        Console.WriteLine("");

        Debug.Assert(command == "1" || command == "2" || command == "3" && !string.IsNullOrEmpty(command), "Anda Harus Memilih Payment Yang Tersedia");

        switch (state)
        {
            case state.Memilih_Payment:
                if (command == "1")
                {
                    state = state.Memilih_Payment;
                    Console.WriteLine("1. " + MBanking.BCA);
                    Console.WriteLine("2. " + MBanking.Mandiri);
                    Console.WriteLine("3. " + MBanking.CIMB);
                    Console.WriteLine("4. " + MBanking.BSI);
                    Console.WriteLine("5. " + MBanking.BNI);
                    Console.WriteLine("");
                    Console.Write("Masukan Nama MBanking  ");

                    command = Console.ReadLine();
                    Debug.Assert(command == "BCA" || command == "Mandiri" || command == "CIMB" || command == "BSI" || command == "BNI", "Nama MBanking Tidak Tersedia");
                    if (command == "BCA")
                    {
                        Console.WriteLine("");
                        Pembayaran.ActiveTrigger(Trigger.Tombol_nominal);
                        Console.Write("Rp ");
                        int nominal = int.Parse(Console.ReadLine());
                        Debug.Assert(nominal != 0, "Nominal Tidak Boleh 0");

                        if (nominal == (int)harga_barang)
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Sesuai);
                        }
                        else
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Tidak_Sesuai);
                        }
                    }
                    else if (command == "Mandiri")
                    {
                        Console.WriteLine("");
                        Pembayaran.ActiveTrigger(Trigger.Tombol_nominal);
                        Console.Write("Rp ");
                        int nominal = int.Parse(Console.ReadLine());
                        Debug.Assert(nominal != 0, "Nominal Tidak Boleh 0");

                        if (nominal == (int)harga_barang)
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Sesuai);
                        }
                        else
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Tidak_Sesuai);
                        }
                    }
                    else if (command == "CIMB")
                    {
                        Console.WriteLine("");
                        Pembayaran.ActiveTrigger(Trigger.Tombol_nominal);
                        Console.Write("Rp ");
                        int nominal = int.Parse(Console.ReadLine());
                        Debug.Assert(nominal != 0, "Nominal Tidak Boleh 0");

                        if (nominal == (int)harga_barang)
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Sesuai);
                        }
                        else
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Tidak_Sesuai);
                        }
                    }
                    else if (command == "BSI")
                    {
                        Console.WriteLine("");
                        Pembayaran.ActiveTrigger(Trigger.Tombol_nominal);
                        Console.Write("Rp ");
                        int nominal = int.Parse(Console.ReadLine());
                        Debug.Assert(nominal != 0, "Nominal Tidak Boleh 0");

                        if (nominal == (int)harga_barang)
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Sesuai);
                        }
                        else
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Tidak_Sesuai);
                        }
                    }
                    else if (command == "BNI")
                    {
                        Console.WriteLine("");
                        Pembayaran.ActiveTrigger(Trigger.Tombol_nominal);
                        Console.Write("Rp ");
                        int nominal = int.Parse(Console.ReadLine());
                        Debug.Assert(nominal != 0, "Nominal Tidak Boleh 0");

                        if (nominal == (int)harga_barang)
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Sesuai);
                        }
                        else
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Tidak_Sesuai);
                        }
                    }
                }
                else if (command == "2")
                {
                    state = state.Memilih_Payment;
                    Console.WriteLine("1. " + CreditCard.MasterCard);
                    Console.WriteLine("2. " + CreditCard.Visa);
                    Console.WriteLine("3. " + CreditCard.AMEX);
                    Console.WriteLine("4. " + CreditCard.JBC);
                    Console.WriteLine("");
                    Console.Write("Masukan Nama Credit Card ");

                    command = Console.ReadLine();
                    Debug.Assert(command == "MasterCard" || command == "Visa" || command == "AMEX" || command == "JBC", "Nama Credit Card Tidak Tersedia");
                    if (command == "MasterCard")
                    {
                        Console.WriteLine("");
                        Pembayaran.ActiveTrigger(Trigger.Tombol_nominal);
                        Console.Write("Rp ");
                        int nominal = int.Parse(Console.ReadLine());
                        Debug.Assert(nominal != 0, "Nominal Tidak Boleh 0");

                        if (nominal == (int)harga_barang)
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Sesuai);
                        }
                        else
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Tidak_Sesuai);
                        }
                    }
                    else if (command == "Visa")
                    {
                        Console.WriteLine("");
                        Pembayaran.ActiveTrigger(Trigger.Tombol_nominal);
                        Console.Write("Rp ");
                        int nominal = int.Parse(Console.ReadLine());
                        Debug.Assert(nominal != 0, "Nominal Tidak Boleh 0");

                        if (nominal == (int)harga_barang)
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Sesuai);
                        }
                        else
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Tidak_Sesuai);
                        }
                    }
                    else if (command == "AMEX")
                    {
                        Console.WriteLine("");
                        Pembayaran.ActiveTrigger(Trigger.Tombol_nominal);
                        Console.Write("Rp ");
                        int nominal = int.Parse(Console.ReadLine());
                        Debug.Assert(nominal != 0, "Nominal Tidak Boleh 0");

                        if (nominal == (int)harga_barang)
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Sesuai);
                        }
                        else
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Tidak_Sesuai);
                        }
                    }
                    else if (command == "JBC")
                    {
                        Console.WriteLine("");
                        Pembayaran.ActiveTrigger(Trigger.Tombol_nominal);
                        Console.Write("Rp ");
                        int nominal = int.Parse(Console.ReadLine());
                        Debug.Assert(nominal != 0, "Nominal Tidak Boleh 0");

                        if (nominal == (int)harga_barang)
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Sesuai);
                        }
                        else
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Tidak_Sesuai);
                        }
                    }
                }
                else if (command == "3")
                {
                    state = state.Memilih_Payment;
                    Console.WriteLine("1. " + EWallet.OVO);
                    Console.WriteLine("2. " + EWallet.Dana);
                    Console.WriteLine("3. " + EWallet.GoPay);
                    Console.WriteLine("");
                    Console.Write("Masukan Nama EWallet ");

                    command = Console.ReadLine();
                    Debug.Assert(command == "OVO" || command == "DANA" || command == "GoPay", "Nama EWallet Tidak Tersedia");
                    if (command == "OVO")
                    {
                        Console.WriteLine("");
                        Pembayaran.ActiveTrigger(Trigger.Tombol_nominal);
                        Console.Write("Rp ");
                        int nominal = int.Parse(Console.ReadLine());
                        Debug.Assert(nominal != 0, "Nominal Tidak Boleh 0");

                        if (nominal == (int)harga_barang)
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Sesuai);
                        }
                        else
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Tidak_Sesuai);
                        }
                    }
                    else if (command == "Dana")
                    {
                        Console.WriteLine("");
                        Pembayaran.ActiveTrigger(Trigger.Tombol_nominal);
                        Console.Write("Rp ");
                        int nominal = int.Parse(Console.ReadLine());
                        Debug.Assert(nominal != 0, "Nominal Tidak Boleh 0");

                        if (nominal == (int)harga_barang)
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Sesuai);
                        }
                        else
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Tidak_Sesuai);
                        }
                    }
                    else if (command == "GoPay")
                    {
                        Console.WriteLine("");
                        Pembayaran.ActiveTrigger(Trigger.Tombol_nominal);
                        Console.Write("Rp ");
                        int nominal = int.Parse(Console.ReadLine());
                        Debug.Assert(nominal != 0, "Nominal Tidak Boleh 0");

                        if (nominal == (int)harga_barang)
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Sesuai);
                        }
                        else
                        {
                            Pembayaran.ActiveTrigger(Trigger.Harga_Tidak_Sesuai);
                        }
                    }
                }
                break;
        }
    }
}