   M S B A M L   `   `   `  ���� ?  ;BAI1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BAI1BAI1      BAI1.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $localclr-namespace:BAI1     U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Icon$  app_icon.ico�� � Title$ Tool Check Game��$	��450��$
��1000��$
��1000��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���  .��� .+�)  #MaterialDesignThemes.Wpf.DialogHost  -   $��
DialogHost��   IsOpen �� *IsShowDialog+   DialogContent �� $��16q�.+��  % !MaterialDesignCircularProgressBar#���  $��Center=�$��16q� � IsIndeterminate .  � Value$ 0Q��� -   $��Loading�����	#FF808080���� *LoadingText+.��� .+�� ���	#FFF5F5F5 � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+��� $��0��$��Bottom=�$
��10 5q����� *Status+&   System.Windows.Controls.DataGrid  -   $��dataGrid��-  'MaterialDesignThemes.Wpf.DataGridAssist	   CellPadding$	 13 8 8 8q�
   ColumnHeaderPadding$
 8q�$��1��   AutoGenerateColumns .     CanUserReorderColumns .     CanUserAddRows .  $��0, 0, 0, 10q�   CanUserDeleteRows .     CanUserResizeRows .  ���� *
Accounts+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$	 STT��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Index+   . $ Username�� �� *
Username+   . $ Mật khẩu�� �� *
Password+   . $ Nickname�� �� *
Nickname+   . $ 	Vip Point�� �� *
VipPoint+ �� StringFormat$ {0:N0}��   . $ Gold Balance�� �� *GoldBalance+$ {0:N0}��   . $ Coin Balance�� �� *CoinBalance+$ {0:N0}��   . $ Stock Balance�� �� *StockBalance+$ {0:N0}��   . $ Mobile�� �� *Mobile+   . $ Telesafe�� �� *
Telesafe+4  .System.Windows.Controls.DataGridTemplateColumn   .    CellTemplate �� .R��� ���� *Status+���� *
Foreground+� $��2�� � ColumnDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+��� $��0��$
��10 5q� �� Orientation$ 
Horizontal=�.+��� )	  #MaterialDesignThemes.Wpf.HintAssist 	  Hint$ 
Nhập URL��$��Center=�$��5q�$	��200������ *AccountsLink+�� ���	#FFFFFFFF���	#FF008080���	#FF008080 * &MaterialDesignFloatingActionMiniButton#��[  � ToolTip$ Load tài khoản��$��30��$��30��$��10(�$��Right=�$��Center=�$��5q�$��1������ *LoadAccountsCommand+.��'
  !MaterialDesignThemes.Wpf.PackIcon
  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ Download=��� $��1��$	��5 0q�$��Center=�$ 
Horizontal=�.+��� $	��5 0q�$��Cổng game��$
��Bold"�$��Center=� �� TextAlignment$ Center=��� $
��Left=�$��Center=�$	��120��$
��10 5q� �� SelectedIndex$ 0��$��2�� �� DisplayMemberPath$
 Name������  �� Path$ 	GameGates� �� SelectedItem �� $ GameGate��� $��2��$
��30 0q�$��Center=�$ 
Horizontal=�$��Right=�.+��� $
��10 5q�$��
Check két��  d� 	IsChecked  �� *IsCheckAccountStock+�� -   $��Login�����	#FFFFFFFF���	#FF008080���	#FF008080#��[ $ Bắt đầu check��$��30��$��30��$��10(�$��Right=�$��Center=�$��5q�$��1������ *LoginCommand+���� ! �� ElementName$! Login��.��
  $ CheckAll=��� -   $��Export�����	#FFFFFFFF���	#FF6495ED���	#FF6495ED#��[ $ Xuất ra file��$��30��$��30��$��10(�$��Right=�$��Center=�$��5q�$��1������ *ExportCommand+���� $! Export��.��
  $ 
FileExport=��� -   $��Filter�����	#FFFFFFFF���	#FFFFA500���	#FFFFA500#��[ $ Lọc tài khoản đúng��$��30��$��30��$��10(�$��Right=�$��Center=�$��5q�$��1������ *FilterAccountCommand+���� $! Filter��.��
  $ Filter=�