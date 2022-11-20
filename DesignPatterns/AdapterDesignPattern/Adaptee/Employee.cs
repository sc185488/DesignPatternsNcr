using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DesignPatternsNew
{
    [Serializable]
    public class Employee
    {
        Employee() { }
        public Employee(int id , string name)
        {
            this.Id = id;
            this.Name = name;
        }
        [XmlAttribute]
        public int Id { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
    }
    public class EmployeeManager 
    {
        public List<Employee> employees;
        public EmployeeManager()
        {
            employees = new List<Employee>();
            this.employees.Add(new Employee(1 , "Rishi"));
            this.employees.Add(new Employee(2 , "Neeru"));
            this.employees.Add(new Employee(3, "Krishna"));
        }
        public virtual string GetAllEmployeesInXml()
        {
            System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(employees.GetType());
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                serializer.Serialize(ms, employees);
                ms.Position = 0;
                xmlDoc.Load(ms);
                return xmlDoc.InnerXml;
            }
        }
    }
}
