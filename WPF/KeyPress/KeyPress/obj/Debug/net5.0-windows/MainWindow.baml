   M S B A M L   `   `   `  ����C  ?KeyPress, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:KeyPressKeyPress  5   	       KeyPress.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:KeyPress     5   	   -   5          � Title$  
MainWindow��5   	   $	��220��6   $	��250��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��Valor 1:��6   $��0��6#   $��0��60   $��Right=�6@   �� 5   
   -   5         ��Name$ 
txtValorUm��5      $��0��6&   $��1��63   $	��100��6C   $��5q�6O   �� 5   
   $��Valor 2:��6   $��1��6#   $��0��60   $��Right=�6@   �� 5   
   -   5        $ txtValorDois��5      $��1��6(   $��1��65   $	��100��6E   $��5q�6Q   �� 5   
   $��	Operador:��6   $��2��6$   $��0��61   $��Right=�6A   �� 5   
   -   5        $ txtOperador��5      $��2��6'   $��1��64   $	��100��6D   $��5q�6P   �� 5    
   -   5         ��Name$ btnCalcular��5       $��3��6&   $��1��63   $��Calcular��6C   $��50��6V   $��	0,10,0,10q�6a   6t   �� 5"   
   $��
Resultado:��6   $��4��6%   $��0��62   $��Right=�6B   �� 5#   
   -   5        $ txtRespCalculo��5#      $��4��6*   $��1��67    �� 
IsReadOnly$
 True��6G   $��False��6Y   $	��100��6k   $��5q�6w   �� 5%   
   $��5��6   $��0��6   $��Tecla Pressionada:��6-   $��Bottom=�6J   $��Right=�6e   �� 5&   
   -   5        $ txtTeclaPressionada��5&      $��5��6/   $��1��6<   $
 True��6L   $��False��6^   $��Bottom=�6p    �� TextAlignment$
 Left=�6�   $��0,0,0,5q�6�   5'      5(      