# Testes unitários
	Inovar mais reduzindo a possibilidade de erros do código.
	
# Porque devemos testar o código de forma unitária?
	Para garantir que o código funciona, sobre várias circunstâncias com diversas entradas, aumentando assim a qualidade 
	do código e melhorando também a manipulação de erros através de baby-steps.

# Usando o AAA
	Arrange = 	Iniciar as variaveis;
	Act		=	Invocar o método para testar;
	Assert	=	Verificar a ação;

# Tratando Exceptions
	Expected Exception, eu especifico o typeof() da excesão no decorator.
	Try catch.

# Boas práticas
	Evitar código grande e complicado, ultilizar costantes semore que possível e armazenar configuralções nos arquivos .config,
	criar sempre os testes unitários perto do código a ser testado, usar bons nomes para variaveis e métodos.

# Sobre o desenvolvimento
	O projeto foi desenvolvido por meio docurso de tetes unitários em C# da Udemy (https://www.udemy.com/course/teste-unitario-dotnet/).

# Requisitos para rodar o projeto
	1 Visual Studio 2017 ou superior.
	
# Execução do projeto
	1 Abra a solução no visual Studio e abra a classe(FileProcessTest.cs).
	2 Clique com o botão direito no corpo da classe e selecione a opção run tests.

