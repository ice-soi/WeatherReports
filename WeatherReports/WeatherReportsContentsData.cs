using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReports
{
    class WeatherReportsContentsData
    {
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region " 'ﾌﾟﾛﾊﾟﾃｨ"
            /// <summary>
            /// ﾀｲﾄﾙ
            /// </summary>
            private string _title;
            public string Title
            {
                get { return this._title; }
                set { this._title = value; }
            }
            /// <summary>
            /// 時間
            /// </summary>
            private string _time;
            public string Time
            {
                get { return this._time; }
                set {
                        DateTime dt = DateTime.Parse(value);
                        this._time = dt.ToString("yyyy/MM/dd HH:mm:ss");
                    }
            }
            /// <summary>
            /// 公開時間
            /// </summary>
            private string _publictime;
            public string PublicTime
            {
                get { return this._publictime; }
                set
                {
                    DateTime dt = DateTime.Parse(value);
                    this._publictime = dt.ToString("(yyyy/MM/dd HH:mm:ss 現在)");
                }
            }
            /// <summary>
            /// ﾃｷｽﾄ
            /// </summary>
            private string _text;
            public string Text
            {
                get { return this._text; }
                set
                {
                    string temp = value.Replace("\n\n", "_n").Replace("\n", "");
                    this._text = temp.Replace("_n", "\n");
                }
            }
            /// <summary>
            /// 日時ﾃﾞｰﾀ
            /// </summary>
            private List<WeatherReportsItem> _items;
            public List<WeatherReportsItem> Items
            {
                get { return this._items;}
                set { this._items = value; }
            }
        #endregion
        //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,

        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region " 'ｺﾝｽﾄﾗｸﾀ"
            /// <summary>
            /// ﾃﾞﾌｫﾙﾄｺﾝｽﾄﾗｸﾀ
            /// </summary>
            public WeatherReportsContentsData()
            {
            }
            /// <summary>
            /// ｺﾝｽﾄﾗｸﾀ
            /// </summary>
            public WeatherReportsContentsData(dynamic pDynamic)
            {
                Title = pDynamic.title;
                Time = pDynamic.publicTime;
                PublicTime = pDynamic.description.publicTime;
                Text = pDynamic.description.text;
                Items = setItemList(pDynamic);
            }
        #endregion
        //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,

        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region " 'ﾒｿｯﾄﾞ"
            /// <summary>
            /// 日時ﾃﾞｰﾀ設定
            /// </summary>
            /// <param name="pDynamic"></param>
            /// <returns></returns>
            private List<WeatherReportsItem> setItemList(dynamic pDynamic)
            {
                List<WeatherReportsItem> list = new List<WeatherReportsItem>();

                foreach (var item in pDynamic.forecasts)
                {
                    WeatherReportsItem temp = new WeatherReportsItem();
                    temp.Date = item.date;
                    temp.DateLabel = item.dateLabel;
                    temp.Telop = item.telop;
                    temp.MaxTemp = (item.temperature.max == null) ? "-" : item.temperature.max.celsius;
                    temp.MinTemp = (item.temperature.min == null) ? "-" : item.temperature.min.celsius;
                    temp.Image = item.image.url;
                    list.Add(temp);
                }
                return list;
            }
        #endregion
        //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
    }
    class WeatherReportsItem
    {
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region " 'ﾌﾟﾛﾊﾟﾃｨ"
            /// <summary>
            /// 日付
            /// </summary>
            private string _date;
            public string Date
            {
                get { return this._date; }
                set
                {
                    DateTime dt = DateTime.Parse(value);
                    this._date = dt.ToString("MM/dd");
                }
            }
            /// <summary>
            /// 日付表示
            /// </summary>
            private string _dateLabel;
            public string DateLabel
            {
                get { return this._dateLabel; }
                set { this._dateLabel = value; }
            }
            /// <summary>
            /// 表示天気
            /// </summary>
            private string _telop;
            public string Telop
            {
                get { return this._telop; }
                set { this._telop = value; }
            }
            /// <summary>
            /// 最高温度
            /// </summary>
            private string _maxtemp;
            public string MaxTemp
            {
                get { return this._maxtemp; }
                set { this._maxtemp = String.Format("{0}℃",value); }
            }
            /// <summary>
            /// 最低温度
            /// </summary>
            private string _mintemp;
            public string MinTemp
            {
                get { return this._mintemp; }
                set { this._mintemp = String.Format("{0}℃", value); }
            }
            /// <summary>
            /// 画像ﾊﾟｽ
            /// </summary>
            private string _image;
            public string Image
            {
                get { return this._image; }
                set { this._image = value; }
            }

        #endregion
        //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,

        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region " 'ｺﾝｽﾄﾗｸﾀ"
        /// <summary>
        /// ﾃﾞﾌｫﾙﾄｺﾝｽﾄﾗｸﾀ
        /// </summary>
        public WeatherReportsItem()
            {
            }
        #endregion 
        //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
    }
}
