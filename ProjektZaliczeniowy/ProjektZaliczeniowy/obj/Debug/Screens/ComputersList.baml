   M S B A M L   `   `   `  ����N  JProjektZaliczeniowy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ProjektZaliczeniowy.ScreensProjektZaliczeniowy.Screens  5      9!clr-namespace:ProjektZaliczeniowyProjektZaliczeniowy  5      /    )ProjektZaliczeniowy.Screens.ComputersList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ProjektZaliczeniowy.Screens     5      AProjektZaliczeniowy!clr-namespace:ProjektZaliczeniowy     5        N� Title$  ComputersList��5
       � 	Resources 5         clientsViewSource  computersViewSource��%:   &	        &	      �� 5   
   6   �� 5   
   6   5      .��5      �  � DataContext# [  6   .+�5   
   �� ���	#FFF4F4F5$
��Left=�6%   $	��350��6@   
���   �$	��Top=�6\   $	��500��6t   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ computersDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��10q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6i   ��  �� Source# [    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        computerAmountColumn��,  &System.Windows.Controls.DataGridColumn	   Header$	 Computer Amount��5   f   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 SizeToHeader 6   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *ComputerAmount+6     5      -   5        computerIDColumn��$	 Computer ID��5   ^   $
 SizeToHeader 6s    6?   �� *
ComputerID+6s     5      -   5        computerModelIdColumn��$	 Computer Model Id��5   h   $
 SizeToHeader 6�    6D   �� *ComputerModelId+6�     5      -   5        computerNameColumn��$	 Computer Name��5   b   $
 SizeToHeader 6y    6A   �� *ComputerName+6y     5      -   5        computerPriceColumn��$	 Computer Price��5   d   $
 SizeToHeader 6|    6B   �� *ComputerPrice+6|     5      -   5        "computerReservationPriceColumn��$ 	 Computer Reservation Price��5   z   $
 SizeToHeader 6�    6M   �� *ComputerReservationPrice+6�     5      -   5        computerTypeColumn��$	 Computer Type��5   b   $
 SizeToHeader 6y    6A   �� *ComputerType+6y   5      5      5       