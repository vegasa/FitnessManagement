using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessManagement.Utilitys
{
    static class AccMessageUtility
    {
        public static string APP_ERROR = "Có lỗi trong quá trình xử lý. Vui lòng thực hiện lại tác vụ hoặc thông báo cho người quản trị.";
        public static string APP_LOGIN_FAILED = "Thông tin đăng nhập không hợp lệ. Vui lòng kiểm tra lại";
        public static string APP_LOGIN_EMPTY_REQUIRE = "Vui lòng nhập tên đăng nhập hoặc mật khẩu để thực hiện đăng nhập.";
        public static string APP_LOGIN_ACCOUNT_LOCKED = "Tài khoản Bạn đang tạm khóa. Vui lòng liên hệ người quản trị.";
        public static string APP_LOGOUT_CONFIRM = "Bạn có chắc muốn thoát khỏi phiên làm việc hiện tại? Hãy đảm bảo Bạn đã lưu các dữ liệu đang làm việc.";
        public static string APP_FUNCTION_SUCESS = "Đăng nhập thành công.";
        public static string INVOICE_INPUTDATA_ERROR = "Dữ liệu nhập không hợp lệ.";
        public static string APP_ORDERENTRY_REQUIRE = "Không có hóa đơn chưa thanh toán được chọn.";
        public static string APP_ORDER_REQUIRE = "Phiếu nhập không có hóa đơn.";
        public static string APP_SERVICE_CONNECTION = "Không thể kết nối với máy chủ. Vui lòng kiểm tra đường truyền.";

        public static string APP_OBJECT_EXIST = "{0} đã tồn tại.";
        public static string APP_OBJECT_INVALID = "{0} không hợp lệ.";
        public static string APP_OBJECT_EXIST_IN = "{0} đã tồn tại trong {1}.";
        public static string APP_OBJECT_EXIST_ON = "Tồn tại {0} trong {1}.";
        public static string APP_OBJECT_SUCCESS = "{0} thành công.";
        public static string APP_OBJECT_ERROR = "{0} thất bại.";
        public static string APP_TEXTBOX_EMPTY_REQUIRE = "Bạn chưa nhập thông tin {0}.";
        public static string APP_LOOKUPEDIT_EMPTY_REQUIRE = "Bạn chưa chọn thông tin {0}.";
        public static string APP_CHECKDELETE = "Bạn có chắc chắn muốn xoá {0}";
    }
}
