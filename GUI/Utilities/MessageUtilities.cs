using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Utilities
{
    public static class TextStorage
    {
        private static readonly Dictionary<Tuple<string, string>, string> 
            labelsDictionary, errorsDictionary, messagesDictionary;

        static TextStorage()
        {
            labelsDictionary = new Dictionary<Tuple<string, string>, string>
            {
                {
                    Tuple.Create("UNKNOWN", "vi"),
                    "Chưa rõ"
                },
                {
                    Tuple.Create("LBL_001_INFO", "vi"),
                    "Thông tin"
                },
                {
                    Tuple.Create("LBL_002_WARN", "vi"),
                    "Cảnh báo"
                },
                {
                    Tuple.Create("LBL_003_ERROR", "vi"),
                    "Lỗi"
                }
            };
            errorsDictionary = new Dictionary<Tuple<string, string>, string>();
            messagesDictionary = new Dictionary<Tuple<string, string>, string>
            {
                {
                    Tuple.Create("UKNOWN", "vi"),
                    "Chưa có thông tin về phần này!" + Environment.NewLine +
                    "Xin vui lòng thử lại sau."
                },
                {
                    Tuple.Create("MSG_001_INFO", "vi"),
                    "Không tìm được lựa chọn khả dĩ với dữ liệu hiện tại!" + Environment.NewLine +
                    "Vui lòng thêm dữ liệu, hoặc sửa lại giới hạn thời gian."
                },
                {
                    Tuple.Create("MSG_002_WARN_NO_DATA", "vi"),
                    "Không có dữ liệu cần thiết!" + Environment.NewLine +
                    "Vui lòng chọn một tệp dữ liệu tương ứng."
                },
                {
                    Tuple.Create("MSG_003_UNKNOWN_ERROR", "vi"),
                    "Đã có lỗi chưa rõ xảy ra!" + Environment.NewLine +
                    "Vui lòng thử chức năng khác, hoặc báo lại cho lập trình viên."
                },
                {
                    Tuple.Create("MSG_004_SAVE_SUCCESS", "vi"),
                    "Lưu thành công!" + Environment.NewLine +
                    "Bạn có thể đóng cửa sổ này lại."
                },
                {
                    Tuple.Create("MSG_005_CONFIRM_UNSAVED_DATA", "vi"),
                    "Dữ liệu chưa được lưu lại." + Environment.NewLine +
                    "Bạn có chắc chắn muốn làm thoát?"
                },
                {
                    Tuple.Create("MSG_006_WRONG_FORMAT", "vi"),
                    "Tệp đầu vào sai định dạng!" + Environment.NewLine +
                    "Mỗi dòng là một lớp môn học có mẫu:" + Environment.NewLine +
                    "  [Tên môn học]; [Thứ]: [Tiết bắt đầu] - [Tiết kết thúc], [Thứ]: [Tiết bắt đầu] - [Tiết kết thúc]" + Environment.NewLine +
                    "  [Tên môn học] có thể là chuỗi bất kỳ. [Thứ] là một số từ 2 đến 8, tương ứng thứ hai đến chủ nhật." + Environment.NewLine +
                    "  Giới hạn tiết học: 1 <= [Tiết bắt đầu], [Tiết kết thúc] <= 16." + Environment.NewLine +
                    "  Một môn học nhiều này có thể được đặt sau dấu phẩy." + Environment.NewLine +
                    "Ví dụ: môn [Cơ sở dữ liệu] học vào [thứ tư] từ [tiết 1 đến tiết 4] và [thứ sáu] từ [tiết 2 đến tiết 4]:" + Environment.NewLine +
                    "  Cơ sở dữ liệu; 4: 1 - 4, 6: 2 - 4." + Environment.NewLine +
                    "Nếu có hai lớp [Ngôn ngữ Lập trình 2], một lớp học vào [thứ hai], một lớp học vào [thứ bảy], " +
                    "và cùng học từ [tiết 1 đến tiết 4] thì biểu diễn bằng hai dòng:" + Environment.NewLine +
                    "  Ngôn ngữ Lập trình 2; 2: 1 - 4" + Environment.NewLine +
                    "  Ngôn ngữ Lập trình 2; 7: 1 - 4"
                },
                {
                    Tuple.Create("MSG_007_INPUT_ERROR", "vi"),
                    "Đã có lỗi xảy ra khi đọc tệp!" + Environment.NewLine +
                    "Vui lòng thử lại sau."
                },
                {
                    Tuple.Create("MSG_008_NOT_UPDATED", "vi"),
                    "Tính năng chưa được cập nhật!" + Environment.NewLine +
                    "Vui lòng thử lại sau."
                },
            };
        }

        private static string Get(Dictionary<Tuple<string, string>, string> dictionary, 
            string key, string language)
        {
            var tuple = Tuple.Create(key, language);
            var unknownTuple = Tuple.Create("UNKNOWN", language);
            return dictionary.ContainsKey(tuple)
                ? dictionary[tuple]
                : dictionary[unknownTuple];
        }

        public static string GetMessage(string key, string language = "vi")
        {
            return Get(messagesDictionary, key, language);
        }

        public static string GetLabel(string key, string language = "vi")
        {
            return Get(labelsDictionary, key, language);
        }
    }

    public static class MessageUtilities
    {
        public static DialogResult ShowMessageWithButtonsAndIcon(string text, 
            string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(null, text, caption, buttons, icon);
        }

        public static void ShowInformativeMessage(string text, string caption)
        {
            ShowMessageWithButtonsAndIcon(text, caption, 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowWarningMessage(string text, string caption)
        {
            ShowMessageWithButtonsAndIcon(text, caption,
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void ShowErrorMessage(string text, string caption)
        {
            ShowMessageWithButtonsAndIcon(text, caption,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool ShowConfirmMessage(string text, string caption)
        {
            return ShowMessageWithButtonsAndIcon(text, caption,
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes;
        }
    }
}
