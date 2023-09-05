using System.Reflection;
using MarketSimulation.Interfaces;
using MarketSimulation.Services;

namespace MarketSimulation.Classes
{
    public class Market : IQueueBehaviour
    {
        private List<IVisitorBehaviour> visitors;
        private readonly Logger logger;
        private readonly int discountCells;


        public Market(int discountCells)
        {
            visitors = new List<IVisitorBehaviour>();
            logger = new Logger();
            this.discountCells = discountCells;
        }

        public void Start()
        {
            GenerateVisitors();
            MakeOrder();

        }

        private void MakeOrder()
        {
            for (int i = 0; i < visitors.Count; i++)
            {
                if (visitors[i].GetType().IsAssignableTo(typeof(Customer)))
                {
                    ((Customer)visitors[i]).IsMakeChoice = true;
                }
                else
                {
                    ((TaxInspector)visitors[i]).MakeInspection();
                }
            }
        }

        private void GenerateVisitors()
        {
            IVisitorBehaviour client1 = new Customer("Alex");
            logger.Log(client1.EnterMarketMessage());
            logger.Log(AddToQueue(client1));
            
            IVisitorBehaviour client2 = new Customer("Serg");
            logger.Log(client2.EnterMarketMessage());
            logger.Log(AddToQueue(client2));

            IVisitorBehaviour client3 = new SpecialCustomer("Ivan", "23");
            logger.Log(client3.EnterMarketMessage());
            logger.Log(AddToQueue(client3));

            IVisitorBehaviour client4 = new TaxInspector("Tax Officer");
            logger.Log(client4.EnterMarketMessage());
            logger.Log(AddToQueue(client4));

            IVisitorBehaviour client5 = new DiscountClient("Olga");
            logger.Log(client5.EnterMarketMessage());
            logger.Log(AddToQueue(client5));

            IVisitorBehaviour client6 = new DiscountClient("Nina");
            logger.Log(client6.EnterMarketMessage());
            logger.Log(AddToQueue(client6));

        }

        public string AddToQueue(IVisitorBehaviour visitor)
        {
            visitors.Add(visitor);
            return $"{visitor.GetVisitor().GetName()} added to queue";
        }

        public string RemoveFromQueue(IVisitorBehaviour visitor)
        {
            visitors.Remove(visitor);
            return $"{visitor.GetVisitor().GetName()} removed from queue";
        }
    }
}