namespace MyProject
{
    public class Curso
    {
        public Curso(string nome, double cargaHoraria, string publicoAlvo, decimal valor)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            PublicoAlvo = publicoAlvo;
            Valor = valor;
        }

        public string Nome { get; set; }
        public double CargaHoraria { get; set; }
        public string PublicoAlvo { get; set; }
        public decimal Valor { get; set; }

        public bool ParaUniversitario()
        {
            if (PublicoAlvo != "Universitário")
                return false;

            return true;
        }
    }
}