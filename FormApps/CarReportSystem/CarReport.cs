namespace CarReportSystem {
    public class CarReport {
        // 列挙型
        public enum MakerGroup {
            なし,
            トヨタ,
            日産,
            ホンダ,
            スバル,
            輸入車,
            その他
        }

        [System.ComponentModel.DisplayName("ID")]
        public int Id { get; set; }
        [System.ComponentModel.DisplayName("日付")]
        public DateTime Date { get; set; }
        [System.ComponentModel.DisplayName("記録者")]
        public string Author { get; set; } = string.Empty;
        [System.ComponentModel.DisplayName("メーカー")]
        public MakerGroup Maker { get; set; }
        [System.ComponentModel.DisplayName("車名")]
        public string CarName { get; set; } = string.Empty;
        [System.ComponentModel.DisplayName("レポート")]
        public string Report { get; set; } = string.Empty;
        [System.ComponentModel.DisplayName("画像")]
        public Image? Picture { get; set; }
    }
}