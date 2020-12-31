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
        public DonViHanhChinh CapTren { get => capTren; set => Set(ref capTren, value); }
    }
}
