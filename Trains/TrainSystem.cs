namespace TrainSystem;

public class TrainSystem
{
    public List<Van> RowOfWagons = new List<Van>();
    private bool trainLineIsReady = false;
    private int countOfPassengers = 0;
    private string point1;
    private string point2;
    Random random = new Random();
    public void TrainLine(string point1, string point2)
    {
        Console.WriteLine($"Метод TrainLine вызван с параметрами: {point1}, {point2}"); // Отладочное сообщение
    
        if (point1 != null && point2 != null)
        {
            this.point1 = point1;
            this.point2 = point2;
            trainLineIsReady = true;
            Console.WriteLine($"Путь {point1} - {point2} сформирован!");
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

    public void TrainForming()
    {
        if (trainLineIsReady == true && countOfPassengers > 0)
        {
            if (countOfPassengers < 30)
            {
                RowOfWagons.Add(new Van(30,1));
                Console.WriteLine($"Состав из 1-го вагона вместительностью 30 человек готов!");
            }

            if (countOfPassengers < 40 && countOfPassengers > 39)
            {
                RowOfWagons.Add(new Van(40, 2));
                Console.WriteLine($"Состав из 1-го вагона вместительностью 40 человек готов!");
            }

            if (countOfPassengers < 60 && countOfPassengers > 49)
            {
                RowOfWagons.Add(new Van(60, 3));
                Console.WriteLine($"Состав из 1-го вагона вместительностью 60 человек готов!");
            }
            else if (countOfPassengers > 60 && countOfPassengers > 49)
            {
                RowOfWagons.Add(new Van(60, 3));
                RowOfWagons.Add(new Van(40, 2));
                Console.WriteLine($"Состав из 2-х вагонов вместительностью 60(1) и 40(2) человек готов!");
            }
            
        }
    }

    public void TrainSending()
    {
        if (trainLineIsReady == true && countOfPassengers > 0 && RowOfWagons != null)
        {
            foreach (Van van in RowOfWagons)
            {
               Console.WriteLine($"Поезд в {countOfPassengers} человек, с - {van.VanID} вагоном(ами) успешно -" +
                                 $" отправлен из {point1} в {point2}!");
               RowOfWagons.RemoveAll(_ => true); 
            }
            
            
        }
    }
}
