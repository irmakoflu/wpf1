   M S B A M L   `   `   `  ����C  ?WpfFirst, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfFirstWpfFirst  5   	       WpfFirst.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfFirst     5   	     � Title$  
MainWindow��5   	   $	��525��6   $	��350��6)   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ resultlabel��5      $��0��6&   $��Right=�5      $��Bottom=�5      $��60(�5      $��4��5      �� 5   
   -   5         ��Name$ acbutton��5      $��AC��5      $��5q�5      $��1��5       �� 5!   
   -   5        $ negativebutton��5!      $	��+/-��5"      $��5q�5#      $��1��5$      $��1��5%      �� 5&   
   -   5        $ percantagebutton��5&      $��%��5'      $��5q�5(   
   $��1��5)   
   $��2��5*   
   �� 5+   
   -   5        $ divisionbutton��5+      $��/��5-      $��5q�5.   
   $��1��5/   
   $��3��50   
   �� 51   
   -   5        $ sevenbutton��51      $��7��52      $��5q�53   
   $��2��54   
   6   �� 55   
   -   5        $ eightbutton��55      $��8��57      $��5q�58   
   $��2��59   
   $��1��5:   
   �� 5;   
   -   5        $ 
ninebutton��5;      $��9��5=      $��5q�5>   
   $��2��5?   
   $��2��5@   
   �� 5A   
   -	   5        $ multiplicationbutton��5A      $��*��5C      $��5q�5D   
   $��2��5E   
   $��3��5F   
   �� 5G   
   -
   5        $ 
fourbutton��5G      $��4��5I      $��5q�5J   
   $��3��5K   
   �� 5L   
   -   5        $ 
fivebutton��5L      $��5��5N      $��5q�5O   
   $��3��5P   
   $��1��5Q   
   �� 5R   
   -   5        $ 	sixbutton��5R      $��6��5T      $��5q�5U   
   $��3��5V   
   $��2��5W   
   �� 5X   
   -   5        $ minusbutton��5X      $��-��5Z      $��5q�5[   
   $��3��5\   
   $��3��5]   
   �� 5^   
   -   5        $ 	onebutton��5^      $��1��5`      $��5q�5a   
   $��4��5b   
   �� 5c   
   -   5        $ 	twobutton��5c      $��2��5e      $��5q�5f   
   $��4��5g   
   $��1��5h   
   �� 5i   
   -   5        $ threebutton��5i      $��3��5k   
   $��5q�5l   
   $��4��5m   
   $��2��5n   
   �� 5o   
   -   5        $ 
plusbutton��5o      $��+��5q      $��5q�5r   
   $��4��5s   
   $��3��5t   
   �� 5w   
   -   5        $ 
zerobutton��5w      $��0��5y      $��5q�5z   
   $��5��5{   
   $��2��5|   
   �� 5}   
   -   5        $ pointbutton��5}      $��.��5~      $��5q�5   
   $��5��5�   
   $��2��5�   
   5�      �� 5�   
   -   5        $ equalbutton��5�      $��=��5�      $��5q�5�   
   $��5��5�   
   $��3��5�   
   5�      5�      