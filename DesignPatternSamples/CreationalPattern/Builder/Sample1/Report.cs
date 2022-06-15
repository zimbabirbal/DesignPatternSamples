using System.Text;

namespace DesignPatternSamples.CreationalPattern.Builder.Sample1
{
    internal class Report
    {
        private string _type;
        private string _description;
        private DateTime _created;
        private string _name;

        public string Name { get => _name; set => _name = value; }
        public string Type { get => _type; set => _type = value; }
        public string Description { get => _description; set => _description = value; }
        public DateTime Created { get => _created; set => _created = value; }

        public string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(sb.Length == 0 ? "?" : "&");
            sb.Append("name");
            sb.Append('=');
            sb.Append(Uri.EscapeDataString(_name));
            sb.Append('&');
            sb.Append("type");
            sb.Append('=');
            sb.Append(Uri.EscapeDataString(_type));
            sb.Append('&');
            sb.Append("description");
            sb.Append('=');
            sb.Append(Uri.EscapeDataString(_description));
            sb.Append('&');
            sb.Append("created");
            sb.Append('=');
            sb.Append(Uri.EscapeDataString(_created.ToLongDateString()));

            return sb.ToString();
        }
    }
}
