   M S B A M L   `   `   `  ����H  DFruits System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Fruits_SystemFruits_System  5   	       Fruits_System.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Fruits_System     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $��Fruits Sale��6   $
��Left=�6&   $��50��6A   $��
170,40,0,0q�6M   $	��Top=�6a   $	��450��6y   $��Center=�6�   $��Center=�6�   $��24(�6�   $
��Bold"�6�   �� 5   
   $
��Name��6   $
��Left=�6   $��27��6:   $��123,112,0,0q�6F   $	��Top=�6[   $��46��6s   $��Center=�6~   $��Center=�6�   �� 5   
   -   5         ��Name$ NameText��5      $
��Left=�6$   $��27��6?   $��169,112,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $��95��6�   �� 5   
   $��ID��6   $
��Left=�6   $��27��68   $��269,112,0,0q�6D   $	��Top=�6Y   $��31��6q   $��Center=�6|   $��Center=�6�   �� 5   
   -   5        $ IdText��5      $
��Left=�6"   $��27��6=   $��300,112,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��102��6�   �� 5   
   $��
Amount(kg)��6   $
��Left=�6%   $��27��6@   $��407,112,0,0q�6L   $	��Top=�6a   $��75��6y   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $ 
AmountText��5      $
��Left=�6&   $��27��6A   $��482,112,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��112��6�   �� 5   
   $��Price(CAD)/kg��6   $
��Left=�6(   $��27��6C   $��594,112,0,0q�6O   $	��Top=�6d   $��84��6|   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $ 	PriceText��5      $
��Left=�6%   $��27��6@   $��678,112,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $��92��6�   �� 5   
   -   5         ��Name$ 	SelectBtn��5      $��SELECT��6$   $
��Left=�65   $��26��6P   $��
54,225,0,0q�6\   $	��Top=�6p   $��83��6�   ���	#FFFB0707���	#FF4FEE1A6�   �� 5   
   -   5        $ 	InsertBtn��5      $��INSERT��6$   $
��Left=�65   $��26��6P   $��
54,166,0,0q�6\   $	��Top=�6p   $��82��6�   ���	#FFFB0707���	#FF4FEE1A6�   �� 5   
   -   5        $ 	UpdateBtn��5      $��UPDATE��6$   $
��Left=�65   $��26��6P   $��
53,284,0,0q�6\   $	��Top=�6p   $��83��6�   ���	#FFFB0707���	#FF4FEE1A6�   �� 5   
   -   5        $ 	DeleteBtn��5      $��Delete��6$   $
��Left=�65   $��26��6P   $��
54,343,0,0q�6\   $	��Top=�6p   $��83��6�   ���	#FFFB0707���	#FF4FEE1A6�   �� 5   
   -	   5        $ SaleBtn��5      $
��SALE��6"   $
��Left=�61   $��26��6L   $��	53,47,0,0q�6X   $	��Top=�6k   $��82��6�   ���	#FFFB0707���	#FF030B006�   &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ dataGridView1��5         AutoGenerateColumns .  $��Center=�6x   $	��203��6�   $��169,166,0,0q�6�   $	��Top=�6�   $	��471��6�      Columns 5   
   0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Product Name��6!      Width5  /System.Windows.Controls.DataGridLengthConverter$	 180 6W   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 67   �� *ProductName+6W     5      $ 
Product ID��6!   $	 120 6S   	 65   �� *	ProductID+6S     5      $ 
Amount(kg)��6!   $ 80 6P   	 65   �� *Amount+6P     5      $ Price(CAD)/kg��6!   $ 90 6R   	 68   �� *Price+6R   5       5"      5#      