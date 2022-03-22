# Knowledge-journey Documentation

## Sentry

Um sentry auf windows benutzen zu können muss man "wsl2" installieren und eingerichtet haben.
Und dann von dort aus in den sentry-ordner navigieren und das "./install.sh" skript ausführen(wie in der [Sentry-doku](https://develop.sentry.dev/self-hosted/)).
Falls dann der Fehler kommt dasdocker nicht erkannt wird in wsl dann [folgende](https://everythingtech.dev/2021/06/how-to-fix-docker-could-not-be-found-ubuntu-20-04-wsl-2-windows-10/) Schritte ausprobieren.

Die installation kann einige Minuten dauern. Sobald diese fertig ist kann man den "docker-compose up"-Befehl auch aus windows ausführen.

Für weiter Infos, zu mehr konfigurationen und änlichem siehe die [offizelle Doku](https://develop.sentry.dev/self-hosted/) zum "self-hosten"

> Die Nutzung von WSL2 ist auf Windows Betriebssystemen notwendig um sentry zu installieren

