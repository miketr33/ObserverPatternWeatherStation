using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// The subscriber (aka observer) interface. 
    /// </summary>
    public interface ISubscriber
    {
        /// <summary>
        /// Method for updating the subscriber.
        /// </summary>
        void Update();
    }
}
