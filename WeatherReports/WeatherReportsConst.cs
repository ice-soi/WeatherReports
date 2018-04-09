using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReports
{
    static class WeatherReportsConst
    {
        //''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region " '地域"
            // 地域
            public const string HOKKAIDOU_CHIHOU = "1_北海道";
            public const string TOUHOKU_CHIHOU = "2_東北";
            public const string KANTOU_SHINETU_TIHOU = "3_関東・信越";
            public const string TOUKAI_HOKURIKU_KINKI_CHIHOU = "4_東海・北陸・近畿";
            public const string TYUUGOKU_SIKOKU_CHIHOU = "5_中国・四国";
            public const string KYUSYUU_CHIHOU = "6_九州";
            public const string OKINAWA_CHIHOU = "7_沖縄";
        #endregion
        //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,

        //''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region " '都道府県"
            // 都道府県
            public const string DOUHOKU = "1_道北";
            public const string DOUNANN = "2_道南";
            public const string DOUTOU = "3_道東";
            public const string DOUOU = "4_道央";
            public const string AOMORIKEN = "5_青森県";
            public const string IWATEKEN = "6_岩手県";
            public const string AKITAKEN = "7_秋田県";
            public const string MIYAGIKEN = "8_秋田県";
            public const string YAMAGATAKEN = "9_山形県";
            public const string HUKUSHIMAKEN = "10_福島県";
            public const string TOUKYOUTO = "11_東京都";
            public const string KANAGAWAKEN = "12_神奈川県";
            public const string SAITAMAKEN = "13_埼玉県";
            public const string CHIBAKEN = "14_福島県";
            public const string IBARAKIKEN= "15_茨城県";
            public const string TOCHIGIKEN = "16_栃木県";
            public const string GUNAMKEN = "17_群馬県";
            public const string YAMANASHIKEN = "18_山梨県";
            public const string NIIGATAKEN = "19_新潟県";
            public const string NAGANOKEN = "20_長野県";
            public const string TOYAMAKEN = "21_富山県";
            public const string ISHIKAWAKEN = "22_石川県";
            public const string HUKUIKEN = "23_福井県";
            public const string AINCHIKEN = "24_愛知県";
            public const string GIFUKEN = "25_岐阜県";
            public const string SIZUOKAKEN = "26_静岡県";
            public const string MIEKEN = "27_三重県";
            public const string OOSAKAHU = "28_大阪府";
            public const string HYOUGOKEN = "29_兵庫県";
            public const string KYOUTOHU = "30_京都府";
            public const string SIGAKEN = "31_滋賀県";
            public const string NARAKEN = "32_奈良県";
            public const string WAKAYAMAKEN = "33_和歌山県";
            public const string TOTTORIKEN = "34_鳥取県";
            public const string SIMANEKEN = "35_島根県";
            public const string OKAYAMAKEN = "36_岡山県";
            public const string HIROSHIMAKEN = "37_広島県";
            public const string YAMAGUCHIKEN = "38_山口県";
            public const string TOKUSHIMAKEN = "39_徳島県";
            public const string KAGAWAKEN = "40_香川県";
            public const string EHIMEKEN = "41_愛媛県";
            public const string KOUCHIKEN = "42_高知県";
            public const string HUKUOKAKEN = "43_福岡県";
            public const string OOITAKEN = "44_大分県";
            public const string NAGASAKIKEN = "45_長崎県";
            public const string SAGAKEN = "46_佐賀県";
            public const string KUMAMOTOKEN = "47_熊本県";
            public const string MIYAZAKIKEN = "48_宮崎県";
            public const string KAGOSHIMAKEN = "49_鹿児島県";
            public const string OKINAWAKEN = "50_沖縄県";
        #endregion
        //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,

        //''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region " '都市"
        // 北海道
        public const string WAKKANAI = "011000_稚内";
        public const string ASAHIKAWA = "012010_旭川";
        public const string RUMOI = "012020_留萌";
        public const string SAPPORO = "016010_札幌";
        public const string IWAMIZAWA = "016020_岩見沢";
        public const string KUTTYAN = "016030_倶知安";
        public const string ABASHIRI = "013010_網走";
        public const string KITAMI = "013020_北見";
        public const string MONBETU = "013030_紋別";
        public const string NEMURO = "014010_根室";
        public const string KUSIRO = "014020_釧路";
        public const string OBIHIRO = "014030_帯広";
        public const string MURORAN = "015010_室蘭";
        public const string URAKAWA = "015020_浦河";
        public const string HAKODATE = "017010_函館";
        public const string ESASI = "017020_江差";

        // 青森県
        public const string AOMORI = "020010_青森";
        public const string MUTU = "020020_むつ";
        public const string HACHINOHE = "020030_八戸";

        // 岩手県
        public const string MORIOKA = "030010_盛岡";
        public const string MIYAKO = "030020_宮古";
        public const string OOHUNATO = "030030_大船渡";

        // 宮城県
        public const string SENDAI = "040010_仙台";
        public const string SIROISI = "040020_白石";

        // 秋田県
        public const string AKITA = "050010_秋田";
        public const string YOKOTE = "050020_横手";

        // 山形県
        public const string YAMAGATA = "060010_山形";
        public const string YONEZAWA = "060020_米沢";
        public const string SAKATA = "060030_酒田";
        public const string SINNJYOU = "060040_新庄";

        // 福島県
        public const string HUKUSIMA = "070010_福島";
        public const string ONAHAMA = "070020_小名浜";
        public const string WAKAMATU = "070030_若松";

        // 東京都
        public const string TOUKYOU = "130010_東京";
        public const string OOSHIMA = "130020_大島";
        public const string HATIJYOUSIMA = "130030_八丈島";
        public const string CHICHISIMA = "130040_父島";

        // 神奈川県
        public const string YOKOHAMA = "140010_横浜";
        public const string ODAWARA = "140020_小田原";

        // 埼玉県
        public const string SAITAMA = "110010_さいたま";
        public const string KUMAGAYA = "110020_熊谷";
        public const string CHICHIBU = "110030_秩父";

        // 千葉県
        public const string CHIBA = "120010_千葉";
        public const string CHOUSI = "120020_銚子";
        public const string TATEYAMA = "120030_館山";

        // 茨城県
        public const string MITO = "080010_水戸";
        public const string TUCHIURA = "080020_土浦";

        // 栃木県
        public const string UTUNOMIYA = "090010_宇都宮";
        public const string OODAWARA = "090020_大田原";

        // 群馬県
        public const string MAEBASHI = "100010_前橋";
        public const string MINAKAMI = "100020_みなかみ";

        // 山梨県
        public const string KOUHU = "190010_甲府";
        public const string KAWAGUCHIKO = "190020_河口湖";

        // 新潟県
        public const string NIIGATA = "150010_新潟";
        public const string NAGAOKA = "150020_長岡";
        public const string TAKADA = "150030_高田";
        public const string AIKAWA = "150040_相川";

        // 長野県
        public const string NAGANO = "200010_長野";
        public const string MATUMOTO = "200020_松本";
        public const string IIDA = "200030_飯田";

        // 富山県
        public const string TOYAMA = "160010_富山";
        public const string HUSIKI = "160020_伏木";

        // 石川県
        public const string KANAZAWA = "170010_金沢";
        public const string WAJIMA = "170020_輪島";

        // 福井県
        public const string HUKUI = "180010_福井";
        public const string SURUGA = "180020_敦賀";

        // 愛知県
        public const string NAGOIYA = "230010_名古屋";
        public const string TOYOHASHI = "230020_豊橋";

        // 岐阜県
        public const string GIHU = "210010_岐阜";
        public const string TAKAYAMA = "210020_高山";

        // 静岡県
        public const string SHIZUOKA = "220010_静岡";
        public const string AJIRO = "220020_網代";
        public const string MISHIMA = "220030_三島";
        public const string HAMAMATU = "220040_浜松";

        // 三重県
        public const string TU = "240010_津";
        public const string OWASHI = "240020_尾鷲";

        // 大阪府
        public const string OOSAKA = "270000_大阪";

        // 兵庫県
        public const string KOUBE = "280010_神戸";
        public const string TOYOOKA = "280020_豊岡";

        // 京都府
        public const string KYOUTO = "260010_京都";
        public const string MAIDURU = "260020_舞鶴";

        // 滋賀県
        public const string OOTU = "250010_大津";
        public const string HIKONE = "250020_彦根";

        // 奈良県
        public const string NARA = "290010_奈良";
        public const string KAZEYA = "290020_風屋";

        // 和歌山県
        public const string WAKAYAMA = "300010_和歌山";
        public const string USHIOMISAKI = "300020_潮岬";

        // 鳥取県
        public const string TOTTORI = "310010_鳥取";
        public const string MAIKO = "310020_米子";

        // 島根県
        public const string MATUE = "320010_松江";
        public const string HAMADA = "320020_浜田";
        public const string SAIGOU = "320030_西郷";

        // 岡山県
        public const string OKAYAMA = "330010_岡山";
        public const string TUYAMA = "330020_津山";

        // 広島県
        public const string HIROSHIMA = "340010_広島";
        public const string SYOUBARA = "340020_庄原";

        // 山口県
        public const string SHIMONOSEKI = "350010_下関";
        public const string YAMAGUCHI = "350020_山口";
        public const string YANAGII = "350030_柳井";
        public const string HAGI = "350040_萩";

        // 徳島県
        public const string TOKUSHIMA = "360010_徳島";
        public const string HIWASA = "360020_日和佐";

        // 香川県
        public const string TAKAMATU = "370000_高松";

        // 愛媛県
        public const string MATUYAMA = "380010_松山";
        public const string NIIHAMA = "380020_新居浜";
        public const string UWASHIMA = "380030_宇和島";

        // 高知県
        public const string KOUCHI = "390010_高知";
        public const string MUROTOMISAKI = "390020_室戸岬";
        public const string SHIMIZU = "390030_清水";

        // 福岡県
        public const string HUKUOKA = "400010_福岡";
        public const string YAHATA = "400020_八幡";
        public const string IIDUKA = "400030_飯塚";
        public const string KURUME = "400040_久留米";

        // 大分県
        public const string OOITA = "440010_大分";
        public const string NAKATU = "440020_中津";
        public const string HIDA = "440030_日田";
        public const string SAEKI = "440040_佐伯";

        // 長崎県
        public const string NAGASAKI = "420010_長崎";
        public const string SASEBO = "420020_佐世保";
        public const string IZUHARA = "420030_厳原";
        public const string HUKUE = "420040_福江";

        // 佐賀県
        public const string SAGA = "410010_佐賀";
        public const string IMARI = "410020_伊万里";

        // 熊本県
        public const string KUMAMOTO = "430010_熊本";
        public const string ASOTOHIME = "430020_阿蘇乙姫";
        public const string USHIBUKA = "430030_牛深";
        public const string HITOYOSHI = "430040_人吉";

        // 宮崎県
        public const string MIYAZAKI = "450010_宮崎";
        public const string NOBEOKA = "450020_延岡";
        public const string MIYAKONOJYOU = "450030_都城";
        public const string TAKACHIHO = "450040_高千穂";

        // 鹿児島県
        public const string KAGOSHIMA = "460010_鹿児島";
        public const string KANOYA = "460020_鹿屋";
        public const string TANEGASHIMA = "460030_種子島";
        public const string NASE = "460040_名瀬";

        // 沖縄県
        public const string NAHA = "471010_那覇";
        public const string NAGO = "471020_名護";
        public const string KUMEJIMA = "471030_久米島";
        public const string MINAMIDAITOU = "472000_南大東";
        public const string MIYAKOJIMA = "473000_宮古島";
        public const string ISHIGAKIJIMA = "474010_石垣島";
        public const string YONAGUNIJIMA = "474020_与那国島";
        #endregion
        //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,

        //''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region " 'URL"
            /// <summary>
            /// URL
            /// </summary>
            public const string URL = "http://weather.livedoor.com/forecast/webservice/json/v1?city={0}";
        #endregion
        //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,

        //''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region " 'ﾒｯｾｰｼﾞ"
            /// <summary>
            /// ｴﾗｰﾒｯｾｰｼﾞ
            /// </summary>
            public const string ERROR_1 = "検索する地域を選択してください";
            /// <summary>
            /// ｴﾗｰﾒｯｾｰｼﾞ
            /// </summary>
            public const string ERROR_2 = "検索処理でエラーが発生しました";
        #endregion
        //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
    }
}
