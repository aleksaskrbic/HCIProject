   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.ZdravstveniKarton   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     ? Title$  ZdravstveniKarton??5   	   $	??673??6#   $
??1168??60   .??5	      ? $??0,0,0,-6q?6   ??5
   
   ?? 5       ?? EndPoint$ 0.5,1&?6"    ?? 
StartPoint$ 0.5,0&?63   .??5      ?  ? Color$ 	AliceBlue??6   ? 5      $ 	AliceBlue??6    ? Offset$ 1Q?61   5      .+?5   
   ?? -   5        $??Sačuvaj Promene??5      $
??Bold"?6+   
??????????	#FF006666$
??Left=?6g   $??1014,34,0,0q?6?   $	??Top=?6?   $	??111??6?   $??38??6?   6?   ?? 5   
   -   5        $??Profil Pacijenta??5      $
??Bold"?6,   
??????????	#FF006666$
??Left=?6h   $??
709,34,0,0q?6?   $	??Top=?6?   $	??111??6?   $??38??6?   6?   ?? 5   
   -   5        $??Unesi Alergene??5      $
??Bold"?6*   
??????????	#FF006666$
??Left=?6f   $??
300,94,0,0q?6?   $	??Top=?6?   $	??111??6?   $??28??6?   6?   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Alergeni??5      $??10,144,757,407q?6%      
IsReadOnly$
 True??6^   $
??Bold"?6p   ??6=   ?? *
alergeni+6?   (  "System.Windows.Controls.DatePicker  5   
   $
??Left=?6   $??1019,101,0,0q?60   $	??Top=?6F   ?? 5   
   -   5        $??Appointments??5      $??601,144,33,309q?6'   ??6?   ?? *
pregledi+??5      ?? 5       $ 0.5,1&?6&   $ 0.5,0&?67   .??5!      ? $ 	AliceBlue??6#   ? 5"      $ White??6#   $ 1Q?61   5#      ??5%      ?? 5&      .R?5'      ? $??0 0 0 10q?6S   ??6   ?? *ActualWidth+ ?? ElementName$ Appointments????5(      ?? 5)      $ 0.5,1&?62   $ 0.5,0&?6C   .??5*   "   ? $ white??6/   ? 5+   "   $ White??6/   $ 1Q?6=   5,       ? ColumnDefinitions 5.      ?? 5/      $??0.15* ?6/   6?   ?? 50      $
??0.15 ?6/   6>   ?? 51      $??0.15* ?6/   6?   	 ? RowDefinitions	 53      ?? 54      6.   ?? 55      6.   ?? 56      6.   ?? 57      6.   ?? 58      6.   ?? 59      6.   .+?5;      ?? $??1??6$   $??0??61   $
??Bold"?6A   $??Center=?5<   $   $??13(?6A   ??5;   S   ?? *TipPregleda+5<   Q   ?? 5=      $??3??6$   $??0??61   $
??Bold"?6A   $??Center=?5>   $   $??13(?6A   ??5=   S   ?? *Vreme_Pregleda+5>   Q   ?? 5?      $??4??6$   $??0??61   $
??Bold"?6A   $??Center=?5@   $   $??13(?6A   ??5?   S   ?? *Doktor+5@   Q   ?? 5B      -   5        $??
Detaljnije??5B   !   $??3??6T   $??2??6a   
???????$??Center=?5C   !   $??DemiBold"?6>   5D      5E      5F      5H        5J   
   $
??Left=?6   $??1019,367,0,0q?60   $	??Top=?6F   ?? 5L   
   -   5        
 ??Name$
 Istorija_Pregleda??5L      $??601,408,33,67q?6.   ??6E   ?? *istorija_pregleda+??5M      ?? 5N      $ 0.5,1&?6&   $ 0.5,0&?67   .??5O      ? $ 	AliceBlue??6#   ? 5P      $ White??6#   $ 1Q?61   5Q      ??5S      ?? 5T      .R?5U      ? $??0 0 0 10q?6S   ??6   ?? *ActualWidth+$ Appointments????5V      ?? 5W      $ 0.5,1&?62   $ 0.5,0&?6C   .??5X   "   ? $ white??6/   ? 5Y   "   $ White??6/   $ 1Q?6=   5Z       5\      ?? 5]      $??0.15* ?6/   ?? 5^      $
??0.15 ?6/   ?? 5_      $??0.15* ?6/   	 5a      ?? 5b      ?? 5c      ?? 5d      ?? 5e      ?? 5f      ?? 5g      .+?5i      ?? $??1??6$   $??0??61   $
??Bold"?6A   $??Center=?5j      $??13(?6:   ??5i   S   ?? *TipPregleda+5j   :   ?? 5k      $??3??6$   $??0??61   $
??Bold"?6A   $??Center=?5l      $??13(?6:   ??5k   S   ?? *Vreme_Pregleda+5l   :   ?? 5m      $??4??6$   $??0??61   $
??Bold"?6A   $??Center=?5n      $??13(?6:   ??5m   S   ?? *Doktor+5n   :   ?? 5p      -   5        $??
Detaljnije??5p   !   $??3??6V   $??2??6c   
???????$??Center=?5q      $??DemiBold"?6:   5r      5s      5u      ?? 5w   
   $
??Left=?6   $??	70,20,0,0q?6/   $ ??Zdravstveni karton: #543op??6B   $
??Wrap=?6d   $	??Top=?6x   $	??227??6?   $
??Bold"?6?   $??18(?6?   ?? 5y   
   $
??Left=?6   $??	23,92,0,0q?6/   $??Unos alergena??6B   $
??Bold"?6W   $
??Wrap=?6i   $	??Top=?6}   $??14(?6?     5z   
   -	   5        $??Propisani_Lekovi??5z      $??10,412,757,139q?6+   $
 True??6b   $
??Bold"?6t   ??6C   ?? *lekovi+6?   ?? 5{   
   $
??Left=?6   $??
23,372,0,0q?6/   $??Propisani Lekovi??6C   $
??Bold"?6[   $
??Wrap=?6m   $	??Top=?6?   $??14(?6?   ?? 5~   
   $
??Left=?6   $??
601,98,0,0q?6/   $??Zakazani Termini:??6C   $
??Wrap=?6\   $	??Top=?6p   $
??Bold"?6?   $??14(?6?    J? RenderTransformOrigin$ 0.5,0.5&?6?   $	??140??6?   z?5      V? 5?      .~?5?      ?? ?? 5?      ?? 5?       ?? Angle$ -0.14Q?6&   T? 5?      5?      5?      ?? 5?   
   $
??Left=?6   $??601,364,0,0q?6/   $??Istorija Pregleda:??6D   $
??Wrap=?6^   $	??Top=?6r   $
??Bold"?6?   $??14(?6?   $	??143??6?   5?      5?      