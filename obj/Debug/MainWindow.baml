   M S B A M L   `   `   `  ����D  @StoragePC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:StoragePC	StoragePC  5   	       StoragePC.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:StoragePC     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$n  hПриложение для учета компьютеров и периферийной техники��5	   	   $	��600��6I   $	��800��6V    � WindowStartupLocation$ CenterScreen=�5
   	   $	��700��5   	   $
��1000��6   .��5      � ���#0e0e0f.+�5   
   �� $	��400��6   $��15q�6    
�������$��Center=�6?    �� Padding$ 30q�6Z   $	��550��6g    �� CornerRadius$ 20��6v    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$	 500Q�6#      Color$
 Blue��64      ShadowDepth$ 0Q�6A   6S   ._�5      �� .+�5      � $��0 0 0 20q�6   .+�5      �� $��Здравствуйте!��6    $��30(�65   $
��Bold"�6C   $��
0,0,280,20q�6U   �� 5      $!��Resources/logo_2020_250.jpg��6   $��61��6A   $��	379,0,0,0q�6M   5      � 5      $��0 0 0 20q�6   .+�5      �� -   5         ��Name$ Bt_Reg��5      $
��Left=�6-   $��Регистрация��6H      MaterialDesignFlatButton#��[  6_   6�   �� 5      -   5        $ BtLog��5      $��Right=�6,   $��
Войти��6H   #��[  6Y   6�   �� 5      -   5        $ test1��5      $��Right=�6,   $��
Войти��6H   #��[  6Y   $��0,0,98,0q�6�   5      �� 5      -   5        	 ��Name$	 Tx_Log��5      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Ведите логин��6*    % !MaterialDesignFloatingHintTextBox#��[ 6Y   6�   G� 5      -   5         G�Name$ PassBx��5      $
 Ведите Пароль��6.    ) %MaterialDesignFloatingHintPasswordBox#��[ 6]   6�   � 5      $��0 10 0 0q�6   .+�5       �� -   5        $ BtClose��5       $
��Left=�6-   $��
Выйти��6H   #��[  6Y   6�   5!      5#      5$      5%      5&      