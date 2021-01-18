using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon.Models
{
    [Table(nameof(DonViHanhChinh))]
    public class DonViHanhChinh : Common.BaseObject
    {
        private string maDonViHanhChinh;
        private string tenDonViHanhChinh;
        private int capDonVi;
        private DonViHanhChinh capTren;
        public DonViHanhChinh()
        {
        }
        public DonViHanhChinh(string maDonViHanhChinh, string tenDonViHanhChinh, int capDonVi)
        {
            this.maDonViHanhChinh = maDonViHanhChinh;
            this.tenDonViHanhChinh = tenDonViHanhChinh;
            this.capDonVi = capDonVi;
        }
        public DonViHanhChinh(string maDonViHanhChinh, string tenDonViHanhChinh, int capDonVi, DonViHanhChinh capTren) 
            : this(maDonViHanhChinh, tenDonViHanhChinh, capDonVi)
        {
            this.capTren = capTren;
        }
        [Display(Name = "Mã ĐVHC")]
        public string MaDonViHanhChinh { get => maDonViHanhChinh; set => Set(ref maDonViHanhChinh, value); }
        [Display(Name = "Tên ĐVHC")]
        public string TenDonViHanhChinh { get => tenDonViHanhChinh; set => Set(ref tenDonViHanhChinh, value); }
        [Display(Name = "Cấp")]
        public int CapDonVi { get => capDonVi; set => Set(ref capDonVi, value); }
        [Display(Name = "Cấp Trên")]
        public virtual DonViHanhChinh CapTren { get => capTren; set => Set(ref capTren, value); }

        public static string DiaChi(DonViHanhChinh tinh,DonViHanhChinh  huyen, DonViHanhChinh xa,string sonha)
        {
            string diachi = string.Empty; ;
            if (tinh == null) return diachi;
            diachi =sonha+ ", "+ tinh.TenDonViHanhChinh;
            if (huyen == null) return diachi;
            diachi = sonha + ", " + huyen.TenDonViHanhChinh + ", " + tinh.TenDonViHanhChinh;
            if (xa == null) return diachi;
            diachi = sonha + ", " + xa.TenDonViHanhChinh +", "+ huyen.TenDonViHanhChinh + ", " + tinh.TenDonViHanhChinh;
            return diachi;
        }
    }
}
