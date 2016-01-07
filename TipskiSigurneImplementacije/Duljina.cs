namespace Vsite.CSharp
{
    struct Duljina
    {
        private int duljina;

        public Duljina(int duljina)
        {
            this.duljina = duljina;
        }

        public override string ToString()
        {
            return string.Format("{0} m", duljina);
        }
    }
}
