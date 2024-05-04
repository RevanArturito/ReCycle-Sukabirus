using System;
using System.ComponentModel.Design;
using System.Diagnostics;

// deklarasi enumerasi bernama state
// berfungsi untuk memilih opsi status pembayaran
public enum state
{
    Memilih_Payment,
    Pembayaran_Berhasil,
    Belum_Terbayar,
    Pembayaran_Gagal,
    Masukan_nominal,
}

public enum SelectPaymetMethod
{
    CreditCard,
    MBanking,
    EWallet
}
public enum CreditCard
{
    Visa,
    MasterCard,
    AMEX,
    JBC
}
public enum MBanking
{
    Mandiri,
    BCA,
    BNI,
    BSI,
    CIMB,

}
public enum EWallet
{
    GoPay,
    Dana,
    OVO
}

// deklarasi enumerasi bernama Trigger
// berfungsi untuk memilih opsi aksi pembayaran atau pemicu untuk melakukan pembayaran
public enum Trigger
{
    Tombol_nominal,
    TombolSelectPayment,
    Harga_Sesuai,
    Harga_Tidak_Sesuai
}

// deklarasi class bernama Payment
public class Payment
{
    // deklarasi variabel bernama tomboltrigger bertipedata variavel dengan modifier private dengan value false
    private bool tomboltrigger = false;
    
    // deklarasi class bernama Transition (transisi) dengan modifier public
    public class Transition
    {
        // deklarasi variabel StateAwal bertipedata state
        public state StateAwal;

        // deklarasi varia StateAkhir bertipedata state
        public state StateAkhir;

        // deklarasi variabel Trigger bertipedata Trigger
        public Trigger Trigger;

        // deklarasi constructor bernamakan Transition (transisi) 
        public Transition(state stateAwal, state stateAkhir, Trigger trigger)
        {
            this.StateAwal = stateAwal;
            this.StateAkhir = stateAkhir;
            this.Trigger = trigger;
        }

    }

    // deklarasi array object / state bernamakan transisi untuk memetakan aktivitas transaksi atau pembayaran
    Transition[] transisi =
    {
            new Transition(state.Belum_Terbayar, state.Memilih_Payment, Trigger.TombolSelectPayment),
            new Transition(state.Memilih_Payment, state.Masukan_nominal, Trigger.Tombol_nominal),
            new Transition(state.Masukan_nominal, state.Pembayaran_Berhasil, Trigger.Harga_Sesuai),
            new Transition(state.Masukan_nominal, state.Pembayaran_Gagal, Trigger.Harga_Tidak_Sesuai),
        };

    // deklarasi atribut yang menyimpan state atau kondisi saat ini
    public state CurrentState = state.Belum_Terbayar;

    // deklarasi method atau fungsi bernamakan GetNextState dengan tipe data state 
    // method ini berfungsi untuk mencari atau mengubah ke kondisi/state berikutnya
    public state GetNextState(state stateAwal, Trigger trigger)
    {
        state stateAkhir = stateAwal;
        for (int i = 0; i < transisi.Length; i++)
        {
            Transition perubahan = transisi[i];
            if (stateAwal == perubahan.StateAwal && trigger == perubahan.Trigger)
            {
                stateAkhir = perubahan.StateAkhir;
            }
        }
        return stateAkhir;
    }

    // 
    public void ActiveTrigger(Trigger trigger)
    {
        CurrentState = GetNextState(CurrentState, trigger);
        Console.WriteLine("Status Saat ini: " + CurrentState);

    }

}