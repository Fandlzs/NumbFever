   M S B A M L   `   `   `  ����D  @NumbFever, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:NumbFever.WindowsNumbFever.Windows  5   	   +    %NumbFever.Windows.CreateInvoiceWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:NumbFever.Windows     5   	     � Title$  Új számla��5   	   $��652.66��6   $��1117.553��6+    
  GreyBg#��[  6<    � 
ResizeMode$ NoResize=�6\   .��5	      � .+�5
   
   �� $��Partner neve:��6   $
��Left=�6(   $��	10,10,0,0q�6C   $	��Top=�6V   �� 5   
   -   5         ��Name$ PartnerNames��5      $
��Left=�6)   $��	94,14,0,0q�6D   $	��Top=�6W   $	��188��6o   6{   �� 5   
   $��Partner címe:��6   $
��Left=�6(   $��
287,14,0,0q�6C   $	��Top=�6W   �� 5   
   -   5         ��Name$ PartnerAddressBox��5      $
��Left=�6/   $��
371,18,0,0q�6J   $
��Wrap=�6^   $	��Top=�6r   $��22��6�   $	��331��6�   �� 5   
   $��Partner adószáma:��6   $
��Left=�6,   $��	10,41,0,0q�6G   $	��Top=�6Z   �� 5   
   -   5        $ PartnerTaxNumberBox��5      $
��Left=�61   $��
122,45,0,0q�6L   $
��Wrap=�6`   $	��Top=�6t   $��22��6�   $	��470��6�   �� 5   
   $ ��Partner bankszámlaszáma:��6   $
��Left=�63   $��	10,72,0,0q�6N   $	��Top=�6a   �� 5   
   -   5        $ PartnerAccountNumberBox��5      $
��Left=�65   $��
164,76,0,0q�6P   $
��Wrap=�6d   $	��Top=�6x   $��22��6�   $	��470��6�   �� 5   
   -   5         ��Name$ ExitBtn��5      $��	Kilépés��6"   $
��Left=�64   $��1025,10,0,0q�6O   $	��Top=�6d   $��75��6|   6�   �� 5   
   $��	Tételek:��6   $
��Left=�6#   $��
10,218,0,0q�6>   $	��Top=�6R   �� 5   
   $��ÁFA(%):��6   $
��Left=�6"   $��164,187,0,0q�6=   $	��Top=�6R    J� RenderTransformOrigin$ 3.699,0.624&�6j   �� 5   
   -   5        $ TaxList��5      $
��Left=�6$   $��220,191,0,0q�6?   $	��Top=�6T   $��56��6l   �� 5   
   -   5        $ 
NewItemBtn��5      $��
Új tétel��6%   $
��Left=�68   $��1025,189,0,0q�6S   $	��Top=�6i   $��75��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	ItemsGrid��5      $
��Left=�6&   $	��364��6A   $��
10,249,0,0q�6N   $	��Top=�6b   $
��1090��6z   �� 5   
   $��Új tétel hozzáadása:��6   $
��Left=�6/   $��
10,187,0,0q�6J   $	��Top=�6^   �� 5   
   $��Megnevezés:��6   $
��Left=�6&   $��287,187,0,0q�6A   $	��Top=�6V   �� 5   
   -	   5         ��Name$ ItemNameBox��5      $
��Left=�6'   $��23��6B   $��371,191,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5   
   $��Mennyiség:��6   $
��Left=�6%   $��522,187,0,0q�6@   $	��Top=�6U   �� 5   
   -
   5        $ ItemAmountBox��5      $
��Left=�6)   $��23��6D   $��597,189,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   $��
Egységár��6   $
��Left=�6#   $��756,186,0,0q�6>   $	��Top=�6S   �� 5   
   -   5        $ ItemPriceBox��5      $
��Left=�6(   $��23��6C   $��819,189,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   $��Teljesítés dátuma:��6   $
��Left=�6-   $��
10,103,0,0q�6H   $	��Top=�6\   (  "System.Windows.Controls.DatePicker  5    
   -   5        	  Name$	 DateOfDeliveryBox��5       $
��Left=�60   $��122,105,0,0q�6K   $	��Top=�6`   �� 5!   
   $��Fizetési határidő:��6   $
��Left=�6-   $��
10,134,0,0q�6H   $	��Top=�6\     5"   
   -   5        $	 TermOfPaymentBox��5"      $
��Left=�6/   $��122,136,0,0q�6J   $	��Top=�6_   �� 5#   
   $��	Pénznem:��6   $
��Left=�6#   $��261,103,0,0q�6>   $	��Top=�6S   �� 5$   
   -   5        $ CurrencyList��5$      $
��Left=�6)   $��345,107,0,0q�6D   $	��Top=�6Y   $	��120��6q   �� 5%   
   -   5        $��Tétel törlése��5%      $
��Left=�6)   $��1025,218,0,0q�6D   $	��Top=�6Z   $��75��6r   6}   �� 5&   
   -   5        $ SaveInvoiceBtn��5&        MaintBtn#��[ 6)   $��Számla mentése��6K   $
��Left=�6d   $��
969,88,0,0q�6   $	��Top=�6�   $	��131��6�   $��41��6�   6�   �� 5'   
   $��Fizetés módja:��6   $
��Left=�6)   $��261,134,0,0q�6D   $	��Top=�6Y   �� 5(   
   -   5        $ MethodOfPaymentList��5(      $
��Left=�60   $��345,136,0,0q�6K   $	��Top=�6`   $	��120��6x   5*      5+      