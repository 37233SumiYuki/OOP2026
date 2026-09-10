
using Microsoft.Data.Sqlite;

using System.Drawing.Imaging;
using System.Globalization;

namespace CarReportSystem;

// Productsテーブルに対するDB操作をまとめたクラス
// CRUD（Create / Read / Update / Delete）を担当する
public class CarReportRepository {
    // 全レポートを取得する。Read（SELECT）に相当する
    public List<CarReport> GetAll() {

        var carReports = new List<CarReport>();

        using var connection = Database.GetConnection();
        connection.Open();

        // SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();

        // Productsテーブルを作るSQL
        command.CommandText =
            """
            SELECT Id, Date, Author, Maker, CarName, Report, Picture
            FROM CarReports
            ORDER BY Id;
            """;

        // SELECTを実行し、複数行の検索結果を読み取る
        using var reader = command.ExecuteReader();

       while (reader.Read()) {
            carReports.Add(new CarReport {
                Id = reader.GetInt32(0),
                Date = DateTime.ParseExact(
                    reader.GetString(1),
                    "yyyy-MM-dd",
                    CultureInfo.InvariantCulture),
                Author = reader.GetString(2),
                Maker = (CarReport.MakerGroup)reader.GetInt32(3),
                CarName = reader.GetString(4),
                Report = reader.GetString(5),
                Picture = reader.IsDBNull(6) ? null :
                BytesToImage(reader.GetFieldValue<byte[]>(6))
            });
        }
        return carReports;

    }
    public void Add(CarReport report) {
        using var connection = Database.GetConnection();
        connection.Open();

        using var command = connection.CreateCommand();

        command.CommandText =
            """
                INSERT INTO CarReports
                (Date, Author, Maker, CarName, Report, Picture)
                VALUES
                ($date, $author, $maker, $carName, $report, $picture);
                """;

        command.Parameters.AddWithValue("$date", report.Date.ToString("yyyy-MM-dd"));
        command.Parameters.AddWithValue("$author", report.Author);
        command.Parameters.AddWithValue("$maker", (int)report.Maker);
        command.Parameters.AddWithValue("$carName", report.CarName);
        command.Parameters.AddWithValue("$report", report.Report);
        command.Parameters.AddWithValue("$picture", (object?)ImageToBytes(report.Picture) ??
            DBNull.Value);

        command.ExecuteNonQuery();

        
    }


    public void Update(CarReport report) {
        using var connection = Database.GetConnection();
        connection.Open();

        using var command = connection.CreateCommand();

        command.CommandText =
            """
                UPDATE CarReports
                SET Date = $date,
                    Author = $author,
                    Maker = $maker,
                    CarName = $carName,
                    Report = $report,
                    Picture = $picture
                WHERE Id = $id;
                """;

        command.Parameters.AddWithValue("$id", report.Id);
        command.Parameters.AddWithValue("$date", report.Date.ToString("yyyy-MM-dd"));
        command.Parameters.AddWithValue("$author", report.Author);
        command.Parameters.AddWithValue("$maker", (int)report.Maker);
        command.Parameters.AddWithValue("$carName", report.CarName);
        command.Parameters.AddWithValue("$report", report.Report);
        command.Parameters.AddWithValue("$picture", ImageToBytes(report.Picture));

        command.ExecuteNonQuery();
    }

    public void Delete(int id) {
        using var connection = Database.GetConnection();
        connection.Open();

        using var command = connection.CreateCommand();

        command.CommandText =
            """
                DELETE FROM CarReports
                WHERE Id = $id;
                """;

        command.Parameters.AddWithValue("$id", id);

        command.ExecuteNonQuery();
    }

    // ImageをSQLiteへ保存できるbyte[]へ変換する
    private static byte[]? ImageToBytes(Image? image) {
        if (image is null) return null;

        using var stream = new MemoryStream();
        // DBへはPNG形式で保存
        image.Save(stream, ImageFormat.Png);
        return stream.ToArray();
    }

    // SQLiteのBLOB（byte[]）をImageへ変換する
    private static Image BytesToImage(byte[] data) {
        using var stream = new MemoryStream(data);
        using var image = Image.FromStream(stream);
        // MemoryStream破棄後も利用できるようBitmapとしてコピーする。
        return new Bitmap(image);
    }
}
