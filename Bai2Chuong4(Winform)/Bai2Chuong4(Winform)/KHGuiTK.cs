namespace Bai2Chuong4_Winform_
{
    internal class KHGuiTK
    {
        string ma, ten, diaChi, ngayGui;
        int thoiGG;
        long soTG;
        bool loai;

        public KHGuiTK(string ma, string ten, string diaChi, string ngayGui, int thoiGG, long soTG, bool loai)
        {
            this.ma = ma;
            this.ten = ten;
            this.diaChi = diaChi;
            this.ngayGui = ngayGui;
            this.thoiGG = thoiGG;
            this.soTG = soTG;
            this.loai = loai;
        }
        public double tinhLai()
        {
            long TG = soTG;
            int TGG = thoiGG;
            bool loai = this.loai;
            double lai, tyle = 0;
            if (loai == false)
            {
                if (TGG == 1)
                {
                    tyle = 0.06;
                }
                else
                    if (TGG == 3)
                    {
                        tyle = 0.07;
                    }
                    else if (TGG == 6)
                    {
                        tyle = 0.08;
                    }
                    else
                    {
                        tyle = 0.09;
                    }
            }
            if (loai == true)
            {
                tyle += 0.01;
            }
            lai = (TG * tyle) / 12;
            return lai;
        }
        public string toString()
        {
            string loaigui = "";
            if (loai == false) loaigui = " loai thuong";
            else loaigui = " phat loc";
            return ma + " | " + ten + " | " + diaChi + " | " + ngayGui + " | " + thoiGG.ToString() + " thang|" + soTG.ToString() + " | " + loaigui + " | " + tinhLai();

        }
    }
}
