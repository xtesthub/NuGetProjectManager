# NuGetProjectManager

### PROJEKTZIEL / BESCHREIBUNG ###

Ein Tool zur NuGet-Packetversion-Erstellung und Veröffentlichung auf dem Firmen-Server

Das Tool soll grob abdecken:
- Inhalt (DLLs / Payload / Cargo wie auch immer :) ) selektieren
- In logische Reihenfolge bringen / Versionen klären
- neues NuSpec-File erstellen
- NuGet-Package erstellen
- NuGet-Package veröffentlichen

### VORBEREITUNGSAUFGABEN UND WEITERBILDUNG ###
- NuGet-Doku anschauen, Verinnerlichen was Packetverwaltung ist
- selbst mal auf Console eine NuGet-Pcket erstellen, um zuwissen _ was die Schritte sind

### GUI_ANFORDERUNG ###
- Grid mit den Packages, welche man schon hat
- Buttons: NEW | EDIT | CREATE | PUSH
- Fenster zur Ordner/DLL-Selektion
- DialogBox zur fallweisen Version-Korrektur des destinierten Paketes
- Menü: mit Item für Config der Umgebung
- Fenster: Config (HOSTs | APIKEYs | WORKING-DIR)

### BACKGROUND-AUFGABEN ###
- Logik zur File-Selektion, Verbringung des Inhalts ins Workin-Dir
- Definitionsfile erstellen, indem grob die Struktur des Erarbeiteten gespeichert wird
- Definition mit Selektion befüllen
- Definition in Specfile überführen
- Specfile schreiben
- fertiges Packet über NuGet-Befehle bündeln
- Packet veröffentlichen
