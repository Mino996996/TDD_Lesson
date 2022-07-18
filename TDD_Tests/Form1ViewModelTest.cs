using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDD_Lesson;

namespace TDD_Tests
{
    [TestClass]
    public class Form1ViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            ////初期値のテスト
            var viewModel = new Form1ViewModel();
            Assert.AreEqual("", viewModel.ATextBoxText);
            Assert.AreEqual("", viewModel.BTextBoxText);
            Assert.AreEqual("", viewModel.ResultLabelText);

            ////入力があったことを模擬
            viewModel.ATextBoxText = "2";
            viewModel.BTextBoxText = "5";
            ////ボタンクリックの模擬
            viewModel.CalculationAction();
            Assert.AreEqual("7", viewModel.ResultLabelText);
        }
    }
}
