   M S B A M L   `   `   `  ����D  @NumbFever, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:NumbFever.WindowsNumbFever.Windows  5   	   +    %NumbFever.Windows.CreatePartnerWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:NumbFever.Windows     5   	     � Title$  Partner létrehozása��5   	   $��414.894��6%   $	��660��66    � 
ResizeMode$ NoResize=�6B    
  GreyBg#��[  6X   .��5	      � .+�5
   
   �� $��Név:��6   $
��Left=�6   $��	10,10,0,0q�6:   $	��Top=�6M   �� 5   
   -   5         ��Name$ PartnerNameBox��5      $��23��6*   $��	10,41,0,0q�66    �� TextWrapping$
 Wrap=�6I   $	��Top=�6]   $
��Left=�6u   $	��244��6�   �� 5   
   $��
Adószám:��6   $
��Left=�6#   $��	10,69,0,0q�6>   $	��Top=�6Q   �� 5   
   -   5        $ PartnerTaxNumberBox��5      $
��Left=�6/   $��23��6J   $��
10,100,0,0q�6V   $
 Wrap=�6j   $	��Top=�6~   $	��244��6�   �� 5   
   $��Bankszámlaszám:��6   $
��Left=�6*   $��
10,128,0,0q�6E   $	��Top=�6Y   �� 5   
   -   5        $ PartnerAccountNumberBox��5      $
��Left=�63   $��23��6N   $��
10,159,0,0q�6Z   $
 Wrap=�6n   $	��Top=�6�   $	��244��6�   �� 5   
   $��Kontaktszemély neve:��6   $
��Left=�6/   $��
10,187,0,0q�6J   $	��Top=�6^   �� 5   
   -   5        $ PartnerContactNameBox��5      $
��Left=�61   $��23��6L   $��
10,218,0,0q�6X   $
 Wrap=�6l   $	��Top=�6�   $	��244��6�   �� 5   
   $!��Kontaktszemély beosztása:��6   $
��Left=�64   $��
10,246,0,0q�6O   $	��Top=�6c   �� 5   
   -   5        $ PartnerContactPositionBox��5      $
��Left=�65   $��23��6P   $��
10,277,0,0q�6\   $
 Wrap=�6p   $	��Top=�6�   $	��244��6�   �� 5   
   $$��Kontaktszemély telefonszáma:��6   $
��Left=�67   $��
10,305,0,0q�6R   $	��Top=�6f   �� 5   
   -   5        $ PartnerContactPhoneBox��5      $
��Left=�62   $��23��6M   $��
10,336,0,0q�6Y   $
 Wrap=�6m   $	��Top=�6�   $	��244��6�   �� 5   
   $��Egyéb:��6   $
��Left=�6!   $��
358,69,0,0q�6<   $	��Top=�6P   �� 5   
   -   5        $ PartnerOtherBox��5      $
��Left=�6+   $��23��6F   $��358,100,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��276��6�   �� 5   
   -   5         ��Name$ SaveBtn��5      $��Mentés��6"   $
��Left=�63   $��358,336,0,0q�6N   $	��Top=�6c   $��75��6{   6�   �� 5   
   -	   5        $ 
AddressBox��5      $
��Left=�6&   $��23��6A   $��
358,41,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��276��6�   �� 5   
   $��Cím:��6   $
��Left=�6   $��
358,10,0,0q�6:   $	��Top=�6N   �� 5   
   -
   5        $ 	CancelBtn��5      $��Mégse��6$   $
��Left=�64   $��559,336,0,0q�6O   $	��Top=�6d   $��75��6|   6�   �� 5   
   $
��Left=�6   $	��159��6+   $��421,159,0,0q�68   $	��Top=�6M   $	��143��6e   $(��"/NumbFever;component/Img/hands.png��6q   5      5      