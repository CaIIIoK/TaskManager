   M S B A M L   `   `   `  ����F  BTaskManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TaskManagerTaskManager  5   	       TaskManager.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TaskManager     5   	   -   5          � Title$  Task Manager��5   	   $	��550��6   $	��700��6+    � 
ResizeMode$ CanMinimize=�5	   "    � Icon$! ./Resources/TaskManager.png��5
   	    � WindowStartupLocation$ CenterScreen=�6,    � 	Resources 5         itemMenu m� Icon��%�  &	        �� 5   
   .@�5      m� -   5        $��_Edit��5       5      �� 5      $��./Resources/Edit.png��6   5      m� 5      -   5        $��_Mark as done��5       5      �� 5      $��./Resources/Complete.png��6   5      �� 5      6   m� 5      -   5        $��_Delete��5       5      �� 5      $$��./Resources/DeleteTableRow.png��6   5      5      5      .��5      �  � RowDefinitions 5    
   �� 5!      $��1* �6   �� 5"      $
��Auto �6   �� 5#      $
��Auto �6    � ColumnDefinitions 5%   
   �� 5&      $
��Auto �6   �� 5'      $��1* �6   �� 5(      $
��Auto �6   .+�5*   
   �� -   5        $��lvToDo��5*      $��Stretch=�6!   $��0��6>   $��3��6K    � ContextMenu# [  5+   >   ��5,      �� 	 �� Path$	 Items�5-      �� 5.   
   -   5        $��label1��5/       $��Task Description��5.      $��1��6+   $
��Left=�68   $��0��5/      $��Center=�6.   �� 50   
   -   5        $��txtItemDesc��50      $��1��6%   $��1��62   
 �� 	MaxLength$	
 150��6B   $��	0,0,166,0q�6R   �� 51   
   -   5        $��btnAdd��52   !   $��Add Task��51      $��1��6$   $��right=�61   $��1��52      $��2��6G   $	��166��6[   �� 53   
   -	   5         ��Name$ chkShowDone��53      $��2��6)   $��2��54      $��Show completed tasks��6    $��0,0,42,0q�56       d� 	IsChecked 55      �� $	 ShowDoneItems� �� Mode$ TwoWay=�56      57      58      