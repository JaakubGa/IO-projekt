# Specyfikacja dot. panelu zamowien oraz profilu konta w aplikacji _Wypożyczalnia elektronarzędzi_


### 1. Ogólny opis wymagań.  
    1.1 Moim celem jest zaprojektowanie panelu konta użytkownika oraz jego zamówień i jego ogłoszeń. Te dane wyświetlane będą pobierane z bazy danych i wyświetlanie na stronie.




### 2.  Użyta technologia oraz środowisko pracy  
    
  
  | Technologia        | Środowisko   |
| ------------- |:-------------------:|
| 1. C#   |VisualStudioCode |
| 2.  Baza Danych MySQL 5  | SglMenagmentServer        |
| 2.Markdown|VScode        |
| 3.Dane dostępowe|     SglMenagmentServer   |
|   dostęp do bazy danych|     SglMenagmentServer   |

### 3.  Definicja i słownik pojęc.  
    - Klient – osoba, która korzysta z systemu.
	  - System – program, który ma za zadanie ułatwić pracę firmy.
    - Moje ogłoszenia - przedmioty które są wystawione do wypożyczenia dla innych użytkowników.
    - Moje zamówienia - przedmioty które zamówił użytkownik od innych.
    




  

### 4.  Panel i moje zamowienia oraz moje ogloszenia. 
![alt text](https://github.com/JaakubGa/IO-projekt/blob/testy/Specyfikacja/panel.png)
![alt text](https://github.com/JaakubGa/IO-projekt/blob/testy/Specyfikacja/konto.png)
   ### 4.1 Wnioski na podstawie diagramu.  
     Na diagramie widać wstępny wygląd stron.

### 5. Wymagania funkcjonalne 

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
  
    
    




### 6.  Wymagania niefunkcjonalne 
    5.1 System powinen łączyć się z zewnętrzną bazą danych aby wszystkie dane były wyświetlane na stronach.
