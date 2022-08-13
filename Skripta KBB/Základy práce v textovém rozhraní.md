# Základy práce v textovém rozhraní

a)  **<u>Terminál</u>**

Textové prostředí, které slouží pro komunikaci uživatele s počítačem bez GUI. Lze přes něj spouštět programy, ovládat procesy, pohybovat se po počítači.

Pokud nějaký program v textovém rozhraní neovládáme dokonale, pomůže nám k jejich pochopení jejich help nebo manuál **`(man / --help / -h)`**

Terminál má své proměnné - **`printenv`** je vypíše



b)  **<u>Shell</u>**

Jedná se o interpret příkazů, o označení programu. Shell umožňuje uživateli využívat služby OS, jako např.: spouštět programy, zajišťovat pro ně vstupy, uchovávat apod.

Dělí se na: 

- **Řádkové shelly** (C shell - csh, Bourne Shell -- sh apod.)

- **Grafické shelly** (Cyber shell (České), Macintosh Finder, Průzkumník windows apod.)

  

c)  **<u>Bash (Bourne-Again shell)</u>**

Jeden z UNIX shellů, který interpretuje příkazový řádek. Programovací jazyk.

Každý příkaz, který vykonáváme, má nějakou svoji exit hodnotu. Hodnota s kterou příkaz končí, se dá poté nadále pracovat. Pokud například řetězíme nějaké příkazy za sebe, tak tím můžeme tvořit podmínky. Takže pokud nějaký příkaz selže, tak i přes to můžeme pokračovat ve vykonávání následujících příkazů nebo naopak. Exit hodnotu nalezneme v proměnné **$?**.

Zároveň, když píšeme nějaký skript, můžeme v podmínce určit, že pokud nastane nějaká situace, ukončíme s určitou exit hodnotou. Tohoto docílíme pomocí příkazu **`exit číslo`**.

- Exit s číslem 0 - vše proběhlo v pořádku

- Nenulový exit (1-255) - chyba

  

d)  **<u>Spouštění programů a skriptů</u>**

Jakmile spustíme program, tak se vytvoří nový proces s novým unikátním PID. Seznam všech běžících procesů se dá spravovat. Pro jejich správu využíváme program **`ps`** nebo **`top`**. Jejich interaktivnější variantou je například **`htop`**.

- **`./`** - spustí spustitelný soubor (většinou nějaký script (začíná #!/bin/sh))

  

e)  **<u>Přepínače a parametry</u>**

Většina programů má mnoho možností, jak se s nimi dá pracovat. Jelikož k práci s nimi neužíváme grafické rozhraní, tak pro upřesnění chování programů používáme přepínače a parametry. Většinou mají dvě verze a to zkrácenou a dlouhou. V případě zkrácené se typicky jedná o pomlčku s nějakým písmenem. Jejich delší verze jsou dvě pomlčky následované nějakým slovem z kterého již jasně plyne, co daný přepínač dělá.

**Např.:** -h / --help

**Často využívané pojmy:**

-   ***`ls -l | head | less`*** - <u>Pipeliny</u> = spojení více příkazů do jednoho

-   ***`echo \*.txt`*** - <u>Expanze</u> - zkrácené značky a výrazy (\*, ?)

-   `' '` - Fungují tak, že do shellu vloží přesně to, co je mezi nimi, neinterpretuje proměnné, nýbrž vše, co je uvnitř jednoduchých uvozovek je interpretováno jako string

![JednoduchyUvozovky](./Images/1-jednoduchy_uvozovky.png)

-   **`\`** - Escapování - abychom například \$ mohli zapsat jako \$ a ne jako proměnnou, v podstatě se jedná o totéž jako jednoduché uvozovky, ovšem \ funguje pouze na následující znak

- Také existují speciální znaky, nejčastěji se v textových rozhraních setkáte:

  -   **`\n`** -- zalomení řádku
  -   **`\t`** -- tabulátor apod.

  

f)  **<u>Standardní vstup/výstup/error</u>**

Rozeznáváme 3 hodnoty:

-   stdin - **0** (Vstup)

-   stdout  - **1** (Standartní výstup)

-   stderr - **2** (Standartní chybový výstup)

```
ls 1> ahoj.txt
```

Přesměruje standartní výstup do souboru ahoj.txt



```
ls 2> ahoj.txt
```

Přesměruje standartní chybový výstup do souboru ahoj.txt



```
ls &> ahoj.txt
```

Přesměruje jak chybový, tak standartní výstup do souboru ahoj.txt



```
find /proc -name fd 2> /dev/null
```

Výše zmíněný příkaz přesměruje chybový výstup do speciálního souboru **`/dev/null`** (bezedný koš, co se tam zapíše, to se ihned zahodí) - používá se v případě, že nechceme, aby chybový výstup rušil při řetězovém zpracování čehokoliv



g)  **<u>Přesměrování výstupu a vstupu</u>**

```
ls > vypis.txt
```

**Výstup** příkazu ls je přesměrován do souboru vypis.txt, přepíše soubor



```
ls >> vypis.txt
```

Výstup příkazu ls je přesměrován do souboru vypis.txt, ale připíše na konec souboru = to, co v souboru do té doby bylo, tam zůstane



```
head < vypis.txt
```

Přesměrování **vstupu** 



```
head < vypis.txt > kratky_vypis.txt
```

Kombinace obou výše zmíněných



```
2>&1
```

**Přesměrování chybového výstupu do standardního výstupu**



h)  **<u>Seznam užitečných a často používaných klávesových zkratek pro terminál</u>**

- **CTRL + A** -- Přesune kurzor na začátek
- **CTRL + E** -- Přesune kurzor na konec
- **CTRL + R** -- Příkaz v historii hledá
- **CTRL + K** -- Odstraní text před kurzorem
- **CTRL + \<** - přemisťuje rychleji v příkazu
- **Shift + Ctrl + C** - kopírovat
- **Shift + Ctrl + V** - vložit

- **Shift + Ctrl + T** -- nová karta
- **Shift + Ctrl + N** -- nové okno
