   M S B A M L   `   `   `  ����>  :LW4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LW4LW4  5   	       LW4.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:LW4     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      ��  �� Orientation$ Vertical=�6   .+�5
   
   �� $	��4.1��6   ]� 5   
   $��5q�6   .+�5      �� $��Введіть текст��6   �� 5      $��5,0,0,0q�6   ��6'   �� *Text41+ �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5   
   $ 
Horizontal=�6   .+�5      �� $��5,0,0,0q�69   $��Шукати��6J   $
��Left=�6[   ��6   �� *SearchCommand41+6[   �� 5      ��6   �� *
Output41+$ PropertyChanged=� �� Mode$ OneWay=�5      �� 5   
   $	��4.2��6   ]� 5   
   $��5q�6   .+�5      �� $��Введіть текст��6   �� 5      $��5,0,0,0q�6   ��6'   �� *Text42+$ PropertyChanged=�5      �� 5   
   $ 
Horizontal=�6   .+�5      �� $��5,0,0,0q�69   $��Шукати��6J   $
��Left=�6[   ��6   �� *SearchCommand42+6[   �� 5      ��6   �� *
Output42+$ PropertyChanged=�$ OneWay=�5      �� 5   
   $	��4.3��6   ]� 5   
   $��5q�6   .+�5      �� $��Введіть текст��6   �� 5      $��5,0,0,0q�6   ��6'   �� *Text43+$ PropertyChanged=�5       �� 5!   
   $ 
Horizontal=�6   .+�5"      �� $��5,0,0,0q�69   $��Видалити��6J   $
��Left=�6]   ��6   �� *DeleteCommand43+6]   5$      �� 5&   
   $	��4.4��6   ]� 5'   
   $��5q�6   .+�5(      �� $��Введіть текст��6   �� 5)      $��5,0,0,0q�6   ��6'   �� *Text44+$ PropertyChanged=�5*      �� 5+   
   $ 
Horizontal=�6   .+�5-      �� $	��100��6   $��5,0,0,0q�6"   ��63   �� *Word44+$ PropertyChanged=��� 5/      $	��100��6   $��5,0,0,0q�6"   ��63   �� *	Replace44+$ PropertyChanged=��� 50      $��5,0,0,0q�6:   $��Замінити��6K   $
��Left=�6^   ��6   �� *ReplaceCommand44+6^   52      53      54      