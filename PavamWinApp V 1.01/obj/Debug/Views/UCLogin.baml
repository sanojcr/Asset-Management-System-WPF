   M S B A M L   `   `   `  ����F  BPavamWinApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PavamWinAppPavamWinApp  5          PavamWinApp.UCLogin   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      %localclr-namespace:PavamWinApp  5      .��5      �� -   5          ��Name$  	UCLoginSP��5      .+�5   
   �  � RowDefinitions 5      �� 5      $��30 �6    �� 5      $	��470 �6    .+�5      � -   5        $��1��5      
����2��.+�5      �� $��Center=�6   $��Center=�67   $��Adobe Gothic Std B)�6T   $��14(�6t   
�������Pavam Version 1.06�   �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�66   $	��105��6R   .+�5      �� -   5           MaterialDesignToolButton#��[  5      $��30��6O   $��30��6[   
�������.��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�62   ��6H   Z� ��6^   Z� 6x   5      �� 5      -   5        #��[  5      $��30��6O   $��30��6[   
�������.��5        $ WindowMaximize=�62   ��6H   Z� ��6^   Z� 6x   5      �� 5      -   5        #��[  5      $��30��6O   $��30��6[   
�������.��5        $ WindowClose=�62   ��6E   Z� ��6[   Z� 6u   5      5      5       � 5!      $��2��6   
�������.+�5"      � .+�5#      ��  �� RadiusX$ 10��6     �� RadiusY$ 10��6-   ���	#FFFDFDFD6:   �� 5$      $��/Assets/loginBg.jpg��6   $��	390,0,0,0q�69    �� StretchDirection$ DownOnly=�6L   $��UniformToFill=�6h   6�   �� 5%      $��	390,0,0,0q�6    ��5&      �� 5'       �� 
StartPoint$ 0,1.2&�62    �� EndPoint$
 0,.3&�6E   .��5(   "   � 	 � Color$	 	#FF7C76FD��6/   
 � Offset$
 1Q�6A   6N   � 5)   "   $	 	#FF93D322��6/   6C   � 5*   "   $	 	#80D749DE��6/   $

 0.36Q�6A   6Q   5+      5-      �� 5.      $��	390,0,0,0q�6    
���   � J� Opacity$	 0.5Q�6@   �� 5/      $��436,156,44,166q�6!   .+�50      �� $��/Assets/NewEdition.png��6    $	��150��6@   $
��10,0q�6M    J� RenderTransformOrigin$ 0.133,1.197&�6[   51      � 52      $��608,356,149,88q�6    .+�53      �� $��20(�6$   
�������$��Freestyle Script)�6E   �� 6d   $�
Powered by��6h   6}   54      � 55      $��662,367,61,69q�6    .+�56      �� $��20(�6$   
�������$#��Brilliantte Presonal Use Only)�6E   	Sanoj C R6{   57      � 58      $��	0,0,352,0q�6   .+�59      �� $��Login��6    $��60(�60   $��20,36,115,365q�6>   $��Adobe Arabic)�6U   $
��Bold"�6o   6�   �� 5:      $��25(�6$   $��Adobe Arabic)�62   $��26,99,0,341q�6L   $
��Left=�6a   $	��343��6|   &$Hi Welcome back to Pavam Version 1.06�   �� 5;      $��15(�6$   $��Adobe Song Std L)�62   $��26,154,0,285q�6P   $
��Left=�6f   $	��352��6�   +)If you have lot of money, Don't waste it.6�   �� 5<      $��15(�6$   $��Adobe Song Std L)�62   $��26,176,0,261q�6P   $
��Left=�6f   $	��329��6�   42Sometimes fate can take all these monies from you.6�   �� 5=      $��20,218,92,137q�6%   .+�5>      � $��5q�6$   .+�5?        $
 User=�66   $��25��5@   6   $��30��5A   6   $��Center=�5B   6   $��5q�5C   6   �� 5D      -   5         ��Name$ EmailTb��5D   &    * &MaterialDesignOutlinedTextFieldTextBox#��[ 5E   &   $��Center=�5F   &   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ User id��5G   &      
Foreground
 �   �$	��280��5I   &   $��40��5J   &   ��62   Z� 6J   5K      � 5L      $��5q�6(   .+�5M   "     $	 Key=�6:   $��25��5N   :   $��30��5O   :   $��Center=�5P   :   $��5q�5Q   :   G� 5R      -   5         G�Name$ 
PasswordTb��5R   *    2 .MaterialDesignOutlinedPasswordFieldPasswordBox#��[ 5S   *   $��Center=�5T   *   $ Password��5U   *   
 �   �$	��280��5W   *   68   5X      5Y      �� 5Z      $��53,338,163,111q�6%   .+�5[      �� $��5,0,0,1q�6'   $��10,0,0,0q�69   -  'MaterialDesignThemes.Wpf.CheckBoxAssist   CheckBoxSize$ 15Q�6K   .��6{   Remember me6�   5\      � 5^      $��66,379,163,43q�6$   .+�5_      �� -   5         ��Name$ Signin��5_   %   $
��Left=�65   $��85��6k   .��6v   Signin6~   � 5`      .+�5a   "   �� $	��9,6q�6-   $��12��6:   or6I   5b      �� 5c      -	   5        $ Signup��5c   %   $��Right=�65   
��� � �
��� � �$��85��6�   .��6�   Signup6�   5d      5e      5f      5h      5i      5j      5k      