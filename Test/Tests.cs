using MY_Game;
namespace Test
{
    [TestClass]
    public class TESTS
    {
        public IMethods methods = new CMethods();
        
        [TestMethod]
        public void EnemyCriticalRandomTest_Min() // Test EnemyCriticalRandom for 0 chance
        {

            bool actual = methods.IsCriticalRandom(0);

            Assert.IsFalse(actual);
        }


        [TestMethod]
        public void EnemyCriticalRandomTest_Max() // Test EnemyCriticalRandom for 100 chance
        {
            bool actual = methods.IsCriticalRandom(100);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void DodgeHeroAttackTest_Min() // Test DodgeHeroAttack for 0 chance
        {
            bool actual = methods.IsDodgeAttack(0);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void DodgeHeroAttackTest_Max() // Test DodgeHeroAttack for 100 chance
        {
            bool actual = methods.IsDodgeAttack(100);

            Assert.IsTrue(actual);
        }



    }
}