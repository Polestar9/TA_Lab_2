using System;
namespace lab_2_TA_test
{
    [TestClass]
    public class array_modular_test
    {
        [TestMethod]
        public void Test_NumBiggerThanFive()
        {
            int[] array = { 8, 8, -2, 5, 0 };
            create_array arrProcessor = new create_array(array);

            int count = arrProcessor.num_bigger_than_five();

            Assert.AreEqual(2, count); // Очікуємо, що кількість елементів більших за 5 буде 2
        }

        [TestMethod]
        public void Test_AfterMaxSum()
        {
            int[] array = { 3, 8, -2, 5, 0 };
            create_array arrProcessor = new create_array(array);

            int sum = arrProcessor.after_max_sum();

            Assert.AreEqual(3, sum); // Очікуємо, що сума елементів після максимального буде 3
        }
    }
}
