using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class PersonDouble
    {
        // trong một số trường hợp nếu bạn muốn đổi kiểu dự liệu từ int sang double ID thì phải tạo một class khác thì hơi cực 
        private int Id;

        public string Name;

        public string Age;

        public PersonDouble(int id, string name, string age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }
        public int GetId()
        {
            return Id;
        }
    }
}
