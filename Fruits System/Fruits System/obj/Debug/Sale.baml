   M S B A M L   `   `   `  ����H  DFruits System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Fruits_SystemFruits_System  5   	       Fruits_System.Sale   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Fruits_System     5   	     � Title$
  Sale��5   	   $	��450��6   $	��800��6#   .��5	      � .+�5
   
   �� $
��Sale��6   $
��Left=�6   $��56��6:   $��
323,33,0,0q�6F   $	��Top=�6Z   $	��119��6r   $��Center=�6~   $��Center=�6�   $��24(�6�   �� 5   
   $��Produnct ID��6   $
��Left=�6&   $��28��6A   $��
205,95,0,0q�6M   $	��Top=�6a   $��83��6y   �� 5   
   $��Weight��6   $
��Left=�6!   $��28��6<   $��
436,94,0,0q�6H   $	��Top=�6\   $��48��6t    J� RenderTransformOrigin$ 	0.5,1.809&�6   �� 5   
   -   5         ��Name$ IdText��5      $
��Left=�6"   $��28��6=   $��
304,94,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��108��6�   �� 5   
   -   5        $ 
WeightText��5      $
��Left=�6&   $��28��6A   $��
507,94,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��101��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridView1��5         AutoGenerateColumns .  $
��Left=�6x   $	��203��6�   $��246,166,0,0q�6�   $	��Top=�6�   $	��470��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Product Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 180 6[   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6;   �� *ProductName+6[     5      $ 
Product ID��6%   $	 120 6W   	 69   �� *	ProductID+6W     5      $ 
Amount(kg)��6%   $ 80 6T   	 69   �� *Amount+6T     5      $ Price(CAD)/kg��6%   $ 90 6V   	 6<   �� *Price+6V   5      �� 5   
   -   5        
 ��Name$
 SaleBtn��5      $
��SALE��6"   $
��Left=�61   $��28��6L   $��
645,95,0,0q�6X   $	��Top=�6l   $��56��6�   6�   �� 5   
   -   5         ��Name$ 	TextBlock��5      $
��Left=�6'   $	��203��6B   $��
28,166,0,0q�6O   $
��Wrap=�6c   $	��Top=�6w   $	��193��6�   �� 5   
   -   5        $
 TotalBtn��5      $��Total��6#   $
��Left=�63   $��27��6N   $��382,134,0,0q�6Z   $	��Top=�6o   $	��281��6�   ���	#FF68FC07$��16(�6�   $
��Bold"�6�   ���	#FF68FC07���	#FFF607076�   5      5      