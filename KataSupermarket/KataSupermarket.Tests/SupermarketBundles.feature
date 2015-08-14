Funzionalità: Supermarket Bundles
	Al fine di ottenere sconti e offerte
	In qualità di acquirente del Supermercato
	Voglio conoscere il costo dei prodotti e le relative offerte associate

@Bundles
Scenario: compro 1 pezzo del ProdottoA e pago 50 dollari
	Dato che ProdottoA costa 50 dollari
	Dato che compro 1 pezzo
	Quando chiedo il prezzo
	Allora il prezzo è 50 dollari

#Scenario: compro 2 pezzi di A, 1 pezzo di B ed un pezzo di C e pago 120
Scenario: la mia lista è AABC e pago 120
	Dato 2 pezzi di A che costa 50 dollari
	Dato 1 pezzi di B che costa 30 dollari
	Dato 1 pezzi di C che costa 10 dollari
	Dato una offerta per 2 pezzi di A per 80 dollari
	Quando chiedo il prezzo totale
	Allora il prezzo totale è 120 dollari

#Scenario: la mia lista è AABC e pago 120
#	Dato la seguente lista <AABC>
#	Dato una offerta per <2> pezzi di <A> per <80> dollari
#	Quando chiedo il prezzo totale
#	Allora il prezzo totale è <120> dollari
#	
#	Esempi: 
#    | <prodotto> | <prezzo> |
#    | A          | 50       |
#    | B          | 30       |
#    | C          | 10       |