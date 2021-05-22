#language:pt-br

Funcionalidade: Realizar manipulações com os dados de um aluno
	COMO coordenador da Escola
	QUERO poder realizar manipulações com os dados cadastrados de um aluno
	PARA que seja capaz de atraves do repositorio dos alunos ter controle de todos os dados cadastrados

	DEVE adicionar um aluno ao repositorio
	DEVE remover um aluno do repositorio
	DEVE atualizar os dados de um aluno do repositorio
	DEVE conseguir mostrar os dados de um aluno pela matricula ou nome

@1
Cenario: Adicionar Aluno ao Repositorio
	Dado que um aluno informou seus dados para o coordenador
	E informou seu NOME como 'Amanda da Silva'
	E informou seu CPF como '068.186.412-53'
	E informou sua matricula como 10
	E informou sua data de Nascimento como '24/05/2012'
	E informou seu sexo como 'Feminino'
	Quando o coordenador processar essas informacoes
	Entao o aluno deve ser adicionado ao Repositorio

@2
Cenario: Aluno com a matricula ja cadastrada no Repositorio
	Dado que um aluno informou seus dados para o coordenador
	E informou seu NOME como 'Felipe da Silveira'
	E informou seu CPF como '828.775.410-02'
	E informou sua matricula como 201910913
	E informou sua data de Nascimento como '29/04/2012'
	E informou seu sexo como 'Masculino'
	Quando o coordenador processar essas informacoes
	Entao o aluno nao deve ser adicionado ao Repositorio

@3
Cenario: Remover Aluno do Repositorio
	Dado que o coordenador tem em maos os dados do Aluno
	E o seu nome e 'Vitor Henrique'
	E a matricula e 201910913
	E o Cpf e '702.163.161-89'
	E a data de Nascimento e '23/03/2001'
	E o sexo e 'Masculino'
	Quando o coordenador confirmar a exclusao 
	Entao o aluno e removido do repositorio

@4
Cenario: Atualizando dados de um aluno do Repositorio
	Dado que o coordenador tem em maos os dados do Aluno e deseja atualiza-los
	E a matricula do aluno e 201915945
	E o nome do aluno e 'Lucas'
	E o Cpf e '255.582.240-29'
	E a data de Nascimento e '29/08/2006'
	E o sexo e 'Masculino'
	Quando o coordenador localizar os dados do aluno para atualiza-los
	Entao os dados sao atualizados

@5
Cenario: Nao foi possivel atualizar dados de um Aluno, pois as informações estavam incompatíveis
	Dado que o coordenador tem em maos os dados do Aluno e deseja atualiza-los
	E a matricula do aluno e 201945678
	E o nome do aluno e 'Amanda da Silva'
	E o Cpf e '113.456.987-02'
	E a data de Nascimento e '24/05/2012'
	E o sexo e 'Feminino'
	Quando o coordenador localizar os dados do aluno para atualiza-los
	Entao os dados nao sao atualizados

@6
Cenario: Consultando dados de Alunos atraves do Nome
	Dado que existam varios alunos no repositorio
	E o coordenador deseja saber os alunos que possuem 'a' no nome
	Quando o coordenador realizar a busca 
	Entao ele recebe a filtragem da pesquisa pelo Nome

@7
Cenario: Consultando dados de Alunos atraves da Matricula
	Dado que existam varios alunos no repositorio
	E o coordenador deseja saber o aluno que possui a matricula 202031245
	Quando o coordenador realizar a busca
	Entao ele recebe a filtragem da pesquisa pela Matricula

@8
Cenario: Consultando todos os Alunos presentes no Repositorio
	Dado que existam varios alunos no repositorio
	E o coordenador deseja ver os dados de todos os alunos
	Quando o coordenador realizar a busca
	Entao ele recebe os dados de todos os alunos 