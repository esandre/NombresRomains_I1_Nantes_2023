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

        [Fact]
        public void Test2()
        {
            // ETANT DONNE le chiffre 2
            const int chiffreArabe = 2;

            // QUAND on le convertir en nombre romain
            var nombreRomain = NombresRomains_I1.NombresRomains.Convertir(chiffreArabe);

            // ALORS on obtient II
            Assert.Equal("II", nombreRomain);
        }

        [Fact]
        public void Test3()
        {
            // ETANT DONNE le chiffre 3
            const int chiffreArabe = 3;

            // QUAND on le convertir en nombre romain
            var nombreRomain = NombresRomains_I1.NombresRomains.Convertir(chiffreArabe);

            // ALORS on obtient III
            Assert.Equal("III", nombreRomain);
        }

        [Fact]
        public void Test4()
        {
            // ETANT DONNE le chiffre 4
            const int chiffreArabe = 4;

            // QUAND on le convertir en nombre romain
            var nombreRomain = NombresRomains_I1.NombresRomains.Convertir(chiffreArabe);

            // ALORS on obtient IV
            Assert.Equal("IV", nombreRomain);
        }
    }
}