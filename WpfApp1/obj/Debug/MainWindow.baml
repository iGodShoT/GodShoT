   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfApp1.ViewModelsWpfApp1.ViewModels  5   	   /clr-namespace:WpfApp1.ModelsWpfApp1.Models  5   	   !clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7
viewmodels clr-namespace:WpfApp1.ViewModels     5   	   2	enumlocalclr-namespace:WpfApp1.Models     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  Авторизация��5
   	   $	��450��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�66    � DataContext 5      /   )WpfApp1.ViewModels.AuthorizationViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��
Логин��6   $��20(�6!   $��0��6/   $��1��6?   $��Center=�6L   $��Center=�6i   $��	0,-35,0,0q�6�   �� 5   
   $��Пароль��6   $��20(�6"   $��0��60   $��1��6@   $��Center=�6M   $��Center=�6j   $��0,35,0,0q�6�   �� 5   
   $��1��6   $��1��6"   $��Stretch=�6/   $��Center=�6M   $��	0,-35,0,0q�6h   ��6{   �� *Login+ �� Mode$ TwoWay=�G� 5   
   -   5         G�Name$ passwordBox��5      $��1��6+   $��1��6;   $��Stretch=�6H   $��Center=�6f   $��0,35,0,0q�6�   �� 5   
   $��1��6   $��2��6!   $��Stretch=�6.   $	��Top=�6L   $��30��6d   $��
Войти��6p   ��6�   �� *Authorization+��6�   ��  �� ElementName$ passwordBox��5      5      