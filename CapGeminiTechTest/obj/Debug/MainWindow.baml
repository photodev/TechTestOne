   M S B A M L   `   `   `  ����L  HCapGeminiTechTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CapGeminiTechTestCapGeminiTechTest  5   	   "    CapGeminiTechTest.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CapGeminiTechTest     5   	     � Title$  Shopping Basket��5   	   $	��350��6!   $	��525��6.    � 	Resources 5	         ScanItemCommand �� Text  CloseCommand��%V   &	        &	 #     �� 5
      $ 	Scan Item��60   �� 5      $ Close��6+   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5      -   5           Command# [  5      5        5      -   5        # [ 5      5      .��5      � .+�5      ]� ��. .+�5      � $��Bottom=�6   .+�5   
   �� -   5         ��Name$ 
pnlButtons��5      $��0q�6)   $��35��64   $��Right=�6@    �� Orientation$ 
Horizontal=�6]   $��Bottom=�6v   .+�5      �� #��[ 6   $��Close��6;   $��92��6K   $��5,5,16,5q�6V    �� IsCancel . 6h   5      5   	   � 5       � ColumnDefinitions 5   
   �� 5      $��15 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��15 �6   	 � RowDefinitions	 5"   
   �� 5#      $��15 �6   �� 5$      $
��Auto �6   �� 5%      $��* �6   �� 5&      $��* �6   �� 5'      $��30 �6   �� 5(      $
��Auto �6   �� 5)      $��15 �6   .+�5+   
   �� -   5        $��cboShopping��5+      $��25��6&   $��3q�62   $��1��6=   $��1��6M   �� 5,   
   #��[  6   $��	Scan Item��6<   $��25��6P   $��3q�6\   $��2��6g   $��1��6w   �� 5-   
   -   5        $��	lstBasket��5-      
 �� DisplayMemberPath$
 Description��6;   $��3q�6[   $��3��6f   $��1��6v   $��3��6�   ��6#   �� 6�   �� 5.   
   $��Total:��6   $��14(�6!   $
��Bold"�6/   $��Right=�6A   $��27��6]   $��3q�6i   $��2��6t   $��5��6�   �� 5/   
   -   5        $��txtTotal��5/       �� TextAlignment$ Right=�6$   $��14(�6:   $��Medium"�6H   $��25��6\   $��3,3,5,3q�6h   $��3��6y   $��5��6�   50   	   51      52      53      