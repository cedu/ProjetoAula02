using ProjetoAula02.Controllers;

//instanciando o contralador

var funcionarioController = new FuncionarioController();

//executando o cadastro do funcionário
funcionarioController.CadastrarFuncionario();

//pausar o console do DOS
Console.ReadKey();
