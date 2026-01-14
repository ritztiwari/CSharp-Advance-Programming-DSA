//Multiple Subscribers

//Attach multiple listeners to a single event and show how all are notified.

using System;

class AlertEventArgs : EventArgs
{
    public string Message { get; }

    public AlertEventArgs(string message)
    {
        Message = message;
    }
}

class SystemMonitor
{
    public event EventHandler<AlertEventArgs> AlertRaised;

    public void RaiseAlert(string message)
    {
        OnAlertRaised(message);
    }

    protected virtual void OnAlertRaised(string message)
    {
        AlertRaised?.Invoke(this, new AlertEventArgs(message));
    }
}
