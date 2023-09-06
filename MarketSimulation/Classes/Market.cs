using MarketSimulation.Interfaces;
using MarketSimulation.Services;

namespace MarketSimulation.Classes
{
    /// <summary>
    /// Class which simulate shop functionality
    /// <para>Implements: <c>IQueueBehaviour</c> interface</para>
    /// </summary>
    public class Market : IQueueBehaviour
    {
        /// <summary>
        /// List to store visitors
        /// </summary>
        private readonly List<IVisitorBehaviour> visitors;
        private readonly Logger logger;
        /// <summary>
        /// max ammount of special visitors whom will get dicount
        /// </summary>
        private readonly int discountCells;


        public Market(int discountCells)
        {
            visitors = new List<IVisitorBehaviour>();
            logger = new Logger();
            this.discountCells = discountCells;
        }
        /// <summary>
        /// Main method to start simulation
        /// </summary>
        public void Start()
        {
            GenerateVisitors();
            MakeOrder();
            TakeOrder();
            UpdateMarket();
        }

        /// <summary>
        /// Generate phisically added customers to simulate shop work
        /// </summary>
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

        /// <summary>
        /// Support method for GenerateVisitors() method
        /// </summary>
        /// <param name="client"></param>
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

        /// <summary>
        /// method which iterate clients List and simulate product selection
        /// If product selected next step is simulation of product return back to shop with chance 25%
        /// </summary>
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
            if (inspector != null)
            {
                message = inspector.LeaveMarketMessage();
                Console.WriteLine(message);
                logger.Log(message);
            }
        }

        /// <summary>
        /// Method which simulate products purchase in store
        /// </summary>
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

        /// <summary>
        /// Method to check if client entity is Discount CLient
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        private static bool IsActionClient(Customer customer) =>
            customer.GetType().IsAssignableTo(typeof(DiscountClient));

        /// <summary>
        /// Method to check if Discount Client is allowed to get discount
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        private string IsAllowedForDiscount(DiscountClient client)
        {
            return (client.DiscountNumber <= discountCells) ?
                $"{client.GetName()} got discount" :
                $"{client.GetName()} did not get discount";
        }

        /// <summary>
        /// Method to check custoemrs status.
        /// If customers got their Products they will be released from queue
        /// </summary>
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