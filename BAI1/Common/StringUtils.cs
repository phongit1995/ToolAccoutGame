using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI1.Common
{
    internal class StringUtils
    {
        // Token: 0x06000099 RID: 153 RVA: 0x0000419C File Offset: 0x0000239C
        public static string GetRandomGender()
        {
            return (StringUtils.rd.Next(0, 1) == 0) ? "male" : "female";
        }

        // Token: 0x0600009A RID: 154 RVA: 0x000041C8 File Offset: 0x000023C8
        public static string GetRandomName()
        {
            string[] ho = new string[]
            {
                "Nguyễn",
                "Lê Minh ",
                "Trần",
                "Mã Thanh ",
                "Phan Thanh ",
                "Phạm ",
                "Vũ",
                "Hạ",
                "Đỗ Minh",
                "Hoàng Thái",
                "Đinh Hoàng",
                "Thiệu",
                "Tạ Công",
                "Dương Thái",
                "Bùi",
                "Mạc",
                "Hứa",
                "Đông",
                "Phùng",
                "Cao",
                "Huỳnh",
                "Trương",
                "Vũ",
                "Lương",
                "Lê",
                "Trần",
                "Dương",
                "Trần",
                "Phan Lệ",
                "Lưu",
                "Hoàng",
                "Đoàn",
                "Trình",
                "Ngô"
            };
            string[] ten = new string[]
            {
                "Thành",
                "Công",
                "Dương",
                "Hãi",
                "Luân",
                "Mạnh",
                "Lục",
                "Phi",
                "Toàn",
                "Kiên",
                "Giang",
                "Hào",
                "Huy",
                "Duy",
                "Quyết",
                "Khánh",
                "Linh",
                "Long",
                "Hùng",
                "Mạnh",
                "Mãi",
                "Tùng",
                "Quang",
                "Kiên",
                "Tuấn",
                "Học",
                "Nam",
                "Tâm",
                "Bắc",
                "Xuân",
                "Kinh",
                "Hoàng",
                "Hậu",
                "Tập",
                "Hoàn",
                "Tam",
                "Kha",
                "Phong",
                "Phước",
                "Công",
                "Mẫn",
                "Đức",
                "Nguyễn",
                "Nhật",
                "Nhựt",
                "Hoàng",
                "Minh",
                "Thiệu",
                "Khải",
                "Đạt",
                "Thành",
                "Hậu",
                "Lưu",
                "Hoàng",
                "Nghiêm",
                "Nguyễn",
                "Đoàn",
                "Trình",
                "Ngô",
                "Hướng",
                "Minh",
                "Toàn",
                "Bình",
                "Đức",
                "Lý",
                "Liêm",
                "Minh",
                "Mạnh",
                "Ninh",
                "Khanh",
                "Khánh",
                "Khiêm",
                "Khoái",
                "Quỳnh",
                "Tiên",
                "Mai",
                "Giang",
                "Linh",
                "Thảo",
                "Diệp",
                "Trang",
                "Vân",
                "Hà",
                "Thu",
                "Hạnh",
                "Hiền",
                "Diệp",
                "Ngọc",
                "Yến",
                "Huyền",
                "Nga",
                "Hương",
                "Lan",
                "My",
                "Loan",
                "Diễm",
                "Ánh",
                "Mỹ",
                "Oanh"
            };
            return ho[StringUtils.rd.Next(0, ho.Length - 1)] + " " + ten[StringUtils.rd.Next(0, ten.Length - 1)];
        }

        // Token: 0x0600009B RID: 155 RVA: 0x000046B4 File Offset: 0x000028B4
        private static string GetRandomNameNonAccented()
        {
            string[] ho = new string[]
            {
                "Nguyen",
                "Le Minh",
                "Tran",
                "Ma Thanh",
                "Phan Thanh",
                "Pham",
                "Vu",
                "Ha",
                "Do Minh",
                "Hoang Thai",
                "Dinh Hoang",
                "Thieu",
                "Ta Cong",
                "Duong Thai",
                "Bui",
                "Mac",
                "Hua",
                "Dong",
                "Phung",
                "Cao",
                "Huynh",
                "Truong",
                "Vu",
                "Luong",
                "Le",
                "Tran",
                "Duong",
                "Tran",
                "Phan Le",
                "Luu",
                "Hoang",
                "Doan",
                "Trinh",
                "Ngo"
            };
            string[] ten = new string[]
            {
                "Thanh",
                "Cong",
                "Duong",
                "Hai",
                "Luan",
                "Manh",
                "Luc",
                "Phi",
                "Toan",
                "Kien",
                "Giang",
                "Hao",
                "Huy",
                "Duy",
                "Quyet",
                "Khanh",
                "Linh",
                "Long",
                "Hung",
                "Manh",
                "Mai",
                "Tung",
                "Quang",
                "Kien",
                "Tuan",
                "Hoc",
                "Nam",
                "Tam",
                "Bac",
                "Xuan",
                "Kinh",
                "Hoang",
                "Hau",
                "Tap",
                "Hoan",
                "Tam",
                "Kha",
                "Phong",
                "Phuoc",
                "Cong",
                "Man",
                "Duc",
                "Nguyen",
                "Nhat",
                "Nhut",
                "Hoang",
                "Minh",
                "Thieu",
                "Khai",
                "Dat",
                "Thanh",
                "Hau",
                "Luu",
                "Hoang",
                "Nghiem",
                "Nguyen",
                "Doan",
                "Trinh",
                "Ngo",
                "Huong",
                "Minh",
                "Toan",
                "Binh",
                "Duc",
                "Ly",
                "Liem",
                "Minh",
                "Manh",
                "Ninh",
                "Khanh",
                "Khanh",
                "Khiem",
                "Khoai",
                "Quynh",
                "Tien",
                "Mai",
                "Giang",
                "Linh",
                "Thao",
                "Diep",
                "Trang",
                "Van",
                "Ha",
                "Thu",
                "Hanh",
                "Hien",
                "Diep",
                "Ngoc",
                "Yen",
                "Huyen",
                "Nga",
                "Huong",
                "Lan",
                "My",
                "Loan",
                "Diem",
                "Anh",
                "My",
                "Oanh"
            };
            return ho[StringUtils.rd.Next(0, ho.Length - 1)] + " " + ten[StringUtils.rd.Next(0, ten.Length - 1)];
        }

        // Token: 0x0600009C RID: 156 RVA: 0x00004BA0 File Offset: 0x00002DA0
        public static string GetRandomBirthDay()
        {
            string day = StringUtils.rd.Next(1, 28).ToString();
            bool flag = day.Length == 1;
            if (flag)
            {
                day = "0" + day;
            }
            string month = StringUtils.rd.Next(1, 12).ToString();
            bool flag2 = month.Length == 1;
            if (flag2)
            {
                month = "0" + month;
            }
            return string.Concat(new string[]
            {
                StringUtils.rd.Next(1980, 2004).ToString(),
                "-",
                month,
                "-",
                day
            });
        }

        // Token: 0x0600009D RID: 157 RVA: 0x00004C58 File Offset: 0x00002E58
        public static string GetRandomPhoneName()
        {
            return StringUtils.listPhoneName[StringUtils.rd.Next(StringUtils.listPhoneName.Length)];
        }

        // Token: 0x0600009E RID: 158 RVA: 0x00004C84 File Offset: 0x00002E84
        public static string GetRandomModel()
        {
            return StringUtils.listModel[StringUtils.rd.Next(StringUtils.listModel.Length)];
        }

        // Token: 0x0600009F RID: 159 RVA: 0x00004CB0 File Offset: 0x00002EB0
        public static string GetRandomEmail()
        {
            return StringUtils.GetRandomNameNonAccented().Replace(" ", ".").ToLower() + StringUtils.GetRandomBirthDay().Replace("-", "") + "@gmail.com";
        }

        // Token: 0x060000A0 RID: 160 RVA: 0x00004CFC File Offset: 0x00002EFC
        public static string GetRandomDeviceId()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }

        // Token: 0x060000A1 RID: 161 RVA: 0x00004D34 File Offset: 0x00002F34
        public static string GetRandomPassword()
        {
            string s = "";
            char[] arr = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for (int i = 0; i < 6; i++)
            {
                s += arr[StringUtils.rd.Next(0, arr.Length - 1)].ToString();
            }
            return s;
        }

        // Token: 0x060000A2 RID: 162 RVA: 0x00004D90 File Offset: 0x00002F90
        public static string GetRandomString(int n)
        {
            string s = "";
            char[] arr = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for (int i = 0; i < n; i++)
            {
                s += arr[StringUtils.rd.Next(0, arr.Length - 1)].ToString();
            }
            return s;
        }

        // Token: 0x060000A3 RID: 163 RVA: 0x00004DEC File Offset: 0x00002FEC
        public static string GetRandomSerialString(int n)
        {
            string s = "";
            char[] arr = "abcdef0123456789".ToCharArray();
            for (int i = 0; i < n; i++)
            {
                s += arr[StringUtils.rd.Next(0, arr.Length - 1)].ToString();
            }
            return s;
        }

        // Token: 0x060000A4 RID: 164 RVA: 0x00004E48 File Offset: 0x00003048
        public static string GetRandomSerial()
        {
            char[] arr = "123456789abcdef".ToCharArray();
            string id = "";
            for (int i = 0; i < 12; i++)
            {
                id += arr[StringUtils.rd.Next(arr.Length)].ToString();
            }
            return id;
        }

        // Token: 0x060000A5 RID: 165 RVA: 0x00004EA0 File Offset: 0x000030A0
        public static string GetRandomImei()
        {
            char[] arr = "123456789abcdef".ToCharArray();
            string id = "";
            for (int i = 0; i < 15; i++)
            {
                id += arr[StringUtils.rd.Next(arr.Length)].ToString();
            }
            return id;
        }

        // Token: 0x060000A6 RID: 166 RVA: 0x00004EF8 File Offset: 0x000030F8
        public static string GetRandomAddress()
        {
            return string.Format("{0:X}:{1:X}:{2:X}:{3:X}:{4:X}:{5:X}", new object[]
            {
                StringUtils.rd.Next(255),
                StringUtils.rd.Next(255),
                StringUtils.rd.Next(255),
                StringUtils.rd.Next(255),
                StringUtils.rd.Next(255),
                StringUtils.rd.Next(255)
            });
        }

        // Token: 0x060000A7 RID: 167 RVA: 0x00004FA4 File Offset: 0x000031A4
        public static string GetRandomAndroidVersion()
        {
            return string.Format("{0}.{1}.{2}", StringUtils.rd.Next(4, 9), StringUtils.rd.Next(0, 9), StringUtils.rd.Next(0, 9));
        }

        // Token: 0x060000A8 RID: 168 RVA: 0x00004FF8 File Offset: 0x000031F8
        public static string GetRandomApiVersion()
        {
            return StringUtils.rd.Next(17, 29).ToString();
        }

        // Token: 0x060000A9 RID: 169 RVA: 0x00005020 File Offset: 0x00003220
        public static int GetRandInt(int min, int max)
        {
            return StringUtils.rd.Next(min, max);
        }

        // Token: 0x060000AA RID: 170 RVA: 0x00005040 File Offset: 0x00003240
        public static string GetRandomProcessorCount()
        {
            return StringUtils.rd.Next(4, 16).ToString();
        }

        // Token: 0x060000AB RID: 171 RVA: 0x00005068 File Offset: 0x00003268
        public static string GetRandomFreq()
        {
            return StringUtils.rd.Next(1000, 2000).ToString();
        }

        // Token: 0x060000AC RID: 172 RVA: 0x00005098 File Offset: 0x00003298
        public static string GetRandomProcessorType()
        {
            return (StringUtils.rd.Next(0, 1) == 0) ? "ARM64 FP ASIMD AES" : "ARM32 FP ASIMD AES";
        }

        // Token: 0x060000AD RID: 173 RVA: 0x000050C4 File Offset: 0x000032C4
        public static string GetRandomUsername()
        {
            return StringUtils.GetRandomNameNonAccented().Replace(" ", "") + StringUtils.GetRandomString(4);
        }

        // Token: 0x060000AE RID: 174 RVA: 0x000050F8 File Offset: 0x000032F8
        public static string GetRandomNickname()
        {
            string nickname = StringUtils.GetRandomNameNonAccented().Replace(" ", "") + StringUtils.GetRandomString(4);
            while (nickname.Length < 6 || nickname.Length > 12)
            {
                nickname = StringUtils.GetRandomNameNonAccented().Replace(" ", "") + StringUtils.GetRandomString(4);
            }
            return nickname;
        }

        // Token: 0x060000AF RID: 175 RVA: 0x0000516C File Offset: 0x0000336C
        public static string GetErrorMessage(int statusCode)
        {
            bool flag = StringUtils.dic == null;
            if (flag)
            {
                StringUtils.dic = new Dictionary<int, string>();
                StringUtils.dic.Add(0, "Thành công");
                StringUtils.dic.Add(2, "Nhập OTP Telesafe của tài khoản {0}");
                StringUtils.dic.Add(3, "Đăng ký tài khoản thành công");
                StringUtils.dic.Add(11001, "Bạn không đủ tiền để tiếp tục ván chơi.");
                StringUtils.dic.Add(11002, "Bạn đã không có hành động trong vòng {0} phút.");
                StringUtils.dic.Add(11003, "Đăng ký rời phòng.");
                StringUtils.dic.Add(11004, "Người chơi {0} đăng ký rời phòng.");
                StringUtils.dic.Add(11005, "Người chơi bị mất kết nối.");
                StringUtils.dic.Add(11006, "Bạn bị mất kết nối.");
                StringUtils.dic.Add(11007, "Bạn cần ít nhất {0} {1} để tiếp tục ván chơi.");
                StringUtils.dic.Add(11008, "Bàn chơi chưa sẵn sàng.");
                StringUtils.dic.Add(11009, "Bàn chơi không tồn tại.");
                StringUtils.dic.Add(11010, "Phiên chơi đã kết thúc");
                StringUtils.dic.Add(11011, "Bàn chơi đã đầy, mời bạn chọn bàn chơi khác.");
                StringUtils.dic.Add(11012, "Mật khẩu vào bàn sai");
                StringUtils.dic.Add(11013, "Không đủ tiền làm chương");
                StringUtils.dic.Add(11014, "Bạn không thể vào bàn. Bạn cần tối thiểu {0} {1} để vào bàn.");
                StringUtils.dic.Add(11015, "Bạn không thể tạo bàn. Bạn cần tối thiểu {0} {1} để tạo bàn.");
                StringUtils.dic.Add(100001, "Đang chọn chương");
                StringUtils.dic.Add(100002, "Đang chờ người mua chương.");
                StringUtils.dic.Add(100003, "Đang chọn chương");
                StringUtils.dic.Add(100004, "Bạn không đủ điều kiện làm chương.");
                StringUtils.dic.Add(110001, "Chưa đặt với chương.");
                StringUtils.dic.Add(110002, "Người bạn thách biên chưa đặt với chương.");
                StringUtils.dic.Add(111001, "Yêu cầu đã được gửi, bạn không được gửi yêu cầu 2 lần.");
                StringUtils.dic.Add(111002, "Số dư không đủ để đánh biên, cần tối thiều {0}.");
                StringUtils.dic.Add(111003, "Người bạn muốn đánh biên không đủ số dư.");
                StringUtils.dic.Add(111004, "Không tồn tại yêu cầu đánh biên này.");
                StringUtils.dic.Add(112001, "Bạn đã góp gà rồi, bạn không thể góp gà 2 lần.");
                StringUtils.dic.Add(112002, "Số dư không đủ để góp gà, cần tối thiều {0}.");
                StringUtils.dic.Add(115001, "Bạn được đặc cách vào  vòng tiếp theo");
                StringUtils.dic.Add(115002, "Bạn đã thua");
                StringUtils.dic.Add(115003, "Bạn đang chơi ở thiết bị khác");
                StringUtils.dic.Add(115004, "Có thiết bị mới vào chơi tài khoản của bạn");
                StringUtils.dic.Add(130001, "Số lượng chip không hợp lệ.");
                StringUtils.dic.Add(300002, "Bài quá mạnh, bạn không thể theo");
                StringUtils.dic.Add(-99, "Hệ thống đang bận");
                StringUtils.dic.Add(-1, "Tài khoản chưa đăng ký SMSPlus");
                StringUtils.dic.Add(-2, "Tài khoản chưa kích hoạt SMSPlus");
                StringUtils.dic.Add(-6, "Mã OTP hết hạn");
                StringUtils.dic.Add(-7, "Mã OTP không chính xác");
                StringUtils.dic.Add(-13, "Mã thẻ hết, mời bạn chọn mã thẻ khác");
                StringUtils.dic.Add(-33, "Tài khoản không hoạt động");
                StringUtils.dic.Add(-41, "Email đã tồn tại");
                StringUtils.dic.Add(-42, "Địa chỉ email không đúng");
                StringUtils.dic.Add(-46, "Tài khoản đã tồn tại");
                StringUtils.dic.Add(-48, "Tài khoản hiện đang bị khóa");
                StringUtils.dic.Add(-49, "Tài khoản đang unactive lâu không hoạt động");
                StringUtils.dic.Add(-50, "Tài khoản không tồn tại");
                StringUtils.dic.Add(-51, "Số dư của bạn không đủ");
                StringUtils.dic.Add(-53, "Mật khẩu không hợp lệ");
                StringUtils.dic.Add(-56, "Tên nhân vật đã tồn tại");
                StringUtils.dic.Add(-60, "GiftCode không hợp lệ");
                StringUtils.dic.Add(-96, "Tiền tệ không hợp lệ");
                StringUtils.dic.Add(-100, "Authen ServiceID không hợp lệ");
                StringUtils.dic.Add(-101, "Authen ServiceKey không hợp lệ");
                StringUtils.dic.Add(-102, "Token không hợp lệ");
                StringUtils.dic.Add(-103, "Token đã hết hạn");
                StringUtils.dic.Add(-144, "GiftCode đã sử dụng");
                StringUtils.dic.Add(-111, "Mã App OTP không đúng");
                StringUtils.dic.Add(-200, "Bạn đặt cửa quá nhanh giữa 2 lần, hãy thử lại");
                StringUtils.dic.Add(-201, "Bạn phải cập nhật Tên nhập vật để tiếp tục chơi");
                StringUtils.dic.Add(-207, "Hết thời gian đặt");
                StringUtils.dic.Add(-208, "Bạn không thể đặt 2 cửa 1 lúc");
                StringUtils.dic.Add(-212, "Giá trị đặt cửa không hợp lệ");
                StringUtils.dic.Add(-213, "Loại tiền không hợp lệ");
                StringUtils.dic.Add(-214, "Chưa đến thời gian đặt cửa");
                StringUtils.dic.Add(-232, "Thông tin không hợp lệ, mời bạn thử lại.");
                StringUtils.dic.Add(-251, "Bạn chưa xác thực số điện thoại hoặc chưa gắn kết TeleSafe.");
                StringUtils.dic.Add(-600, "Dữ liệu không hợp lệ");
                StringUtils.dic.Add(-611, "Email đã kích hoạt");
                StringUtils.dic.Add(-612, "Số điện thoại đã kích hoạt");
                StringUtils.dic.Add(-613, "Mật khẩu cũ không đúng");
                StringUtils.dic.Add(-631, "Tài khoản chưa khóa");
                StringUtils.dic.Add(-641, "Số điện thoại đã tồn tại");
                StringUtils.dic.Add(-642, "Số điện thoại không đúng");
                StringUtils.dic.Add(-649, "GiftCode chưa kích hoạt");
                StringUtils.dic.Add(-654, "Số điện thoại cũ không hợp lệ");
                StringUtils.dic.Add(-657, "Dữ liệu bị trùng");
                StringUtils.dic.Add(-663, "Bạn không có quyền mở khóa");
                StringUtils.dic.Add(-665, "Bạn đã hết số lần lấy mã OTP theo mức quy định");
                StringUtils.dic.Add(-666, "Giftcode đã hết hạn");
                StringUtils.dic.Add(-701, "Tài khoản chưa đăng ký TeleSafe");
                StringUtils.dic.Add(-702, "Tài khoản chưa kích hoạt TeleSafe");
                StringUtils.dic.Add(-712, "Tài khoản TeleSafe đã được kích hoạt");
                StringUtils.dic.Add(-741, "TeleSafe đã tồn tại");
                StringUtils.dic.Add(-748, "TeleSafe không đúng");
                StringUtils.dic.Add(-750, "TeleSafe không tồn tài");
                StringUtils.dic.Add(-1030, "Bạn cần xác thực OTP SMS trước");
                StringUtils.dic.Add(-1031, "Bạn cần xác thực OTP TeleSafe trước");
                StringUtils.dic.Add(-1032, "Tài khoản đã xác thực TeleSafe");
                StringUtils.dic.Add(-1033, "Tài khoản đã xác thực Mobile");
                StringUtils.dic.Add(-3031, "Số lượng Giftcode đã sử dụng đạt hạn mức tối đa. Bạn vui lòng nhập loại Giftcode khác hoặc đợi lần tiếp theo.");
                StringUtils.dic.Add(-1000, "Bạn cần nhập vào tên tài khoản");
                StringUtils.dic.Add(-1001, "Tên tài khoản từ {0} đến {1} ký tự, gồm chữ cái, chữ số. ");
                StringUtils.dic.Add(-1002, "Bạn cần nhập vào mật khẩu");
                StringUtils.dic.Add(-1003, "Mật khẩu từ {0} đến {1} ký tự. Không trùng với tài khoản");
                StringUtils.dic.Add(-1004, "Dữ liệu truyền vào không hợp lệ");
                StringUtils.dic.Add(-1005, "Bạn cần nhập vào mã xác nhận");
                StringUtils.dic.Add(-1006, "Đăng nhập không thành công, xin vui lòng thử lại");
                StringUtils.dic.Add(-1007, "Tên nhân vật đặt từ {0} - {1} kí tự, không chứa kí tự đặc biệt, khoảng trắng, từ nhạy cảm");
                StringUtils.dic.Add(-1008, "Tên nhân vật không được chứa tên tài khoản");
                StringUtils.dic.Add(-1009, "Tên nhân vật không được nằm trong tên tài khoản");
                StringUtils.dic.Add(-1010, "Mật khẩu không được chứa tên tài khoản");
                StringUtils.dic.Add(-1011, "Mật khẩu không được nằm trong tên tài khoản");
                StringUtils.dic.Add(-1012, "Mã xác nhận không chính xác, mời thử lại!");
                StringUtils.dic.Add(-1013, "Tên tài khoản phải bắt đầu bằng chữ cái, không chứa kí tự đặc biệt, khoảng trắng, từ nhạy cảm");
                StringUtils.dic.Add(-1014, "Tên nhân vật không hợp lệ");
                StringUtils.dic.Add(-1015, "Mật khẩu không hợp lệ");
                StringUtils.dic.Add(-1016, "Địa chỉ IP {0} bị tạm khóa trong vòng {1} phút");
                StringUtils.dic.Add(-1017, "Tài khoản {0} bị tạm khóa trong vòng {1} phút");
                StringUtils.dic.Add(-1018, "Bạn chưa nhập số điện thoại");
                StringUtils.dic.Add(-1019, "Bạn chưa nhập mã OTP");
                StringUtils.dic.Add(-1020, "Bạn chưa nhập Email");
                StringUtils.dic.Add(-1021, "Bạn chưa nhập CMTND");
                StringUtils.dic.Add(-1022, "Số CMTND không hợp lệ");
                StringUtils.dic.Add(-1023, "Bạn vui lòng đăng nhập tài khoản!");
                StringUtils.dic.Add(-1024, "Đăng nhập Facebook thất bại");
                StringUtils.dic.Add(-1025, "Dữ liệu hết hiệu lực");
                StringUtils.dic.Add(-1026, "Địa chỉ IP của bạn đang bị khóa, vui lòng liên hệ quản trị để biết thêm chi tiết");
                StringUtils.dic.Add(-1027, "Mật khẩu mới phải khác mật khẩu cũ");
                StringUtils.dic.Add(-1035, "Hệ thống đang bảo trì mời các bạn quay lại sau");
                StringUtils.dic.Add(-1036, "Hiện ga đang bảo trì mời các bạn quay lại sau");
                StringUtils.dic.Add(-3000, "Giá trị chuyển khoản không hợp lệ");
                StringUtils.dic.Add(-3001, "Lý do chuyển khoản quá ngắn");
                StringUtils.dic.Add(-3002, "Số dư không đủ để thanh toán");
                StringUtils.dic.Add(-3003, "Tài khoản chưa đăng ký bảo mật");
                StringUtils.dic.Add(-3004, "Thời gian đăng ký bảo mật chưa đủ 24 tiếng");
                StringUtils.dic.Add(-3005, "Số lần sai OTP vượt quá giới hạn cho phép");
                StringUtils.dic.Add(-3006, "Thanh toán không thành công");
                StringUtils.dic.Add(-3007, "Giao dịch đang nghi vấn");
                StringUtils.dic.Add(-3008, "Mã gift code không tồn tại");
                StringUtils.dic.Add(-3009, "Mã giftcode không hợp lệ");
                StringUtils.dic.Add(-3010, "Mã Gift code chưa kích hoạt hoặc đã sử dụng");
                StringUtils.dic.Add(-3011, "Mã giftcode đã hết hạn");
                StringUtils.dic.Add(-3012, "Tài khoản đã sử dụng mã giftcode cùng loại");
                StringUtils.dic.Add(-3013, "Trạng thái giftcode không đúng");
                StringUtils.dic.Add(-3014, "Giftcode không hợp lệ");
                StringUtils.dic.Add(-3015, "Tài khoản vi phạm chính sách giftcode");
                StringUtils.dic.Add(-3021, "Số serial hoặc mã thẻ không hợp lệ");
                StringUtils.dic.Add(-3022, "Bạn đã nhập sai tên nhà mạng");
                StringUtils.dic.Add(-3023, "Mua thẻ không thành công. Bạn không được tiêu quá 3 triệu [money[1]] trong vòng 1 giờ");
                StringUtils.dic.Add(-3024, "Bạn đã nhập sai id hoặc mã thẻ");
                StringUtils.dic.Add(-3025, "Mệnh giá không hợp lệ");
                StringUtils.dic.Add(-3026, "Chức năng này hiện đang tạm ngừng hoạt động");
                StringUtils.dic.Add(-3027, "Mỗi giao dịch chỉ được mua tối đa {0} thẻ");
                StringUtils.dic.Add(-3028, "Phiên giao dịch hết hạn");
                StringUtils.dic.Add(-3029, "Mệnh giá không tồn tại");
                StringUtils.dic.Add(-60001, "Chưa đến thời gian đặt cửa");
                StringUtils.dic.Add(-60002, "Quá hạn mức đặt cửa");
                StringUtils.dic.Add(-60007, "Giá trị đặt cửa không hợp lệ");
                StringUtils.dic.Add(-60008, "Chỉ được đặt lại 1 lần");
                StringUtils.dic.Add(-60009, "Chỉ được gấp thếp 1 lần");
                StringUtils.dic.Add(-60010, "Ván trước bạn chưa đặt cửa");
                StringUtils.dic.Add(-60011, "Chưa có dữ liệu đặt cửa");
                StringUtils.dic.Add(-60051, "Bạn chưa đăng nhập, xin vui lòng thử lại!");
                StringUtils.dic.Add(-60200, "Bạn thực hiện quá nhanh giữa 2 lần đặt");
                StringUtils.dic.Add(-60201, "Bạn cần nhập tên nhân vật để chơi Ga ({0})");
                StringUtils.dic.Add(-60207, "Hết thời gian đặt cửa");
                StringUtils.dic.Add(-60208, "Bạn không thể đặt 2 cửa 1 lúc");
                StringUtils.dic.Add(-60212, "Cửa đăt không hợp lệ ({0})");
                StringUtils.dic.Add(-60213, "Loại tiền không hợp lệ");
                StringUtils.dic.Add(-60214, "Mệnh giá không đúng ({0})");
                StringUtils.dic.Add(-60215, "Bạn chưa nhập thông tin đặt ({0})");
                StringUtils.dic.Add(-60216, "Dữ liệu đặt không hơp lệ ({0})");
                StringUtils.dic.Add(-60217, "Mã phiên không đúng ({0})");
                StringUtils.dic.Add(-60500, "Ga bảo trì");
                StringUtils.dic.Add(-60600, "Dữ liệu không hợp lệ");
                StringUtils.dic.Add(-67012, "Chưa nhập đủ số cần đặt");
                StringUtils.dic.Add(-67013, "Số vé phải là chữ số");
                StringUtils.dic.Add(-67014, "Số vé không được trùng nhau");
                StringUtils.dic.Add(-68101, "Lỗi ghép cặp đấu, mời bạn thử lại");
                StringUtils.dic.Add(-68232, "Bạn đã đăng ký tham gia đấu trường ({0})");
                StringUtils.dic.Add(-68401, "Bạn đang chơi ({0})");
                StringUtils.dic.Add(-68402, "Bạn đã đăng ký chờ phiên tiếp theo rồi ({0})");
                StringUtils.dic.Add(-68403, "Đăng ký không thành công ({0})");
                StringUtils.dic.Add(-68501, "Đấu trường đang diễn ra, bạn không thể tham gia ({0})");
                StringUtils.dic.Add(-68502, "Phiên chơi bị hủy, bạn sẽ được hoàn lại tiền ({0})");
                StringUtils.dic.Add(-68503, "Phiên không đủ người chơi, bạn sẽ được hoàn lại tiền ({0})");
                StringUtils.dic.Add(-100000, "Mã số nạp tiền không tồn tại hoặc đã được sử dụng");
                StringUtils.dic.Add(-100001, "Giao dịch thất bại");
                StringUtils.dic.Add(-100002, "Sai chữ ký");
                StringUtils.dic.Add(-100003, "Thẻ đã bị sử dụng");
                StringUtils.dic.Add(-100004, "Thẻ đã bị khóa");
                StringUtils.dic.Add(-100005, "Thẻ đã hết hạn sử dụng");
                StringUtils.dic.Add(-100006, "Thẻ chưa được kích hoạt");
                StringUtils.dic.Add(-100007, "Sai quá số lần cho phép");
                StringUtils.dic.Add(-100008, "Card serial hoặc cardcode không đúng");
                StringUtils.dic.Add(-100009, "Nhà cung cấp không tồn tại");
                StringUtils.dic.Add(-100010, "Hệ thống đang bận");
                StringUtils.dic.Add(-100011, "Hệ thống đang bận");
                StringUtils.dic.Add(-100012, "Thông tin không đúng định dạng");
                StringUtils.dic.Add(-100013, "Partner không tồn tại");
                StringUtils.dic.Add(-100014, "Partner đang bị khóa");
                StringUtils.dic.Add(-100015, "Sai serviceKey hoặc serviceID");
                StringUtils.dic.Add(-100017, "Tài khoản không tồn tại");
                StringUtils.dic.Add(-100018, "Không tồn tại giao dịch");
                StringUtils.dic.Add(-100021, "Loại thẻ không hỗ trợ");
                StringUtils.dic.Add(-100023, "Tạo giao dịch không thành công");
                StringUtils.dic.Add(-100025, "Số tiền không chính xác");
                StringUtils.dic.Add(-100040, "Lỗi xử lý giao dịch với nhà cung cấp");
                StringUtils.dic.Add(-100302, "Ip không cho phép");
                StringUtils.dic.Add(-100999, "Giao dịch nghi vấn");
                StringUtils.dic.Add(-100998, "Giao dịch đang xử lý,Vui lòng kiểm tra lại tài khoản");
            }
            string msg;
            StringUtils.dic.TryGetValue(statusCode, out msg);
            return msg;
        }

        // Token: 0x060000B0 RID: 176 RVA: 0x00006214 File Offset: 0x00004414
        public static string GetLoginMessage(int statusCode)
        {
            bool flag = StringUtils.dicLogin == null;
            if (flag)
            {
                StringUtils.dicLogin = new Dictionary<int, string>();
                StringUtils.dicLogin.Add(106, "NickName không hợp lệ!");
                StringUtils.dicLogin.Add(116, "Không chọn NickName nhạy cảm!");
                StringUtils.dicLogin.Add(1001, "Mất kết nối máy chủ!");
                StringUtils.dicLogin.Add(1005, "Thông tin đăng nhập không hợp lệ!");
                StringUtils.dicLogin.Add(1007, "Thông tin đăng nhập không hợp lệ!");
                StringUtils.dicLogin.Add(1008, "Mã xác thực không chính xác!");
                StringUtils.dicLogin.Add(1010, "NickName đã tồn tại!");
                StringUtils.dicLogin.Add(1011, "NickName không được trùng với UserName!");
                StringUtils.dicLogin.Add(1012, "Enter OTP");
                StringUtils.dicLogin.Add(1013, "Đã có NickName rồi!");
                StringUtils.dicLogin.Add(1021, "Mã xác thực đã hết thời gian sử dụng!");
                StringUtils.dicLogin.Add(1109, "Tài khoản đang bị khóa!");
                StringUtils.dicLogin.Add(1114, "Hệ thống bảo trì vui lòng quay lại sau!");
                StringUtils.dicLogin.Add(2001, "Update NickName");
                StringUtils.dicLogin.Add(2002, "Change Password");
                StringUtils.dicLogin.Add(0, "Thành công");
            }
            string msg;
            StringUtils.dicLogin.TryGetValue(statusCode, out msg);
            return msg;
        }

        // Token: 0x04000056 RID: 86
        private static Random rd = new Random();

        // Token: 0x04000057 RID: 87
        private static string[] listPhoneName = new string[]
        {
            "Galaxy Note9",
            "Galaxy Tab S4 10.5",
            "Galaxy Tab A 10.5",
            "Galaxy On6",
            "Galaxy J7 (2018)",
            "Galaxy J3 (2018)",
            "Galaxy A8 Star (A9 Star)",
            "Galaxy S Light Luxury",
            "Galaxy J8",
            "Galaxy J6",
            "Galaxy J4",
            "Galaxy A6+ (2018)",
            "Galaxy A6 (2018)",
            "Galaxy J7 Duo",
            "Galaxy J7 Prime 2",
            "Galaxy S9+",
            "Galaxy S9",
            "Galaxy J2 Pro (2018)",
            "Galaxy A8+ (2018)",
            "Galaxy A8 (2018)",
            "Galaxy J2 (2017)",
            "Galaxy Tab Active 2",
            "Galaxy Tab A 8.0 (2017)",
            "Galaxy C7 (2017)",
            "Galaxy Note8",
            "Galaxy S8 Active",
            "Galaxy J7 V",
            "Galaxy Note FE",
            "Galaxy J7 Max",
            "Galaxy J7 Pro",
            "Galaxy J7 (2017)",
            "Galaxy J5 (2017)",
            "Galaxy J3 (2017)",
            "Galaxy S8",
            "Galaxy S8+",
            "Gear S3 classic LTE",
            "Galaxy C5 Pro",
            "Galaxy Xcover 4",
            "Galaxy Tab S3 9.7",
            "Galaxy J1 mini prime",
            "Galaxy J3 Emerge",
            "Galaxy C7 Pro",
            "Galaxy A7 (2017)",
            "Galaxy A5 (2017)",
            "Galaxy A3 (2017)",
            "Galaxy Grand Prime Plus",
            "Galaxy J2 Prime",
            "Galaxy C9 Pro",
            "Galaxy C10",
            "Galaxy A8 (2016)",
            "Galaxy On8",
            "Galaxy On7 (2016)",
            "Gear S3 classic",
            "Gear S3 frontier",
            "Gear S3 frontier LTE",
            "Galaxy J5 Prime",
            "Galaxy J7 Prime",
            "Galaxy Note7 (USA)",
            "Galaxy Note7",
            "Galaxy On7 Pro",
            "Galaxy On5 Pro",
            "Galaxy Tab J",
            "Galaxy J Max",
            "Galaxy J2 Pro (2016)",
            "Galaxy J2 (2016)",
            "Z3 Corporate Edition",
            "Galaxy Xcover 3 G389F",
            "Galaxy S7 active",
            "Galaxy J3 Pro",
            "Galaxy C7",
            "Galaxy C5",
            "Galaxy A9 Pro (2016)",
            "Galaxy J7 (2016)",
            "Galaxy J5 (2016)",
            "Galaxy Tab A 10.1 (2016)",
            "Galaxy Tab A 7.0 (2016)",
            "Galaxy S7",
            "Galaxy S7 edge",
            "Galaxy S7 edge (USA)",
            "Galaxy S7 (USA)",
            "Galaxy J1 Nxt"
        };

        // Token: 0x04000058 RID: 88
        private static string[] listModel = new string[]
        {
            "Samsung",
            "Xiaomi",
            "Vivo",
            "Huawei",
            "Oppo",
            "Lenovo",
            "LG",
            "Google"
        };

        // Token: 0x04000059 RID: 89
        private static string[] listUserAgent = new string[0];

        // Token: 0x0400005A RID: 90
        private static Dictionary<int, string> dic;

        // Token: 0x0400005B RID: 91
        private static Dictionary<int, string> dicLogin;
    }
}
