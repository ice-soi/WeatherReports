using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WeatherReports
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        //''''''''''''''''''''''''''''''''''''''''''''''''''
        #region " 'ﾌﾟﾛﾊﾟﾃｨ"
        private Point mousePoint;
            /// <summary>
            /// ﾏｳｽのｸﾘｯｸ位置
            /// </summary>
            public Point MousePoint
            {
                get { return mousePoint; }
                set { mousePoint = value; }
            }
            /// <summary>
            /// ﾋﾞｼﾞﾈｽﾛｼﾞｯｸ
            /// </summary>
            private WeatherReportsLogic logic = new WeatherReportsLogic();
        #endregion
        //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,

        //''''''''''''''''''''''''''''''''''''''''''''''''''
        #region " 'ｺﾝｽﾄﾗｸﾀ"
            /// <summary>
            /// Initialize
            /// </summary>
            public MainWindow()
            {
                InitializeComponent();
                // ｺﾝﾎﾞﾎﾞｯｸｽ初期設定
                Init();
            }
            /// <summary>
            /// ｺﾝﾎﾞﾎﾞｯｸｽ初期設定
            /// </summary>
            private void Init()
            {
                List<string> list = logic.setArea();

                // 都道府県ﾘｽﾄ設定
                WeatherReportsListData item = new WeatherReportsListData(list);
                this.cmbArea.ItemsSource = item.List;
                this.cmbPref.ItemsSource = null;
                this.cmbCity.ItemsSource = null;
            }
        #endregion
        //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,

        //''''''''''''''''''''''''''''''''''''''''''''''''''
        #region " 'ﾘｽﾄｲﾍﾞﾝﾄ"
            /// <summary>
            /// Closeﾎﾞﾀﾝｸﾘｯｸ
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void Close_Click(object sender, RoutedEventArgs e)
            {
                this.Close();
            }
            /// <summary>
            /// ﾏｳｽﾀﾞｳﾝｲﾍﾞﾝﾄ
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    // 押下した位置の座標を取得
                    MousePoint = e.GetPosition(this);
                }
            }
            /// <summary>
            /// ﾏｳｽﾑｰﾌﾞｲﾍﾞﾝﾄ
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void Grid_MouseMove(object sender, MouseEventArgs e)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    Point pt = e.GetPosition(this);
                    // 座標移動
                    this.Left += pt.X - MousePoint.X;
                    this.Top += pt.Y - MousePoint.Y;
                }
            }
            /// <summary>
            /// ｴﾘｱｺﾝﾎﾞﾎﾞｯｸｽ選択
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void cmbArea_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                String val = logic.getSelectItem((List<ListItemData>)this.cmbArea.ItemsSource, this.cmbArea.SelectedIndex);
                List<string> list = logic.setPref(val);
                this.cmbCity.ItemsSource = null;

                // 地域ﾘｽﾄ設定
                WeatherReportsListData item = new WeatherReportsListData(list);
                this.cmbPref.ItemsSource = item.List;
            }
            /// <summary>
            /// 地域ｺﾝﾎﾞﾎﾞｯｸｽ選択
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void cmbPref_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                if (this.cmbPref.SelectedIndex == -1) { return; }

                String val = logic.getSelectItem((List<ListItemData>)this.cmbPref.ItemsSource, this.cmbPref.SelectedIndex);
                List<string> list = logic.setCity(val);

                // 都市ﾘｽﾄ設定
                WeatherReportsListData item = new WeatherReportsListData(list);
                this.cmbCity.ItemsSource = item.List;
            }
        #endregion
        //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,

        //''''''''''''''''''''''''''''''''''''''''''''''''''
        #region " '検索ｲﾍﾞﾝﾄ"
            /// <summary>
            /// 検索ﾎﾞﾀﾝ押下
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void Search_Click(object sender, RoutedEventArgs e)
            {
                // 地域未選択の場合はﾒｯｾｰｼﾞを表示
                if (this.cmbCity.SelectedIndex == -1)
                {
                    MessageBox.Show(WeatherReportsConst.ERROR_1);
                    return;
                };

                try
                {
                    String val = logic.getSelectItem((List<ListItemData>)this.cmbCity.ItemsSource, this.cmbCity.SelectedIndex);
                    WeatherReportsContentsData ret = logic.getRequest(val);
                    setCommonItem(ret);
                    setDetailItem(ret.Items);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(WeatherReportsConst.ERROR_2);
                    clsLogManager.writeLog(ex);
                }
            }
            /// <summary>
            /// 共通項目設定
            /// </summary>
            /// <param name="pItem"></param>
            private void setCommonItem(WeatherReportsContentsData pItem)
            {
                this.WeatherReportsArea.Text = pItem.Title;
                this.WeatherReportsTime.Text = pItem.Time;
                this.TextBlock.Text = pItem.Text;
                this.PublicTime.Text = pItem.PublicTime;
            }
            /// <summary>
            /// 詳細項目設定
            /// </summary>
            /// <param name="pItem"></param>
            private void setDetailItem(List<WeatherReportsItem> pList)
            {
                int cnt = 0;
                foreach (WeatherReportsItem item in pList)
                {
                    switch (cnt)
                    {
                        case 0:
                            setToday(item);
                            break;
                        case 1:
                            setTommorow(item);
                            break;
                        case 2:
                            setDayAfterTommorow(item);
                            break;
                    }
                    cnt++;
                }
            }
            /// <summary>
            /// 当日分設定
            /// </summary>
            /// <param name="pItem"></param>
            private void setToday(WeatherReportsItem pItem)
            {
                this.WeatherReportsAreaDate1.Text = pItem.Date;
                this.WeatherReportsTelop1.Text = pItem.Telop;
                this.TodayMaxTemp.Text = pItem.MaxTemp;
                this.TodayMinTemp.Text = pItem.MinTemp;
                this.imgToday.Source = new BitmapImage(new Uri(pItem.Image));
            }
            /// <summary>
            /// 翌日分設定
            /// </summary>
            /// <param name="pItem"></param>
            private void setTommorow(WeatherReportsItem pItem)
            {
                this.WeatherReportsAreaDate2.Text = pItem.Date;
                this.WeatherReportsTelop2.Text = pItem.Telop;
                this.TommorowMaxTemp.Text = pItem.MaxTemp;
                this.TommorowMinTemp.Text = pItem.MinTemp;
                this.imgTommorow.Source = new BitmapImage(new Uri(pItem.Image));
            }
            /// <summary>
            /// 明後日分設定
            /// </summary>
            /// <param name="pItem"></param>
            private void setDayAfterTommorow(WeatherReportsItem pItem)
            {
                this.WeatherReportsAreaDate3.Text = pItem.Date;
                this.WeatherReportsTelop3.Text = pItem.Telop;
                this.DayAfterTommorowMaxTemp.Text = pItem.MaxTemp;
                this.DayAfterTommorowMinTemp.Text = pItem.MinTemp;
                this.imgDayAfterTommorow.Source = new BitmapImage(new Uri(pItem.Image));
            }
        #endregion
        //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
    }
}
