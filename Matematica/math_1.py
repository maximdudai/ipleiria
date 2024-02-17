# Entrada de dados
Massa = float(input('Indique a Massa (Kg) -> '))
Altura = float(input('Indique a Altura (m) -> '))
# Cálculos
IMC = Massa / (Altura**2)
if IMC <= 17:
  tipo = 'Muito abaixo do peso'
elif IMC <= 18.49:
  tipo = 'Abaixo do peso'
elif IMC <= 24.99:
  tipo = 'Peso normal'
elif IMC <= 29.99:
  tipo = 'Acima do peso'
elif IMC <= 34.99:
  tipo = 'Obesidade I'
elif IMC <= 39.99:
  tipo = 'Obesidade II (severa)'
else:
  tipo = 'Obesidade III (mórbida)'
# Apresentação de resultados
print('*' * 40)
print('O seu IMC é igual a ',round(IMC,2))
print('e a sua classificação é ' + tipo.upper())