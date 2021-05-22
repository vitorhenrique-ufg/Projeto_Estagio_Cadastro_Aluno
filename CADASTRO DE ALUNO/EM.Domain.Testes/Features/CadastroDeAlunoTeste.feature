#language:pt-br

Funcionalidade: Cadastrar as Informações de um Aluno
	COMO Coordenador 
	QUERO cadastrar as informações de um determinado aluno
	Para que seus dados possam ser armazenados no sistema

	DEVE verificar se uma matricula é valida ou nao
	DEVE verificar se um determinado Cpf é valido ou nao
	DEVE verificar se uma data de nascimento é valida ou nao
	DEVE verificar se um nome é valido ou nao

@1
Cenario: Aluno informou uma matricula invalida
	Dado que o aluno informou seus dados para o coordenador
	E informou sua matricula como 1234567890		
	E informou seu nome como 'Vitor Henrique'
	E informou seu cpf como '702.163.161-89'
	E informou sua data de nascimento como '23/03/2001'
	E seu sexo como 'Masculino'
	Quando o coordenador verificar a validade dos dados
	Entao e apresentado a mensagem de erro a respeito da Matricula

@2
Cenario: Aluno informou um nome invalido
	Dado que o aluno informou seus dados para o coordenador
	E informou sua matricula como 201610234
	E informou seu nome como ''
	E informou seu cpf como '535.283.790-49'
	E informou sua data de nascimento como '24/05/2016'
	E seu sexo como 'Masculino'
	Quando o coordenador verificar a validade dos dados
	Entao e apresentado a mensagem de erro a respeito do Nome

@3
Cenario: Aluno informou um Cpf valido
	Dado que o aluno informou seus dados para o coordenador
	E informou sua matricula como 201910456	
	E informou seu nome como 'Felipe da Silva'
	E informou seu cpf como '027.232.790-57'
	E informou sua data de nascimento como '24/05/2020'
	E seu sexo como 'Masculino'
	Quando o coordenador verificar a validade dos dados
	Entao nao é apresentado a mensagem de erro

@4
Cenario: Aluno informou um Cpf invalido
	Dado que o aluno informou seus dados para o coordenador
	E informou sua matricula como 201945786	
	E informou seu nome como 'Amanda Menezes'
	E informou seu cpf como '012.650.954-50'
	E informou sua data de nascimento como '15/03/2013'
	E seu sexo como 'Feminino'
	Quando o coordenador verificar a validade dos dados
	Entao e apresentado a mensagem de erro a respeito do Cpf

@5
Cenario: Aluno informou uma Data de Nascimento valida
	Dado que o aluno informou seus dados para o coordenador
	E informou sua matricula como 201643123	
	E informou seu nome como 'Lucas Henrique'
	E informou seu cpf como '636.370.830-35'
	E informou sua data de nascimento como '29/08/2003'
	E seu sexo como 'Masculino'
	Quando o coordenador verificar a validade dos dados
	Entao nao é apresentado a mensagem de erro a respeito da Data de Nascimento

@6
Cenario: Aluno informou uma Data de Nascimento invalida
	Dado que o aluno informou seus dados para o coordenador
	E informou sua matricula como 201645789	
	E informou seu nome como 'Klemerson Oliveira'
	E informou seu cpf como '854.643.070-52'
	E informou sua data de nascimento como '27/11/2020'
	E seu sexo como 'Masculino'
	Quando o coordenador verificar a validade dos dados
	Entao e apresentado a mensagem de erro a respeito da Data de Nascimento