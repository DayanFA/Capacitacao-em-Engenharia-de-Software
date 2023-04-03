CREATE TABLE filmes 
(
	Id INT PRIMARY KEY AUTO_INCREMENT,
	Título VARCHAR(255) NOT NULL,
	Estou VARCHAR(255),
	Nota float,
	Ano_Assistido float,
	Crítica TEXT
);
INSERT INTO filmes 
VALUES 
(
	1,
	'O Poderoso Chefão', 
    'Assistindo',
    9, 
    '2022', 
    'Um dos melhores filmes de todos os tempos.'
),
(
	2,
	'O Senhor dos Anéis: A Sociedade do Anel', 
    'Assistido',
    8, 
    '2022', 
    'Adaptação incrível do livro.'
),
(
	3,
	'Pulp Fiction', 
    'Assistido', 
    9, 
    '2022', 
    'Estilo único de Quentin Tarantino.'
),
(
	4,
	'Interestelar', 
    'Planejado',
    NULL,
    NULL,
    NULL
),
(
	5,
	'Coringa', 
    'Assistido', 
    10, 
    '2021', 
    'Atuação impressionante de Joaquin Phoenix.'
),
(
	6,
	'Forrest Gump', 
    'Assistido', 
    8, 
    '2022', 
    'História emocionante e inspiradora.'
),
(
	7,
	'O Iluminado', 
    'Desistido', 
    4, 
    '2022', 
    'Decepcionante e perturbador. Não recomendo.'
),
(
	8,
	'Clube da Luta', 
    'Assistindo',
    NULL,
    NULL,
    NULL
),
(
	9,
	'Matrix', 
    'Assistido',
    9, 
    '2021', 
    'Inovador e cheio de ação.'
)