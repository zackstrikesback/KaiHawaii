   M S B A M L   `   `   `  ����J  FProjectCalendar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProjectCalendarProjectCalendar  5           ProjectCalendar.AddControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ProjectCalendar     5      -   5          >�Name$  AddCont��5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0��6   $��Name:��6-   �� 5   
   $��1��6   $��0��6   $��Notes:��6-   �� 5   
   $��2��6   $��0��6   $��Members:��6-   �� 5   
   -   5         ��Name$ uxDue��5   <   $��4��6   $��0��6   $
��Due:��6-   $y�Visible=�6K   �� 5   
   -   5         ��Name$ uxName��5   ;   $��1��6   $��0��6"   $��3q�6/   6;   �� 5   
   -   5        $ uxNotes��5   :   $��1��6   $��1��6"   $��3q�6/    �� TextWrapping$
 Wrap=�6K   �� 5   
   -   5         ��Name$ 	uxEmpList��5   :   $��1��6   $��2��6"   $��3q�6/   6M   �� 5    
   -   5         ��Name$ 
uxEmpCombo��5       $��1��5!      $��3��6#   $��3q�60    �� DisplayMemberPath$ Email��5#      ��5"      �� *Person.Persons+5%      (  "System.Windows.Controls.DatePicker  5&   
   -   5        	  Name$	 uxDate��5&   G   $��1��6   $��4��6%   $y�Visible=�62   6�   �� 5'   
   -   5        $��2��5'      $��2��6!   $	��Top=�6.   $��60��6F   $��25��6T   $��3q�6d   $��Remove��6o   6�   �� 5(   
   -	   5        $��2��5(      $��3��6!   $��60��6.   $��25��6<   $��3q�6K   $	��Add��6V   6d   �� 5)   
   -
   5        
 ��Name$
 btnSave��5)      $��2��6"   $��5��62   $��60��6?   $��25��6M   $��3q�6\   $
��Save��6g   6v   5*      5+      