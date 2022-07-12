using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi2
{
    class Program
    {
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
           

                Console.Title = "Responsi UAS Matakuliah Pemrograman";

                while (true)
                {
                    TampilMenu();

                    Console.Write("\nNomor Menu [1..3]: ");
                    int nomorMenu = Convert.ToInt32(Console.ReadLine());

                    switch (nomorMenu)
                    {
                        case 1:
                            TambahPenjualan();
                            break;

                        case 2:
                            TampilPenjualan();
                            break;

                        case 3: // keluar dari program
                            return;

                        default:
                            break;
                    }
                }
            }

            static void TampilMenu()
        {
                Console.Clear();

                Console.WriteLine("Pilih Menu Aplikasi");
                Console.WriteLine();
                Console.WriteLine("1. Tambah Penjualan");
                Console.WriteLine("2. Tampilkan Penjualan");
                Console.WriteLine("3. Keluar");

                // PERINTAH: lengkapi kode untuk menampilkan menu
            }

            static void TambahPenjualan()
        {
                Console.Clear();

                int kodeID;
                string tanggal, nama, kategori1;
                string kategori2 = "error";
                double total;

                Console.WriteLine("Tambah Data Penjualan");
                Console.WriteLine("");
                Console.Write("Nota       : ");
                kodeID = int.Parse(Console.ReadLine());

                Console.Write("Tanggal    : ");
                tanggal = Console.ReadLine();

                Console.Write("Customer    : ");
                nama = Console.ReadLine();

                Console.Write("Jenis [T/K]: ");
                kategori1 = Console.ReadLine();

                Console.Write("Total Nota : ");
                total = int.Parse(Console.ReadLine());

                if (kategori1 == "Tunai" || kategori1 == "T")
                {
                    kategori2 = "Tunai";
                }
                if (kategori1 == "K" || kategori1 == "k")
                {
                    kategori2 = "kredit";
                }
                daftarPenjualan.Add(new Penjualan() { Code = kodeID, Tanggal = tanggal, Nama = nama, Jenis = kategori2, Total = total });

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

                Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
                Console.ReadKey();
            }

            static void TampilPenjualan()
        {
                Console.Clear();
                Console.WriteLine("Data Penjualan");
                Console.WriteLine("");
                int no = 1;
                foreach (Penjualan daftar in daftarPenjualan)
                {
                    Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}",
                    no, daftar.Code, daftar.Tanggal, daftar.Nama, daftar.Jenis, daftar.Total);
                    no++;
                }
            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
                Console.ReadKey();
            }
        }
    }

