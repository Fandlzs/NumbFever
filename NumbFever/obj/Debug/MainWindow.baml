   M S B A M L   `   `   `  ����D  @NumbFever, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:NumbFever	NumbFever  5   	       NumbFever.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:NumbFever     5   	     � Title$  NumbFever - Főmenü��5   	   $	��550��6$   $	��800��61    � 
ResizeMode$ NoResize=�6=    
  GreyBg#��[  6S   .��5	      � $��500px��6   $	��Top=�6   .+�5
   
   �� $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   $��	NumbFever��6V   $	��Top=�6g   $��47��6   $	��277��6�   $��48(�6�   $��Arial Rounded MT Bold)�6�   $
��Bold"�6�   ��6�   Z� 6�   �� 5   
   $
��Left=�6   $��
287,32,0,0q�6/   $
��Wrap=�6C   $��- Számlázás okosan!��6W   $	��Top=�6r   $��27��6�   $	��245��6�   $��22(�6�   �� 5   
   $
��Left=�6   $	��155��6+   $��
581,32,0,0q�68   $	��Top=�6L   $	��178��6d   $��Img/main_img.png��6p    J� RenderTransformOrigin$ 1.184,0.387&�6�   � 5   
   $	��100��6   $��10,312,10,88q�6    � ColumnDefinitions 5      �� 5      $��1* �6#   60   �� 5      $��1* �6#   60   �� 5      $��1* �6#   60   �� 5      $��1* �6#   60   �� 5      $��1* �6#   60   .+�5      �� -   5         ��Name$ NewInvoiceBtn��5   7     MaintBtn#��[ 6   $��0��6N   $��Új számla��6^   $	��100��6r   $��50��6~   6�   �� 5      -   5        $ InvoiceListBtn��5   7   #��[ 6   $��1��6O   $��Meglévő tételek��6_   $	��100��6y   $��50��6�   6�   �� 5      -   5        $ PartnersBtn��5   7   #��[ 6   $��2��6L   $��	Partnerek��6\   $	��100��6p   $��50��6|   6�   �� 5      -   5        $ SettingsBtn��5   7   #��[ 6   $��3��6L   $��Beállítások��6\   $	��100��6r   $��50��6~   6�   �� 5      -   5        $ ExitBtn��5   7   #��[ 6   $��4��6H   $��	Kilépés��6X   $	��100��6j   $��50��6v   6�   � 5      $��-12,104,-13,-85q�6   $��5��6,   .+�5      �� $D��>©2018 NumbFever. All contents are copyright of their authors.��6   $��Italic$�6|    �� TextAlignment$ Center=�6�   $��
0,68,0,-17q�6�   ��6a   Z� 6�   5      5      &   System.Windows.Controls.Calendar  5   
   $
��Left=�6   $��
34,103,0,0q�6.   $	��Top=�6B   �� 5    
   $��287,84,266,211q�6   $��Img/Image3.png��6(   $
��Fill=�6@   5"      5#      