   M S B A M L   `   `   `  ????F  BStockMarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StockMarket.PagesStockMarket.Pages  5          StockMarket.Pages.Catalog   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:StockMarket.Pages     5        N? Title$  Catalog??5	      .??5      ? 
??????? ? ColumnDefinitions 5   
   ?? 5      $??3* ?6   ?? 5       ? RowDefinitions 5   
   ?? 5      ?? 5      $??5* ?6   ?? 5      .+?5   
   ?? $??Каталог акций??6   $
??30px(?6)   $??Center=?69   ?? 5   
   $??	Инфо:??6   $??1??6!   $
??30px(?61   $??Center=?6A   ?? 5   
   -   5         ??Name$ StackBasket??5   2   $??1??6   $??1??6"   .+?5      ??  ?? Orientation$ 
Horizontal=?6   .+?5      ?? $(??"В корзине товаров: ??6   ?? 5      -   5         ??Name$ TxtCount??5      5      ?? 5       .+?5!      ?? -   5         ??Name$ 	btnBasket??5!      $&?? Перейти в корзину??6,   $??0, 10, 30, 0q?6H   6^   5"      5$      ?? 5&   
   $??1??6   .+?5(      ?? $??	40,0,0,50q?6   $??300px??6.   .??5)      ?? .+?5*      ?? -   5         ??Name$ listTemplate??5*      ??5+      ?? 5,      .R?5-   "   ?? $ 
Horizontal=?6-   $??Center=?6F   
???????.+?5.   &   ?? $??100px??6E   ??6,   ?? *Image+6E   ?? 5/   &   $
??20px(?6F   $??100px??6V   $??Center=?6d   $??10q?6   
?????????60   ?? *Name+6?   ?? 50   &   $
??30px(?6_   $??100px??6o   $??Center=?6}   $??	210,0,0,0q?6?   ??60   ?? *Price+ ?? StringFormat$ {0} ₽??6?   52   #   53      55      56      57      59      5:      5;      