using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPFCommandsDemo
{
    // public 키워드를 이용해 외부에서 접근 가능하게 변경
    public class ViewModel
    {
        // ICommand 타입의 MyCommand 속성을 선언하고 생성자를 추가함.
        public ICommand MyCommand { get; set; }

        public ViewModel()
        {
            // 생성자 내에 MyCommand를 초기화한다.
            // Action 으로 입력할 함수는 "ExecuteMethod"로 정하고, 
            // 조건을 검사할 Func에 해당하는 함수는 "CanExecuteMethod"로 정한다.
            MyCommand = new Command(ExecuteMethod, CanExecuteMethod);
        }

        private void ExecuteMethod(object obj)
        {
            MessageBox.Show("코드비하인드가 아닌 Command ExecuteMethod");
        }

        private bool CanExecuteMethod(object arg)
        {
            return true;
        }
    }
}
