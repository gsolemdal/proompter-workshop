# Dårlig kode med ChatGPT #

Du har overtatt et stykke kode fra en tidligere kollega. Koden er uorganisert, dårlig kommentert og inneholder flere feil. Din oppgave er å bruke ChatGPT til å forstå, forbedre og feilsøke koden. Koden er som følger:

```python
import random

def numrs(n):
  if n == 1:
    return random.randint(1, 100)
  elif n == 2:
    return [random.randint(1, 100) for _ in range(10)]
  elif n == 3:
    return [random.randint(1, 100) for _ in range(10)], [random.randint(1, 100) for _ in range(10)]
  else:
    print("Wrong input")

def adder(lst1, lst2):
  return [a + b for a, b in zip(lst1, lst2)]

def operation(n):
  if n == 1:
    print(numrs(1))
  elif n == 2:
    print(numrs(2))
  elif n == 3:
    print(adder(numrs(3)[0], numrs(3)[1]))
  else:
    print("Wrong input")

operation(3)
```

**Trinn 1: Forstå Koden**
Bruk ChatGPT til å forstå hva denne koden gjør. Still spørsmål om deler av koden du ikke forstår og noter ned funksjonaliteten til hver funksjon.

**Trinn 2: Identifisere Dårlige Praksiser**
Gjennomgå koden og identifiser dårlige praksiser. Dette kan inkludere dårlig navngiving, mangel på kommentarer, unødvendig kompleksitet, og andre ting. Still spørsmål til ChatGPT for å få forslag til forbedringer.

**Trinn 3: Feilsøking**
Kjør koden og identifiser eventuelle feil eller problemer. Bruk ChatGPT til å hjelpe deg med å feilsøke og løse disse problemene. Forsikre deg om at alle funksjonene i koden fungerer som forventet når du er ferdig.

**Trinn 4: Forbedre Koden**
Bruk tilbakemeldingene du har fått fra ChatGPT til å forbedre koden. Dette kan inkludere å omskrive deler av koden, legge til kommentarer, endre navn på variabler og funksjoner, og generell kodeopprensing.

**Trinn 5: Refleksjon**
Reflekter over prosessen. Hvordan hjalp ChatGPT deg med å forstå, forbedre og feilsøke koden? Hva lærte du underveis? Hva ville du gjort annerledes neste gang?
