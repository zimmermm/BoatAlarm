   M S B A M L   `   `   `  ���� D  @BoatAlarm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BoatAlarm	BoatAlarm      BoatAlarm.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:BoatAlarm     -     �Name$
  Main�� � Title$ 
Boat Alarm��$��628.333��$	��850�����	#FF59777E � Icon$ sailing_boat.png�� � 	Resources    KeypadButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name	 �� Triggers
 P� Property P� Value �� 
TargetName��%�  &	        �� " ��.���  � ��
 �������  � ��$ 28(���  � ��$ Segoe UI)���  � �� �� " ��.R�� $��1q�.+��� $
 Rect��
��������� $��2q�$��Center=�$��Center=���. 	 P� 
 �@J�IsMouseOver . . ��� $
 Rect�� � ��
 �����P� 
 � �� . . ��� $
 Rect�� � ��
 ��� �P� 
 � {� .  . ��� $
 Rect�� � ��
 �����.���  � RowDefinitions �� $	��43* ��� $	��43* ��� $
��367* � � ColumnDefinitions �� $
��297* ��� $
��545* �.+��� -    ��Name$ button��$��Select Log File...��$
��Left=�$��	10,10,0,0q�$	��Top=�$	��117��$��23���� -    ��Name$ logFilePath_txtBox��$��23�� �� TextWrapping$
 Wrap=�$��Select a log file...��$	��Top=�$��
10,10,10,0q�$��1��$��2�� �� 
IsReadOnly . �� -    ��Name$ eventListBox��$��1��$��10q�$��2���� -   $ fastBoatButton��#���   $��	Fast Boat��$��10,119,10,0q�$��2��$	��Top=�$	��104���� -   $ bigBoatButton��#���   $��Big Boat��$��
10,10,10,0q�$��2��$	��Top=�$	��104���� -   $ slowBoatButton��#���   $��	Slow Boat��$��10,228,10,0q�$��2��$	��Top=�$	��104���� -   $ customMsgButton��#���   $��Custom msg...��$��10,337,10,0q�$��2��$	��Top=�$	��104��