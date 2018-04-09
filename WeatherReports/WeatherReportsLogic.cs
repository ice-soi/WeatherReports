using Codeplex.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReports
{
    public class WeatherReportsLogic
    {
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region " 'AreaList設定"
            /// <summary>
            /// AreaItem設定
            /// </summary>
            /// <returns>項目ﾘｽﾄ</returns>
            public List<String> setArea()
            {

                List<String> country = new List<string>();
                country.Add(WeatherReportsConst.HOKKAIDOU_CHIHOU);
                country.Add(WeatherReportsConst.TOUHOKU_CHIHOU);
                country.Add(WeatherReportsConst.KANTOU_SHINETU_TIHOU);
                country.Add(WeatherReportsConst.TOUKAI_HOKURIKU_KINKI_CHIHOU);
                country.Add(WeatherReportsConst.TYUUGOKU_SIKOKU_CHIHOU);
                country.Add(WeatherReportsConst.KYUSYUU_CHIHOU);
                country.Add(WeatherReportsConst.OKINAWA_CHIHOU);

                return country;
            }
        #endregion
        //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,

        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region " 'PrefList設定"
            /// <summary>
            /// PrefItem設定
            /// </summary>
            /// <returns>項目ﾘｽﾄ</returns>
            public List<String> setPref(string val)
            {
                List<String> pref = new List<string>();
                switch(val)
                {
                    case "1":
                        pref.Add(WeatherReportsConst.DOUHOKU);
                        pref.Add(WeatherReportsConst.DOUNANN);
                        pref.Add(WeatherReportsConst.DOUTOU);
                        pref.Add(WeatherReportsConst.DOUOU);
                        break;
                    case "2":
                        pref.Add(WeatherReportsConst.AOMORIKEN);
                        pref.Add(WeatherReportsConst.IWATEKEN);
                        pref.Add(WeatherReportsConst.MIYAGIKEN);
                        pref.Add(WeatherReportsConst.AKITAKEN);
                        pref.Add(WeatherReportsConst.YAMAGATAKEN);
                        pref.Add(WeatherReportsConst.NIIGATAKEN);
                        pref.Add(WeatherReportsConst.NAGANOKEN);
                        break;
                    case "3":
                        pref.Add(WeatherReportsConst.TOUKYOUTO);
                        pref.Add(WeatherReportsConst.KANAGAWAKEN);
                        pref.Add(WeatherReportsConst.SAITAMAKEN);
                        pref.Add(WeatherReportsConst.CHIBAKEN);
                        pref.Add(WeatherReportsConst.IBARAKIKEN);
                        pref.Add(WeatherReportsConst.TOCHIGIKEN);
                        pref.Add(WeatherReportsConst.GUNAMKEN);
                        pref.Add(WeatherReportsConst.YAMANASHIKEN);
                        break;
                    case "4":
                        pref.Add(WeatherReportsConst.TOYAMAKEN);
                        pref.Add(WeatherReportsConst.ISHIKAWAKEN);
                        pref.Add(WeatherReportsConst.HUKUIKEN);
                        pref.Add(WeatherReportsConst.AINCHIKEN);
                        pref.Add(WeatherReportsConst.GIFUKEN);
                        pref.Add(WeatherReportsConst.SIZUOKAKEN);
                        pref.Add(WeatherReportsConst.MIEKEN);
                        pref.Add(WeatherReportsConst.OOSAKAHU);
                        pref.Add(WeatherReportsConst.HYOUGOKEN);
                        pref.Add(WeatherReportsConst.KYOUTOHU);
                        pref.Add(WeatherReportsConst.SIGAKEN);
                        pref.Add(WeatherReportsConst.NARAKEN);
                        pref.Add(WeatherReportsConst.WAKAYAMAKEN);
                        break;
                    case "5":
                        pref.Add(WeatherReportsConst.TOTTORIKEN);
                        pref.Add(WeatherReportsConst.SIMANEKEN);
                        pref.Add(WeatherReportsConst.OKAYAMAKEN);
                        pref.Add(WeatherReportsConst.HIROSHIMAKEN);
                        pref.Add(WeatherReportsConst.YAMAGUCHIKEN);
                        pref.Add(WeatherReportsConst.TOKUSHIMAKEN);
                        pref.Add(WeatherReportsConst.KAGAWAKEN);
                        pref.Add(WeatherReportsConst.EHIMEKEN);
                        pref.Add(WeatherReportsConst.KOUCHIKEN);
                        break;
                    case "6":
                        pref.Add(WeatherReportsConst.HUKUOKAKEN);
                        pref.Add(WeatherReportsConst.OOITAKEN);
                        pref.Add(WeatherReportsConst.NAGASAKIKEN);
                        pref.Add(WeatherReportsConst.SAGAKEN);
                        pref.Add(WeatherReportsConst.KUMAMOTOKEN);
                        pref.Add(WeatherReportsConst.MIYAZAKIKEN);
                        pref.Add(WeatherReportsConst.KAGOSHIMAKEN);
                        break;
                    case "7":
                        pref.Add(WeatherReportsConst.OKINAWAKEN);
                        break;

                }
                return pref;
            }
        #endregion
        //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,

        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region " 'CityList設定"
            /// <summary>
            /// CityItem設定
            /// </summary>
            /// <returns>項目ﾘｽﾄ</returns>
            public List<String> setCity(string val)
            {
                List<String> city = new List<string>();
                switch (val)
                {
                    case "1":
                        // 道北
                        city.Add(WeatherReportsConst.WAKKANAI);
                        city.Add(WeatherReportsConst.RUMOI);
                        city.Add(WeatherReportsConst.KITAMI);
                        break;
                    case "2":
                        // 道南
                        city.Add(WeatherReportsConst.HAKODATE);
                        city.Add(WeatherReportsConst.ESASI);
                        break;
                    case "3":
                        // 道東
                        city.Add(WeatherReportsConst.ABASHIRI);
                        city.Add(WeatherReportsConst.NEMURO);
                        city.Add(WeatherReportsConst.KUSIRO);
                        city.Add(WeatherReportsConst.OBIHIRO);
                        break;
                    case "4":
                        // 道央
                        city.Add(WeatherReportsConst.ASAHIKAWA);
                        city.Add(WeatherReportsConst.IWAMIZAWA);
                        city.Add(WeatherReportsConst.SAPPORO);
                        city.Add(WeatherReportsConst.MONBETU);
                        city.Add(WeatherReportsConst.MURORAN);
                        city.Add(WeatherReportsConst.URAKAWA);
                        city.Add(WeatherReportsConst.KUTTYAN);
                        break;
                    case "5":
                        // 青森県
                        city.Add(WeatherReportsConst.AOMORI);
                        city.Add(WeatherReportsConst.MUTU);
                        city.Add(WeatherReportsConst.HACHINOHE);
                        break;
                    case "6":
                        // 岩手県
                        city.Add(WeatherReportsConst.MORIOKA);
                        city.Add(WeatherReportsConst.MIYAKO);
                        city.Add(WeatherReportsConst.OOHUNATO);
                        break;
                    case "7":
                        // 宮城県
                        city.Add(WeatherReportsConst.SENDAI);
                        city.Add(WeatherReportsConst.SIROISI);
                        break;
                    case "8":
                        // 秋田県
                        city.Add(WeatherReportsConst.AKITA);
                        city.Add(WeatherReportsConst.YOKOTE);
                        break;
                    case "9":
                        // 山形県
                        city.Add(WeatherReportsConst.YAMAGATA);
                        city.Add(WeatherReportsConst.YONEZAWA);
                        city.Add(WeatherReportsConst.SAKATA);
                        city.Add(WeatherReportsConst.SINNJYOU);
                        break;
                    case "10":
                        // 福島県
                        city.Add(WeatherReportsConst.HUKUSIMA);
                        city.Add(WeatherReportsConst.ONAHAMA);
                        city.Add(WeatherReportsConst.WAKAMATU);
                        break;
                    case "11":
                        // 東京都
                        city.Add(WeatherReportsConst.TOUKYOU);
                        city.Add(WeatherReportsConst.OOSHIMA);
                        city.Add(WeatherReportsConst.HATIJYOUSIMA);
                        city.Add(WeatherReportsConst.CHICHISIMA);
                        break;
                    case "12":
                        // 神奈川県
                        city.Add(WeatherReportsConst.YOKOHAMA);
                        city.Add(WeatherReportsConst.ODAWARA);
                        break;
                    case "13":
                        // 埼玉県
                        city.Add(WeatherReportsConst.SAITAMA);
                        city.Add(WeatherReportsConst.KUMAGAYA);
                        city.Add(WeatherReportsConst.CHICHIBU);
                        break;
                    case "14":
                        // 千葉県
                        city.Add(WeatherReportsConst.CHIBA);
                        city.Add(WeatherReportsConst.CHOUSI);
                        city.Add(WeatherReportsConst.TATEYAMA);
                        break;
                    case "15":
                        // 茨城県
                        city.Add(WeatherReportsConst.MITO);
                        city.Add(WeatherReportsConst.TUCHIURA);
                        break;
                    case "16":
                        // 栃木県
                        city.Add(WeatherReportsConst.UTUNOMIYA);
                        city.Add(WeatherReportsConst.OODAWARA);
                        break;
                    case "17":
                        // 群馬県
                        city.Add(WeatherReportsConst.MAEBASHI);
                        city.Add(WeatherReportsConst.MINAKAMI);
                        break;
                    case "18":
                        // 山梨県
                        city.Add(WeatherReportsConst.KOUHU);
                        city.Add(WeatherReportsConst.KAWAGUCHIKO);
                        break;
                    case "19":
                        // 新潟県
                        city.Add(WeatherReportsConst.NIIGATA);
                        city.Add(WeatherReportsConst.NAGAOKA);
                        city.Add(WeatherReportsConst.TAKADA);
                        city.Add(WeatherReportsConst.AIKAWA);
                        break;
                    case "20":
                        // 長野県
                        city.Add(WeatherReportsConst.NAGANO);
                        city.Add(WeatherReportsConst.MATUMOTO);
                        city.Add(WeatherReportsConst.IIDA);
                        break;
                    case "21":
                        // 富山県
                        city.Add(WeatherReportsConst.TOYAMA);
                        city.Add(WeatherReportsConst.HUSIKI);
                        break;
                    case "22":
                        // 石川県
                        city.Add(WeatherReportsConst.KANAZAWA);
                        city.Add(WeatherReportsConst.WAJIMA);
                        break;
                    case "23":
                        // 福井県
                        city.Add(WeatherReportsConst.HUKUI);
                        city.Add(WeatherReportsConst.SURUGA);
                        break;
                    case "24":
                        // 愛知県
                        city.Add(WeatherReportsConst.NAGOIYA);
                        city.Add(WeatherReportsConst.TOYOHASHI);
                        break;
                    case "25":
                        // 岐阜県
                        city.Add(WeatherReportsConst.GIHU);
                        city.Add(WeatherReportsConst.TAKAYAMA);
                        break;
                    case "26":
                        // 静岡県
                        city.Add(WeatherReportsConst.SHIZUOKA);
                        city.Add(WeatherReportsConst.AJIRO);
                        city.Add(WeatherReportsConst.MISHIMA);
                        city.Add(WeatherReportsConst.HAMAMATU);
                        break;
                    case "27":
                        // 三重県
                        city.Add(WeatherReportsConst.TU);
                        city.Add(WeatherReportsConst.OWASHI);
                        break;
                    case "28":
                        // 大阪府
                        city.Add(WeatherReportsConst.OOSAKA);
                        break;
                    case "29":
                        // 兵庫県
                        city.Add(WeatherReportsConst.KOUBE);
                        city.Add(WeatherReportsConst.TOYOOKA);
                        break;
                    case "30":
                        // 京都府
                        city.Add(WeatherReportsConst.KYOUTO);
                        city.Add(WeatherReportsConst.MAIDURU);
                        break;
                    case "31":
                        // 滋賀県
                        city.Add(WeatherReportsConst.OOTU);
                        city.Add(WeatherReportsConst.HIKONE);
                        break;
                    case "32":
                        // 奈良県
                        city.Add(WeatherReportsConst.NARA);
                        city.Add(WeatherReportsConst.KAZEYA);
                        break;
                    case "33":
                        // 和歌山県
                        city.Add(WeatherReportsConst.WAKAYAMA);
                        city.Add(WeatherReportsConst.USHIOMISAKI);
                        break;
                    case "34":
                        // 鳥取取県
                        city.Add(WeatherReportsConst.TOTTORI);
                        city.Add(WeatherReportsConst.MAIKO);
                        break;
                    case "35":
                        // 島根県
                        city.Add(WeatherReportsConst.MATUE);
                        city.Add(WeatherReportsConst.HAMADA);
                        city.Add(WeatherReportsConst.SAIGOU);
                        break;
                    case "36":
                        // 岡山県
                        city.Add(WeatherReportsConst.OKAYAMA);
                        city.Add(WeatherReportsConst.TUYAMA);
                        break;
                    case "37":
                        // 広島県
                        city.Add(WeatherReportsConst.HIROSHIMA);
                        city.Add(WeatherReportsConst.SYOUBARA);
                        break;
                    case "38":
                        // 山口県
                        city.Add(WeatherReportsConst.SHIMONOSEKI);
                        city.Add(WeatherReportsConst.YAMAGUCHI);
                        city.Add(WeatherReportsConst.YANAGII);
                        city.Add(WeatherReportsConst.HAGI);
                        break;
                    case "39":
                        // 徳島県
                        city.Add(WeatherReportsConst.TOKUSHIMA);
                        city.Add(WeatherReportsConst.HIWASA);
                        break;
                    case "40":
                        // 香川県
                        city.Add(WeatherReportsConst.TAKAMATU);
                        break;
                    case "41":
                        // 愛媛県
                        city.Add(WeatherReportsConst.MATUYAMA);
                        city.Add(WeatherReportsConst.NIIHAMA);
                        city.Add(WeatherReportsConst.UWASHIMA);
                        break;
                    case "42":
                        // 高知県
                        city.Add(WeatherReportsConst.KOUCHI);
                        city.Add(WeatherReportsConst.MUROTOMISAKI);
                        city.Add(WeatherReportsConst.SHIMIZU);
                        break;
                    case "43":
                        // 福岡県
                        city.Add(WeatherReportsConst.HUKUOKA);
                        city.Add(WeatherReportsConst.YAHATA);
                        city.Add(WeatherReportsConst.IIDUKA);
                        city.Add(WeatherReportsConst.KURUME);
                        break;
                    case "44":
                        // 大分県
                        city.Add(WeatherReportsConst.OOITA);
                        city.Add(WeatherReportsConst.NAKATU);
                        city.Add(WeatherReportsConst.HIDA);
                        city.Add(WeatherReportsConst.SAEKI);
                        break;
                    case "45":
                        // 長崎県  
                        city.Add(WeatherReportsConst.NAGASAKI);
                        city.Add(WeatherReportsConst.SASEBO);
                        city.Add(WeatherReportsConst.IZUHARA);
                        city.Add(WeatherReportsConst.HUKUE);
                        break;
                    case "46":
                        // 佐賀県
                        city.Add(WeatherReportsConst.SAGA);
                        city.Add(WeatherReportsConst.IMARI);
                        break;
                    case "47":
                        // 熊本県
                        city.Add(WeatherReportsConst.KUMAMOTO);
                        city.Add(WeatherReportsConst.ASOTOHIME);
                        city.Add(WeatherReportsConst.USHIBUKA);
                        city.Add(WeatherReportsConst.HITOYOSHI);
                        break;
                    case "48":
                        //宮崎県
                        city.Add(WeatherReportsConst.MIYAZAKI);
                        city.Add(WeatherReportsConst.NOBEOKA);
                        city.Add(WeatherReportsConst.MIYAKONOJYOU);
                        city.Add(WeatherReportsConst.TAKACHIHO);
                        break;
                    case "49":
                        // 鹿児島県
                        city.Add(WeatherReportsConst.KAGOSHIMA);
                        city.Add(WeatherReportsConst.KANOYA);
                        city.Add(WeatherReportsConst.TANEGASHIMA);
                        city.Add(WeatherReportsConst.NASE);
                        break;
                    case "50":
                        // 沖縄県
                        city.Add(WeatherReportsConst.NAHA);
                        city.Add(WeatherReportsConst.NAGO);
                        city.Add(WeatherReportsConst.KUMEJIMA);
                        city.Add(WeatherReportsConst.MINAMIDAITOU);
                        city.Add(WeatherReportsConst.MIYAKOJIMA);
                        city.Add(WeatherReportsConst.ISHIGAKIJIMA);
                        city.Add(WeatherReportsConst.YONAGUNIJIMA);
                        break;
                }
                return city;
            }

        #endregion
        //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,

        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region " 'ﾘｽﾄ選択"
            /// <summary>
            /// 
            /// </summary>
            /// <param name="list"></param>
            /// <param name="index"></param>
            /// <returns></returns>
            internal String getSelectItem(List<ListItemData> list, int index)
            {
                return list[index].Val;
            }
        #endregion
        //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,

        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region " 'ﾘｸｴｽﾄ"
            /// <summary>
            /// APIﾘｸｴｽﾄ
            /// </summary>
            /// <param name="code"></param>
            internal WeatherReportsContentsData getRequest(String code)
            {
                WebRequest req = WebRequest.Create(string.Format(WeatherReportsConst.URL,code));
                WebResponse res = req.GetResponse();

                using (Stream stream = res.GetResponseStream())
                {
                    dynamic json = DynamicJson.Parse(stream);
                    return new WeatherReportsContentsData(json);  
                }
        }
        #endregion
        //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
    }
}
