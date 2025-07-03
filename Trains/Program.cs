namespace TrainSystem
{
    internal class Program ()
    {
        static public void Main()
        {
            while (true)
            {
                Console.WriteLine("Чтобы войти в систему управления поездами, нажмите ENTER.");
                if (Console.ReadLine() == "")
                {
                    TrainSystem ts = new TrainSystem();
                    Console.WriteLine("Добро пожаловать! Введите сначала город отправления, затем город прибытия! Нажмите ENTER.");
                    
                    string inputCities = Console.ReadLine();
                    string[] words = inputCities.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    
                    if (words.Length == 2)
                    {
                        string firstCity = words[0];
                        string secondCity = words[1];
                        ts.TrainLine(firstCity, secondCity);
                        
                        Console.WriteLine("Нажмите ENTER чтобы начать продажу билетов.");
                        if (Console.ReadLine() == "")
                        {
                            ts.TicketSale();
                            
                            Console.WriteLine("Нажмите ENTER чтобы начать формирование состава.");
                            if (Console.ReadLine() == "")
                            {
                                ts.TrainForming();
                                
                                Console.WriteLine("Нажмите ENTER чтобы начать отправку состава.");
                                if (Console.ReadLine() == "")
                                {
                                    ts.TrainSending();
                                    Console.WriteLine("Нажмите ENTER чтобы начать заново.");
                                    Console.ReadLine(); // Ожидание перед restart
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Нужно ввести ровно два города!");
                    }
                }
            }
        }
    }
}
