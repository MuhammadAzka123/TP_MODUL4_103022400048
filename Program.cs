using System;
using TP_MODUL4_103022400048;

class Program
{
    static void Main(string[] args)
    {
        //kodepos
        KodePos kode = new KodePos();

        Console.Write("Masukkan kelurahan: ");
        string kel = Console.ReadLine();

        int hasil = kode.getKodePos(kel);

        if (hasil != -1)
        {
            Console.WriteLine("Kode Pos : " + hasil);
        }
        else
        {
            Console.WriteLine("Kelurahan tidak ditemukan");
        }
        Console.WriteLine("");

        //doormachine
        DoorMachine pintu = new DoorMachine();

        pintu.BukaPintu();
        pintu.KunciPintu();
    }
}
