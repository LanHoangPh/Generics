using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace GenericsDemo
{
    // thông thường chúng ta thường đặt các kiểu dữ liệu thuộc tính trong class
    // VD: đây là cách thông thường 
    //public class Person 
    //{
    //    // trong một số trường hợp nếu bạn muốn đổi kiểu dự liệu từ int sang double ID thì phải tạo một class khác thì hơi cực 
    //    private int Id;  // có thẻ các bạn sẽ nói chỉnh cần chỉnh int thành double trực tiếp ở đây là đc mà :))) nhưng bạn nên như  bạn phải làm việc thông qua CSDL 
    //    // Để giải quyết vấn đè này thì ta có generics :D

    //    public string Name;
        
    //    public string Age;

    //    public Person(int id, string name, string age) 
    //    {
    //        this.Id = id;
    //        this.Name = name;
    //        this.Age = age;
    //    }
    //    public int GetId()
    //    {
    //        return Id;
    //    }
    //}
    

    public class Person<TId, Tname, Tage> where TId : class, IEquatable<TId> 
    {
        private TId id;

        private Tname name;

        private Tage age;

        public Person (TId id, Tname name, Tage age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public TId GetId() { return id; }
        public Tname GetName() { return name; }
        public Tage GetAge() { return age; }
    }
}
