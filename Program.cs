using Casos_de_Usuarios;

class Program{
  static void Main(string[] args){
    GerenciadorPerguntasRespostas gerenciador = new GerenciadorPerguntasRespostas();

    while(true) {
      Console.WriteLine("Digite a pergunta (ou 'sair' para terminar): ");
      string pergunta = Console.ReadLine();

      if(pergunta.ToLower() == "sair") {
        break;
      }

      Console.WriteLine("Digite a resposta: ");
      string resposta = Console.ReadLine();

      gerenciador.AdicionarPerguntaResposta(pergunta, resposta);
    }

    gerenciador.ExportarParaArquivo("perguntas_e_respostas.txt");

    Console.ReadLine();
}
  
}
