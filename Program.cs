using System;

class SanPham
{
    public string MaSP { get; set; }
    public string TenSP { get; set; }
    public double Gia { get; set; }

    public SanPham()
    {
        MaSP = "";
        TenSP = "";
        Gia = 0;
    }

    public SanPham(string maSP, string tenSP, double gia)
    {
        MaSP = maSP;
        TenSP = tenSP;
        Gia = gia;
    }

    public double TinhThueVAT()
    {
        return Gia * 0.1;
    }

    public void Nhap()
    {
        Console.Write("Nhap ma san pham: ");
        MaSP = Console.ReadLine();

        Console.Write("Nhap ten san pham: ");
        TenSP = Console.ReadLine();

        Console.Write("Nhap gia san pham: ");
        Gia = double.Parse(Console.ReadLine());
    }

    public void Xuat()
    {
        Console.WriteLine("Ma SP: {0} | Ten SP: {1} | Gia: {2} | Thue VAT (10%): {3}",
            MaSP, TenSP, Gia, TinhThueVAT());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== BAI TAP 3.3: LOP SAN PHAM ===");

        Console.WriteLine("\n--- Nhap thong tin san pham thu 1 ---");
        SanPham sp1 = new SanPham();
        sp1.Nhap();

        SanPham sp2 = new SanPham("SP02", "Ban phim co", 750000);

        Console.WriteLine("\n--- DANH SACH SAN PHAM ---");
        Console.Write("San pham 1: ");
        sp1.Xuat();

        Console.Write("San pham 2: ");
        sp2.Xuat();

        Console.ReadKey();
    }
}