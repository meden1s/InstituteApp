# Návrh datové mapy

Formát: název – datový typ – příklad hodnoty\
Položky světle šedé nemusíte implementovat na začátku vývoje.\

## 1) Skupinka:

Zkratka – string - SWI\
Ročník – int – 4\
Semestr – enum – LS\
Počet studentů – int – 36\
Forma studia – enum – P\
Typ studia – enum – Bc.\
Jazyk – enum – cz\


Doplňující info, zatím bez přímého vlivu na aplikaci:

Název – string – Softwareové inženýrství
Seznam předmětů – List<Předmět> - množina referencí na 2)

## 2) Předmět

Zkratka (jednoznačný identifikátor) – string – AP8PO
Počet týdnů – int – 14 defaultně (u kombinovaného studia, vždy 1)
Hodiny přednášek – int – 1
Hodiny cvičení – int – 3
Hodiny seminářů – int – 2
Způsob zakončení – enum – z, zk
Jazyk – enum – cz
Velikost třídy – int – 24 (defaultně 24, často 12, 0 u kom)
Seznam skupin – List<Skupinka> - množina referencí na 1)

Doplňující info, zatím bez přímého vlivu na aplikaci:

Název předmětu – string – Pokročilé programování
Počet kreditů – int - 5
Garantující ústav – enum – UIUI
Jméno garanta – string – Pavel Vařacha 

## 3) Zaměstnanec 

Jméno – string – Pavel
Příjmení – string - Vařacha
Celé jméno – Jméno + Příjmení – Pavel Vařacha
Pracovní e-mail – string – varacha@utb.cz
Soukromý e-mail – string – pavel.varacha@gmail.com
Pracovní body bez angličtiny – int – 526 (Toto nebude vlastnost, ale metoda.)
Pracovní body – int – 767 (Toto nebude vlastnost, ale metoda.)
Doktorand – bool - false
Úvazek – double – 0 až 1 (0 zaměstnanec na dohodu, nebo doktorand, jinak procento)
Seznam štítků – List<Pracovní štítek> - množina referencí na 4)

Doplňující info, zatím bez přímého vlivu na aplikaci:

Pracovní telefon – string - +420 576 035 186
Soukromý telefon – string – 777567135

## 4) Pracovní štítek

Název – string – Cvičení AP8PO 1
Zaměstnanec – reference na 4) – (Pavel Vařacha) nebo null
Předmět – reference na 2) – (AP8PO) nebo null 
Typ – enum – přednáška, cvičení, seminář, zápočet, klasifikovaný zápočet zkouška
Počet studentů – int – 11
Počet hodin – int – 0 u z, zk, kl, protože se počítá na člověka, číslo u p, c, s, (např. 2)
Počet týdnů – int – 0 u z, zk, kl, protože se počítá na člověka, číslo u p, c, s, (např. 14)
Jazyk – enum – cz
Počet bodů za pracovní štítek – int – 12.5 (Toto nebude vlastnost, ale metoda.)

## 5) Váhy pracovních bodů

(Doplňující model, který se po spuštění aplikace načte z XML, nebo databáze, někam do GlobalConfig.)

Hodina přednášky – double – 1,8
Hodina cvičení – double – 1,2
Hodina semináře – double – 1,2
Hodina přednášky anglicky – double – 2,4
Hodina cvičení anglicky – double – 1,8
Hodina semináře anglicky – double – 1,8
Udělení jednoho zápočtu – double – 0,2
Udělení jednoho klasifikovaného zápočtu – double – 0,3
Udělení jedné zkoušky – double – 0,4
Udělení jednoho zápočtu anglicky – double – 0,2
Udělení jednoho klasifikovaného zápočtu anglicky – double – 0,3
Udělení jedné zkoušky – anglicky - double – 0,4
