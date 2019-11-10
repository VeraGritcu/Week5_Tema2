using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            var alex = new Person("Alex");
            

            Producer bmw = new Producer(CarProducer.BMW);
            Producer ford = new Producer(CarProducer.Ford);
            Producer skoda = new Producer(CarProducer.Skoda);

            Vehicle bmvX1 = new Vehicle(bmw, "X1", 2015, 12000);
            Vehicle fordFiesta = new Vehicle(ford, "Fiesta", 2016, 1500);
            Vehicle skodaOctavia = new Vehicle(skoda, "Octavia", 2017, 1600);


            Store bmwStore = new Store(bmw);
            Store fordStore = new Store(ford);
            Store skodaStore = new Store(skoda);

            alex.VisitShowroom(fordStore);
            Order fordOrder = new Order(fordFiesta, 4, alex);
            fordStore.PlaceOrder(fordOrder);

            alex.VisitShowroom(skodaStore);
            Order skodaOrder = new Order(skodaOctavia, 3, alex);
            skodaStore.PlaceOrder(skodaOrder);

            fordStore.CancelOrder(fordOrder);

            ///// after  weeks

            skodaOrder.OrderDelivered();



            
           

        }
    }
}
