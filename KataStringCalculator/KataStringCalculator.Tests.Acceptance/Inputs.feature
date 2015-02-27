Funzionalità: Calcolo della somma di una sequenza di numeri
	Al fine di ottenere il risultato di una addizione
	In qualità di calcolatore 
	Voglio calcolare la somma di una sequenza di numeri separati da virgola

Scenario: se la sequenza è vuota, allora il risultato è 0
	Data una stringa vuota
	Quando eseguo il calcolo
	Allora il risultato è:0

Schema dello scenario: se la sequenza contiene un numero, allora il risultato è quel numero
	Data la seguente stringa:<Stringa>
	Quando eseguo il calcolo
	Allora il risultato è:<Risultato>
	Esempi:
	| Stringa | Risultato |
	| 1       | 1         |
	| 2       | 2         |
	| 9       | 9         |
	| 13      | 13        |
	| 123     | 123       |
	| 1234    | 1234      |

Schema dello scenario: se la sequenza contiene due numeri separati da virgola, allora il risultato è la somma di quei numeri
	Data la seguente stringa:<Stringa>
	Quando eseguo il calcolo
	Allora il risultato è:<Risultato>
	Esempi:
	| Stringa | Risultato |
	| 0,      | 0         |
	| 1,      | 1         |
	| 1,2     | 3         |
	| 13,23   | 36        |
	| 145,23  | 168       |
	| 1234,2  | 1236      |

Schema dello scenario: se la sequenza contiene diversi numeri separati da virgola, allora il risultato è la somma di quei numeri
	Data la seguente stringa:<Stringa>
	Quando eseguo il calcolo
	Allora il risultato è:<Risultato>
	Esempi:
	| Stringa     | Risultato |
	| 1,2,3,4,5,6 | 21        |
	| 0,10,33,456 | 499       |
