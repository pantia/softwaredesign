   M S B A M L   `   `   `  ����>  :LW8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:LW8.ViewLW8.View  5   	   %clr-namespace:LW8.Model	LW8.Model  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5	   	   "    LW8.View.AddConstructionView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:LW8.View     5   	   )modelclr-namespace:LW8.Model     5      9System&clr-namespace:System;assembly=mscorlib     5	   	     � Title$)  #Додати конструкцію��5
   	    � SizeToContent$ WidthAndHeight=�6$    � WindowStartupLocation$ CenterScreen=�6C   $	��450��6h   $	��800��6u    � 	Resources 5       	  Types S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%�   &	        S� 5   
   $ 	GetValues��6+   "  5       5      M� 5      $ model:ConstructionState��6   5      5      .��5      ��  �� Orientation$ Vertical=�6   	 � IsSharedSizeScope	 . $��5q�6F    5   
   
 �� 
TargetType �� Property �� Value(  "System.Windows.Controls.DatePicker��%�  '��       '�� r     '� �     '  1    �� 5      "
 ��6   .�5      ��  � ��$	 200��6-   �� 5       � ��$ 5,0,0,0q�6+   5      �� 5      "
 ��6   .�5      ��  � ��$	 200��6-   �� 5       � ��$ 5,0,0,0q�6+   5      �� 5      "
 �6   .�5      ��  � ��$ 0,5,0,0q�6+   5       �� 5!      "
  6   .�5"      ��  � ��$	 200��6-   �� 5#       � ��$ 5,0,0,0q�6+   5$      5%      .+�5&   
   �  � ColumnDefinitions 5'      �� 5(       z� SharedSizeGroup$ A��6#   �� 5)      .+�5+      �� $��
Назва��6   �� 5,      $��1��6   ��6&   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�5-      � 5.   
    5/      �� 50      $ A��6#   �� 51      .+�53      �� $��Об'єкт��6   �� 54      $��1��6   ��6&   �� *
ObjectName+$ PropertyChanged=�55      � 56   
    57      �� 58      $ A��6#   �� 59      .+�5;      �� $��
Площа��6   �� 5<      $��1��6   ��6&   �� *Area+$ PropertyChanged=�5=      � 5>   
    5?      �� 5@      $ A��6#   �� 5A      .+�5C      �� $��Дата початку��6     5D      $��1��6<      SelectedDate 6   �� *	StartDate+6<   5F      � 5H   
    5I      �� 5J      $ A��6#   �� 5K      .+�5M      �� $#��Дата завершення��6     5N      $��1��6:    6   �� *	EndDate+6:   5P      � 5R   
    5S      �� 5T      $ A��6#   �� 5U      .+�5W      �� $��Стан��6   �� 5X      $��1��6    �� SelectedValue 6'   �� *State+��6G   ��  �� Source# [  5Y      �� 5[   
   $��Right=�6   $��Зберегти��6-   $��0,5,0,0q�6�   ��6@   �� *SaveCommand+��6`   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" �6�   5\      5]      