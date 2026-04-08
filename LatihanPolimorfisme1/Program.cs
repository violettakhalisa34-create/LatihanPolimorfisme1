using System.ComponentModel.Design;
ImageProcessor imageProcessor = new ImageProcessor();

imageProcessor.Resize(-20);
imageProcessor.Resize(80);
imageProcessor.Resize(150);
imageProcessor.Resize(100);

class ImageProcessor
{
    public void Resize(int persentase)
    {
        if(persentase <= 0)
        {
            Console.WriteLine("Eror! persentase tidak boleh nol(0) atau negatif");
        }
        else if (persentase < 100)
        {
            Console.WriteLine($"Mengecilkan gambar menjadi {persentase}%");
        }
        else if (persentase > 100)
        {
            Console.WriteLine($"Memperbesar gambar menjadi {persentase}%");
        }
        else
        {
            Console.WriteLine("ukuran tetap (100%). tidak ada perubahan");
        }
    }
    public void Resize(int lebar, int tinggi)
    {
        Console.WriteLine($"Mengubah ukuran gambar menjadi {lebar}px X {tinggi}px");
    }
    public void Resize(string ukuran_kertas)
    {
        Console.WriteLine($"Menyesuaikan ke format kertas {ukuran_kertas}");
    }
}