   M S B A M L   `   `   `  ����?  ;BAI1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BAI1BAI1  5   	       BAI1.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:BAI1     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	     � Icon$  app_icon.ico��5   	    � Title$ Tool Check Game��5	   	   $	��450��6!   $
��1000��6.   $
��1000��6>      MaterialDesignBody#���   5   
   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper#���  5   
     MaterialDesignFont#���  5   
   .��5      � .+�5   
   )  #MaterialDesignThemes.Wpf.DialogHost  -   5        $��
DialogHost��5         IsOpen 5      �� *IsShowDialog+   DialogContent 5      �� 5      $��16q�5      .+�5      �  % !MaterialDesignCircularProgressBar#���  5      $��Center=�5      $��16q�5       � IsIndeterminate .  � Value$ 0Q�5      �� 5      -   5        $��Loading��5       ���	#FF808080��5"      �� *LoadingText+5#      .��5%      � .+�5&      � ���	#FFF5F5F5 � RowDefinitions 5(      �� 5)      $
��Auto �5*      �� 5+      $��* �5,      �� 5-      $
��Auto �5.      .+�50      �� $��0��51      $��Bottom=�52      $
��10 5q�53      ��54      �� *Status+&   System.Windows.Controls.DataGrid  55      -   5        $��dataGrid��56      -  'MaterialDesignThemes.Wpf.DataGridAssist	   CellPadding$	 13 8 8 8q�57      
   ColumnHeaderPadding$
 8q�58      $��1��59         AutoGenerateColumns .     CanUserReorderColumns .     CanUserAddRows .  $��0, 0, 0, 10q�5=         CanUserDeleteRows .     CanUserResizeRows .  ��5@      �� *
Accounts+   Columns 5A      0  *System.Windows.Controls.DataGridTextColumn  5B      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$	 STT��5D      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5E      �� *Index+  5F       . $ Username��5H       5I      �� *
Username+  5J       . $ Mật khẩu��5L       5M      �� *
Password+  5N       . $ Nickname��5P       5Q      �� *
Nickname+  5R       . $ 	Vip Point��5T       5U      �� *
VipPoint+ �� StringFormat$ {0:N0}��  5V       . $ Gold Balance��5X       5Y      �� *GoldBalance+$ {0:N0}��  5Z       . $ Coin Balance��5\       5]      �� *CoinBalance+$ {0:N0}��  5^       . $ Stock Balance��5`       5a      �� *StockBalance+$ {0:N0}��  5b       . $ Mobile��5d       5e      �� *Mobile+  5f       . $ Telesafe��5h       5i      �� *
Telesafe+4  .System.Windows.Controls.DataGridTemplateColumn  5j       .    CellTemplate 5l   "   �� 5m   &   .R�5n   *   �� ��5o      �� *Status+��5p      �� *
Foreground+5q   '   5s      5u      � 5v      $��2��5w       � ColumnDefinitions 5x      �� 5y      $
��Auto �5z      �� 5{      $��* �5|      �� 5}      $
��Auto �5~      .+�5�      �� $��0��5�      $
��10 5q�5�       �� Orientation$ 
Horizontal=�5�      .+�5�      �� )	  #MaterialDesignThemes.Wpf.HintAssist 	  Hint$ 
Nhập URL��5�      $��Center=�5�      $��5q�5�      $	��200��5�      ��5�      �� *AccountsLink+�� 5�      ���	#FFFFFFFF���	#FF008080���	#FF008080 * &MaterialDesignFloatingActionMiniButton#��[ 5�       � ToolTip$ Load tài khoản��5�      $��30��5�      $��30��5�      $��10(�5�      $��Right=�5�      $��Center=�5�      $��5q�5�      $��1��5�      ��5�      �� *LoadAccountsCommand+.��5�   "   '
  !MaterialDesignThemes.Wpf.PackIcon
  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ Download=�5�   !   5�      5�      �� 5�      $��1��5�      $	��5 0q�5�      $��Center=�5�      $ 
Horizontal=�5�      .+�5�      �� $	��5 0q�5�      $��Cổng game��5�      $
��Bold"�5�      $��Center=�5�       �� TextAlignment$ Center=�5�      �� 5�      $
��Left=�5�      $��Center=�5�      $	��120��5�      $
��10 5q�5�       �� SelectedIndex$ 0��5�      $��2��5�       �� DisplayMemberPath$
 Name��5�      ��5�      ��  �� Path$ 	GameGates� �� SelectedItem 5�      �� $ GameGate�5�      �� 5�      $��2��5�      $
��30 0q�5�      $��Center=�5�      $ 
Horizontal=�5�      $��Right=�5�      .+�5�      �� $
��10 5q�5�      $��
Check két��5�        d� 	IsChecked  5�      �� *IsCheckAccountStock+�� 5�      -   5        $��Login��5�      ���	#FFFFFFFF���	#FF008080���	#FF008080#��[ 5�      $ Bắt đầu check��5�      $��30��5�      $��30��5�      $��10(�5�      $��Right=�5�      $��Center=�5�      $��5q�5�      $��1��5�      ��5�      �� *LoginCommand+��5�      �� ! �� ElementName$! Login��.��5�   "   
  $ CheckAll=�5�   	   5�      �� 5�      -   5        $��Cacel��5�      ���	#FFFFFFFF���	#FF008080���	#FF008080#��[ 5�      $ Dừng Lại��5�      $��30��5�      $��30��5�      $��10(�5�      $��Right=�5�      $��Center=�5�      $��5q�5�      $��1��5�      ��5�      �� *CancelButton+��5�      �� $! Cacel��.��5�   "   
  $
 Stop=�5�   	   5�      �� 5�      -   5        $��Export��5�      ���	#FFFFFFFF���	#FF6495ED���	#FF6495ED#��[ 5�      $ Xuất ra file��5�      $��30��5�      $��30��5�      $��10(�5�      $��Right=�5�      $��Center=�5�      $��5q�5�      $��1��5�      ��5�      �� *ExportCommand+��5�      �� $! Export��.��5�   "   
  $ 
FileExport=�5�   	   5�      �� 5�      -   5        $��Filter��5�      ���	#FFFFFFFF���	#FFFFA500���	#FFFFA500#��[ 5�      $ Lọc tài khoản đúng��5�      $��30��5�      $��30��5�      $��10(�5�      $��Right=�5�      $��Center=�5      $��5q�5     $��1��5     ��5     �� *FilterAccountCommand+��5     �� $! Filter��.��5  "   
  $ Filter=�5  	   5     5     5	     5
     5     5     5     5     