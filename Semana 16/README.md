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

# Requisitos para rodar o projeto
	Visual Studio 2017 ou superior.
	Git Bash Terminal.

# Instalação do projeto

	 - Rode estes comandos no seu git bash para criar o arquivo de teste, a criação deste arquivo é necesária pois o teste verifica se o aquivo está na pasta temp.
	 	1 - cd 'C:\temp' 
	 	2 - touch test.txt
