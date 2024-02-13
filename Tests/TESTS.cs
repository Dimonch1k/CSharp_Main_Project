namespace Tests
{
    [TestClass]
    public class TESTS
    {
        public CommonMethods methods = new CommonMethods();

        ///////////////////////////////////////////////////////////////////////////////////////     ENEMY
        [TestMethod]
        public void EnemyCriticalRandomTest_Min() // Test EnemyCriticalRandom for 0 chance
        {
            bool actual = methods.isCriticalRandom(0);

            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void EnemyCriticalRandomTest_Max() // Test EnemyCriticalRandom for 100 chance
        {
            bool actual = methods.isCriticalRandom(100);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void DodgeHeroAttackTest_Min() // Test DodgeHeroAttack for 0 chance
        {
            bool actual = methods.isDodgeAttack(0);

            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void DodgeHeroAttackTest_Max() // Test DodgeHeroAttack for 100 chance
        {
            bool actual = methods.isDodgeAttack(100);

            Assert.IsTrue(actual);
        }



    }
}