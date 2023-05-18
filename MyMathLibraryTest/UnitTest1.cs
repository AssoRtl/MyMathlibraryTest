using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyMathLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AlgebraTest1()
        {
            //Arrange
            double[] mass = { 1, 1.1, 2,3,4.5 };
            double summ = 11.6;
            //Act
            double res = MyMathlibrary.AlgebraClass.RowSumm(mass);

            //Assert
            Assert.AreEqual(summ, res);
        }
        [TestMethod]
        public void AlgebraTest2()
        {
            //Arrange
            double[] mass = { -1, -1.1, -2, -3, -4.5 };
            double summ = -11.6;
            //Act
            double res = MyMathlibrary.AlgebraClass.RowSumm(mass);

            //Assert
            Assert.AreEqual(summ, res);
        }
        [TestMethod]
        public void AlgebraTest3()
        {
            //Arrange
            double[] mass = {100,-100,1234567890,-1234567890};
            double summ = 0;
            //Act
          
            double res = MyMathlibrary.AlgebraClass.RowSumm(mass);

            //Assert
            Assert.AreEqual(summ, res);
        }
        [TestMethod]
        public void AlgebraTest4()
        {
            //Arrange
            double[] mass = { };
            double summ = 0;
            //Act
            double res = MyMathlibrary.AlgebraClass.RowSumm(mass);

            //Assert
            Assert.AreEqual(summ, res);
        }
        [TestMethod]
        public void AlgebraTest5()
        {
            //Arrange
            double[] mass = { 1 };
            double summ = 1;
            //Act
            double res = MyMathlibrary.AlgebraClass.RowSumm(mass);

            //Assert
            Assert.AreEqual(summ, res);
        }

        //
        //RowMax
        //
        [TestMethod]
        public void AlgebraTest6()
        {
            //Arrange
            double[] mass = { 1, 1.1, 2, 3, 4.5 };
            double summ = 4.5;
            //Act
            double res = MyMathlibrary.AlgebraClass.RowMax(mass);

            //Assert
            Assert.AreEqual(summ, res);
        }
        [TestMethod]
        public void AlgebraTest7()
        {
            //Arrange
            double[] mass = { -1, -1.1, -2, -3, -4.5 };
            double summ = -1;
            //Act
            double res = MyMathlibrary.AlgebraClass.RowMax(mass);

            //Assert
            Assert.AreEqual(summ, res);
        }
        [TestMethod]
        public void AlgebraTest8()
        {
            //Arrange
            double[] mass = { 100, -100, 1234567890, -1234567890 };
            double summ = 1234567890;
            //Act

            double res = MyMathlibrary.AlgebraClass.RowMax(mass);

            //Assert
            Assert.AreEqual(summ, res);
        }
        [TestMethod]
        public void AlgebraTest9()
        {
            //Arrange
            double[] mass = { };
            double summ = 0;
            //Act
            double res = MyMathlibrary.AlgebraClass.RowMax(mass);

            //Assert
            Assert.AreEqual(summ, res);
        }
        [TestMethod]
        public void AlgebraTest10()
        {
            //Arrange
            double[] mass = { 1 };
            double summ = 1;
            //Act
            double res = MyMathlibrary.AlgebraClass.RowMax(mass);

            //Assert
            Assert.AreEqual(summ, res);
        }

        //
        //RowMin
        //
        [TestMethod]
        public void AlgebraTest11()
        {
            //Arrange
            double[] mass = { 1, 1.1, 2, 3, 4.5 };
            double summ = 1;
            //Act
            double res = MyMathlibrary.AlgebraClass.RowMin(mass);

            //Assert
            Assert.AreEqual(summ, res);
        }
        [TestMethod]
        public void AlgebraTest12()
        {
            //Arrange
            double[] mass = { -1, -1.1, -2, -3, -4.5 };
            double summ = -4.5;
            //Act
            double res = MyMathlibrary.AlgebraClass.RowMin(mass);

            //Assert
            Assert.AreEqual(summ, res);
        }
        [TestMethod]
        public void AlgebraTest13()
        {
            //Arrange
            double[] mass = { 100, -100, 1234567890, -1234567890 };
            double summ = -1234567890;
            //Act

            double res = MyMathlibrary.AlgebraClass.RowMin(mass);

            //Assert
            Assert.AreEqual(summ, res);
        }
        [TestMethod]
        public void AlgebraTest14()
        {
            //Arrange
            double[] mass = { };
            double summ = 0;
            //Act
            double res = MyMathlibrary.AlgebraClass.RowMin(mass);

            //Assert
            Assert.AreEqual(summ, res);
        }
        [TestMethod]
        public void AlgebraTest15  ()
        {
            //Arrange
            double[] mass = { 1 };
            double summ = 1;
            //Act
            double res = MyMathlibrary.AlgebraClass.RowMax(mass);

            //Assert
            Assert.AreEqual(summ, res);
        }
        //
        //RowAvg
        //
        [TestMethod]
        public void AlgebraTest16()
        {
            //Arrange
            double[] mass = { 1, 1.1, 2, 3, 4.5 };
            double summ = 2.32;
            //Act
            double res = MyMathlibrary.AlgebraClass.RowAvg(mass);

            //Assert
            Assert.AreEqual(summ, res);
        }
        [TestMethod]
        public void AlgebraTest17()
        {
            //Arrange
            double[] mass = { -1, -1.1, -2, -3, -4.5 };
            double summ = -2.32;
            //Act
            double res = MyMathlibrary.AlgebraClass.RowAvg(mass);

            //Assert
            Assert.AreEqual(summ, res);
        }
        [TestMethod]
        public void AlgebraTest18()
        {
            //Arrange
            double[] mass = { 100, -100, 1234567890, -1234567890 };
            double summ = 0;
            //Act

            double res = MyMathlibrary.AlgebraClass.RowAvg(mass);

            //Assert
            Assert.AreEqual(summ, res);
        }
        [TestMethod]
        public void AlgebraTest19()
        {
            //Arrange
            double[] mass = { };
            double summ = 0;
            //Act
            double res = MyMathlibrary.AlgebraClass.RowAvg(mass);

            //Assert
            Assert.AreEqual(summ, res);
        }
        [TestMethod]
        public void AlgebraTest20()
        {
            //Arrange
            double[] mass = { 1 };
            double summ = 1;
            //Act
            double res = MyMathlibrary.AlgebraClass.RowAvg(mass);

            //Assert
            Assert.AreEqual(summ, res);
        }
    }

    [TestClass]
    public class UnitTest2
    
    {
        [TestMethod]
        public void GeometryTest1()
        {
            //Arrange
            double num1 =10;
            double num2 =10;
            double FinalSquare = 50;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareTriangle(num1,num2);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void GeometryTest2()
        {
            //Arrange
            double num1 = -10;
            double num2 = -10;
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareTriangle(num1, num2);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void GeometryTest3()
        {
            //Arrange
            double num1 = -10;
            double num2 = 10;
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareTriangle(num1, num2);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
         [TestMethod]
        public void GeometryTest4()
        {
            //Arrange
            double num1 = 0;
            double num2 = 0;
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareTriangle(num1, num2);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void GeometryTest5()
        {
            //Arrange
            double num1 = 10.3434;
            double num2 = -10.565655;
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareTriangle(num1, num2);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        //
        //SquareSquare
        //
        [TestMethod]
        public void GeometryTest6()
        {
            //Arrange
            double num1 = 10;
            double FinalSquare = 100;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareSquare(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void GeometryTest7()
        {
            //Arrange
            double num1 = -10;
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareSquare(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void GeometryTest8()
        {
            //Arrange
            double num1 = 0;
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareSquare(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void GeometryTest9()
        {
            //Arrange

            string num1 = "aa";
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareSquare(Convert.ToDouble(num1));

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void GeometryTest10()
        {
            //Arrange
            double num1 = 10.1;
            double FinalSquare = 102.01;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareSquare(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }

        //
        //SquareRectangle
        //
        [TestMethod]
        public void GeometryTest11()
        {
            //Arrange
            double num1 = 10;
            double num2 = 10;
            double FinalSquare = 100;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareRectangle(num1, num2);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void GeometryTest12()
        {
            //Arrange
            double num1 = -10;
            double num2 = -10;
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareRectangle(num1, num2);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void GeometryTest13()
        {
            //Arrange
            double num1 = -10;
            double num2 = 10;
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareRectangle(num1, num2);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void GeometryTest14()
        {
            //Arrange
            double num1 = 0;
            double num2 = 0;
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareRectangle(num1, num2);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void GeometryTest15()
        {
            //Arrange
            double num1 = 10.3434;
            double num2 = -10.565655;
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareRectangle(num1, num2);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }

        //
        //SquareRomb
        //
        [TestMethod]
        public void GeometryTest16()
        {
            //Arrange
            double num1 = 10;
            double num2 = 10;
            double FinalSquare = 50;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareRhomb(num1, num2);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void GeometryTest17()
        {
            //Arrange
            double num1 = -10;
            double num2 = -10;
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareRhomb(num1, num2);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void GeometryTest18()
        {
            //Arrange
            double num1 = -10;
            double num2 = 10;
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareRhomb(num1, num2);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void GeometryTest19()
        {
            //Arrange
            double num1 = 0;
            double num2 = 0;
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareRhomb(num1, num2);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void GeometryTest20()
        {
            //Arrange
            double num1 = 10.3434;
            double num2 = -10.565655;
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareRhomb(num1, num2);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        //
        //SquareRound
        //
        [TestMethod]
        public void GeometryTest21()
        {
            //Arrange
            double num1 = 10;
            double FinalSquare = 314;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareRound(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void GeometryTest22()
        {
            //Arrange
            double num1 = -10;
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareRound(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void GeometryTest23()
        {
            //Arrange
            double num1 =1.1;
            double FinalSquare = 1.01;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareRound(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void GeometryTest24()
        {
            //Arrange
            double num1 = 0;
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareRound(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void GeometryTest25()
        {
            //Arrange
            double num1 = -10.1;
            double FinalSquare = 320.3114;
            //Act
            double res = MyMathlibrary.GeometryClass.SquareRound(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
    }

    [TestClass]
    public class UnutTest3
    {
        [TestMethod]
        public void TriganometryTest1()
        {
            //Arrange
            double num1 = 10;
            double FinalSquare = -0.54402111088937;
            //Act
            double res = MyMathlibrary.TriganometryClass.SinA(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void TriganometryTest2()
        {
            //Arrange
            double num1 = -10;
            double FinalSquare = 0.54402111088937;
            //Act
            double res = MyMathlibrary.TriganometryClass.SinA(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void TriganometryTest3()
        {
            //Arrange
            double num1 = 0;
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.TriganometryClass.SinA(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void TriganometryTest4()
        {
            //Arrange
            string num1 = "s";
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.TriganometryClass.SinA(Convert.ToDouble(num1));

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void TriganometryTest5()
        {
            //Arrange
            double num1 = 10.001;
            double FinalSquare = -0.544859910268068;
            //Act
            double res = MyMathlibrary.TriganometryClass.SinA(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }

        //
        //CosA
        //
        [TestMethod]
        public void TriganometryTest6()
        {
            //Arrange
            double num1 = 10;
            double FinalSquare = -0.839071529076452;
            //Act
            double res = MyMathlibrary.TriganometryClass.CosA(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void TriganometryTest7()
        {
            //Arrange
            double num1 = -10;
            double FinalSquare = -0.839071529076452;
            //Act
            double res = MyMathlibrary.TriganometryClass.CosA(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void TriganometryTest8()
        {
            //Arrange
            double num1 = 0;
            double FinalSquare = 1;
            //Act
            double res = MyMathlibrary.TriganometryClass.CosA(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void TriganometryTest9()
        {
            //Arrange
            string num1 = "s";
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.TriganometryClass.CosA(Convert.ToDouble(num1));

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void TriganometryTest10()
        {
            //Arrange
            double num1 = 10.001;
            double FinalSquare = -0.838527088520504;
            //Act
            double res = MyMathlibrary.TriganometryClass.CosA(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        //
        //TanA
        //
        [TestMethod]
        public void TriganometryTest11()
        {
            //Arrange
            double num1 = 10;
            double FinalSquare = 0.648360827459087;
            //Act
            double res = MyMathlibrary.TriganometryClass.TanA(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void TriganometryTest12()
        {
            //Arrange
            double num1 = -10;
            double FinalSquare = -0.648360827459087;
            //Act
            double res = MyMathlibrary.TriganometryClass.TanA(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void TriganometryTest13()
        {
            //Arrange
            double num1 = 0;
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.TriganometryClass.TanA(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void TriganometryTest14()
        {
            //Arrange
            string num1 = "s";
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.TriganometryClass.TanA(Convert.ToDouble(num1));

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void TriganometryTest15()
        {
            //Arrange
            double num1 = 10.001;
            double FinalSquare = -0.649782121206624;
            //Act
            double res = MyMathlibrary.TriganometryClass.TanA(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        //
        //CtgA
        //
        [TestMethod]
        public void TriganometryTest16()
        {
            //Arrange
            double num1 = 10;
            double FinalSquare = -1.54235104535692;
            //Act
            double res = MyMathlibrary.TriganometryClass.CtgA(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void TriganometryTest17()
        {
            //Arrange
            double num1 = -10;
            double FinalSquare = -1.54235104535692;
            //Act
            double res = MyMathlibrary.TriganometryClass.CtgA(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void TriganometryTest18()
        {
            //Arrange
            double num1 = 0;
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.TriganometryClass.CtgA(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void TriganometryTest19()
        {
            //Arrange
            string num1 = "s";
            double FinalSquare = 0;
            //Act
            double res = MyMathlibrary.TriganometryClass.CtgA(Convert.ToDouble(num1));

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
        [TestMethod]
        public void TriganometryTest20()
        {
            //Arrange
            double num1 = 10.001;
            double FinalSquare = -1.53897740082942;
            //Act
            double res = MyMathlibrary.TriganometryClass.CtgA(num1);

            //Assert
            Assert.AreEqual(FinalSquare, res);
        }
    }
}
