namespace NombresRomains.Test
{
    public class NombresRomainsTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void TestUnité(int n)
        {
            // ETANT DONNE un chiffre <n> entre 1 et 3

            // QUAND on le convertir en nombre romain
            var nombreRomain = NombresRomains_I1.NombresRomains.Convertir(n);

            // ALORS on obtient I répété <n> fois
            Assert.Equal(new string('I', n), nombreRomain);
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

        [Fact]
        public void Test5()
        {
            // ETANT DONNE le chiffre 5
            const int chiffreArabe = 5;

            // QUAND on le convertir en nombre romain
            var nombreRomain = NombresRomains_I1.NombresRomains.Convertir(chiffreArabe);

            // ALORS on obtient V
            Assert.Equal("V", nombreRomain);
        }

        [Fact]
        public void Test6()
        {
            // ETANT DONNE le chiffre 6
            const int chiffreArabe = 6;

            // QUAND on le convertir en nombre romain
            var nombreRomain = NombresRomains_I1.NombresRomains.Convertir(chiffreArabe);

            // ALORS on obtient VI
            Assert.Equal("VI", nombreRomain);
        }
    }
}