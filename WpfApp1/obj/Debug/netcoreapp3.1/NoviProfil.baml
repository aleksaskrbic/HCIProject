   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.NoviProfil   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     ? Title$  
NoviProfil??5   	   $	??620??6   $
??1211??6)   .??5	      ? $??0,0,0,-6q?6   ??5
   
   ?? 5       ?? EndPoint$ 0.5,1&?6"    ?? 
StartPoint$ 0.5,0&?63   .??5      ?  ? Color$ 	AliceBlue??6   ? 5      $ White??6    ? Offset$ 1Q?6-   5      .+?5   
   ?? $??-178,0,472,527q?6   .+?5      o? $??45??6   $	??543??6   .@?5      m? $
??HOME??6   $
??Bold"?6)   
???????$??45??6P   ???	#FF0066666\   m? 5      -   5        $??Kalendar??5      $
??Bold"?6-   
??????? m? InputGestureText$ ctrl+k??6S   $??45??6m   ???	#FF006666 m? IsCheckable$ False??6?   6?   m? 5      -   5        $??Novi Termin??5      $
??Bold"?60   
??????????	#FF006666$??45??6m   6y   m? 5      -   5        $??Termini??5      $
??Bold"?6,   
??????????	#FF006666$??45??6i   6v   m? 5      -   5        $??	Pacijenti??5      $
??Bold"?6.   
??????????	#FF006666$??45??6k   6w   m? 5      -   5        $??Novi Profil??5      $
??Bold"?60   
??????????	#FF006666$??45??6m   6y   m? 5      -   5        $??Oglasna Tabla??5      $
??Bold"?62   
??????????	#FF006666$??45??6o   6{   m? 5       -   5        $??
Izveštaji??5       $
??Bold"?6.   
??????????	#FF006666$??45??6k   6w   5!      5#      ?? 5%   
   -   5         ??Name$ Pacijenti_Box??5%      $??0q?6)   $??302,127,717,386q?5&   :   ??6   ?? *
patients+??5'      ?? 5(      .R?5)      ?? .+?5*      ?? $??12(?6=   $
??Bold"?6K   ??6$   ?? *	Prezime+6_   ?? 5+      $??12(?69   $
??Bold"?6G   ??6$   ?? *Ime+6]   ?? 5,      $??12(?6C   $
??Bold"?6Q   ??6$   ?? *Broj_Telefona+6g   ?? 5-      $??12(?6A   
????  ?$??	Underline{?6a   $
??Bold"?6~   ??6$   ?? *Mail_Adresa+6?   5.      5/      51      ?? 53   
   -	   5        $ lbPatientList??53      $
??Left=?6)   $
??bold"?6E   
?????? $??2q?6q   $??50??6?   $??752,148,0,0q?6?   $	??Top=?6?   $	??148??6?   ?? 56   
   -
   5        $??Profil Pacijenta??56      $
??Bold"?6,   
???????$
??Left=?6Q   $??1008,158,0,0q?6l   $	??Top=?6?   $??31??6?   $??96??6?   ???	#FF0066666?   ?? 58   
   -   5        $?? ??58      
?????? $
??Left=?66   $??169,295,0,0q?6Q   $	??Top=?6f   $??60??6~   $??54??6?   ??59      ?? 5:       ?? ImageSource$) #/calendar-interface-symbol-tool.png??6   5<      ?? 5>   
   -   5        $?? ??5>      
?????? $
??Left=?66   $??314,299,0,0q?6Q   $	??Top=?6f   $??60??6~   $??54??6?   ??5?      ?? 5@      $ /stethoscope.png??6   5B      ?? 5D   
   -   5        $?? ??5D      $
??Left=?6   $??456,302,0,0q?67   
?????? $	??Top=?6f   $??62??6~   $??60??6?   ??5E      ?? 5F      $% /book-of-black-cover-closed.png??6   5H      ?? 5J   
   -   5        $?? ??5J      
?????? $
??Left=?66   $??164,416,0,0q?6Q   $	??Top=?6f   $??60??6~   $??54??6?   ??5K      ?? 5L      $ /noticeboard.png??6   5N      ?? 5P   
   -   5        $?? ??5P      $
??Left=?6   $??314,412,0,0q?67   $	??Top=?6L   
?????? $??60??6~   $??54??6?   ??5Q      ?? 5R      $ 	/user.png??6   5T      ?? 5V   
   -   5        $?? ??5V      
?????? $
??Left=?66   $??456,411,0,0q?6Q   $	??Top=?6f   $??60??6~   $??54??6?   ??5W      ?? 5X      $ /patient.png??6   5Z      ?? 5^   
   -   5        $??Tvoj Profil??5^      $
??Bold"?6'   
???????$
??Left=?6L   $??1006,426,0,0q?6g   $	??Top=?6}   $??31??6?   $??96??6?   ???	#FF0066666?   ?? 5`   
   -   5        $??	Odjavi Se??5`      
???????$
??bold"?68   $??31??6J   $??96??6V   $
??Left=?6a   $??1008,509,0,0q?6|   $	??Top=?6?   ???	#FF0066666?   ?? 5d   
   $
??Left=?6   $??164,125,0,0q?6/   $
??Wrap=?6D   $	??Top=?6X   $	??138??5e       $
??Bold"?6,   $??94??6>   $??12(?6J   	 J? RenderTransformOrigin$	 0.165,-1.216&?6X   ?? 6~   $?Osnovni podaci:??6?   ?? 6?   ?? 6?   $?	Prezime :??6?   ?? 6?   ?? 6?   $
?Ime:??6?   ?? 6?   ?? 6?   $?Kontakt:??6?   ?? 6?   ?? 6
  $?E-mail:??6  ?? 6  6,  ?? 5l   
   $
??Left=?6   $??410,887,0,0q?6/   $
??Wrap=?6D   $	??Top=?6X   $??50??6p   $
??Bold"?6|   $	 -0.433,0.579&?6?   $??18(?6?   $	??126??6?   ?? 6?   $?	Soba 773a??6?   ?? 6?   ?? 6?   $?07:00-08:15??6?   6  ?? 5m   
   $??/profile_picture.jpg??6   $??23,127,1077,369q?6.   ?? 5n   
   $
??Left=?6   $	??100??6+   $??1004,291,0,0q?68   $	??Top=?6N   $	??100??6f   $??	/Crni.png??6r   ?? 5o   
   $
??Left=?6   $??563,156,0,0q?6/   $??12(?6D   $
??Bold"?6R   $
??Wrap=?6d   $	??Top=?6x   $??44??6?   $	??143??6?   $	 0.523,1.074&?6?   ?? 6?   $?	Soba 33a:??6?   ?? 6?   ?? 6?   $?07:15 - 08:45??6?   6  ?? 5p   
   $
??Left=?6   $	??136??6/   $??
10,116,0,0q?6<   
???   ?$	??Top=?6_   $
??1136??6w   ?? 5q   
   $
??Left=?6   $	??214??6/   $??962,261,0,0q?6<   
???   ?$	??Top=?6`   $	??184??6x   ?? 5r   
   $
??Left=?6   $
??Bold"?6/   $??14(?6A   $??	17,78,0,0q?6O   $??Naredni Termin:??6b   $
??Wrap=?6y   $	??Top=?6?   ?? 5w   
   $??
Izveštaji??6   $
??Bold"?6$   $
??Left=?66   $??456,368,0,0q?6Q   $	??Top=?6f   $	 -1.611,0.579&?6~   ?? 5x   
   $??Oglasna Tabla??6   $
??Bold"?6(   $
??Left=?6:   $??146,481,0,0q?6U   $	??Top=?6j   $	 -1.611,0.579&?6?   ?? 5y   
   $??Kalendar??6   $
??Bold"?6#   $
??Left=?65   $??169,364,0,0q?6P   $	??Top=?6e   $	 -1.611,0.579&?6}   ?? 5z   
   $??	Pacijenti??6   $
??Bold"?6$   $
??Left=?66   $??452,481,0,0q?6Q   $	??Top=?6f   $	 -1.611,0.579&?6~   ?? 5{   
   $??Novi Termin??6   $
??Bold"?6&   $
??Left=?68   $??302,364,0,0q?6S   $	??Top=?6h   $	 -1.611,0.579&?6?   ?? 5}   
   $??Novi Korisnik??6   $
??Bold"?6(   $
??Left=?6:   $??304,481,0,0q?6U   $	??Top=?6j   $	 -1.611,0.579&?6?   5?      5?      