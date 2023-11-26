using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul12
{
    
    public interface iPropertychanged
    {
        event PropertyeventHandler Propertychanged;
    }

    public delegate void PropertyeventHandler(object sender, PropertyeventArgs e);

    public class PropertyeventArgs : EventArgs
    {
        public string PropertyName { get; private set; }

        public PropertyeventArgs(string propertyName)
        {
            PropertyName = propertyName;
        }
    }

}
