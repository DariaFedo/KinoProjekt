   M S B A M L   `   `   `  ����F  BNowy system, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Nowy_systemNowy_system  5   	       Nowy_system.Film_sForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Nowy_system     5   	     � Title$  
Film_sForm��5   	   $	��900��6   $	��900��6)   $	��500��69   $	��400��6E    � 	Resources 5
         TextBoxStyling �� 
TargetType �� Property �� Value  LabelStyling��%�  &	        &	     �� 5   
   " ��6'   .�5      ��  � ��$ 30��6(   �� 5       � ��$	 200��6'   �� 5       � ��$ 2q�61   �� 5       � ��
 ��� �6-   �� 5       �@��TextAlignment$
 Left=�6/   �� 5       � ��$ Center=�6:   5      �� 5   
   " ��6%   .�5      ��  � ��$ 30��6(   �� 5       � ��$	 100��6'   �� 5       � ��$ Center=�6:   5      5      .��5      �� .��5   
   � -   5         �Name$ FilmForm��5       � ColumnDefinitions 5      �� 5      $	��500 �6#    � RowDefinitions 5"      �� 5#      $��55 �6!   �� 5$      $��80 �6!   �� 5%      $��80 �6!   �� 5&      $��80 �6!   �� 5'      $��80 �6!   �� 5(      $��80 �6!   �� 5)      $��80 �6!   �� 5*      $��80 �6!   �� 5+      $��80 �6!   �� 5,      $��80 �6!   �� 5-      $��80 �6!   .+�52      �� -   5         ��Name$ WorkerHeader��52      $��0��6.   $��0��6;   $��Center=�6K   $��24(�53      $��Center=�6"   $��Normal$�6=   $��	UltraBold"�6P   $��135,13,128,10q�6g   Film's form54      �� 57      -   5        	 ��Name$	 
Titlelabel��57      $
��Bold"�6(   #��[ 6:   $��1��6`   $��50,26,350,25q�6n   .��6�   Title6�   �� 58      -   5        
 ��Name$
 
TitleInput��58      #��[  6*   $��1��6j   ��6S   �� *Title+6j   �� 5;      -   5        $	 Directorlabel��5;      $
��Bold"�6+   #��[ 6=   $��2��6c   $��50,25,350,26q�6p   .��6�   
Director6�   �� 5<      -   5        $
 DirectorInput��5<      #��[  6-   $��2��6p   ��6V   �� *
Director+6p   �� 5?      -   5        $	 	Castlabel��5?      $
��Bold"�6'   #��[ 69   $��3��6_   $��50,26,350,25q�6l   .��6�   Cast6�   �� 5@      -   5        $
 	CastInput��5@      #��[  6)   $��3��6h   ��6R   �� *Cast+6h   �� 5C      -	   5        $	 
Genrelabel��5C      $
��Bold"�6(   #��[ 6:   $��4��6`   $��50,26,350,25q�6m   .��6�   Genre6�   �� 5D      -
   5        $
 
GenreInput��5D      #��[  6*   $��4��6j   ��6S   �� *Genre+6j   �� 5G      -   5        $	 Languagelabel��5G      $
��Bold"�6+   #��[ 6=   $��5��6c   $��50,26,350,25q�6p   .��6�   
Language6�   �� 5H      -   5        $
 LanguageInput��5H      #��[  6-   $��5��6p   ��6V   �� *
Language+6p   �� 5K      -   5        $	 Lengthlabel��5K      $
��Bold"�6)   #��[ 6;   $��6��6a   $��50,26,350,25q�6n   .��6�   Length6�   �� 5L      -   5        $
 LengthInput��5L      #��[  6+   $��6��6l   ��6T   �� *Length+6l   �� 5O      -   5        $	 AgeRestrictionlabel��5O      $
��Bold"�61   #��[ 6C   $��7��6i   $��50,26,350,25q�6v   .��6�   Age Restriction6�   �� 5P      -   5        $
 AgeRestrictionInput��5P      #��[  63   $��7��6|   ��6\   �� *AgeRestriction+6|   �� 5S      -   5        $	 TechVerlabel��5S      $
��Bold"�6*   #��[ 6<   $��8��6b   $��50,26,350,25q�6o   .��6�   Tech Version6�   �� 5T      -   5        $
 TechVerInput��5T      #��[  6,   $��8��6r   ��6U   �� *TechVersion+6r   �� 5W      -   5        $	 Premierelabel��5W      $
��Bold"�6+   #��[ 6=   $��9��6c   $��50,26,350,25q�6p   .��6�   
Premiere6�   �� 5X      -   5        $
 PremiereInput��5X      #��[  6-   $��9��6p   ��6V   �� *
Premiere+6p   �� 5[      -   5         ��Name$ 	zatwierdz��5[      $��10��6(   $	��100��66   $��30��6B   $��Center=�6N   $
��Bold"�5\      
���   �$��2q�67   $��98,25,302,26q�6K   .��6{   Apply5]      �� 5`      -   5        $ cancel��5`      $��10��6%   $	��100��63   $��30��6?   $��Center=�6K   $
��Bold"�5a      
���   �$��2q�67   $��302,25,98,26q�6K   .��6x   Cancel5b      5h      5i      5k      