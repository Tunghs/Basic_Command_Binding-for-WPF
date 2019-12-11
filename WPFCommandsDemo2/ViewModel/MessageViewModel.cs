using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFCommandsDemo2.ViewModel.Command;

namespace WPFCommandsDemo2.ViewModel
{
    public class MessageViewModel
    {
        // public string MessageText { get; set; }

        // MessageCommand가 만들어졌으므로 이를 사용할 수 있도록 MessageCommand 의 
        // 인스턴스 속성인 DisplayMessageCommand라는 속성을 선언한다.
        // 읽기는 public이고 쓰기는 내부에서만 가능하도록 private으로 설정한다.
        public MessageCommand DisplayMessageCommand { get; private set; }

        public MessageViewModel()
        {
            DisplayMessageCommand = new MessageCommand(DisplayMessage);
        }

        public void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
