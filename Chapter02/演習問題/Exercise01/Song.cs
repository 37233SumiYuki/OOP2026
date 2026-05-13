using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    public class Song {
        //タイトル
        public string Title { get; set; } = string.Empty;
        //商品カテゴリー
        public string ArtistName { get; set; } = string.Empty;
        //演奏時間
        public int Length { get; set; }
        //コンストラクター
        public Song(String title, string artistName, int length) {
            Title = title;
            ArtistName = artistName;
            Length = length;
           


        }
    }
}
