   M S B A M L   `   `   `  ����F  BPavamWinApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PavamWinAppPavamWinApp  5          PavamWinApp.UCSignup   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      %localclr-namespace:PavamWinApp  5      $��502.5��5   3   .��5	      �� -   5          ��Name$  
UCSignupSP��5	      .+�5
      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $	��470 �6   .+�5   
   � -   5        $��1��5      
����2��.+�5      �� $��Center=�6   $��Center=�67   $��Adobe Gothic Std B)�6T   $��14(�6t   
�������Pavam Version 1.06�   �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�66   $	��105��6R   .+�5      �� -   5           MaterialDesignToolButton#��[  5      $��30��6K   $��30��6W   
�������.��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�6.   ��6D   Z� ��6Z   Z� 6t   5      �� 5      -   5        #��[  5      $��30��6K   $��30��6W   
�������.��5        $ WindowMaximize=�6.   ��6D   Z� ��6Z   Z� 6t   5      �� 5      -   5        #��[  5      $��30��6K   $��30��6W   
�������.��5        $ WindowClose=�6.   ��6A   Z� ��6W   Z� 6q   5      5      5      � 5   
   $��2��6   
�������.+�5      � .+�5       ��  �� RadiusX$ 10��6    �� RadiusY$ 10��6)   ���	#FFFDFDFD66   �� 5!      $��/Assets/loginBg.jpg��6   $��	390,0,0,0q�65    �� StretchDirection$ DownOnly=�6H   $��UniformToFill=�6d   6~   �� 5"      $��	390,0,0,0q�6   ��5#      �� 5$       �� 
StartPoint$ 0,1.2&�6.    �� EndPoint$
 0,.3&�6A   .��5%      � 	 � Color$	 	#FF7C76FD��6+   
 � Offset$
 1Q�6=   6J   � 5&      $	 	#FF93D322��6+   6?   � 5'      $	 	#80D749DE��6+   $

 0.36Q�6=   6M   5(      5*      �� 5+      $��	390,0,0,0q�6   
���   � J� Opacity$	 0.5Q�6<   �� 5,      $��436,156,44,166q�6   .+�5-      �� $��/Assets/NewEdition.png��6   $	��150��6<   $
��10,0q�6I    J� RenderTransformOrigin$ 0.133,1.197&�6W   5.      � 5/      $��608,356,122,88q�6   .+�50      �� $��20(�6    
�������$��Freestyle Script)�6A   �� 6`   $�
Powered by��6d   6y   51      � 52      $��662,367,44,69q�6   .+�53      �� $��20(�6    
�������$#��Brilliantte Presonal Use Only)�6A   	Sanoj C R6w   54      � 55      $��	0,0,410,0q�6   .+�56      �� $��Register��6    $��60(�63   $��20,36,115,365q�6A   $��Adobe Arabic)�6X   $
��Bold"�6r   6�   �� 57      $��25(�6    $��Adobe Arabic)�6.   $��26,99,0,341q�6H   $
��Left=�6]   $	��343��6x    Hi you can register here . . .6�   �� 59      $��20,129,10,111q�6%   .+�5:      � $��5q�6(   .+�5;   "     $
 User=�6:   $��25��5<   :   $��30��5=   :   $��Center=�5>   :   $��5q�5?   :   �� 5@   "   -   5         ��Name$ NameTb��5@   *    * &MaterialDesignOutlinedTextFieldTextBox#��[ 5A   *   $��Center=�5B   *   )  #MaterialDesignThemes.Wpf.HintAssist   
Foreground
 �   �   Hint$ Username��5D   *   $	��280��5E   *   
���   �66   5F      � 5G      $��5q�6(   .+�5H   "     $ Email=�6:   $��25��5I   :   $��30��5J   :   $��Center=�5K   :   $��5q�5L   :   �� 5M   "   -   5        $ EmailTb��5M   *   #��[ 5N   *   $��Center=�5O   *   
 �   �$ Email Id��5Q   *   $	��280��5R   *   68   5S      � 5T      $��5q�6(   .+�5U   "     $ Onepassword=�6:   $��25��5V   :   $��30��5W   :   $��Center=�5X   :   $��5q�5Y   :   G� 5Z   "   -   5         G�Name$ 
PasswordTb��5Z   .    2 .MaterialDesignOutlinedPasswordFieldPasswordBox#��[ 6B   $��Center=�5[   .   
 �   �$ Password��5]   .   $	��280��5^   .   6<   5_      � 5`      $��5q�6(   .+�5a   "     $ Onepassword=�6:   $��25��5b   :   $��30��5c   :   $��Center=�5d   :   $��5q�5e   :   G� 5f   "   -	   5        $ CPasswordTb��5f   .   #��[ 6C   $��Center=�5g   .   
 �   �$ Confirm password��5i   .   $	��280��5j   .   6<   5k      5l      �� 5m      $��53,338,163,111q�6%   .+�5n      �� -
   5         ��Name$ 	PrivacyCb��5n   #   $��5,0,0,1q�5o   #   $��10,0,0,0q�5p   #   -  'MaterialDesignThemes.Wpf.CheckBoxAssist   CheckBoxSize$ 15Q�5q   #   .��6S   Accept privacy policy5s      5t      � 5u      $��66,379,115,43q�6$   .+�5v      �� -   5         ��Name$ Register��5v   %   $
��Left=�67   
��� � �
��� � �$��85��6�   .��6�   
Register6�   � 5w      $��30��6(   .+�5x   "   �� $	��9,6q�6,   $��12��69   or6H   5y      �� 5z      -   5        $ Signin��5z   %   $��Right=�65   $��85��6l   .��6w   Signin6   5{      5|      5}      5      5�      5�      5�      