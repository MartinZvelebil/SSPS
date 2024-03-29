# IDS a IPS

**Systém prevence a detekce průniku (Intrusion Prevention Systems)**

- Slouží k chytré analýze provozu na síti, nečeká se na něj (jako např. u firewallu), sbírají se data do nějakého GUI, kde je mohou lidé nějak analyzovat. Bývají spíše u větších firem.

- NIC Promiscious mode - Jakýkoliv provoz na síti zaznamenán, ihned zasílán dál

- Nedílná součást středních a větších firem - v případě korporátů existence SOC - vyhodnocování bezpečnostních incidentů člověkem v reálném čase

- Nejedná se o automatická pravidla, která pak sama něco dělají, spíše jen podle nějakých pravidel se filtrují data, které pak analyzuje konkrétně člověk. (Platí především u IDS, jelikož IPS již umí na určité hrozby reagovat, kooperovat s Firewallem apod.)

- **IDS** - <u>pasivní systém!</u>

- **IPS** - Rozšíření IDS, umí jak provoz na síti, tak aktivity OS. Zároveň již může komunikovat s Firewallem a může na něco reagovat. Umí také opravovat chybný CRC, chybné řazení TCP paketů apod. - jedná se o <u>aktivní systém!</u>

  

a)  **Popis druhů a jejich využití**

-   **Network-based Intrusion Prevention (NIPS):**

    -   Monitoruje celou síť na podezřelou aktivitu analyzováním síťového provozu.

    -   Např.: Snort

-   **Wireless Intrusion Prevention System (WIPS):**

    -   Monitoruje bezdrátovou síť na podezřelou aktivitu analyzováním síťových **protokolů** bezdrátových sítí.

-   **Network Behavior Analysis (NBA):**

    -   Zkoumá síťový provoz kvůli identifikaci hrozeb, které generují neobvyklý provoz na síti, jako například útoky DDoS (odmítnutí služby), určité formy malware a porušení zásad.

-   **Host-based Intrusion Prevention (HIPS):**

    -   Instalovaný softwarový balíček, který monitoruje jediný počítač na podezřelou aktivitu analyzováním událostí, které se na tomto počítači právě provádí včetně integrity souborů

    - Např.: OSSE
    
      

b)  **IDS Solution -- Jak to funguje**

-   **Signature detection**

    -   Kontrola podpisů podle seznamu podpisů určitých útoků

    -   **Malý počet false positives** - Upozornění systému, na něco, co si myslí, že je hrozba, ale ve skutečnosti není

    -   **Větší počet false negatives** - Upozornění, co jsou reálnou hrozbou, ale systém je nezachytí

    -   Snort

-   **Anomaly Detection**

    - Zjištění normálního provozu - zjišťuje normální chování sítě, podle kterého se učí

    - Upozornění při neobvyklých událostech

    - **Větší počet false positives**

    - **Menší počet false negatives**
    
      ![](./Images/20-output.png)
    
    - Output vypadá jako typický LOG - Čas, source, destination, popis útoku a jeho priorita
    
      

c)  **Nastavení nástrojů**

-   **<https://github.com/StamusNetworks/SELKS> - kombinace různých nástroju (Surikata, elastic, logstash atd.)**
    -   Instalace podobná jako když člověk instaluje čistě Debian
    
    -   Vše pod jednou aplikací
    
-   **Surikata**

    -   Pravidla (sources) si nepíše člověk sám, spíše se někde stahují nebo kupují

    -   Snort pravidla jdou konvertovat na surikatu

-   **Snort**
    -   Pravidla - pokud si platíte, tak je máte o měsíc dříve, za 30 dní od vydání již vychází pro všechny zadarmo
    
    -   Existuje jak pro Linux, tak pro Windows, ale je to napsané spíše pro Linux - pro Windows potřeba změnit některé defaultní konfigurace
    
    -   **Snort.conf** - Soubor pro hlavní konfiguraci snortu, povolování portů, cesty k pravidlům
    
    -   **Local.rules** -- Soubor pro vlastní pravidla pokud nám něco v zakoupených pravidlech chybí (ID 1 000 000 a více je pro vlastní pravidla)
    
    -   `Snort -w` - Všechny interface
    
    -   `-T` pro test `-A` zapnutí, poté následuje otázka, kam vypsat výstup
    
    -   Typický syntax: `snort -i 2 -c c:\Snort\etc\snort.conf -A console`
    
    -   Po ukončení následuje velké shrnutí
    
-   **Elastic search**
    -   Indexovaná databáze - díky indexům dokáže program velmi rychle pracovat s databází
    
-   **Kibana**
    -   Webové rozhraní nad elastic search
    
    -   Vytváří rozhraní, kde jsou zajímavé grafy a informace z elastic searche
    
-   **Kismet**

    -   Bohatý nástroj pro práci s bezdrátovými sítěmi

    -   Součást nástrojové sady je také IDS pro bezdrátové sítě
