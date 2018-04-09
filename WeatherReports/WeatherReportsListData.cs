using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReports
{

    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''
    #region " 'ﾘｽﾄﾃﾞｰﾀ取得"
        /// <summary>
        /// ﾘｽﾄﾃﾞｰﾀ取得
        /// </summary>
        class WeatherReportsListData
        {
            /// <summary>
            /// ﾃﾞﾌｫﾙﾄｺﾝｽﾄﾗｸﾀ
            /// </summary>
            public WeatherReportsListData()
            {
            }
            /// <summary>
            /// ｺﾝｽﾄﾗｸﾀ
            /// </summary>
            /// <param name="setItem"></param>
            public WeatherReportsListData(List<String> pList)
            {
                // 取得したﾘｽﾄ項目を設定
                pList.ForEach((s) =>
                {
                    ListItemData val = new ListItemData();
                    String[] sitem = s.Split('_');
                    val.Val = sitem[0];
                    val.Name = sitem[1];
                    _list.Add(val);
                });
            }
            /// <summary>
            /// 項目ﾘｽﾄ
            /// </summary>
            private List<ListItemData> _list = new List<ListItemData>();
            /// <summary>
            /// 項目ﾘｽﾄﾌﾟﾛﾊﾟﾃｨ
            /// </summary>
            public List<ListItemData> List
            {
                get { return this._list; }
            }
        }
    #endregion
    //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,

    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''
    #region " 'ﾘｽﾄﾌﾟﾛﾊﾟﾃｨ"
        /// <summary>
        /// ﾘｽﾄﾌﾟﾛﾊﾟﾃｨ
        /// </summary>
        class ListItemData
        {
            /// <summary>
            /// 名称
            /// </summary>
            private String _name;
            public String Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            /// <summary>
            /// 設定値
            /// </summary>
            private String _val;
            public String Val
            {
                get { return this._val; }
                set { this._val = value; }
            }
            public override string ToString()
            {
                return Name;
            }
        }
    #endregion
    //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
}
