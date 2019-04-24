# CaixeiroViajanteGuloso
Trabalho final da disciplina DevOps e Arquiteturas para Entrega Contínua, neste projeto foram realizados todos os requisitos solicitados na tarefa, conforme abaixo:

[![Quality gate](https://sonarcloud.io/api/project_badges/quality_gate?project=otavioreis_CaixeiroViajanteGuloso)](https://sonarcloud.io/dashboard?id=otavioreis_CaixeiroViajanteGuloso) <br/>
[![Build Status](https://dev.azure.com/arquiteturadevops/CaixeiroViajanteGuloso/_apis/build/status/otavioreis.CaixeiroViajanteGuloso?branchName=master)](https://dev.azure.com/arquiteturadevops/CaixeiroViajanteGuloso/_build/latest?definitionId=7&branchName=master)
[![Build Status GitLab](https://gitlab.com/otavioreis/CaixeiroViajanteGuloso/badges/master/pipeline.svg)](https://gitlab.com/otavioreis/CaixeiroViajanteGuloso/badges/master/pipeline.svg)
## Grupo
**_OTÁVIO AUGUSTO REIS_**<br />
**_FREDERICO BITENCOURT_**<br />
**_MATEUS SORIANO_**<br />


O objetivo desse trabalho é criar um pipeline DevOps que contemple pelo menos as seguintes
ferramentas:
- GitHub (para gestão de configuração de código)
- SonarQube (para qualidade contínua de código)
- xUnit (para automação de testes de unidade)
- Slack (para automação da comunicação técnica)
- GitLab (para CI e CD)
- Docker (para conteinerização)
- Heroku (para provisionamento de nuvem)
- Terraform (para implementar IAC)
- Gremlim (para testes de engenharia de caos)

O problema de negócio a ser automatizado com o pipeline acima é o seguinte
Exemplo (João, o caixeiro viajante). O João é um caixeiro viajante que tem clientes em cinco
cidades, que abreviamos por A, B, C, D e E. Ele precisa de planear uma viagem de negócios com
cidade de partida e de destino final A (a cidade onde mora), passando por cada uma das
restantes quatro cidades precisamente uma vez. O grafo abaixo representa o custo de cada
viagem (em qualquer um dos sentidos) entre cada par de cidades.

Qual o percurso mais barato para esta viagem do João? Por outras palavras, pretendemos
encontrar um ciclo Hamiltoniano ótimo no grafo dado (isto ́e, um ciclo Hamiltoniano cuja soma do
peso das arestas é mínimo).
Um detalhamento maior do problema e orientações para solução são apresentados aqui:
https://en.wikipedia.org/wiki/Travelling_salesman_problem
Requisitos da Entrega:
- Implementar o algoritmo manualmente em Java, C#, PHP, Python ou JS. Não é
permitido usar bibliotecas que implementam esse algoritmo.
- Criar automação de testes de unidade com cobertura de 100%
- Possuir cinco experimentos de Engenharia do Caos com o Gremlim
(https://principlesofchaos.org)
- Contemplar todas as ferramentas citadas na página 1
- Todo o código fonte e o código do pipeline devem ser disponibilizado no GitHub
- O seu código deve rodar em ambiente Linux ou Windows.
Requisitos Opcionais:
- Você pode incluir outras ferramentas além das ferramentas citadas na página 1.
- Abordagens adicionais de testes podem ser usadas tais como TDD ou BDD.
