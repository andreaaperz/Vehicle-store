   M S B A M L   `   `   `  ����F  BActividad_6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Actividad_6.GuiActividad_6.Gui  5   	       Actividad_6.Gui.Clientes   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Actividad_6.Gui     5   	     � Title$  Clientes��5   	   $	��450��6   $	��800��6'   .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5      $	��150 �6   �� 5      $��60 �6   �� 5      .+�5   
   �� $��3��6   $��Center=�6   5      �� 5   
   $��2��6   $��Center=�6   $��0,0,1,0q�6;   $	��791��6L   $��Center=�6X   ._�5      ]� $��60��6   ��.  $��304,0,306,0q�6:   $��2��6O   $��2��6\   $	��Top=�6m   .+�5      �� -   5         ��Name$ 
btnAgregar��5      $��64��6F   .��5      �� $��60��6   $%��/Actividad_6;component/img1.png��6(   $
��Fill=�6Q   $��60��6`   5      �� 5      -   5        $ 	btnBuscar��5      $��66��6D   .��5      �� $��56��6   $%��/Actividad_6;component/img2.png��6(   $
��Fill=�6Q   $��56��6`   5      �� 5      -   5        $ btnEliminar��5      $��59��6.   .��5      �� $��50��6   $%��/Actividad_6;component/img3.png��6(   $
��Fill=�6Q   $��50��6`   5      5      5      �� 5    
   $��1��6   ._�5!      �� .+�5"      �� -   5         ��Name$ txtApMaterno��5"      $
��Left=�60   $��23��6K   $��
474,47,0,0q�6W   $��1��6k    �� TextWrapping$
 Wrap=�6x   $	��Top=�6�   $	��120��6�   �� 5#      -   5        $ txtApPaterno��5#      $
��Left=�60   $��23��6K   $��
349,47,0,0q�6W   $��1��6k   $
 Wrap=�6x   $	��Top=�6�   $	��120��6�   �� 5$      -   5        $ 	txtNombre��5$      $
��Left=�6-   $��23��6H   $��
224,47,0,0q�6T   $��1��6h   $
 Wrap=�6u   $	��Top=�6�   $	��120��6�   �� 5%      $��Nombre��6   $
��Left=�6)   $��
153,48,0,0q�6D   $��1��6X   $	��Top=�6e   $��23��6}   $��66��6�   �� 5&      $��Email��6   $
��Left=�6(   $��1��6C   $	��Top=�6P   $��23��6h   $��66��6t    �� Left$	 153��6   
 �� Top$ 76��6�   �� 5'      -   5        $ txtNombreUsuario��5'      $
��Left=�64   $��23��6O   $��224,104,0,0q�6[   $��1��6p   $
 Wrap=�6}   $	��Top=�6�   $	��120��6�   �� 5(      $��	IdUsuario��6   $
��Left=�6,   $��153,104,0,0q�6G   $��1��6\   $	��Top=�6i   $��23��6�   $��66��6�   �� 5)      -   5        $ txtEmail��5)      $
��Left=�6,   $��23��6G   $
 Wrap=�6S   $	��Top=�6g   $	��120��6   $	 224��6�   $ 76��6�   5*      5+      �� 5,   
   $��0��6   $��Center=�6   $��Center=�6;   ._�5-      �� -	   5        $ btnRegresar��5-      $��X��6*   $��
711,16,0,0q�66   $��47��6K   $��32��6V   $
��Bold"�6|   ���	#FFFBFBFB
���   �$��18(�6�   5.      �� 50   
   $��Center=�6   $��0��6-   $
��Left=�6:   ._�51      �� $��Clientes��6   $	��116��6'   $��18(�63   $
��Bold"�6A   6U   52      �� 53   
   $.��(Puede ingresar usuario del 5 hasta el 11��6   $
��Left=�6C   $��153,46.724,0,0q�6^   $��3��6v   $	��Top=�6�   54      55      