using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public sealed class Settings {

        private const string FileName = "setting.xml";
        
        //唯一のSettingオブジェクト
        private static readonly Settings _instance = new Settings();

        //メイン画面に設定した色情報
        public int MainFormBackColor { get; set; }
        = SystemColors.Control.ToArgb();

        public static Settings Instance {
            get { return _instance; }
        }

        //外部からnewできないようにする
        private Settings() {}

        public void Save() {
            var date = new SettingsDate {
                ManiFormBackColor = MainFormBackColor
            };

            using var writer = XmlWriter.Create(FileName);
            var serializer = new XmlSerializer(typeof(SettingsDate));
            serializer.Serialize(writer, date);

        }
        //XML保存用のクラス
        public class SettingsDate {
            public int ManiFormBackColor { get; set; }
        }
    }
}
