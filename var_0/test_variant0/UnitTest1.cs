using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test_variant0
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_eng_slov()
        {
            {
                // исходные данные
                string S = "Testing this test";
                int expected = 3;

                // получение значения с помощью тестируемого метода
                programm1.Form1 test = new programm1.Form1();
                int actual = test.FindWords(ref S);

                // сравнение ожидаемого результата с полученным
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        public void TestMethod2_eng_slov_znaki()
        {
            {
                // исходные данные
                string S = "I said, test tone";
                int expected = 1;

                // получение значения с помощью тестируемого метода
                programm1.Form1 test = new programm1.Form1();
                int actual = test.FindWords(ref S);

                // сравнение ожидаемого результата с полученным
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        public void TestMethod3_nicego()
        {
            {
                // исходные данные
                string S = "";
                int expected = 0;

                // получение значения с помощью тестируемого метода
                programm1.Form1 test = new programm1.Form1();
                int actual = test.FindWords(ref S);

                // сравнение ожидаемого результата с полученным
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        public void TestMethod4_rus_slov()
        {
            {
                // исходные данные
                string S = "Тест выполнен";
                int expected = 0;

                // получение значения с помощью тестируемого метода
                programm1.Form1 test = new programm1.Form1();
                int actual = test.FindWords(ref S);

                // сравнение ожидаемого результата с полученным
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        public void TestMethod5_rus_and_eng()
        {
            {
                // исходные данные
                string S = "тест tetris tetris";
                int expected = 2;

                // получение значения с помощью тестируемого метода
                programm1.Form1 test = new programm1.Form1();
                int actual = test.FindWords(ref S);

                // сравнение ожидаемого результата с полученным
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        public void TestMethod6_znaki()
        {
            {
                // исходные данные
                string S = "!@#$ test %^^&*() test ";
                int expected = 2;

                // получение значения с помощью тестируемого метода
                programm1.Form1 test = new programm1.Form1();
                int actual = test.FindWords(ref S);

                // сравнение ожидаемого результата с полученным
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
