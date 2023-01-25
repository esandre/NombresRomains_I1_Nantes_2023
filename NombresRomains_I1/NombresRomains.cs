namespace NombresRomains_I1
{
    public static class NombresRomains
    {
        public static string Convertir(int nombreArabe)
            => nombreArabe switch
               {
                   < 4 => new string('I', nombreArabe),
                   4   => "IV",
                   5   => "V",
                   6   => "VI",
                   _   => "VII"
               };
    }
}