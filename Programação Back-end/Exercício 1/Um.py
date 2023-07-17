num_alunos = int(input("Digite o número de alunos: "))

notas = []
for i in range(num_alunos):
    nota = float(input(f"Digite a nota do aluno {i+1}: "))
    notas.append(nota)

media = sum(notas) / num_alunos
print("A média das notas é:", media)