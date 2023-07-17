#Função para calcular o fatorial
# 5! = 5x4x3x2x1 = 120.
#função para calcular fatorial com laço de repetição
def fatorial (numero):
    resultado = 1
    for i in range(1, numero+1):
        resultado = resultado * i
    return resultado
fat1= fatorial(1)
print(fat1)
fat6= fatorial(6)
print (fat6)
#função com recursão
def fatorial_recursivo(numero):
    if numero ==1:
        return 1
    return numero * fatorial_recursivo(numero-1)
print(fat1)
fat= fatorial_recursivo(6)
print(fat)
#escreva uma função recursiva que faça contagem regressiva.
def contagem(numero):
    print(numero)
    if (numero == 1):
        numero = 1
        return numero
    return contagem(numero-1)
contagem(10)
#sequencia de Fibonacci
def seq_fib (n):
    if n < 1:
        return 0
    if n<=2:
        return 1
    return seq_fib(n-1) + seq_fib(n-2)
print (seq_fib(10))