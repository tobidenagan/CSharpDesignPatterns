namespace CSharpDesignPatterns.DesignPatterns
{
    interface IUserNotifier
    {
        void NotifyUser(int id);
    }
    class EmailUserNotifier : IUserNotifier
    {
        public void NotifyUser(int id)
        {
            Console.WriteLine($"Notified user {id} by Email");
        }
    }
    class TestUserNotifier : IUserNotifier
    {
        public void NotifyUser(int id)
        {
            Console.WriteLine($"Pretending to notify User {id}");
        }
    }
    class NotificationServiceProvider
    {
        public IUserNotifier GetUserNotifier()
        {
#if DEBUG
            return new TestUserNotifier();
#else
            return new EmailUserNotifier();
#endif
        }
    }
    class ShippingService
    {
        NotificationServiceProvider _serviceProvider;
        public ShippingService(NotificationServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void ShipItem()
        {
            //code to ship item
            _serviceProvider.GetUserNotifier().NotifyUser(1);
        }
    }
}
