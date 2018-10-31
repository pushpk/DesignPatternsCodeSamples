using System.Collections.Generic;

namespace DesignPattern.Adapter
{
    public class Adaptee
    {
        public List<string> GetEmployeeList()
        {
            List<string> EmployeeList = new List<string>();
            EmployeeList.Add("Tom");
            EmployeeList.Add("Sam");
            EmployeeList.Add("Jack");
            EmployeeList.Add("Mary");
            return EmployeeList;
        }
    }
}