using System;

internal class Program
{
    internal static void Main(string[] args)
    {
        //ButtonEvent button = new ButtonEvent();
        //Screen screen = new Screen();

        //button.click += screen.ShowMessage;

        //button.Press();

        //PublisherSubscriber p = new PublisherSubscriber();
        //Subscriber s = new Subscriber();

        //p.message += s.MessageToSubscriber;

        //string result = p.MessageSent();
        //Console.WriteLine(result);

        //Subscription subscription = new Subscription();
        //Message message = new Message();

        //subscription.subs += message.Show;

        //subscription.Subscribe();

        //subscription.subs -= message.Show;
        //subscription.Subscribe();
        //subscription.Subscribe();

        //Student s = new Student();

        //s.MarksChanged += (sender, e) =>
        //{
        //    Console.WriteLine($"Marks changed from {e.OldMarks} to {e.NewMarks}");
        //};

        //s.Marks = 80;
        //s.Marks = 95;

        //OnlineShoppingCart cart = new OnlineShoppingCart();

        //cart.ItemAdded += (sender, e) =>
        //{
        //    cart.UpdateTotal(e.Item.price);
        //    cart.ApplyDiscount();
        //    cart.SendNotification(e.Item);
        //};

        //cart.AddItem(new CartItem("lenovo laptop", 53215.3m));
        //cart.AddItem(new CartItem("hp laptop", 215.3m));

        //BankingSystem bank = new BankingSystem();
        //Account acc = new Account(101, 1000);

        //bank.AddAccount(acc);

        //bank.WithdrawalOccurred += (sender, e) =>
        //{
        //    bank.CheckBalance(e.Account);
        //    bank.LogTransaction(e.Account, e.Amount);
        //    bank.SendSMS(e.Account, e.Amount);
        //};

        //bank.Withdraw(acc, 300);

        //EmployeeAttendanceSystem emp = new EmployeeAttendanceSystem("Rishabh");

        //emp.LateCheckedIn += (sender, e) =>
        //{
        //    Console.WriteLine($"ALERT: {e.EmployeeName} checked in late at {e.CheckInTime.TimeOfDay}");
        //};

        //Console.Write("Enter check-in time (HH:mm): ");
        //TimeSpan input = TimeSpan.Parse(Console.ReadLine());

        //DateTime todayCheckIn = DateTime.Today + input;
        //emp.CheckIn(todayCheckIn);

        //SystemMonitor monitor = new SystemMonitor();

        //// Subscriber 1: Logger
        //monitor.AlertRaised += (s, e) =>
        //{
        //    Console.WriteLine("LOG: " + e.Message);
        //};

        //// Subscriber 2: Email Service
        //monitor.AlertRaised += (s, e) =>
        //{
        //    Console.WriteLine("EMAIL SENT: " + e.Message);
        //};

        //// Subscriber 3: SMS Service
        //monitor.AlertRaised += (s, e) =>
        //{
        //    Console.WriteLine("SMS SENT: " + e.Message);
        //};

        //monitor.RaiseAlert("High CPU Usage Detected");

        TemperatureMonitoringSystem temp = new TemperatureMonitoringSystem();

        temp.TempAdd(35);



    }
}