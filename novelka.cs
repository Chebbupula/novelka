using System;
using System.Net.Mail;

namespace novelka
{
    class Programm
    {
        static void Main()
        {
            System.Console.WriteLine("Привет никита, надеюсь ты прочитал описание novelka.cs.Я обязуюсь, такого больше не будет(мэйби).(рекомендую не играть пока не прочитаешь)\nПриветствую в новелке, она про поездеку в голубы.\nВ данный момент вы на Мостовском Автовокзале.Вы зашли в автобус, выберите с кем сесть\n1.Бабушка\n2.Дедушка\n3.Женщина с грудным ребенком\n4.Красивая альтушка\n5.Женщина с псом");
            string UserChoice = Console.ReadLine();
            if (1 == Convert.ToInt32(UserChoice))
            {
                System.Console.WriteLine("Вы подсели к бабушке.Она начала разговор\nМилок, ты до куда\nДо голубов\nА ты чей? Что ответите\n1.Назвать фамилию\n2.Соврать.");
                string FirstUserChoice = Console.ReadLine();
                if (1 == Convert.ToInt32(FirstUserChoice))
                {
                    System.Console.WriteLine("О так она моя подружка.Всю поездку вы слушали рассказы из детства связаные с вашей бабушкой.Вам было интересно.Хорошая концовка.");
                }
                if (2 == Convert.ToInt32(FirstUserChoice))
                {
                    System.Console.WriteLine("Понятно\nВсю дальнейшую дорогу вы проехали в тишине.Нормальная концовка");
                }
            }
            if (2 == Convert.ToInt32(UserChoice))
            {
                System.Console.WriteLine("Вы сели к дедушке\nТы куда едешь? Что ответие\n1.Сделать вид что не слышите\n2.Ответить");
                string SecondUserChoice = Console.ReadLine();
                if (1 == Convert.ToInt32(SecondUserChoice))
                {
                    System.Console.WriteLine("Ну ладно\n");//TODO
                }
            }
        }
    }
}