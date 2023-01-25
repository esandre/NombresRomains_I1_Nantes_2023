namespace NombresRomains.Test
{
    public class NombresRomainsTest
    {
        [Fact]
        public void Test1()
        {
            // ETANT DONNE le chiffre 1
            const int chiffreArabe = 1;

            // QUAND on le convertir en nombre romain
            var nombreRomain = NombresRomains_I1.NombresRomains.Convertir(chiffreArabe);

            // ALORS on obtient I
            Assert.Equal("I", nombreRomain);
        }
    }
}