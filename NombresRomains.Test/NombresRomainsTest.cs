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

        [Theory]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void TestCinqPlusUnité(int n)
        {
            // ETANT DONNE un chiffre <n> entre 5 et 8
            // QUAND on le convertir en nombre romain
            var nombreRomain = NombresRomains_I1.NombresRomains.Convertir(n);

            // ALORS on V suivi de I répété <n - 5> fois
            var attendu = 'V' + new string('I', n - 5);
            Assert.Equal(attendu, nombreRomain);
        }

        [Fact]
        public void Test9()
        {
            // ETANT DONNE le chiffre 9
            const int chiffreArabe = 9;

            // QUAND on le convertir en nombre romain
            var nombreRomain = NombresRomains_I1.NombresRomains.Convertir(chiffreArabe);

            // ALORS on obtient IX
            Assert.Equal("IX", nombreRomain);
        }

        [Fact]
        public void Test10()
        {
            // ETANT DONNE le chiffre 10
            const int chiffreArabe = 10;

            // QUAND on le convertir en nombre romain
            var nombreRomain = NombresRomains_I1.NombresRomains.Convertir(chiffreArabe);

            // ALORS on obtient X
            Assert.Equal("X", nombreRomain);
        }
    }
}