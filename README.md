# Parlem.FitxaClient.WebApi

## Descripció
Web api utilitzant Clean Arquitecture. 

### Inteface
S'ha implementat swagger
La api no està autenticada. S'hauria d'implimentar la autentificasió.

### Application
S'han implementat casos d'ún que realitzan les crides als repositoris i fan el mapeig de les entitats de domini. Es podria implementar el patró mediator i realitzar el fluxe mitjançant comands i events.

### Domain
Les entitats de domini (Customer i Product) haurien de validar la integritat de les seves dades.

### Infrastructure
S'ha utilitzat dos fitxer json per emular un container de dades amb les dades de clients i de productes contractats. Els repositories es podríen modificar per que accedissin a una base de dades no relacional (p.e. MongoDB).

