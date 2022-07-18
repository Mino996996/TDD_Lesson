using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD_Lesson
{
    public partial class Form1View : Form
    {
        private Form1ViewModel _viewModel = new Form1ViewModel();
        public Form1View()
        {
            InitializeComponent();

            ////データバインド
            /// AtextBoxのTextプロパティ(=AtextBox.Text)を_viewModelのATextBoxTextと連動させる
            AtextBox.DataBindings.Add("Text", _viewModel, "ATextBoxText");

            BtextBox.DataBindings.Add("Text", _viewModel, "BTextBoxText");
            ResultLabel.DataBindings.Add("Text", _viewModel, "ResultLabelText");
        }

        private void CaluculationButton_Click(object sender, EventArgs e)
        {
            _viewModel.CalculationAction();
        }
    }
}
