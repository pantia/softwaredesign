   M S B A M L   `   `   `  ����>  :LW8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:LW8.ViewLW8.View  5   	       LW8.View.Task4View   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:LW8.View     5   	     � Title$  Завдання 4��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65   .��5	      ��  �� Orientation$ Vertical=�6   .+�5
   
   �� �� 5      $�Кількість:��6    �� 5      �6   �� *Count+ �� Mode$ OneWay=�5      �� 5   
   $ 
Horizontal=�6   $��5q�6.   .+�5      �� $��Ключ��6   $��Center=�6$   �� 5      $��5,0,0,0q�6   $	��100��6f   ��6'   �� *
InputKey+ �� UpdateSourceTrigger$ PropertyChanged=�6f   �� 5      $��5,0,0,0q�6   $��Значення��6)   $��Center=�69   �� 5      $��5,0,0,0q�6   $	��100��6h   ��6'   �� *
InputValue+$ PropertyChanged=�6h   �� 5      $��5,0,0,0q�6   $��Додати��6&   ��67   �� *
AddCommand+5      �� 5   
   $ 
Horizontal=�6   $��5q�6.   .+�5      �� $��Ключ��6   $��Center=�6$   �� 5      $��5,0,0,0q�6   $	��100��6g   ��6'   �� *	DeleteKey+$ PropertyChanged=�6g   �� 5      $��5,0,0,0q�6   $��Видалити��6&   ��69   �� *DeleteCommand+5      �� 5   
   $��Очистити��6   $
��Left=�6E   $��5,0,0,0q�6`   ��6$   �� *ClearCommand+6`   �� 5   
   $ 
Horizontal=�6   $��5q�6.   .+�5      �� $��Ключ��6   $��Center=�6$   �� 5      $��5,0,0,0q�6   $	��100��6f   ��6'   �� *
CheckKey+$ PropertyChanged=�6f   �� 5      $��5,0,0,0q�6   $-��'Перевірити наявність��6&   ��6E   �� *CheckKeyCommand+�� 5      ��6   �� *CheckKeyOutput+$ PropertyChanged=�5       �� 5!   
   $ 
Horizontal=�6   $��5q�6.   .+�5"      �� $��Значення��6   $��Center=�6(   �� 5#      $��5,0,0,0q�6   $	��100��6h   ��6'   �� *
CheckValue+$ PropertyChanged=�6h   �� 5$      $��5,0,0,0q�6   $-��'Перевірити наявність��6&   ��6E   �� *CheckValueCommand+�� 5%      ��6   �� *CheckValueOutput+$ PropertyChanged=�5&      5'      5(      