using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// A simple display interface.
    /// </summary>
    public interface IDisplay
    {
        /// <summary>
        /// The display method, used for refreshing a display.
        /// </summary>
        void Display();
    }
}
