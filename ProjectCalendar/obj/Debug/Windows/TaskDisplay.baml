   M S B A M L   `   `   `  ����J  FProjectCalendar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProjectCalendarProjectCalendar  5   	   !    ProjectCalendar.TaskDisplay   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ProjectCalendar     5   	     � Title$  TaskDisplay��5   	   $	��300��6   $	��500��6*   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ tasks��5
         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5      $��Stretch=�5         AutoGenerateColumns .  ��5      �� *DTasks+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      Width$
 Auto 5   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *TName+5   %   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Notes��6)      CellTemplate 5      �� 5      .R�5      �� 	 �� TextWrapping$
	 Wrap=�5   &   
 �� 
IsReadOnly
 . ��5   &   �� *Notes+.��5   8   5      5      5        5      $ Assigned��6)   $
 Auto 5   )    5      �� 5       .R�5!      �� ��6&   �� *
Assigned+6I   5"      5$      5'      5(      5)      