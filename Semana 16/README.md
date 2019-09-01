# Testes unitários
	Inovar mais reduzindo a possibilidade de erros do código.
	
# Porque devemos testar o código de forma unitária?
	Para garantir que o código funciona, sobre várias circunstâncias com diversas entradas, aumentando assim a qualidade do código e melhorando também a manipulação de erros através de baby-steps.

# Usando o AAA
	Arrange = 	Iniciar as variaveis;
	Act		=	Invocar o método para testar;
	Assert	=	Verificar a ação;

# Tratando Exceptions
	Expected Exception, eu especifico o typeof() da excesão no decorator.
	Try catch.

# Sobre o desenvolvimento
	O projeto foi desenvolvido por meio docurso de tetes unitários em C# da Udemy (https://www.udemy.com/course/teste-unitario-dotnet/).

# Requisitos para rodar o projeto
	1 Visual Studio 2017 ou superior.
	2 Git Bash Terminal.
	3 Rode estes comandos no seu git bash para criar o arquivo test.txt, a criação deste arquivo é necesária pois o teste (FileNameDoesExisit) verifica se o aquivo está na pasta temp.
	 3.1 cd 'C:\temp' 
	 3.2 touch test.txt

# Execução do projeto
	1 Abra a solução no visual Studio e abra a classe(FileProcessTest.cs).
	2 Clique com o botão direito no corpo da classe e selecione a opção run tests.
