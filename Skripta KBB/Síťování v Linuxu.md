# Síťování v Linuxu

- Při síťování v Linuxu se využívá balíčku net-tools nebo iproute2. Net-tools je nyní považované za zastaralé a ačkoliv stále funguje, tak se nevyužívá tak hojně jako iproute2. Oproti iproute2, tak nepočítá se dvěma ip adresami najednou nebo také zatajuje nějaké informace před uživatelem. Pokud se síťováním v Linuxu začínáte, tak určitě nebude ani jedna z možností krok vedle. V této lekci se zaměříme na oba tyto balíčky, ať si můžete vybrat, který je pro Vás ten lepší.

  

-   #### **Získání aktuální konfigurace:**

**<u>Síťového rozhraní na fyzické (link) i síťové úrovni (ip):</u>**

> `ip [ OPTIONS ] OBJECT { COMMAND | help }`

-   `ip a` - Vypíše seznam IP adres s interface (rozhraními) ke kterými jsou přiřazeny **/** `ip adress show` - iproute2 verze
-   `ip l ls` - Vypíše všechny interface **/** `ip link` - iproute2 verze
-   `ip l ls up` - Vypíše všechny interface, které jsou up (které běží) **/** `ip link ls up` - iproute2 verze

-   `ip route show` - Vypíše routing tabulku včetně default gateway **/** `ip r list` - iproute2 verze



**<u>Nastavení síťových rozhraní:</u>**

<u>Instalace ifconfig</u>

- Pokud nemáme ifconfig, musíme si ho nainstalovat, jelikože je součástí balíčku net-tools nainstalujeme právě jej

  -   `apt-get install net-tools`

  

<u>Shození a nahození rozhraní:</u>

- `ifconfig eth0 up` - Nahodí rozhraní eth0 **/** `ip link set dev eth0 up` - iproute2 verze

- `ifconfig eth0 down` - Shodí rozhraní eth0 **/** `ip link set dev eth0 down` - iproute2 verze

  

<u>Přidání / odebrání / změnění IP konfigurace u síťových rozhraní</u>

-   `ip a add {ip_addr/mask} dev {interface}` - Přiřadí IP adresu vybranému interface / `ip addr add 192.168.1.11/24 dev eth0`

- `ip a del {ipv6_addr_OR_ipv4_addr} dev {interface}` - Odebere IP adresu z vybraného interface **/** `ip addr del 192.168.1.11/24 dev eth0`

  

<u>Získání / přidání / odebrání routing pravidel</u> (iproute2)

- `ip route show` - Vypíše routing tabulku včetně default gateway **/** `ip r list` - iproute2 verze

  

- `ip route add {ip_addr/mask} dev {interface}` - Přidá route (všechny pakety do sítě {ip_addr/mask} půjdou přes interface {interface})

- `ip route delete {ip_addr/mask} dev {interface}` - Odebere route

  

- `ip route add {ip_addr/mask} via {ip_addr} dev {interface}` - Přidá route (všechny pakety do sítě {ip_addr/mask} půjdou přes adresu {ip_addr} a interface {interface})

- `ip route delete {ip_addr/mask} via {ip_addr} dev {interface}` - Odebere route

  

- `ip route add default via {ip_addr/mask}` - Přidá default route

- `ip route del to default via {ip_addr/mask}` - Odebere default route



- #### **Soubor /etc/hosts :**

Slouží k mapování doménových jmen a IP adres

Tento soubor se při výchozím nastavení operačního systému prohledává při překladu domény na IP adresu nejdříve, tedy ještě před dotazováním nastavených DNS serverů. Poté, co se prohledá soubor `etc/hosts`, tak se přechází na soubor `etc/resolv.conf`, kde jsou nakonfigurované DNS servery

Zápisem do tohoto souboru tedy můžete pro svůj počítač, ovlivnit, na jakou IP adresu se bude která doména překládat.

- <u>Např.:</u> (mojedomena.cz se bude překládat na IP adresu 10.0.0.1)

```
# moje mapování
10.0.0.1 	mojedomena.cz www.mojedomena.cz test.mojedomena.cz #\...\... atd
```



- #### **Soubor /etc/resolv.conf:**

Slouží ke konfiguraci používaných DNS Resolverů

Pro upřesnění:

-   DNS klient je jakýkoliv počítač, který posílá DNS dotazy na DNS server

-   DNS Resolver je služba, která předává DNS dotazy na DNS server za účelem překladu

-   DNS server následně překládá (nameserver)

Příkladný obsah:

- search example.com local.lan

- nameserver 1.1.1.1

- nameserver 8.8.8.8

- nameserver 9.9.9.9
