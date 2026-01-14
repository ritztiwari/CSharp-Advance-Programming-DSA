//Temperature Monitoring System

//Raise an alert event when temperature exceeds threshold.

using System;

//event handler
class TemperatureEventArgs : EventArgs
{
    public double Temperature { get; set; }

    public TemperatureEventArgs(double temperature)
    {
        this.Temperature = temperature;
    }
}

//actual class that will implement the event.
internal class TemperatureMonitoringSystem
{
    //field
    private double temperature { get; set; }

    //readonly variable
    public readonly double safeTemperature;
    
    //event handler using delegate.
    public event EventHandler<TemperatureEventArgs> temperatureHandler;

    //adding temperature in this class
    public void TempAdd(double temperature)
    {
        this.temperature = temperature;
        TemperatureRaised(temperature);
    }

    //checking if the temperature is greator than safe or not.
    public void TemperatureRaised(double temperture)
    {
        if (temperature > safeTemperature)
        {
            Console.WriteLine("Temperature is raised & it is unsafe");
        }
        else
        {
            //calling TemperatureEventArgs to handle unsafe condition. 
            temperatureHandler?.Invoke(this,new TemperatureEventArgs(temperature));
            Console.WriteLine($"{temperature} is safe temperature");
        }
    }
}