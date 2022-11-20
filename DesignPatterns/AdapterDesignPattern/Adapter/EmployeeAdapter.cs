using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DesignPatternsNew.AdapterDesignPattern.Adapter
{
    public class EmployeeAdapter : IEmployee
    {
        private readonly EmployeeManager _employeeManager;
        public EmployeeAdapter(EmployeeManager employeeManager)
        {
            this._employeeManager = employeeManager;
        }
        public string GetAllEmployees()
        {
            string xmlData = _employeeManager.GetAllEmployeesInXml();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlData);
            var json = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.None, true);
            return json;
        }
    }
}
