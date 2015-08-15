Funzionalità: Supermarket Bundles
	Al fine di ottenere sconti e offerte
	In qualità di acquirente del Supermercato
	Voglio conoscere il costo dei prodotti e le relative offerte associate

@Bundles
Scenario: acquisto AABC e pago 120 dollari
	Dato il seguento listino prezzi:
	| Prodotto | Prezzo |
	| A        | 50     |
	| B        | 30     |
	| C        | 10     |
	Dato le seguenti offerte:
	| Prodotto | Quantità | Prezzo |
	| A        | 2        | 80     |
	Dato la seguente lista di prodotti acquistati AABC
	Quando vado a pagare
	Allora il prezzo totale è 120 dollari

Scenario: acquisto AAABC e pago 170 dollari
	Dato il seguento listino prezzi:
	| Prodotto | Prezzo |
	| A        | 50     |
	| B        | 30     |
	| C        | 10     |
	Dato le seguenti offerte:
	| Prodotto | Quantità | Prezzo |
	| A        | 2        | 80     |
	Dato la seguente lista di prodotti acquistati AAABC
	Quando vado a pagare
	Allora il prezzo totale è 170 dollari