using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace day01 {
    class Video { 
        public string title;
        public string author;
        //影片的類型只有4種: 教育、娛樂、音樂、其他
        private string type;
        public static int video_count = 0; //創建了多少個Video物件

        public Video(string title, string author, string type) {
            this.title = title;
            this.author = author;
            Type = type;
            video_count++; //每建構一次物件 ，就+1(建構方法)
        }

        public int getVideoCount() { 
            return video_count;
        }

        public string Type {
            get { return type; }  //當有人要取得原先type屬性要做的事情
            set {
                if (value == "教育" || value == "娛樂" || value == "音樂") {
                    type = value;
                } else { 
                    type="其他";
                }
            }//當有人要設定Type要做的事情 設定的值就是value
        }
    }

}
