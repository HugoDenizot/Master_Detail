   M S B A M L   `   `   `  ����H  DProjet_CSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Projet_CSharpProjet_CSharp  5          Projet_CSharp.Competences   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Projet_CSharp     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $	��100 �6    �� 5      $
��Auto �6    .+�5   
   � $��0��6   .+�5      �  � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $��Center=�6   $!��Compétences du personnages��69   $��0��6[   $��Center=�6k   $��Black"�6�   $��32(�6�   � 5      $��1��6   .+�5      �� -   5        $��Modifier��5   2   $	��100��6E   $��40��6R   $��Center=�6^   $��1��6y   5      5      5      � 5   
   $��1��6    5      �� 5      $	��400��6'   �� 5       $	��400��6'   .+�5"      � $��0��6   $��Center=�6#     5#      �� 5$      $
��Auto �6(   �� 5%      $
��Auto �6(   �� 5&      $
��Auto �6(   �� 5'      $
��Auto �6(   �� 5(      $
��Auto �6(   �� 5)      $
��Auto �6(   �� 5*      $
��Auto �6(   �� 5+      $
��Auto �6(   �� 5,      $
��Auto �6(   �� 5-      $
��Auto �6(   .+�50      �� $��0��6#   $��Passif��60   $��Black"�6>   $
��0 10q�6Q   �� 51      $��0��6!   $��Passif��6.   $��Black"�6<   $
��0 10q�6O   �� 53      -   5         ��Name$ 
editPassif��53      $y�	Collapsed=�61   $��1��6H   $
��5 10q�6|   ��6U   �� *SesCompétences.Passif+6|   �� 54      -   5         ��Name$ displayPassif��54      $��1��65   $
��5 10q�6i   ��6B   �� *SesCompétences.Passif+6i   �� 55      $��2��6    $��Compétence 1��6-   $��Black"�6A   $
��0 10q�6T   �� 56      -   5        $ editCompetence1��56      $y�	Collapsed=�69   $��3��6Q   $
��5 10q�6�   ��6^   �� *SesCompétences.CapPrimaire+6�   �� 57      -   5        $ displayCompetence1��57      $��3��69   $
��5 10q�6r   ��6F   �� *SesCompétences.CapPrimaire+6r   �� 59      $��Compétence 2��6!   $��4��65   $��Black"�6B   $
��0 10q�6U   �� 5:      -   5        $ editCompetence2��5:       $y�	Collapsed=�6;   $��5��6S   $
��5 10q�6�   ��6`   �� *SesCompétences.CapSecondaire+6�   �� 5;      -   5        $ displayCompetence2��5;      $��5��68   $
��5 10q�6s   ��6E   �� *SesCompétences.CapSecondaire+6s   �� 5<      $��6��6    $��Ultimate��6-   $��Black"�6=   $
��0 10q�6P   �� 5=      -   5        $ editUltimate��5=      $y�	Collapsed=�60   $��7��6G   $
��5 10q�6}   ��6T   �� *SesCompétences.Ultimate+6}   �� 5>      -	   5        $ displayUltimate��5>      $��7��65   $
��5 10q�6k   ��6B   �� *SesCompétences.Ultimate+6k   �� 5?      -
   5        $��Enregistrer��5?   8   $��40��6N   $	��100��6Z   $��	0,0,200,0q�6f   $��8��6y   6�   5A      � 5C      $��1��6   .+�5D      r�  r� LoadedBehavior$
 Play=�6G   $��Center=�6]   $��Center=�6x    r� Source 6   �� *SesCompétences.Vidéo+6x   5E      5H      �� 5J   
   -   5        $��Modifier La Vidéo��5J      $	��100��6-   $��40��6:   $��1��6G   $��right=�6X   $��Bottom=�6t   $��2��6�   6�   5M      5O      