   M S B A M L   `   `   `  ����G  CUniinfo Desk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Uniinfo_DeskUniinfo_Desk  5   	       Uniinfo_Desk.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Uniinfo_Desk     5   	   -   5          �Name$  mnaLogin��5   	    � Title$ Login��5	   	   $��171.491��6   $��261.311��6(    � 
ResizeMode$ NoResize=�68    � WindowStartupLocation$ CenterScreen=�6N   
�������#��� ��6�   ��6�   Z� .��5
      � .+�5   
   �� -   5         ��Name$ lblUsuário��5      $��	Usuário:��6$   $
��Left=�67   $��	15,17,0,0q�6R   $	��Top=�6e    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Opacity$ 1Q�6#      RenderingBias$ Quality=�6/   5      �� 5   
   -   5         ��Name$ txbUsuário��5      $
��Left=�6'   $��30��6B   $��68,9,0,0q�6N   	 �� TextWrapping$
	 Wrap=�6`   $	��Top=�6t   $	��156��6�   
���   �
 �� SelectionBrush

 �������	#89000000 �� 	MaxLength$ 50��6   �� MaxLines$ 1��6   �� 
CaretBrush 6�   Z� ��6�   Z� .��6'   5        5      $	 0.9Q�6#   $ Quality=�61   .��5      5      �� 5   
   -   5        $ lblSenha��5      $��Senha:��6"   $
��Left=�63   $��	23,57,0,0q�6N   $	��Top=�6a    J� RenderTransformOrigin$ 0.489,0.833&�6y    5        5      $ 1Q�6#   $ Quality=�6/   5      �� 5   
   -   5         ��Name$ btnLogar��5      $��Logar��6#   $
��Left=�63   $��
89,108,0,4q�6N   $��Center=�6b   $��70��6}    �� 	IsDefault . $��30��6�   ���	#FF006DBE
������ $
��Thin"�6�   $��	Condensed&�6  &   System.Windows.Media.TextOptions   TextHintingMode$ Animated=�6  $��Warsaw)�6@  $	��123��6T   5        5      $ Quality=�6#      ShadowDepth$ 1Q�6;      Color$ 	#FF1232FF��6K   5      G� 5    
   -   5         G�Name$ psdSenha��5       $
��Left=�6(   $��	68,51,0,0q�6C   $	��Top=�6V   $	��156��6n   
���   � G� SelectionBrush
 ���� G� 	MaxLength$ 50��6�    G� 
CaretBrush 6�   Z� ��6�   Z�  5!        5"      $	 0.9Q�6#   $ Quality=�61   5$      �� 5%   
   -   5        $ txbErros��5%      $
��Left=�6$   $��23��6?   $��	23,83,0,0q�6K   $
	 Wrap=�6^   $	��Top=�6r   $	��206��6�   
���  �� �� TextAlignment$ Center=�6  $��10(�6  ��6�   Z� ��6�   Z� 
 6�   Z�  6�   Z� 6  5&      5'      