# Specyfikacja dot. logowania/rejestracji użytkownika w aplikacji _Wypożyczalnia elektronarzędzi_


### 1. Ogólny opis wymagań.  
    1.1 Celem projektu jest zaprojektowanie i wdrożenie platformy do obsługi rejestracji oraz logowania na stronie __wypożyczalni elektronarzędzi__.
    Przedstawia wynik fazy analizy i przedstawia specyfikację wymagań dostarczoną przez klienta w dogodny i przejrzysty sposób. 




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
    




  

### 4.  Diagram przypadków użycia. 
![](https://raw.githubusercontent.com/JaakubGa/IO-projekt/testy/Specyfikacja/2021-10-13-20-46-28.png)

   ### 4.1 Wnioski na podstawie diagramu przypadków użycia.  
     Na diagramie widać jak ma odbywać się komunikacja między __klientem__ a __sprzedawcą__.
     Klient korzysta z funkcji opisanych jako _Wypożyczanie sprzętu_ a także _Logowanie/rejestracja_ natomiast nie ma dostępu do _Wystawiania ogłoszeń_.

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
  
      

### 6. Szkic interfejsu  
     

    




### 7.  Wymagania niefunkcjonalne 
    5.1 System powinen łączyć się z zewnętrzną bazą danych (baza użtykowników oraz narzędzi)