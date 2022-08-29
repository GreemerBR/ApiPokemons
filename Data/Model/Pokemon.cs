namespace Data.Model
{
    public class Pokemon : BaseModel
    {
        public string Nome { get; set; }
        public int NumeroNaPokedex { get; set; }
        public string Tipo1 { get; set; }
        public string Tipo2 { get; set; }

    }
}
