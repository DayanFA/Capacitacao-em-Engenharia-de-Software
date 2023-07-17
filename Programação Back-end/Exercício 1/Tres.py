pessoas = {}

for _ in range(5):
    nome = input("Digite o nome da pessoa: ")
    altura = float(input("Digite a altura da pessoa (em metros): "))
    peso = float(input("Digite o peso da pessoa (em kg): "))
    pessoas[nome] = {"altura": altura, "peso": peso}

nome_busca = input("Digite um nome para buscar: ")
if nome_busca in pessoas:
    pessoa = pessoas[nome_busca]
    imc = pessoa["peso"] / (pessoa["altura"] ** 2)
    print(f"IMC de {nome_busca}: {imc:.2f}")
else:
    print("Nome não encontrado.")