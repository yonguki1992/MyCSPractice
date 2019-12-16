using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpandoObjectEx
{
    class MyClass
    {
        public void M1()
        {
            //ExpandoObject 에서 dynamic 타입 생성
            // 동적으로 멤버 추가가 가능
            dynamic person = new ExpandoObject();

            //속성 지정
            person.Name = "한사람";
            person.Age = 28;

            //메서드 지정
            //이름, 나이 출력
            person.Display = (Action)(() =>
            {
                Console.WriteLine("{0}({1}세, 백수)",person.Name, person.Age);
            });
            
            //나이 바꾸기
            person.ChangeAge = (Action<int>)((age)=>
            {
                person.Age = age;
                if(person.AgeChanged != null)
                {
                    person.AgeChanged(this, EventArgs.Empty);
                }

            });

            //이벤트 초기화
            person.AgeChanged = null;// dynamic 이벤트는 null로 먼저 초기화해야함

            //이벤트 핸들러 지정
            person.AgeChanged += new EventHandler(OnChanged);

            M2(person);

        }

        private void M2(dynamic person)
        {
            person.Display();
            person.ChangeAge(29);
            person.Display();
        }

        private void OnChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Age changed");
        }

        public void M3()
        {
            dynamic person = new ExpandoObject();
            person.Name = "Kim";
            person.Age = 10;
            person.Display = (Action)(() => { });
            person.ChangeAge = (Action<int>)((age) => { person.Age = age; });
            person.AgeChanged = null;
            person.AgeChanged += new EventHandler((s, e) => { });

            // ExpandoObject를 IDictionary로 변환
            var dict = (IDictionary<string, object>)person;

            // person 의 속성,메서드,이벤트는
            // IDictionary 해시테이블에 저정되어 있는데
            // 아래는 이를 출력함
            foreach(var v in dict)
            {
                Console.WriteLine("{0} : {1}",v.Key,v.Value);
            }
            
        }
    }
}
