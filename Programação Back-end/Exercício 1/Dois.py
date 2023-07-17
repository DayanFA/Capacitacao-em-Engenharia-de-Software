frase = input("Digite uma frase: ")

espacos_em_branco = frase.count(" ")

ocorrencias_vogais = {
    "a": frase.count("a"),
    "e": frase.count("e"),
    "i": frase.count("i"),
    "o": frase.count("o"),
    "u": frase.count("u")
}

print("Quantidade de espaços em branco:", espacos_em_branco)
print("Ocorrências das vogais:", ocorrencias_vogais)
