using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
// program ini diberi nama IPK
namespace IPK
{    /// <summary>
    /// membuat class IPK
    /// </summary>
    public class IPK
    {
        /// <summary>
        /// mendeklarasikan variable
        /// </summary>
        /// <param nama="nama">Memasukkan nama </param>
        /// <param kelas="kelas">Memasukkan kelas </param>
        /// <param namaFile="namaFile">Memasukkan namaFile </param>
        /// <param NIM="NIM">Memasukkan NIM </param>
        public void MasukkannilaiIPK()
        {
            //menggunakan variable string berupa nama, kelas dan namaFile
            string nama, kelas, namaFile;
            //menggunakan variable double berupa nim
            double NIM;
            try
            {
                //digunakan untuk menuliskan nama file
                Console.Write("Nama File : ");

                //membaca namaFile dan disimpan didalam variable namaFile
                namaFile = Console.ReadLine();

                //deklarasi string untuk penyimpan path di drive C pada folder my document 
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                //lewatkan folder dan nama file yang digunakan untuk menyimpan data di drive C
                StreamWriter sw = new StreamWriter(Path.Combine(path, $"{namaFile}.txt"));

                Console.WriteLine("----------------------- IPK ---------------------------");
                //untuk memasukkan nim
                Console.Write("Masukkan NIM     : "); NIM = Convert.ToDouble(Console.ReadLine());
                //untuk memasukkan nama
                Console.Write("Masukkan Nama    : "); nama = (Console.ReadLine());
                //untuk memasukkan kelas
                Console.Write("Masukkan Kelas   : "); kelas = (Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------");
                string[,] strArray = new string[6, 3];
                for (int index1 = 0; index1 < 6; ++index1)
                {
                    for (int index2 = 0; index2 < 3; ++index2)
                    {
                        if (index2 == 0)
                        {
                            Console.Write("Masukkan Nama Mata Kuliah : "); strArray[index1, index2] = Console.ReadLine();
                        }
                        else if (index2 == 1)
                        {
                            Console.Write("Masukkan Nilai Angka      : "); strArray[index1, index2] = Console.ReadLine();
                        }
                        else
                        {
                            Console.Write("Masukkan Nilai Huruf      : "); strArray[index1, index2] = Console.ReadLine();
                            Console.WriteLine();
                        }
                    }
                }
                //untuk membaca dari apa yang sudah disimpan : nim, nama dan kelas
                Console.ReadLine();
                Console.ReadLine();
                Console.ReadLine();
                //menampilkan awalan berupa transkip kuliah
                sw.WriteLine("-------------------------------------------------------");
                sw.WriteLine("Transkip Kuliah");
                sw.WriteLine("-------------------------------------------------------");
                sw.WriteLine();
                //menampilkan hasil berupa nim dan nim yang sudah di simpan akan di tampilkan
                sw.WriteLine("NIM :" + NIM);
                //menampilkan hasil berupa nama dan nama yang sudah di simpan akan di tampilkan
                sw.WriteLine("NAMA :" + nama);
                //menampilkan hasil berupa kelas dan kelas yang sudah di simpan akan di tampilkan
                sw.WriteLine("KELAS :" + kelas);
                sw.WriteLine("-------------------------------------------------------");
                sw.WriteLine();

                //menampilkan hasil berupa Transkip mahasiswa dengan nim dan nim yang sudah di simpan akan di tampilkan
                sw.WriteLine("Transkip Mahasiswa dengan NIM :" + NIM);
                //menampilkan hasil dari yang sudah diisi tadi
                sw.WriteLine("-------------------------------------------------------");
                sw.WriteLine("Mata Kuliah          Nilai Angka            Nilai huruf");
                for (int index3 = 0; index3 < 6; ++index3)
                {
                    sw.Write("\n");
                    for (int index4 = 0; index4 < 3; ++index4)
                    {
                        sw.Write("{0}\t", (object)strArray[index3, index4]);
                    }
                }
                Console.Write("\n\n");
                Console.ReadKey();
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }

    public class Kartukeluarga
    {
        /// <summary>
        /// membuat class KartuKeluarga
        /// </summary>
        public void MasukkandataKartukeluarga()
        {
            string namaFile;
            try
            {
                //menuliskan namaFile
                Console.Write("Nama File : ");
                //membaca namaFile yang sudah disimpan
                namaFile = Console.ReadLine();

                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                StreamWriter sw = new StreamWriter(Path.Combine(path, $"{namaFile}.txt"));

                Console.WriteLine("----------------- Kartu Keluarga ----------------------");
                Console.WriteLine("-------------------------------------------------------");
                Console.Write("Masukkan Jumlah Anggota Keluarga     : ");
                string[][] strArray = new string[Convert.ToInt32(Console.ReadLine())][];
                int length = 3;
                for (int index1 = 0; index1 < strArray.Length; ++index1)
                {
                    strArray[index1] = new string[length];
                    for (int index2 = 0; index2 < strArray[index1].Length; ++index2)
                    {
                        switch (index2)
                        {
                            case 0:
                                Console.Write("Masukkan Nama Lengkap                : "); strArray[index1][index2] = Console.ReadLine();
                                break;
                            case 1:
                                Console.Write("Masukkan Pendidikan Terakhir         : "); strArray[index1][index2] = Console.ReadLine();
                                break;
                            case 2:
                                Console.Write("Masukkan Status                      : "); strArray[index1][index2] = Console.ReadLine();
                                Console.WriteLine("-------------------------------------------------------");
                                break;
                        }
                    }
                }

                sw.WriteLine("Daftar Kartu Keluarga");
                sw.WriteLine("-----------------------------------------------------------------------");
                sw.WriteLine("Nama Lengkap             Pendidikan Terakhir             Status");
                sw.WriteLine();
                for (int index3 = 0; index3 < strArray.Length; ++index3)
                {
                    for (int index4 = 0; index4 < strArray[index3].Length; ++index4)
                        sw.Write(strArray[index3][index4] + "\t\t         ");
                    sw.WriteLine();
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IPK ipk = new IPK();
            Kartukeluarga kartukeluargaa = new Kartukeluarga();

            double pilih;
            //menu utama akan menampilkan pilihan antara ipk dan kartu keluarga
            Console.WriteLine("---------------Menu Utama-------------");
            Console.WriteLine("1. IPK");
            Console.WriteLine("2. Kartu Keluarga");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Silakan pilih Menu : (1/2)");
            pilih = Convert.ToDouble(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    Console.Clear();
                    ipk.MasukkannilaiIPK();
                    break;
                case 2:
                    Console.Clear();
                    kartukeluargaa.MasukkandataKartukeluarga();
                    break;
                default:
                    Console.WriteLine("Pilihan Salah");
                    Console.ReadKey();
                    break;
            }
        }


    }
}
