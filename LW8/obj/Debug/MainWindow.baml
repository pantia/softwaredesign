   M S B A M L   `   `   `  ����>  :LW8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LW7LW7  5   	       LW7.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:LW7     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65   .��5	      ]� $��5q�6   .+�5
   
   � $	��Top=�6    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      �� 5      $
��Auto �6#   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��5,0,0,0q�6   $��Завдання 2��6K   ��6*   �� *Task2Command+6K   �� 5      $��5,0,0,0q�6   $��Завдання 3��6K   ��6*   �� *Task3Command+6K   �� 5      $��5,0,0,0q�6   $��Завдання 4��6K   ��6*   �� *Task4Command+6K   5      �� 5      $��2��6   $ 
Horizontal=�6)   .+�5      �� $��5,0,0,0q�6   $��Оновити��6M   ��6*   �� *RefreshCommand+6M   �� 5      $��5,0,0,0q�6   $��Додати��6I   ��6*   �� *
AddCommand+6I   5      5      �� 5   
   $��0,5,0,0q�6   ��6$   �� *Shop+ �� View 5      �� 5      P�5      �� 5      $��
Назва��6)    �� DisplayMemberBinding 68   �� *Name+�� 5       $��Дата��6)    67   �� *Date+ �� StringFormat$ dd.MM.yyyy HH:mm:ss���� 5!      $��Давність��6)    6;   �� *
TimePassed+5#      5%      5&      5'      