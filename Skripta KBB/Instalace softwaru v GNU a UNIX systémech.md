# Instalace softwaru v GNU/UNIX systémech

#### **Použití správce balíčků**

- <u>Co vůbec správce balíčků je?</u>

  -   **Balíčky** = zkompilovaná aplikace v jednom speciálním souboru, který je různý dle distribucí Linuxu ([kompletní seznam](https://cs.wikipedia.org/wiki/Správce_balíčků#Různí_správci_balíčků))
  -   Ve windows známe pouze .msi instalačky, které jsou jednodušší
  -   Jedná se o nástroj pro správu software nainstalovaného v PC
  -   Většinou správce řeší i závislosti = stáhnou automaticky z internetu ostatní programy a knihovny, které aplikace ke svému běhu potřebuje, což je právě jeden z rozdílů oproti sestavení software ze zdrojového kódu
  -   Velmi snadná a pohodlný druh instalace

- Správci balíčků na nejčastějších distribucích Linuxu:

  | Jméno správce | Jméno distribuce                                             |
  | ------------- | ------------------------------------------------------------ |
  | apt           | Debian, Ubuntu (aptitude = vyšší level apt)                  |
  | yum           | Fedora, Red Hat, CentOS                                      |
  | pacman        | Arch Linux                                                   |
  | tgz           | Slackware (Neumí řešit závislosti, jedná se o tar.gz archiv s určenou vnitřní strukturou) |
  | winget        | Windows CMD správce balíčků                                  |

  - Kromě textových správců balíčků existuje také grafický správce balíčků a to například: **Synaptic, Centrum softwaru pro Ubuntu**

  - Pokud chceme konvertovat .rpm balíčky (yum) na .deb (apt), tak k tomu lze využít `alien`

  - **`dpkg --list` - Přehled všech balíčků**

    

- <u>Instalace</u>

  Jak již bylo výše popsáno, tak dle distribucí se liší správce balíčků. Což znamená, že i samotná instalace apod. se bude lišit dle distribuce. Nejčastěji se setkáte s Debianem / Kali, které používá `apt` a tudíž se zaměříme především právě na `apt`

  - `apt-get install balicek` 

    - Nainstaluje do systému zadaný balíček (balíčky)

  - `pacman -S firefox` 

    - Instalace Firefox v Arch Linux

  - `sudo dpkg -i <balík.deb>` 

    - Většinou lze vše řešit také přes dpkg

      

- <u>Smazání</u>

  - `apt-get remove balicek` 

    - Odebere ze systému zadaný balíček / balíčky, při použití parametru `-purge` smažeme také konfigurační soubory

  - `pacman -R firefox` 

    - Odinstaluje Firefox v Arch Linux, při použití `-Rcsn` smažeme také konfigurační soubory

  - `sudo dpkg -r <balík.deb>`

    - Odebrání pomocí dpkg

      

- <u>Aktualizace</u>

  -   `apt-get update`
      -   Aktualizuje seznam balíčků
      
  -   `apt-get upgrade`
      -   Aktualizuje všechny balíčky nainstalované v systému

  Mezi tím, co vlastně znamená update a upgrade se dělá často chyba, doporučuji si tyto dva pojmy objasnit.

  -   `apt-get dist-upgrade`

      -   Upgraduje distribuci (najde aktualizace balíčků)

  -   `pacman -Syu`

      -   Stáhne novou databázi balíčků a upgraduje celý systém
      -   V podstatě se jedná o souhrn veškerých příkazů výše zmíněných, ale opět pouze pro distribuce Arch Linux
      
      

- <u>Repozitáře distribucí</u>

  Je označení pro místo, odkud mohou být staženy a nainstalovány softwarové balíčky, jedná se o nějaký server, který bývá uveden na oficiálních stránkách konkrétní distribuce

  -   `/etc/apt/sources.list` - Seznam repozitářů

  -   **Backports** - repozitáře, které zpřístupňují nové verze vybraných programů ve starší verzi distribuce.
      -   Využíváno u programů, co se často aktualizují (VirtualBox, LibreOffice)
      -   Musí být <u>povoleno</u> v `/etc/apt/sources.list`

  Repozitáře nejčastějších distribucí:

  -   **Arch Linux** - AUR
  -   **Ubuntu** - 4 oficiální repozitáře (main, restricted, universe, multiverse)
  -   **Debian** - Pyšní se obrovským množstvím balíčků v repozitářích

  Pokud nějaký balíček není obsažen v oficiálních repozitářích, tak pro většinu distribucí existuje také velké množství neoficiálních repozitářů.

  

#### **Sestavení software ze zdrojového kódu (kompilace)**

- <u>Teorie a principy</u>

  - `.tar.gz` - Jedná se o více souborů uvnitř jednoho (Obdoba .RAR / .ZIP), uvnitř .sh instalační skript / zdrojové soubory k přeložení

    <span style='color:green'>**+** Nejste závislý, zda software je v distribuci depozitářů, instalujete si verzi jakou chcete nehledě na to, jaká je v repozitářích</span>

    <span style='color:red'>**-** Negarantovaná kompatibilita, nutnost sám hlídat aktualizace</span>

  - Ke kompilaci je nezbytné nejprve si nainstalovat balíčky `build-essential` a `checkinstall`

    

-   <u>ROZBALENÍ:</u>

    - `tar xzf /kde/je/tento/soubor.tar.gz` nebo `tar xjf /kde/je/tento/soubor.tar.bz2`

      -   Po rozbalení je nejlepší cestou číst soubor INSTALL s návodem pokud je takový soubor v adresáři zahrnut

      - Někdy je potřeba kompilace, knihovny nebo například jiné programy

        

-   <u>KOMPILACE</u>

    Překladač provádí přeměnu zdrojového kódu čitelného člověkem na binární kód

    **Takový proces uděláme pomocí:**

    - `./configure`

    - `make`

      -   Ve složce, kde je archiv .tar rozbalený

      

-   <u>INSTALACE</u>

    - `sudo checkinstall -D -y --install`

      -   Jedná se o lepší způsob instalace, jelikož se přidá jako .deb balík a lze s ním manipulovat přes správce balíků

    - `sudo make install`

      -   Nelze ovládat přes správce balíků - pouze `sudo make uninstall`

      

- <u>Kdy využít</u>

  | Klady                                                        | Zápory                                                       |
  | ------------------------------------------------------------ | ------------------------------------------------------------ |
  | <span style='color:green'>Především jde o teoretické zrychlení. Program, který je přeložen přímo pro váš typ hardware by měl běžet (a většinou běží) o něco rychleji</span> | <span style='color:red'>Těžká kontrola nezkušených uživatelů</span> |
  | <span style='color:green'>Stabilita - záleží na okolnostech, nemusí být vždy stabilnější</span> | <span style='color:red'>Kolize s balíčkovacím systémem</span> |
  | <span style='color:green'>Možné nainstalovat balíček i pro nestandartní architekturu, distribuci</span> | <span style='color:red'>Kompilace může zabrat i několik hodin</span> |
  | <span style='color:green'>Můžeme něco přidat do zdrojových kódů programu</span> |                                                              |
