   M S B A M L   `   `   `  ����N  JProjektZaliczeniowy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ProjektZaliczeniowy.ScreensProjektZaliczeniowy.Screens  5      9!clr-namespace:ProjektZaliczeniowyProjektZaliczeniowy  5      ,    &ProjektZaliczeniowy.Screens.ModelsList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ProjektZaliczeniowy.Screens     5      AProjektZaliczeniowy!clr-namespace:ProjektZaliczeniowy     5        N� Title$  
ModelsList��5
       � 	Resources 5         clientsViewSource  modelsViewSource��%:   &	        &	      �� 5   
   6   �� 5   
   6   5      .��5      �  � DataContext# [  6   .+�5   
   �� ���	#FFF4F4F5$
��Left=�6%   $	��350��6@   
���   �$	��Top=�6\   $	��500��6t   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ modelsDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��10q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6f   ��  �� Source# [    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        modelIDColumn��,  &System.Windows.Controls.DataGridColumn	   Header$	 Model ID��5   X   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 SizeToHeader 6j   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *	ModelID+6j     5      -   5        modelNameColumn��$	 
Model Name��5   \   $
 SizeToHeader 6p    6>   �� *	ModelName+6p   5      5      5      