   M S B A M L   `   `   `  ����N  JProjektZaliczeniowy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ProjektZaliczeniowy.ScreensProjektZaliczeniowy.Screens  5      9!clr-namespace:ProjektZaliczeniowyProjektZaliczeniowy  5      -    'ProjektZaliczeniowy.Screens.ClientsList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ProjektZaliczeniowy.Screens     5      AProjektZaliczeniowy!clr-namespace:ProjektZaliczeniowy     5        N� Title$  ClientsList��5
       � 	Resources 5         clientsViewSource��%   &	        �� 5   
   6   5      .��5      �  � DataContext# [  6   .+�5   
   �� ���	#FFF4F4F5$
��Left=�6%   $	��350��6@   
���   �$	��Top=�6\   $	��500��6t   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ clientsDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��18,18,19,10q�6      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6g   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        clientEmailColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Client Email��5   `   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 SizeToHeader 6v   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6@   �� *ClientEmail+6v     5      -   5        clientGenderColumn��$ Client Gender��5   b   $	 SizeToHeader 6y   
 6A   �� *ClientGender+6y     5      -   5        clientIDColumn��$ 	Client ID��5   Z   $	 SizeToHeader 6m   
 6=   �� *
ClientID+6m     5      -   5        clientNameColumn��$ Client Name��5   ^   $	 SizeToHeader 6s   
 6?   �� *
ClientName+6s     5      -   5        clientPhoneColumn��$ Client Phone��5   `   $	 SizeToHeader 6v   
 6@   �� *ClientPhone+6v   5      5      5      