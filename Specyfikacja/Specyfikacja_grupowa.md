# Specyfikacja dot. aplikacji _Wypożyczalnia elektronarzędzi_


### 1. Ogólny opis wymagań.  
    ###1.1 Celem projektu jest zaprojektowanie aplikacji "Wypożyczalnia elektronarzędzi". Wchodzi w nią: wdrożenie platformy do obsługi rejestracji oraz logowania na stronie,
    zaprojektowanie panelu konta użytkownika oraz jego zamówień i jego ogłoszeń(dane wyświetlane będą pobierane z bazy danych i wyświetlanie na stronie),
    zaprojektowanie koszyka oraz dodawania przedmitów do niego, zaprojektowanie strony wyszukiwarki i strona przedmiotu.


### 2.  Użyta technologia oraz środowisko pracy  
    
  
  | Technologia        | Środowisko   |
| ------------- |:-------------------:|
| 1. C#   |VisualStudioCode |
| 2.  Baza Danych MySQL 5  | SglMenagmentServer        |
| 2.Markdown|VScode        |
| 3.Dane dostępowe|     SglMenagmentServer   |
|   dostęp do bazy danych|     SglMenagmentServer   |


### 3.  Definicja i słownik pojęc.  
    -  Klient – osoba, która korzysta z systemu.
	  - System – program, który ma za zadanie ułatwić pracę
    firmy.
    - Sprzedawca - osoba która wystawia i sprzedaje/wypożycza swoje narzędzia
    - Koszyk – miejsce, w którym klient przechowuje interesujace go rzeczy
firmy.
- Moje ogłoszenia - przedmioty które są wystawione do wypożyczenia dla innych użytkowników.
- Moje zamówienia - przedmioty które zamówił użytkownik od innych.
    




  

### 4.  Diagram przypadków użycia. 
![](https://raw.githubusercontent.com/JaakubGa/IO-projekt/testy/Specyfikacja/2021-10-13-20-46-28.png)

   ### 4.1 Wnioski na podstawie diagramu przypadków użycia.  
     Na diagramie widać jak ma odbywać się komunikacja między __klientem__ a __sprzedawcą__.
     Klient korzysta z funkcji opisanych jako _Wypożyczanie sprzętu_ a także _Logowanie/rejestracja_ natomiast nie ma dostępu do _Wystawiania ogłoszeń_.
   ### 4.2 Diagram wyszukiwarki i strony przedmiotu.
   ![alt text](https://github.com/JaakubGa/IO-projekt/blob/testy/Specyfikacja/diagram_sabina.png)
   ### 4.3 Diagram zamówień i ogłoszeń.
   ![alt text](https://github.com/JaakubGa/IO-projekt/blob/testy/Specyfikacja/panel.png)
    ![alt text](https://github.com/JaakubGa/IO-projekt/blob/testy/Specyfikacja/konto.png)

### 5. Wymagania funkcjonalne 

| ID        | Identyfikator wymagania                                                                   |
|-----------|-------------------------------------------------------------------------------------------|
| Nazwa     | Tworzenia konta                                                                           |
| Priorytet | Wysoki                                                                                    |
| Rola      | Wszyscy                                                                                   |
| Opis      | Każdy użytkownik (klient/sprzedawca) może utworzyć  konto dodając tym samym wpis do bazy  |   

  
  | ID        | Identyfikator wymagania                                                                                                                                                        |
|-----------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Nazwa     | Zarządzanie kontami                                                                                                                                                            |
| Priorytet | Wysoki                                                                                                                                                                         |
| Rola      | Wszyscy                                                                                                                                                                        |
| Opis      | Każdy sprzedawca ma możliwość przeglądania swoich ogłoszeń oraz informacji dotyczących kont.  Każdy klient ma możliwość przeglądania swoich zamówień oraz informacji o koncie. |  
  
| ID        | Identyfikator wymagania                                                                   |
|-----------|-------------------------------------------------------------------------------------------|
| Nazwa     | Strona wyszukiwania                                                                       |
| Priorytet | Wysoki                                                                                    |
| Rola      | Wszyscy                                                                                   |
| Opis      | Każdy użytkownik (klient) może wyszukiwać narzędzia po kategori i nazwie, lub samej kategori czy samej nazwie, dodatkowo może zaznaczyć, aby pokazywało mu tylko przedmioty, które są dostępne w interesującym go czasie, po naciśnięciu na jeden z wyświetlonych przedmiotów przekierowywuje klienta na stronę danego przedmiotu. |   

  
  | ID        | Identyfikator wymagania                                                                                                                                                        |
|-----------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Nazwa     | Strona przedmiotu                                                                                                                                                           |
| Priorytet | Wysoki                                                                                                                                                                         |
| Rola      | Wszyscy                                                                                                                                                                        |
| Opis      | Wyświetla wszystkie dane jednego urządzenia oraz jego zdjęcie. Z tej strony można cofnąć się do wyszukiwarki. Pokazuje nam także podstawowe dane osoby wynajmującej. |        

| ID        | Identyfikator wymagania                                                                   |
|-----------|-------------------------------------------------------------------------------------------|
| Nazwa     | Konto użytkownika                                                                     |
| Priorytet | Wysoki                                                                                    |
| Rola      | Wszyscy                                                                                   |
| Opis      | Każdy użytkownik posiada swoje konto w którym sa jego dane które go indentyfikują, bedzie tam takze jego zdjęcia oraz przejscia do zakladki z jego ogloszeniami oraz jego zamowieniami narzedzi które ma otrzymać lub któe są w trakcie, w planach powstanie tam także historia jego zamówień. |   

  
  | ID        | Identyfikator wymagania                                                                                                                                                        |
|-----------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Nazwa     | Moje ogloszenia i moje zamowienia                                                                                                                                                           |
| Priorytet | Wysoki                                                                                                                                                                         |
| Rola      | Wszyscy                                                                                                                                                                        |
| Opis      | Wyświetla wszystkie aktywne ogłoszenia danego uzytkowanika oraz jego aktualne zamowienia na elektronarzedzi i sprzet budowlany. Pokazuje nam także podstawowe dane osoby wynajmującej. |  
  

| ID        | Identyfikator wymagania                                                                             |
|-----------|-----------------------------------------------------------------------------------------------------|
| Nazwa     | Koszyk                                                                                              |
| Priorytet | Wysoki                                                                                              |
| Rola      | Wszyscy                                                                                             |
| Opis      | Każdy użytkownik będzie miał swój osobisty koszyk, do którego może dodać interesujące go narzedzia  |  


| ID        | Identyfikator wymagania                                                                             |
|-----------|-----------------------------------------------------------------------------------------------------|
| Nazwa     | Dodawanie przedmiotu do koszyka                                                                                             |
| Priorytet | Wysoki                                                                                              |
| Rola      | Wszyscy                                                                                             |
| Opis      | Przycisk przy przedmiocie aby dodać go do koszyka  |  


### 6.  Wymagania niefunkcjonalne 
    ###6.1 System powinen łączyć się z zewnętrzną bazą danych (baza użtykowników oraz narzędzi)
