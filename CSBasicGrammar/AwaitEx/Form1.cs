using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwaitEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Run();
        }
        // async 가 표시된 메서드는 await를 1개 이상 가질 수 있다,
        // 하나도 없더라도 컴파일은 가능하지만 Waring뜸
        
        // 실제 핵심 키워드는 await이고, 일반적으로 Task 또는 Task<T>와 함께 사용
        // 또는 awaitable 클래스나 GetAwaiter()를 가진  클래스면 됨.

        // 1번
        private async void Run()
        {
            // 비동기로 Worker Thread에서 도는 task1
            // Task.Run; .NET Framework 4.5+
            // Thread 를 10초간 돌림
            var task1 = Task<int>.Run(() => LongCalcAsync(10));

            //task1 이 끝나길 기다렸다가 끝나면 결과를 sum 에 할당
            int sum = await task1;

            //UI Thread에서 실행
            // Control.Invoke 또는 Control.BeginInvok 필요 없음
            this.label1.Text = string.Format("Sum = {0}",sum);
            this.button1.Enabled = true;
        }

        private int LongCalcAsync(int times)
        {
            int result = 0;

            for(int i = 0; i < times; ++i)
            {
                result += i;
                Thread.Sleep(1000);
            }

            return result;
        }

        
        private void Button2_Click(object sender, EventArgs e)
        {
            Run2();
        }

        // 2번
        private async void Run2()
        {
            // await 는 Task와 같은 awaitable 클래스의 객체가 완료되기를 기다린다.
            int sum = await LongCalc2(10);
            // ui 스레드가 정지되지 않고 메시지 루프를 계속 돌 수 있도록 필요한 코드를
            // 컴파일러가 await를 만나면 자동으로 추가함.
            this.label2.Text = string.Format("합계는 {0}",sum);
            this.button2.Enabled = true;
        }

        private async Task<int> LongCalc2(int times)
        {
            //ui thread 에서 실행
            Debug.WriteLine(Thread.CurrentThread.ManagedThreadId);
            int result = 0;

            for(int i = 1; i <= times; ++i)
            {
                result += i;
                await Task.Delay(1000);
            }
            return result;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Run3();
        }

        // 3번 : 1번 예제 변형
        private void Run3()
        {
            var task1 = Task<int>.Run(() => LongCalc2(5));

            // await task1 과 같은 효과
            task1.ContinueWith(x =>
            {
                this.label3.Text = "전부 합하면 : " + task1.Result;
                this.button3.Enabled = true;
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}