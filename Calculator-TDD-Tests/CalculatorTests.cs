using Calculator_TDD.Models;

namespace Calculator_TDD_Tests
{
    public class CalculatorTests
    {

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2, 10, 12)]
        public void Add(int value1, int value2, int result) 
        {
            //Arrange
            Calculator _calculator = new Calculator();

            //Act
            var res =_calculator.Add(value1, value2);
            //Assert
            Assert.Equal(result, res);
            Assert.Equal(_calculator.LastValues.Last(), res);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(12, 10, 2)]
        public void Subtract(int value1, int value2, int result)
        {
            //Arrange
            Calculator _calculator = new Calculator();

            //Act
            var res = _calculator.Subtract(value1, value2);
            //Assert
            Assert.Equal(result, res);
            Assert.Equal(_calculator.LastValues.Last(), res);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 10, 20)]
        public void Multiply(int value1, int value2, int result)
        {
            //Arrange
            Calculator _calculator = new Calculator();

            //Act
            var res = _calculator.Multiply(value1, value2);
            //Assert
            Assert.Equal(result, res);
            Assert.Equal(_calculator.LastValues.Last(), res);
        }


        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(2, 1, 2)]
        public void Divide(int value1, int value2, int result)
        {
            //Arrange
            Calculator _calculator = new Calculator();
            //Act
            var res = _calculator.Divide(value1, value2);
            //Assert
            Assert.Equal(result, res);
            Assert.Equal(_calculator.LastValues.Last(), res);
        }

        [Theory]
        [InlineData(10, 0)]
        public void DivideByZero(int value1, int value2)
        {
            //Arrange
            Calculator _calculator = new Calculator();
            Func<dynamic> divideByZero = (() => _calculator.Divide(value1, value2));
            //Act
            //Assert
            Assert.Throws<DivideByZeroException>(divideByZero);
        }

        [Fact]
        public void ChangeTheListAndAssertTheLastNumber()
        {
            //Arrange
            Calculator _calculator = new Calculator();
            var val1 = 1;
            var val2 = 3;
            //Act
            _calculator.Add(val1, val2);
            _calculator.Add(val1, val2);
            _calculator.Add(val1, val2);
            _calculator.Multiply(val1, val2);

            //Assert
            Assert.Equal(3, _calculator.LastValues.Last());
        }
    }
}