﻿namespace NombresRomains_I1
{
    public static class NombresRomains
    {
        public static string Convertir(int nombreArabe)
            => nombreArabe switch
               {
                   < 4 => new string('I', nombreArabe),
                   4   => "IV",
                   <= 8   => 'V' + Convertir(nombreArabe - 5),
                   _   => throw new NotSupportedException()
               };
    }
}