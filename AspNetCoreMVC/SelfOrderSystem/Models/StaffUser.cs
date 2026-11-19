namespace SelfOrderSystem.Models {
    public class StaffUser {
        public int Id { get; set; }
        // DB 内部の主キー 
        public string UserName { get; set; } = "";// ログイン名 
        public string PasswordHash { get; set; } = "";// パスワードのハッシュ 
        public string Role { get; set; } = "Staff";   // 操作権限
    }
}
