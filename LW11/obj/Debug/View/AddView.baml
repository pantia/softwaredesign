   M S B A M L   `   `   `  ����?  ;LW11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:LW11.View	LW11.View  5   	   'clr-namespace:LW11.Model
LW11.Model  5   
   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5	   	       LW11.View.AddView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:LW11.View     5   	   *modelclr-namespace:LW11.Model     5   
   9System&clr-namespace:System;assembly=mscorlib     5	   	     � Title$  Додати��5
   	   $	��450��6   $	��800��6%    � WindowStartupLocation$ CenterScreen=�61    � SizeToContent$ WidthAndHeight=�6V    � 	Resources 5       	  Types S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%z   &	        S� 5   
   $ 	GetValues��6+   "  5       5      M� 5      $ model:SKLADType��6   5      5      .��5      ��  �� Orientation$ Vertical=�6   	 � IsSharedSizeScope	 . $��5q�6F    5   
   
 �� 
TargetType �� Property �� Value��%O  '��       '�� r     '� �     �� 5      "
 ��6   .�5      ��  � ��$	 200��6-   �� 5       � ��$ 5,0,0,0q�6+   5      �� 5      "
 ��6   .�5      ��  � ��$	 200��6-   �� 5       � ��$ 5,0,0,0q�6+   5      �� 5      "
 �6   .�5      ��  � ��$ 0,5,0,0q�6+   5      5       .+�5!   
   �  � ColumnDefinitions 5"      �� 5#       z� SharedSizeGroup$ A��6#   �� 5$      .+�5&      �� $��
Назва��6   �� 5'      $��1��6   ��6&   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�5(      � 5)   
    5*      �� 5+      $ A��6#   �� 5,      .+�5.      �� $��Тип��6   �� 5/      $��1��6    �� SelectedValue 6'   �� *Type+��6F   ��  �� Source# [  50      � 51   
    52      �� 53      $ A��6#   �� 54      .+�56      �� $��Кількість��6   �� 57      $��1��6   ��6&   �� *
Quantity+$ PropertyChanged=�58      � 59   
    5:      �� 5;      $ A��6#   �� 5<      .+�5>      �� $��Ціна��6   �� 5?      $��1��6   ��6&   �� *Cost+$ PropertyChanged=�5@      �� 5B   
   $��Right=�6   $��Зберегти��6-   $��0,5,0,0q�6�   ��6@   �� *SaveCommand+��6`   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" �6�   5C      5D      