using System;
using System.Collections.Generic;

// Абстрактний клас Vehicle
public abstract class Vehicle
{
    public int Speed { get; set; }
    public int Capacity { get; set; }

    public abstract void Move();
}

// Клас Human
public class Human
{
    public int Speed { get; set; }

    public void Move()
    {
        Console.WriteLine("Human is walking");
    }
}

// Спадкоємці класу Vehicle: Car, Bus, Train
public class Car : Vehicle
{
    public string FuelType { get; set; }

    public override void Move()
    {
        Console.WriteLine($"Car is moving at {Speed} km/h");
    }
}

public class Bus : Vehicle
{
    public int RouteNumber { get; set; }

    public override void Move()
    {
        Console.WriteLine($"Bus is moving at {Speed} km/h on route {RouteNumber}");
    }
}

public class Train : Vehicle
{
    public string TrackNumber { get; set; }

    public override void Move()
    {
        Console.WriteLine($"Train is moving at {Speed} km/h on track {TrackNumber}");
    }
}

// Клас Route
public class Route
{
    public string Start { get; set; }
    public string End { get; set; }
}

// Клас TransportNetwork
public class TransportNetwork
{
    private List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void ControlMovement()
    {
        foreach (var vehicle in vehicles)
        {
            vehicle.Move();
        }
    }

    public void CalculateOptimalRoute(Vehicle vehicle, Route route)
    {
        if (vehicle is Car)
        {
            // Розрахунок оптимального маршруту для автомобіля
        }
        else if (vehicle is Bus)
        {
            // Розрахунок оптимального маршруту для автобуса
        }
        else if (vehicle is Train)
        {
            // Розрахунок оптимального маршруту для поїзда
        }
    }

    public void EmbarkPassengers(Vehicle vehicle, List<string> passengers)
    {
        // Логіка посадки пасажирів в транспортний засіб
    }

    public void DisembarkPassengers(Vehicle vehicle, List<string> passengers)
    {
        // Логіка висадки пасажирів з транспортного засобу
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car { Speed = 120, Capacity = 5, FuelType = "gasoline" };
        Bus bus1 = new Bus { Speed = 80, Capacity = 40, RouteNumber = 101 };
        Train train1 = new Train { Speed = 160, Capacity = 300, TrackNumber = "Track A" };

        Human human1 = new Human { Speed = 5 };

        Route route1 = new Route { Start = "City A", End = "City B" };

        TransportNetwork network = new TransportNetwork();
        network.AddVehicle(car1);
        network.AddVehicle(bus1);
        network.AddVehicle(train1);

        network.ControlMovement();

        network.CalculateOptimalRoute(car1, route1);

        List<string> passengers = new List<string> { "Passenger 1", "Passenger 2" };
        network.EmbarkPassengers(bus1, passengers);

        network.DisembarkPassengers(train1, passengers);
    }
}