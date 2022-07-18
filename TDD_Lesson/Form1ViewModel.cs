using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TDD_Lesson
{
    /// <summary>
    /// ビューのデザイナーの関数をここにコピーして実行を模擬したテストを書くことでビューのテストを作る
    /// INotify～～はデータバインディングで必要 using System.ComponentModel; もセットすること
    /// </summary>
    public class Form1ViewModel: INotifyPropertyChanged
    {
        private string _aTextBoxText = string.Empty;
        private string _bTextBoxText = string.Empty;
        private string _resultLabelText = string.Empty;
        public string ATextBoxText
        {
            get { return _aTextBoxText; }
            set
            {
                if (_aTextBoxText == value)
                {
                    return;
                }
                _aTextBoxText = value;
                OnPropertyChanged("ATextBoxText");
            }
        }
        public string BTextBoxText
        {
            get { return _bTextBoxText; }
            set
            {
                if (_bTextBoxText == value)
                {
                    return;
                }
                _bTextBoxText = value;
                OnPropertyChanged("BTextBoxText");
            }
        }
        public string ResultLabelText
        {
            get { return _resultLabelText; }
            set
            {
                if (_resultLabelText == value)
                {
                    return;
                }
                _resultLabelText = value;
                OnPropertyChanged("ResultLabelText");
            }
        }


        // データバインドの設定で必須
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void CalculationAction()
        {
            int a = Convert.ToInt32(ATextBoxText);
            int b = Convert.ToInt32(BTextBoxText);

            ResultLabelText = Calclation.Sum(a, b).ToString();
        }
    }
}
