   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   7 clr-namespace:WpfApp1.ValidationWpfApp1.Validation  5   	   !    WpfApp1.ZaboravljenaLozinka   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   1util clr-namespace:WpfApp1.Validation     5   	     ? Title$  ZaboravljenaLozinka??5
   	   $	??450??6%   $	??800??62   .??5      ? ??5   
   ?? 5       ?? EndPoint$ 0.5,1&?6"    ?? 
StartPoint$ 0.5,0&?63   .??5      ?  ? Color$ white??6   ? 5      $ 	AliceBlue??6    ? Offset$ 1Q?61   5      .+?5   
   ?? $
??Left=?6   $??206,137,0,0q?6/   $A??;Unesite Vašu mail adresu, kako bi Vam stigla nova lozinka!??6D   $??15(?6?   $
??Bold"?6?   $
??Wrap=?6?   $	??Top=?6?   $??37??6?   $	??425??6?   ?? 5   
   $??E-Mail Adresa :??6   $
??Left=?6*   $??133,212,0,0q?6E   $	??Top=?6Z   $
??Bold"?6r   $??18(?6?   $	??145??6?   ?? 5   
   -   5         ??Name$ Mail_Adresa??5      $
??Left=?5       ?? TextWrapping$
 Wrap=?6.   $	??Top=?5      $	??176??6*   $??24??66    J? RenderTransformOrigin$ 0.5,0.5&?6B   $??328,217,0,0q?6b   $
??Bold"?6w   .??6?   ??5      ?? 5       ?? Path$ Email?6   	 ?? UpdateSourceTrigger$	 PropertyChanged=?5      
 ?? Mode$
 TwoWay=?5       ?? ValidationRules 5      '   !WpfApp1.Validation.MailValidation  5      ,  &System.Windows.Controls.ValidationRule   ValidationStep$ RawProposedValue=?6*   5       .??5"       =? ErrorTemplate 5$      ?? 5%      .R?5&      ?  ? ColumnDefinitions 5'      ?? 5(      ?? 5)       ? RowDefinitions 5+      ?? 5,      ?? 5-      .+?5/      ?? $??0??64   $??0??6A   6S   ?? 50      $??0??6$   $??1??64   $??8(?6A   $
??bold"?6q   
???  ????6N   ?? *[0].ErrorContent+6?   ?? 51      $??15(?6    $??0??6.   $??1??6;   
???  ??$
??Bold"?6]   $??Segoe MDL2 Assets)?6o   $	????6?   6?   52      53      .??54   (   56      ?? 57   
   -   5        $??Pošalji zahtev!??57      $
??Left=?6+   $??340,265,0,0q?6F   
???????$	??Top=?6n   $
??Bold"?6?   $??18(?6?   ???	#FF006667$	??152??6?   6?   ?? 58   
   $??Center=?6   $	??100??6-   $??0,10,0,0q?6:   $	??Top=?6L   $	??100??6d   $??/simbol.png??6p   $ 0.701,0.503&?6?   ?? 59   
   -   5        $??Odustani??59      $
??Left=?6$   $??341,327,0,0q?6?   
???????$	??Top=?6g   $
??Bold"?6   $??18(?6?   ???	#FF006667$	??151??6?   6?   5;      5<      