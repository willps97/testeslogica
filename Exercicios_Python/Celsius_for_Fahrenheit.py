"""
Leia uma temperatura em graus Celsius e apresente - a convertida em Fahrenheit.
A fórmula de conversão é: F = C *(9.0/5.0)+32.0, sendo F a temperatura em Fahrenheit e C
a temperatura em Celcius.
"""
c = float (input('Olá digite a temperatura em graus Célsius para ser convertida em Fahrenheit: '))

f = (c * (9/5) + 32)

print(f'O valor de {c} em farenheit é de {f}')
