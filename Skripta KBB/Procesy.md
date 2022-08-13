# Procesy

#### Základní vlastnosti procesů v Linuxu:

-   **PID** - Unikátní identifikátor každého procesu (sbin/init - 1. proces) - max 32768 PID

    -   *<u>Fork bomb attack</u>* - Tvorba tolika procesů, že to systém nezvládne

-   **Vlastník / Skupina procesu** - Pokud by například v `dhcpcd` byla chyba, tak dostanu přístup k procesům, které patří právě jemu (jedná se o speciálního dhcp uživatele). Jestliže spustím proces, jsem vlastníkem jako uživatel -> izolace oprávnění

-   **TIME** - Kolik procesorového času daný proces zatím využil

-   **Command -** Argumenty, co k procesu patří (`usr/lib/firefox` apod.)

-   **Priorita** - Způsob jakým procesoru říct, jaký program má přednost před kterým **(-20 maximální priorita, 20 minimální priorita)**

-   **Status (výčet + význam)** - Různé stavy programů

    - (S - nic nevykonává, čeká na signál - idle)

    - (R - právě vykonávaný proces)

    - (T - zastavený)

    - (Z-- žádost o zastavení, ale nevypnul se, visí v paměti - nutnost `forcekill`)
    
      

#### Signály

Procesy ovládáme pomocí signálu. Jejich kompletní seznam nalezneme přes příkaz `htop`, kde procesy spravujeme.

Po stisknutí F9 si zvolím druh signálu a ID procesu. Naprosto nejčastěji využívané jsou dva:

- **SIGKILL -** Násilné zrušení procesu, může dojít k chybě, ztrátě dat apod. = okamžité zrušení procesu

- **SIGTERM -** Žádost o samo vypnutí, uživatelé si můžou uložit svou práci apod. aby vše zůstalo bez problémů

  

#### Jak pracovat s procesy a zjistit informace o nich?

-   `ps` - Nejjednodušší forma práce s procesy, dvojitá syntaxe, vhodný pro automatizaci

    -   `ps` - Pouze vypíše procesy pod aktuálním uživatelem

    -   `ps aux` - Všechny procesy v systému

    -   `ps -e -forrest` - Stromová struktura, jak jsou procesy pod sebou v hierarchické podobě

    -   `ps -u <uživatel>` - Procesy konkrétního uživatele

-   `top` - Interaktivní správce procesů, druhý nejjednodušší

-   `htop` - Potřebuje mnoho věcí kolem, na serverech často není, špatný pro automatizaci, **nejvíce interaktivní**, řídí se pomocí f1-10

-   `renice` - Když chci předělat parametry procesu

- `nice` - Vytvoření nového procesu a zadání parametrů

  

#### Vyhledávání procesů podle uživatele / PID / Commandu / stavu

-   `ps -u <uživatel>`

-   `htop -u <uživatel>`

-   `htop` - Kolonka stavu (S+/S-)



#### Práce s procesy pomocí regulární výrazů

-   `pgrep (-full) st` - Vypíše mnoho informací o procesech zmiňující terminály

-   `pkill (--full) firefox` - Vypne vše, co má v sobě zmínku o Firefoxu

    - **--full** - Parametr, který zajistí vyhledávání daného slova i v argumentech
    
      

#### Monitorování procesů:

-   Získání seznamu otevřených souborů procesem

    -   `tail -f <cesta>` - Čeká na změnu v daném souboru, co pak vypíše

    -   `lsof -p <PID>` - Vo vše běží pod tím daným procesem, ačkoliv se to může tvářit, že se jedná pouze o jeden textový soubor, tak pod ním může být mnoho různých procesů

    -   `lsof +D /tmp` - Práce s adresářem, co vše běží se složkou /tmp, rekurzivní

-   Získání seznamu otevřených socketů (síťových spojení)

    -   `lsof -i` - Jaké různé jsou síťové spojení u procesů

    -   `lsof -Pi | grep LISTEN` - Hledá všechny otevřené porty u procesů

    -   `ss -tnlp` - Otevřené porty, možnost otevřít i za uživatele, všechny tcp (-t) spojení, bez překládání portů
