using DevExpress.XtraBars.Alerter;
using System.Windows.Forms;

namespace Horizon.AppHelper
{
    public static class MessageCustom
    {
        public static void ShowNotify(string text, string title)
        {
            using (AlertControl alertControl1 = new AlertControl())
            {
                using (Form frm = new Form())
                {
                    alertControl1.AutoFormDelay = 1000;
                    alertControl1.Show(frm, title, text);
                }

            }
        }
        public static void ShowNotify(Status status)
        {
            using (AlertControl alertControl1 = new AlertControl())
            {
                using (Form frm = new Form())
                {
                    alertControl1.AutoFormDelay = 1000;
                    switch(status)
                    {
                        case Status.SaveComplete:
                            alertControl1.Show(frm, "COMPLETE", "Lưu dữ liệu thành công!");
                            break;
                        case Status.SaveError:
                            alertControl1.Show(frm, "ERROR", "Lưu dữ liệu không thành công!");
                            break;
                        case Status.DeleteComplete:
                            alertControl1.Show(frm, "COMPLETE", "Xóa dữ liệu thành công!");
                            break;
                        case Status.DeleteError:
                            alertControl1.Show(frm, "ERROR", "Xóa dữ liệu không thành công!");
                            break;
                    }
                }
            }
        }
    }
    public enum Status
    {
        SaveComplete,
        SaveError,
        DeleteComplete,
        DeleteError
    }
}
