using MarketSimulation.Interfaces;
using MarketSimulation.Services;

namespace MarketSimulation.Classes
{
    public class Market : IQueueBehaviour
    {
        private readonly List<IVisitorBehaviour> visitors;
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
            TakeOrder();
            UpdateMarket();
        }

        private void UpdateMarket()
        {
            for (int i = 0; i < visitors.Count;)
            {
                Customer customer = (Customer)visitors[i];
                if (customer.IsGetOrder)
                {
                    string message;
                    message = RemoveFromQueue(customer);
                    Console.WriteLine(message);
                    logger.Log(message);
                    message = customer.LeaveMarketMessage();
                    Console.WriteLine(message);
                    logger.Log(message);
                }
            }
        }

        private void TakeOrder()
        {
            for (int i = 0; i < visitors.Count; i++)
            {
                Customer customer = (Customer)visitors[i];

                if (customer.IsMakeChoice)
                {
                    string message;
                    if (IsActionClient(customer))
                    {
                        message = IsAllowedForDiscount((DiscountClient)customer);
                        Console.WriteLine(message);
                        logger.Log(message);
                    }

                    customer.IsGetOrder = true;
                    message = $"{customer.GetName()} recived his products";
                    Console.WriteLine(message);
                    logger.Log(message);
                }
            }
        }

        private void MakeOrder()
        {
            string message;
            IVisitorBehaviour? inspector = null;
            for (int i = 0; i < visitors.Count; i++)
            {
                if (visitors[i] is Customer customer)
                {
                    customer.IsMakeChoice = true;
                    message = $"{customer.GetName()} selected products to purchase";
                    Console.WriteLine(message);
                    logger.Log(message);

                    if (Utilities.GetChance(0.25))
                    {
                        string returnMessage = customer.GetName() + " " + customer.ReturnProduct();
                        Console.WriteLine(returnMessage);
                        logger.Log(returnMessage);
                    }
                }

                else
                {
                    inspector = (TaxInspector)visitors[i];
                    message = ((TaxInspector)visitors[i]).MakeInspection();
                    Console.WriteLine(message);
                    logger.Log(message);
                }
            }

            message = RemoveFromQueue(inspector);
            Console.WriteLine(message);
            logger.Log(message);
            if(inspector != null)
            {
                message = inspector.LeaveMarketMessage();
                Console.WriteLine(message);
                logger.Log(message);
            }
        }

        private static bool IsActionClient(Customer customer) => 
            customer.GetType().IsAssignableTo(typeof(DiscountClient));

        private string IsAllowedForDiscount(DiscountClient client)
        {
            return (client.DiscountNumber <= discountCells)? 
                $"{client.GetName()} got discount" : 
                $"{client.GetName()} did not get discount";
        }

        private void GenerateVisitors()
        {
            
            IVisitorBehaviour client1 = new Customer("Alex");
            HandleNewClient(client1);

            IVisitorBehaviour client2 = new Customer("Serg");
            HandleNewClient(client2);

            IVisitorBehaviour client3 = new SpecialCustomer("Ivan", "23");
            HandleNewClient(client3);

            IVisitorBehaviour client4 = new TaxInspector("Tax Officer");
            HandleNewClient(client4);

            IVisitorBehaviour client5 = new DiscountClient("Olga", "10% discount");
            HandleNewClient(client5);

            IVisitorBehaviour client6 = new DiscountClient("Nina", "10% discount");
            HandleNewClient(client6);
        }

        private void HandleNewClient(IVisitorBehaviour client)
        {
            string message;
            message = client.EnterMarketMessage();
            Console.WriteLine(message);
            logger.Log(message);
            message = AddToQueue(client);
            Console.WriteLine(message);
            logger.Log(message);
        }

        public string AddToQueue(IVisitorBehaviour visitor)
        {
            visitors.Add(visitor);
            return $"{visitor.GetVisitor().GetName()} added to queue";
        }

        public string RemoveFromQueue(IVisitorBehaviour? visitor)
        {
            if (visitor != null)
            {
                visitors.Remove(visitor);
                return $"{visitor.GetVisitor().GetName()} removed from queue"; 
            }
            return String.Empty;
        }
    }
}