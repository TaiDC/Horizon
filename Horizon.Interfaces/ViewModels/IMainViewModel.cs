using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon.Interfaces.ViewModels
{
    public interface IMainViewModel
    {
        void Load();
        void BC_001_NhapXuatTon(DateTime tungay, DateTime denngay);
        void BC_002_TheKho(DateTime tungay, DateTime denngay);
    }
}
