   M S B A M L   `   `   `  ���� I  EWeatherReports, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WeatherReportsWeatherReports  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem     WeatherReports.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:WeatherReports     6sys&clr-namespace:System;assembly=mscorlib       � Title$  
MainWindow��$��412.544��$��667.544�� � ShowInTaskbar .   � WindowStyle$
 None=�$��0q� � SizeToContent$ WidthAndHeight=� � 
ResizeMode$ NoResize=� � 	Resources +  %WeatherReports.WeatherReportsListData   cmbData  NormalSearchButtonBrush �� Color  NormalSearchBackgroundBrush  HoverSearchButtonBrush  HoverSearchBackgroundBrush  NormalCloseButtonBrush  NormalCloseBackgroundBrush  HoverCloseButtonBrush  HoverCloseBackgroundBrush 	 NormalComboBoxBrush !
 NormalComboBoxBackgroundBrush  HoverComboBoxBrush   HoverComboBoxBackgroundBrush  HoverSearchButtonStyle �� 
TargetType �� Property	 �� Value
 �� 
TargetType �� Triggers P� Property P� Value �� 
TargetName  HoverCloseButtonStyle  HoverSearchComboBoxStyle��%�  &	        &	      &	      &	 /     &	 D     &	 Y     &	 n     &	 �     &	 �     &		 �     &	
 �     &	 �     &	 �     &	     7  7  7  7  7  7  7  &	 ]    7  7  7  7  7  7  7  &	 �      �� $ 	#FFFF8D1A���� $ 	#FFFF8D1A���� $ 	#FFFFBD5A���� $ 	#FFFFBD5A���� $ 	#FFF10E0E���� $ 	#FFF10E0E���� $ 	#FFF14E4E���� $ 	#FFF14E4E���� $ 	#FF98BB53���� $ 	#FF98BB53���� $ 	#FF98BB53���� $ 	#FF98BB53���� " ��.���  � ��8	   ��  � ��	 �� "
 ��.R��� $��HoverButtonBorder��$��2q�8�� 8�� ._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ��� $ HoverButtonBorder��8	   � ���� $ HoverButtonBorder��8	   � ���� 8	   � ��P�  � �� . . ��� $ HoverButtonBorder��8	   � ���� " ��.���  � ��8	   ��  � ��	 �� "
 ��.R��� $��HoverButtonBorder��$��2q�8�� 8�� ._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ��� $ HoverButtonBorder��8	   � ���� $ HoverButtonBorder��8	   � ���� 8	   � ��P�  � �� . . ��� $ HoverButtonBorder��8	   � ���� " ��.���  � ��	 �	#FF632523��  � ��	 �	#FF98BB53��  � ��	 �	#FF98BB53 � Triggers :�  :� RoutedEvent$ FrameworkElement.Loaded��.��� ���	#FFC2D69A$
��Left=�$	��667��.+��� -    � Cursor$
 Hand��$
��Left=�$	��412��$��0,1,0,0q�$	��Top=�$	��512�����	#FFC2D69A�� .+��� $
��Auto=�$��Hidden=�
 �� Top$	 282��.���� -    ��Name$ 	TextBlock��$
��Left=�$	��110��$��25,0,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��456�����	#FFEAF1DD$��0q� � UseLayoutRounding . $��0q� �� 
IsReadOnly . �� $
��Left=�$	��412��$��	512,0,0,0q�$	��Top=�$	��155�����	#FF75923C.+��� -    ��Name$ cmbArea��#��[ $��22�� �� Left$ 10��$ 47��$	��135��$
 Hand��$��0q��� -   $ cmbPref��#��[ $��22��$ 10��$ 96��$	��135��$
 Hand��$��0q��� -   $ cmbCity��#��[ $��22��$ 10��$	 144��$	��135��$
 Hand��$��0q��� -    ��Name$
 Area��$��19��$ 17��$
��Wrap=�$��地方��$ 29��$��58�����	#FFEAF1DD�� -   $
 Pref��$��19��$ 17��$
��Wrap=�$��都道府県��$ 78��$��58�����	#FFEAF1DD�� -   $
 City��$��19��$ 17��$
��Wrap=�$��地域��$	 127��$��58�����	#FFEAF1DD�� -	    ��Name$ Search��#��[ $�� ��$��30��$ 10��$	 361��$��47��$
 Hand��$��2q��� -
   $ Close��#��[ $�� ��$��30��$ 98��$	 361��$��47��$
 Hand���� -   $ WeatherReportsArea��$
��Left=�$��	25,21,0,0q�$
��Wrap=�$��--��$	��Top=����	#FF632523$��16(��� -   $ WeatherReportsAreaDate1��$
��Left=�$��	50,50,0,0q�$
��Wrap=�$��--/--��$	��Top=����	#FF632523$��13.333(��� -   $ WeatherReportsAreaDate2��$
��Left=�$��
216,50,0,0q�$
��Wrap=�$��--/--��$	��Top=����	#FF632523$��13.333(��� -   $ WeatherReportsAreaDate3��$
��Left=�$��
372,50,0,0q�$
��Wrap=�$��--/--��$	��Top=����	#FF632523$��13.333(��� -    ��Name$ imgToday��$
��Left=�$	��100��$��	50,75,0,0q�$	��Top=�$	��100���� -   $ imgDayAfterTommorow��$
��Left=�$	��100��$��
372,75,0,0q�$	��Top=�$	��100���� -   $ imgTommorow��$
��Left=�$	��100��$��
216,75,0,0q�$	��Top=�$	��100���� -   $ imgTodayMaxTemp��$��image/maxtemp.png��$
��Left=�$��24��$��
65,213,0,0q�$	��Top=�$��24���� -   $ imgTodayMinTemp��$��image/mintemp.png��$
��Left=�$��24��$��
65,241,0,0q�$	��Top=�$��24���� -   $ TodayMaxTemp��$
��Left=�$��
94,215,0,0q�$
��Wrap=�$
��-℃��$	��Top=����	#FF632523�� -   $ TodayMinTemp��$
��Left=�$��
94,245,0,0q�$
��Wrap=�$
��-℃��$	��Top=����	#FF632523�� -   $ imgTommorowMaxTemp��$��image/maxtemp.png��$
��Left=�$��24��$��236,213,0,0q�$	��Top=�$��24���� -   $ imgTommorowMinTemp��$��image/mintemp.png��$
��Left=�$��24��$��236,241,0,0q�$	��Top=�$��24���� -   $ TommorowMaxTemp��$
��Left=�$��265,215,0,0q�$
��Wrap=�$
��-℃��$	��Top=����	#FF632523�� -   $ TommorowMinTemp��$
��Left=�$��265,245,0,0q�$
��Wrap=�$
��-℃��$	��Top=����	#FF632523�� -   $  imgDayAfterTommorowMaxTemp��$��image/maxtemp.png��$
��Left=�$��24��$��397,213,0,0q�$	��Top=�$��24���� -   $  imgDayAfterTommorowMinTemp��$��image/mintemp.png��$
��Left=�$��24��$��397,241,0,0q�$	��Top=�$��24���� -   $ DayAfterTommorowMaxTemp��$
��Left=�$��426,215,0,0q�$
��Wrap=�$
��-℃��$	��Top=����	#FF632523�� -   $ DayAfterTommorowMinTemp��$
��Left=�$��426,245,0,0q�$
��Wrap=�$
��-℃��$	��Top=����	#FF632523�� -   $ 
PublicTime��$
��Left=�$��332,266,0,0q�$
��Wrap=�$"��(----/--/-- --:--:-- 現在)��$	��Top=����	#FF632523$��10.667(��� -   $ WeatherReportsTime��$
��Left=�$��
351,25,0,0q�$
��Wrap=�$��----/--/-- --:--:--��$	��Top=����	#FF632523�� -    $ WeatherReportsTelop1��$
��Left=�$��
50,185,0,0q�$
��Wrap=�$��--��$	��Top=����	#FF632523$��13.333(��� -!   $ WeatherReportsTelop2��$
��Left=�$��216,185,0,0q�$
��Wrap=�$��--��$	��Top=����	#FF632523$��13.333(��� -"   $ WeatherReportsTelop3��$
��Left=�$��372,185,0,0q�$
��Wrap=�$��--��$	��Top=����	#FF632523$��13.333(�