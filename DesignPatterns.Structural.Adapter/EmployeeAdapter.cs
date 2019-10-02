using Newtonsoft.Json;
using System.Xml;

namespace DesignPatterns.Structural.Adapter
{
    public class EmployeeAdapter : EmployeeManager, IEmployee
    {
        public override string GetAllEmployees()
        {
            string xml = base.GetAllEmployees();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);
            string jsonStr = JsonConvert.SerializeObject(xmlDocument);
            return jsonStr;
        }
    }
}
