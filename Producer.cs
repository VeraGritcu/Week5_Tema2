using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Tema2
{
    public class Producer : IProducer
    {
        public Producer(CarProducer name)
        {
            this.ProducerName = name;
        }
        public CarProducer ProducerName { get;}
        public string AllDetails 
        {
            get
            {
                return this.ProducerName.ToString();
            }
                
        }
    }
    
}
