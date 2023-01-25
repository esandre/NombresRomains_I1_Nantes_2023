namespace NombresRomains_I1
{
    public static class NombresRomains
    {
        public static string Convertir(int nombreArabe)
        {
            return nombreArabe < 4 ? new string('I', nombreArabe) : "IV";
        }
    }
}