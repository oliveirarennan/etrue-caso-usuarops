namespace Casos_de_Usuarios{
  public class GerenciadorPerguntasRespostas{
    private List<PerguntaResposta> listaPerguntasRespostas;

    public GerenciadorPerguntasRespostas(){
      listaPerguntasRespostas = new List<PerguntaResposta>();
    }

    public void AdicionarPerguntaResposta(string pergunta, string resposta){
      listaPerguntasRespostas.Add(new PerguntaResposta{
        Pergunta = pergunta,
        Resposta = resposta
      });
    }

    public void ExportarParaArquivo(string caminhoArquivo){
      using(StreamWriter escritor = File.CreateText(caminhoArquivo)){
        foreach(var item in listaPerguntasRespostas){
          escritor.WriteLine($"Pergunta: {item.Pergunta}");
          escritor.WriteLine($"Resposta: {item.Resposta}");
          escritor.WriteLine("");
        }
      }
      Console.WriteLine($"Perguntas e respostas salvas em '{caminhoArquivo}'.");
    }
  }
}