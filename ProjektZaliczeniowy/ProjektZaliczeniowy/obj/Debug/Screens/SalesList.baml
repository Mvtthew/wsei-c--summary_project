   M S B A M L   `   `   `  ����N  JProjektZaliczeniowy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ProjektZaliczeniowy.ScreensProjektZaliczeniowy.Screens  5      9!clr-namespace:ProjektZaliczeniowyProjektZaliczeniowy  5      +    %ProjektZaliczeniowy.Screens.SalesList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ProjektZaliczeniowy.Screens     5      AProjektZaliczeniowy!clr-namespace:ProjektZaliczeniowy     5        N� Title$  	SalesList��5
       � 	Resources 5         clientsViewSource  salesViewSource��%:   &	        &	      �� 5   
   6   �� 5   
   6   5      .��5      �  � DataContext# [  6   .+�5   
   �� ���	#FFF4F4F5$
��Left=�6%   $	��350��6@   
���   �$	��Top=�6\   $	��500��6t   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ salesDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��10q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6e   ��  �� Source# [    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        clientIDColumn��,  &System.Windows.Controls.DataGridColumn	   Header$	 	Client ID��5   Z   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 SizeToHeader 6m   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
ClientID+6m     5      -   5        computerIDColumn��$	 Computer ID��5   ^   $
 SizeToHeader 6s    6?   �� *
ComputerID+6s   4  .System.Windows.Controls.DataGridCheckBoxColumn  5      -   5        payedColumn��$	 Payed��5   X   $
 SizeToHeader 6g    6>   �� *Payed+6g     5      -   5        priceToPayColumn��$	 Price To Pay��5   ^   $
 SizeToHeader 6t    6?   �� *
PriceToPay+6t     5      -   5        reservationIDColumn��$	 Reservation ID��5   d   $
 SizeToHeader 6|    6B   �� *ReservationID+6|   5      5      5      