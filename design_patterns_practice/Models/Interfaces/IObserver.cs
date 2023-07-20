using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns_practice.Models.Interfaces
{
    public interface IObserver
    {
        void Update(IObservable subject);
    }
}
