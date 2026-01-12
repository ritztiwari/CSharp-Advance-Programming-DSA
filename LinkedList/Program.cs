using System;

class Program
{
    static void Main()
    {
		WorkflowEngine workflow = new();
		workflow.AddStep(new ValidateStep());
		workflow.AddStep(new ReviewStep());
		workflow.AddStep(new ApproveStep());
		workflow.RunWorkflow();


		/*RetryQueue retryQueue = new();
		retryQueue.AddTask(new SmsTask());
		retryQueue.AddTask(new EmailTask());
		retryQueue.AddTask(new SmsTask());
		retryQueue.RetryAll();*/


		/*SupportQueue queue = new();
		queue.AddRequest(new ChatRequest());
		queue.AddRequest(new CallRequest());
		queue.AddRequest(new EmailRequest());
		queue.ServeNext();
		queue.ServeNext();
		queue.ServeNext();*/


		/*JobQueue queue = new();
		queue.AddJob(new DataSyncJob());
		queue.AddJob(new EmailJob());
		queue.AddJob(new CleanupJob());
		queue.RunJobs();*/


		/*OrderQueue queue = new();
		queue.AddOrder(new OnlineOrder());
		queue.AddOrder(new OfflineOrder());
		queue.AddOrder(new SubscriptionOrder());
		queue.ProcessOrders();*/


		/*NotificationQueue queue = new();
		queue.Add(new EmailNotification());
		queue.Add(new SmsNotification());
		queue.Add(new PushNotification());
		queue.SendAll();*/


		/*Document doc = new();
		CommandManager manager = new();
		manager.ExecuteCommand(new TypeCommand(doc, "Hello "));
		manager.ExecuteCommand(new TypeCommand(doc, "World"));
		manager.Undo();
		manager.Redo();
		Console.WriteLine("Final Text: " + doc.Text);*/


		/*LRUCache cache = new LRUCache(2);
		cache.Put(1, "A");
		cache.Put(2, "B");
		Console.WriteLine(cache.Get(1)); 
		cache.Put(3, "C"); 
		Console.WriteLine(cache.Get(2)); */


		/*NotificationFeed feed = new NotificationFeed();
		feed.AddNotification(new LikeNotification("Lucky liked your post"));
		feed.AddNotification(new CommentNotification("Rishabh commented: Nice work!"));
		feed.AddNotification(new LikeNotification("Riya liked your photo"));
		feed.DisplayFeed();*/


		/*TaskScheduler scheduler = new TaskScheduler();
		scheduler.AddTask(new EmailTask("Send Weekly Report", 2));
		scheduler.AddTask(new ReportTask("Generate Monthly Report", 1));
		scheduler.AddTask(new EmailTask("Send Daily Alerts", 3));
		scheduler.ExecuteNext();
		scheduler.ExecuteNext();
		scheduler.ExecuteNext();
		scheduler.ExecuteNext();*/


		/*Route route = new ExpressRoute();
		route.AddStation("Mathura");
		route.AddStation("Agra");
		route.AddStation("Delhi");
		route.AddStation("Ghaziabad");
		route.ShowRoute();
		route.RemoveStation("Agra");
		route.ShowRoute();
		route.ReverseRoute();
		route.ShowRoute();*/


		/*TicketQueue queue = new TicketQueue();
		queue.AddTicket(new CallTicket("Payment issue"));
		queue.AddTicket(new ChatTicket("Authentication issues"));
		queue.AddTicket(new EmailTicket("Refund request"));
		queue.ProcessNext();
		queue.ProcessNext();
		queue.ProcessNext();*/


		/*Editor editor = new Editor();
		editor.Edit(new TextState("Hello"));
		editor.Edit(new TextState("Hello World"));
		editor.Edit(new TextState("Hello World!"));
		editor.Undo();
		editor.Undo();
		editor.Redo();*/


		/*Console.WriteLine("Media Playlist Queue");
		MediaPlayer player = new MusicPlayer();
		player.Add("teri metti");
		player.Add("waka waka");
		player.Add("humdard");
		player.PlayNext();
		player.PlayNext();
		player.PlayNext();*/


		/*Console.WriteLine("Browser History Navigation");
		NavigationBase browser = new BrowserHistory();
		browser.Visit("google.com");
		browser.Visit("github.com");
		browser.Visit("stackOverflow.com");
		browser.Back();
		browser.Back();
		browser.Forward();*/
	}
}