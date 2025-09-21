namespace TrainSystem;

public class TrainSystem
{
    internal string City1;
    internal string City2;
    internal bool trainLineIsReady = false;
    internal int countOfPassengers { get; set; }
    Random random = new Random();
    
    public void TrainLine(string point1, string point2)
    {
        Console.WriteLine($"Метод TrainLine вызван с параметрами: {point1}, {point2}"); // Отладочное сообщение
    
        if (point1 != null && point2 != null)
        {
            City1 = point1;
            City2 = point2;
            trainLineIsReady = true;
            Console.WriteLine($"Путь {City1} - {City2} сформирован!");
        }
        else
        {
            Console.WriteLine("Ошибка: один из параметров равен null!"); // Добавлено для отладки
        }
    }

    public void TicketSale()
    {
        if (trainLineIsReady == true)
        {
            countOfPassengers = random.Next(1, 100);
            Console.WriteLine($"Билеты в количестве - {countOfPassengers} распроданы!");
        }
    }
}
