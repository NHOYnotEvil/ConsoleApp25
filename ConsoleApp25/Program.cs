namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleInLine;
            int durationDoctorAppointment = 10;

            Console.WriteLine("Вы пришли в поликлинику и видите очередь из людей. Так как времени у вас не много, вы" +
                " можете расчитать: сколько времени у вас уйдёт на ожидание свой очереди.");
            Console.Write("Сколько людей в очереди:");
            peopleInLine = Convert.ToInt32(Console.ReadLine());

            int timeHours = peopleInLine * durationDoctorAppointment / 60;
            int timeMinutes = peopleInLine * durationDoctorAppointment % 60;

            Console.WriteLine("Время ожидания в очереди - " + timeHours + " часов и " + timeMinutes + " минут.");

        }
    }
}