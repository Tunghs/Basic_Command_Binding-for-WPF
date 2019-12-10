using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFCommandsDemo
{
    // ICommand 상속
    public class Command : ICommand
    {
        // 아래와 같은 인터페이스 구현은 ICommand 위에 커서를 올려두고 Ctrl + .
        // 버튼 클릭시 수행할 Action과 Action 수행전에 필요한 조건을 검사하는 Func를 선언.
        // Action의 파라미터는 <object>를 의미하고 인스턴스명은 _executeMdthod이다.
        // Func의 파라미터는 <object>이고 return 타입은 <bool>인 _executeMdthod 인스턴스이다.
        Action<object> _executeMethod;
        Func<object, bool> _canexecuteMethod;

        // 추가된 생성자의 파라미터에 Action과 Func를 입력받고, 입력 받은 파라미터를 선언한 인스턴스에 대입한다.
        public Command(Action<object> executeMethod, Func<object, bool> canexecuteMethod)
        {
            this._executeMethod = executeMethod;
            this._canexecuteMethod = canexecuteMethod;
        }
    
        public event EventHandler CanExecuteChanged;

        // 버튼 클릭에 필요한 조건은 별도로 설정하지 않을 것이므로 CanExecute 메서드에 true를 항상 반환하도록 함.
        public bool CanExecute(object parameter)
        {
            return true;
        }

        // Action의 인스턴스인 _executeMdthod를 들어오는 파라미터를 대입해 그대로 실행한다.
        public void Execute(object parameter)
        {
            _executeMethod(parameter);
        }
    }
}
