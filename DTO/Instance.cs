using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public static class Instance
    {
        //thêm 
        public static string TBThemThanhCong = "Thêm thành công";

        public static string TBThemThatBai = "Thêm thất bại";

        //sửa
        public static string TBSuaThanhCong = "Sửa thành công";

        public static string TBSuaThatBai = "Sửa thất bại";

        //xóa
        public static string TBXoaThanhCong = "Xóa thành công";

        public static string TBXoaThatBai = "Xóa thất bại";

        //tìm kiếm
        public static string TBKhongTimThay = "Không tìm thấy";

        //nhập liệu
        public static string TBNhapThieuTT = "Bạn chưa nhập đầy đủ thông tin";

        //tồn tại tên dn
        public static string TBTTTenDN = "Tên đăng nhập này đã tồn tại. Hãy nhập tên khác!";

        //lỗi
        public static string Loi = "Lỗi";

        //cảnh báo
        public static string CanhBao = "Cảnh báo";

        //thông báo 
        public static string ThongBao = "Thông báo";

        //thành công 
        public static string ThanhCong = "Thành công";

        //thất bại
        public static string ThatBai = "Thất bại";

        //xác nhận
        public static string XacNhan = "Xác nhận";

        //hỏi xác nhận thanh toán
        public static string HoiXacNhanThanhToan = "Bạn có chắc muốn thanh toán";

        //thanh toán
        public static string TBThanhToanThanhCong = "Thanh toán thành công";

        public static string TBDaHuyThanhToan = "Đã hủy thanh toán";

        //bàn có người
        public static string TBBanCoNguoi = " Bàn Đã Có Người. Bàn Muốn Sự Lựa Chọn Khác Không ?";

        //xác nhận chuyển bàn
        public static string XacNhanChuyenBan = "Bạn có chắc muốn chuyển bàn";

        //hỏi xác nhận đã chọn thêm món vào bàn quen biết
        public static string HoiXacNhanThemMonVaoBanQuenBiet = " Thêm Các Món Vào Bàn Đã Chọn (Quen Biết) ?";

        //thông báo chưa thêm hàng hóa vào đơn hàng
        public static string TBChuaThemHHVaoDDH = "Bạn chưa thêm hàng hóa vào đơn đặt hàng!";

        //thông báo hh đã tồn tại
        public static string TBHHDaTonTai = "Hàng hóa này đã được thêm trước đó !";

        //đặt hàng 
        public static string TBDatHangThanhCong = "Đặt hàng thành công!";

        public static string TBDatHangThatBai = "Đặt hàng thất bại!";

        //giá
        public static string TBChuaNhapGia = "Bạn chưa nhập giá";

        public static string TBChuaNhapDayDuGia = "Bạn chưa nhập đầy đủ giá, hãy nhập thêm giá!";

        public static string TBNhapGiaChuaDungDinhDang = "Nhập giá chưa đúng định dạng, giá phải là số (số nguyên hoặc số thực)";

        //tb chọn hàng 
        public static string TBHayChonHangDeXoa = "Hãy chọn háng hóa muốn xóa";

        public static string TBHayChonHangDeSua = "Hãy chọn háng hóa muốn sửa";

        //nhập hàng
        public static string TBTaoPhieuNhapThanhCong = "Tạo phiếu nhập thành công!";

        public static string TBTaoPhieuNhapThatBai = "Tạo phiếu nhập thất bại!";

        //sua mat khau
        public static string TBMkMoiPhaiGiongMkCu = "Mật Khẩu Mới Trùng Mật Khẩu Cũ";

        public static string TBNhapLaiMkMoiKhongDung = "Nhập Lại Mật Khẩu Mới Không Đúng";

        public static string TBCapNhatMkThanhCong = "Cập nhật mật khẩu thành công";

        public static string TBNhapSaiMkCu = "Sai Mật Khẩu Cũ";

        public static string XacNhanThoat = "Bạn có chắc muốn thoát không ?";

        //hình ảnh bàn 
        public static string HinhAnhBan = "../../image/caiBan.png";

        //trạng thái bàn
        public static int TrangThaiBanTrong = 1;

        //dn
        public static string TBTTDNKhongDung = "Tên Đăng nhập Hoặc Mật Khẩu không Đúng!";

        // Size Bàn
         public static int ChieuDaiBan=120;
         public static int ChieuRongBan = 120;

        // Hiển thị bàn trống hay không trống
         public static string BanTrong = "\nTrống";
         public static string BanKhongTrong = "\nCó người";

        // hiển thi tên loại tài khoản
         public static string chuQUan = "Chủ_Cửa_Hàng";
         public static int MaChuQUan=1;

         public static string amdin = "Admin";
         public static int Maadmin = 2;

         public static string QLiKho = "";
         public static int MaQLkho = 4;

         public static string ThuNgan = "Thu_Ngân";
         public static int Mathungan = 3;
    }
}
