using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFCommandsDemo2.ViewModel.Command
{
    public class MessageCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action _execute;

        // 실제 명령 수행에 사용되는 Action을 선언하고 생성자를 추가한다.
        public MessageCommand(Action execute)
        {
            // 생성자로 전달되는 함수명을 실제 실행할 명령(_execute)으로 대입한다.
            _execute = execute;
        }

        // CanExecute는 명령 전 선 조건에 해당하지만 여기서 별도의 조건이 없으므로 항상 true를 반환하도록 함.
        public bool CanExecute(object parameter)
        {
            return true;
        }

        // 실제 명령을 수행하는 함수인 Execute 메서드에는 _execute를 수행하도록 함.
        public void Execute(object parameter)
        {
            _execute.Invoke();
        }
    }
}
