namespace NombresRomains_I1
{
    public static class NombresRomains
    {
        public static string Convertir(int nombreArabe)
            => nombreArabe switch
               {
                   < 4 => new string('I', nombreArabe),
                   4   => "IV",
                   <= 8   => 'V' + Convertir(nombreArabe - 5),
                   9   => "IX",
                   10   => "X",
                   _   => throw new NotSupportedException()
               };
    }
}