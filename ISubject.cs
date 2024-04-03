using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// The subject (aka observable) interface.
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Registers a new subscriber (aka observer) to a collection.
        /// </summary>
        /// <param name="subscriber"></param>
        void RegisterSubscriber(ISubscriber subscriber);

        /// <summary>
        /// Unregisters a subscriber (aka observer) from a collection.
        /// </summary>
        /// <param name="subscriber"></param>
        void UnregisterSubscriber(ISubscriber subscriber);

        /// <summary>
        /// Notifies all subscribers of a change.
        /// </summary>
        void Notify();
    }
}
