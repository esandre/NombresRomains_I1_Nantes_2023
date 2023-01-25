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

        [Theory]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        public void TestDixPlusUnité(int n)
        {
            // ETANT DONNE un chiffre <n> entre 10 et 11
            // QUAND on le convertir en nombre romain
            var nombreRomain = NombresRomains_I1.NombresRomains.Convertir(n);

            // ALORS on X suivi de I répété <n - 10> fois
            var attendu = 'X' + new string('I', n - 10);
            Assert.Equal(attendu, nombreRomain);
        }

        [Theory]
        [InlineData(4, 'V')]
        [InlineData(9, 'X')]
        public void TestUnitéAvantSymbole(int nombreArabe, char symbole)
        {
            // ETANT DONNE un chiffre <nombreArabe> directement inférieur à un symbole <symbole> donné

            // QUAND on le convertir en nombre romain
            var nombreRomain = NombresRomains_I1.NombresRomains.Convertir(nombreArabe);

            // ALORS on obtient I<symbole>
            Assert.Equal("I" + symbole, nombreRomain);
        }
    }
}