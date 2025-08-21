namespace AppTarefas.Models
{
    public class Tarefa
    {
        // Nome da chave primaria deve ser Nome da Classse + "ID"
        public int TarefaId { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public bool Concluida { get; set; }
    }
}
