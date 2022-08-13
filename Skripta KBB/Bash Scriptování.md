## Bash skriptování

**Shell** je interpretr pro uživatelské rozhraní v okně terminálu. **Shell** může být použit se spuštění skriptů i v neinteraktivní session terminálu stejně, jako by byl příkaz přímo vypsán a spuštěn.

```bash
#!/bin/bash
find ~/Music -name "*.mp3" -ls
```

První řádek skriptu je ``#!/bin/bash``. Jedná se o absolutní cestu k interpretru, který má daný skript vykonat. 

Často používané interpretry mohou být tyto:

```
/usr/bin/perl
/bin/bash
/bin/csh
/bin/tcsh
/bin/ksh
/usr/bin/python
/bin/sh
```

Skriptování není omezené pouze na **bash** shell. Stejnou cestou můžete vytvářet skripty i pro **Python**.

```python
# ls -la skript.py
-rwxr--r--. 1 root root 55 Mar  3 15:22 script
# cat skript.py
#!/usr/bin/python
print "Vítej v python skriptu!"
# ./skript.py
Vítej v python skriptu!
```

Skripty mohou být i interaktivní.

```bash
# cat skript.sh
#!/bin/bash
   # Interaktivní zápis do proměnné
   echo "Zadejte své jméno"
   read sname
   # Výpis hodnoty proměnné
   echo "Vítej "$sname"!"
# ./skript.sh
Zadejte své jméno
Karel
Vítej Karel!
```

Všechny skripty generují návratovou hodnotu. Tato návratová hodnota může být nastavena pomocí příkazu ``exit``. Tyto hodnoty se hodí pro informování zřetězených akcí o výsledku předchozího vykonaného skriptu. Typicky ve vztahu nadřazený-potokem. Z konvence plyne, že návratová hodnota pro úspěšné vykonání skriptu je **0** a naopak hodnoty pro chybu jsou jiné než nula (non-zero). Návratové hodnoty jsou vždy po vykonání skriptu zapsány do environment proměnné ``$?``.

```bash
# cat jmena.txt
01 Karel Čapek
02 Petr Čech
03 Petr Novotný
04 Don Juan
# echo $?
0
# cat jmena
cat: names: No such file or directory
# echo $?
1
```

#### Základní syntaxe

| Znak | Popis                                                        |
| ---- | ------------------------------------------------------------ |
| #    | Komentář. Příkazy za znakem komentáře nebudou vykonány.      |
| \    | Další řádek vnímá jako jeden celistvý příkaz.                |
| ;    | Odděluje příkazy. Za tímto znakem vykoná další příkaz na stejném řádku. |
| $    | Označuje proměnnou.                                          |

Někdy potřebujete vykonat několik příkazů na jednom řádku. Toho můžete docílit pomocí ``středníku``.

```bash
$ make ; make install ; make clean
```

Také se hodí reagovat na výsledek předchozího příkazu. K tomu slouží ``ampersand``. Pokud předchozí příkaz vrátí ``non-zero``návratovou hodnotu, tak se celá sekvence příkazů ukončí.

```bash
$ make && make install && make clean
```

Další možností je operátor ``or``, který se v **bash** syntaxi značí pomocí znaku ``svislé čáry``, známé také jako ``pipe``. V takovém případě se vykonávání jednotlivých příkazů ukončí v moměntě, kdy je jeden úspěšně vykonán a vrátí návratovou hodnotu **0**.

```bash
$ cat soubor1 || cat soubor2 || cat soubor3
```

#### Funkce

Funkce je blok kódu, který obsahuje sekvenci příkazů. Funkce můžeme znát i z dalších programovacích jazyků například pod názvem ``metody``.

Funkce se používají, pokud chceme stejnou proceduru použít vícekrát v jednom skriptu. Fuknce jsou často nazývány ``metody``, nebo ``subrutiny``.

Použití funkce ve skriptu vyžaduje dvě operace:

	1. Deklarace funkce
 	2. Zavolání funkce

Deklarace funkce může vypadat takto:

```bash
moje_funkce () {
	prikaz...
}
```

Například můžeme vytvořit následující funkci, která bude jednoduše vypisovat prostý text:

```bash
ahoj_svete() {
	echo "Ahoj světe!"
}
```

#### Parametry

Další základní operací je předávání parametrů do skriptu. Parametry jsou přístupné pod proměnnými: ``$1, $2, $3 ..., $n``. Název vykonávaného skriptu je ukryt v proměnné ``$0``. Všechny parametry jsou přístupné pod proměnnou ``$*`` a celkový počet parametrů najdete uložený v proměnné ``$#``.

```bash
# cat skript.sh
#!/bin/bash
echo Název skriptu je: $0
echo První parametr: $1
echo Druhý parametr: $2
echo Třetí parametr: $3
echo Všechny parametry: $*
exit 0
```

```bash
# ./skript.sh A B C
Název skriptu je: ./skript.sh
První parametr: A
Druhý parametr: B
Třetí parametr: C
Všechny parametry: A B C
```

### Vyhodnocení vnořeného příkazu

Pokud potřebujete spustit ve vašem skriptu příkaz a následně zpracovat jeho výsledek, tak to můžete provést dvěma způsoby:

1. Pomocí zpětných uvozovek ``(`)``
2. Pomocí zápisu příkazu do: ``$( )``

Bez ohledu na metodu, kterou zvolíte, tak se vnořený příkaz spustí v nové instanci shellu a standardní výstup daného příkazu bude dosazen na místo, kde jste jej deklarovali ve vašem skriptu.

Obě metody dovolují vnoření příkazu, ale druhá z výše zmíněných dovoluje ``command nesting``.

```bash
# cat ./count.sh
#!/bin/bash
echo "Soubor " $1 " obsahuje " $(wc -l < $1) " řádků."
echo $?
```

```bash
# ./count.sh /var/log/messages
Soubor  /var/log/messages  obsahuje  114  řádků.
0
```

V tomto příkladu se první  parametr stává vstupem pro vnořený příkaz.

### Podmínka If

Podmínka za použití příkazu ``if`` je základním stavebním kamenem, které můžeme využít ve většině programovacích a skriptovacích jazyků. Při použití příkazu ``if`` je další akce závyslá na vyhodnocení podmínek, které byly podmínce ``if`` předány. Například:

- Porovnání čísledných hodnot, nebo textových řetězců
- Návratová hodnota příkazu
- Existence souboru, nebo jeho oprávnění

Jednořádkový zápis podmínky ``if`` může vypadat takto:

```
if TEST-COMMANDS; then CONSEQUENT-COMMANDS; fi
```

Oběcnější zápis vypadá takto:

```bash
if podminka
then
       prikaz
else
       prikaz
fi
```

Následující skript zkontroluje existenci souboru, ke kterému je předána cesta jako první parametr a následně vypíše zprávu.

```bash
#!/bin/bash
if [ -f $1 ]
then
    echo "Soubor " $1 " obsahuje " $(wc -l < $1) " řádků.";
    echo $?
fi
```

```bash
# ./count.sh /etc/passwd
Soubor  /etc/passwd  obsahuje  35  řádků.
0
```



Možnosti vyhodnocení souboru

| Možnost   | Akce                                              |
| --------- | ------------------------------------------------- |
| -e soubor | Vyhodnocuje existenci souboru.                    |
| -d soubor | Vyhodnocuje, jestli se jedná o adresář.           |
| -f soubor | Vyhodnocuje, jestli se jedná o standardní soubor. |
| -s soubor | Vyhodnocuje, jestli není soubor prázdný.          |
| -g soubor | Vyhodnocuje, jestli má soubor příznak sgid.       |
| -u soubor | Vyhodnocuje, jestli má soubor příznak suid.       |
| -r soubor | Vyhodnocuje, jestli je soubor čitelný.            |
| -w soubor | Vyhodnocuje, jestli je soubor zapisovatelný.      |
| -x soubor | Vyhodnocuje, jestli je soubor spustitelný.        |



Můžete použít podmínku ``if`` k porovnání textových řetězců:

```bash
if [ text1 == text2 ]
then
   prikaz
fi
```

Nebo porovnat číselné hodnoty:

```bash
if [ exp1 OPERATOR exp2 ]
then
   prikaz
fi
```

Dostupné operátory vztahu jsou:

| Operátor | Akce              |
| -------- | ----------------- |
| -eq      | Rovná se          |
| -ne      | Nerovná se        |
| -gt      | Větší než         |
| -lt      | Menší než         |
| -ge      | Větší, nebo rovno |
| -le      | Menší, nebo rovno |